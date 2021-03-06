﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using DataPackage = MSDesigner.Classes.DataPackage;
using L2Item = MSDesigner.Classes.L2Item;
using MSDesignerContorls = MSDesigner.Classes.Controls;
using MultiSell = MSDesigner.Classes.MultiSell;

namespace MSDesigner
{
    public partial class Form1 : Form
    {
        private int _maxPerPage = 100;
        private int _currentPage = 0;

        private DataPackage::Package _package;

        private L2Item.List _currentList;
        private List<L2Item.List> _itemsLists;

        private MultiSell::List _msList;
        private MultiSell::Item _currentMSItem;

        public Form1()
        {
            InitializeComponent();
        }

        #region Main app logic

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Init
            this._package = DataPackage::Package.ReadConfigFile("package.json");
            this._msList = new MultiSell.List();
            this._itemsLists = new List<L2Item.List>();

            // If defined some items
            if (this._package != null && this._package.Items.Count > 0)
            {
                L2Item.List allItems = new L2Item.List() { Name = "All" };
                allItems.Items = new List<L2Item.Item>();

                // Start load it
                foreach (DataPackage::Item configItem in this._package.Items)
                {
                    try
                    {
                        L2Item.List l2ItemList = new L2Item.List { Name = configItem.Name };
                        l2ItemList.ReadItemsToListFromPackage(configItem.Path);

                        allItems.Items.AddRange(l2ItemList.Items);
                        this._itemsLists.Add(l2ItemList);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error IO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Make "All" list
                this._itemsLists.Insert(0, allItems);
                this._currentList = this._itemsLists[0];
            }

            // Init events
            this.TableLayoutPanelMSItem.ControlAdded += new ControlEventHandler(TableLayoutPanelMSItem_ControlAdded);
            this.TableLayoutPanelMSItem.ControlRemoved += new ControlEventHandler(TableLayoutPanelMSItem_ControlRemoved);
            this.TableLayoutMSList.ControlAdded += new ControlEventHandler(TableLayoutMSList_ControlAdded);
            this.TableLayoutMSList.ControlRemoved += new ControlEventHandler(TableLayoutMSList_ControlRemoved);

            // Init controls
            this.InitControls();
        }

        private void DisplayItemsInListView(int start)
        {
            this.ItemsListView.Items.Clear();
            this.ItemsListView.LargeImageList.Images.Clear();

            this._currentList.FillListViewByItems(this.ItemsListView, this._package.Icons, start, this._maxPerPage);
        }

        private void InitControls()
        {
            #region Default Controls State
            // Pager
            this.ButtonNextItemListPage.Enabled = false;
            this.ButtonPrevItemListPage.Enabled = false;

            // ComboBox
            this.ComboBoxPager.Enabled = false;
            this.ComboBoxPackageItemName.Enabled = false;

            // Search controls
            this.TextBoxSearch.Enabled = false;
            this.ButtonSearchClear.Enabled = false;

            // Other controls
            this.PictureBoxInvChangeView.Enabled = false;
            this.ItemsListView.Enabled = false;
            this.LabelDataPackageDisable.Visible = true;

            // OMG: Search other way to do it (Button add item to MSList)
            this.PictureBoxAddItem.Parent = this.PictureBoxMSListBot;
            this.PictureBoxAddItem.Location = new Point((this.PictureBoxMSListBot.Width / 2) - (this.PictureBoxAddItem.Width / 2), 0);
            #endregion

            // If DataPackage loaded
            if (this._package != null)
            {
                this.InitPager();

                this.LabelDataPackageDisable.Visible = false;

                // Search controls
                this.TextBoxSearch.Enabled = true;
                this.ButtonSearchClear.Enabled = true;

                this.ComboBoxPackageItemName.DataSource = this._itemsLists;
                this.ComboBoxPackageItemName.Enabled = true;

                this.PictureBoxInvChangeView.Enabled = true;
                this.ItemsListView.Enabled = true;
            }
        }

        private void InitPager()
        {
            int maxPagesCount = (int)Math.Ceiling((decimal)this._currentList.Items.Count / (decimal)this._maxPerPage);

            this.ComboBoxPager.Items.Clear();
            this.ComboBoxPager.Enabled = true;

            this.ButtonNextItemListPage.Enabled = true;
            this.ButtonPrevItemListPage.Enabled = true;

            if (maxPagesCount <= 1)
            {
                maxPagesCount = 1;

                this.ComboBoxPager.Enabled = false;

                this.ButtonNextItemListPage.Enabled = false;
                this.ButtonPrevItemListPage.Enabled = false;
            }

            for (int i = 1; i <= maxPagesCount; i++)
                this.ComboBoxPager.Items.Add(i.ToString());

            // TODO: I really doubt that it must be here
            this.ComboBoxPager.SelectedIndex = 0;
        }

        private void ComboBoxPager_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._currentPage = this.ComboBoxPager.SelectedIndex;

            DisplayItemsInListView(this._currentPage * this._maxPerPage);

            if (this._currentPage > 0)
                this.ButtonPrevItemListPage.Enabled = true;
            else
                this.ButtonPrevItemListPage.Enabled = false;

            if ((this.ComboBoxPager.SelectedIndex + 1) >= this.ComboBoxPager.Items.Count)
                this.ButtonNextItemListPage.Enabled = false;
            else
                this.ButtonNextItemListPage.Enabled = true;
        }

        private void ItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ItemsListView.SelectedItems.Count == 1)
            {
                int index = this.ItemsListView.SelectedItems[0].Index;

                if (this._currentPage != 0)
                    index += this._currentPage * this._maxPerPage;

                this.textBoxItemId.Text = this._currentList.Items[index].Id.ToString();
                this.textBoxItemName.Text = this._currentList.Items[index].Name;
                this.textBoxItemDesc.Text = this._currentList.Items[index].Description.Replace(@"\\n", "\r\n");

                string itemParams = "";

                foreach (var pair in this._currentList.Items[index].Params)
                {
                    itemParams += string.Format("{0}: {1} \r\n", pair.Key, pair.Value);
                }

                this.TextBoxItemParams.Text = itemParams;
            }
        }

        /// <summary>
        /// Filter current list
        /// </summary>
        /// <param name="filterQuery">Filter query string</param>
        private void FilterCurrentList(string filterQuery = "")
        {
            this._currentList = (L2Item.List)this._itemsLists
                                    .Find(i => i.Name == this.ComboBoxPackageItemName.SelectedValue.ToString())
                                    .Clone();

            if (filterQuery != "")
            {
                double id;

                if (double.TryParse(filterQuery, out id))
                    this._currentList.Items = this._currentList.Items.Where(i => i.Id == id).ToList();
                else
                    this._currentList.Items = this._currentList.Items
                                                .FindAll(i => i.Name.ToLower().Contains(filterQuery))
                                                .ToList();
            }

            this.InitPager();
        }

        private void ClearSearchQuery()
        {
            this.TextBoxSearch.Clear();
            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxSearch.Text = "ID or Name";
        }

        public void AddMSItemToMSList(MultiSell::Item msItem)
        {
            MSDesignerContorls::MSItemPictureBox itemIcon = new MSDesignerContorls::MSItemPictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(0, 0),
                Margin = new System.Windows.Forms.Padding(2, 1, 3, 3),
                Cursor = Cursors.Hand,
                ContextMenuStrip = this.ContextMenuMSItem,
                MSItem = msItem,
                BackgroundImage = Properties.Resources.no_icon
            };

            if (msItem.productions[0].Icon != null && this._package != null)
                itemIcon.BackgroundImage = msItem.productions[0].GetIconImage(this._package.Icons);

            itemIcon.Click += PictureBoxInMSList_Click;

            this._msList.Items.Add(msItem);
            this.TableLayoutMSList.Controls.Add(itemIcon);
        }

        private void PictureBoxInMSList_Click(object sender, EventArgs e)
        {
            MSDesignerContorls::MSItemPictureBox msItemPictureBox = sender as MSDesignerContorls::MSItemPictureBox;
            this._currentMSItem = msItemPictureBox.MSItem;
            this.ShowCurrentMSItem();
        }

        private void ItemsListView_DoubleClick(object sender, EventArgs e)
        {
            MSDesignerContorls::ListViewItem lvi = (MSDesignerContorls::ListViewItem)this.ItemsListView.SelectedItems[0];

            MultiSell.Product msProduct = MultiSell.Product.CreateProductFromL2Item(lvi.Item);

            MultiSell.Item msItem = new MultiSell.Item();
            msItem.AddProductToProductions(msProduct);
            this.AddMSItemToMSList(msItem);
        }

        private void RemoveMSItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._msList.Items.Remove(((MSDesignerContorls::MSItemPictureBox)this.ContextMenuMSItem.SourceControl).MSItem);
            this._currentMSItem = null;

            this.ButtonAddProductToMSItem.Text = "Add Item";
            this.ButtonAddProductToMSItem.Enabled = false;

            this.TableLayoutPanelMSItem.Controls.Clear();
            this.TableLayoutMSList.Controls.Remove(this.ContextMenuMSItem.SourceControl);
        }

        /**
         * Save MS List to XML file
         *
         */
        private void SaveMSListToXML_Click(object sender, EventArgs e)
        {
            if (this._msList.Items.Count < 1)
            {
                MessageBox.Show("MultiSell does not contain any items", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < this._msList.Items.Count; i++)
            {
                this._msList.Items[i].Id = i + 1;
            }

            this._msList.Config.ShowAll = this.CheckBoxMSConfigShowAll.Checked ? true : false;
            this._msList.Config.NoTax = this.CheckBoxMSConfigNoTax.Checked ? true : false;
            this._msList.Config.IgnorePrice = this.CheckBoxMSConfigIgnorePrice.Checked ? true : false;
            this._msList.Config.KeepEnchanted = this.CheckBoxMSConfigKeepEnchanted.Checked ? true : false;

            //XmlSerializer serializer = new XmlSerializer(typeof(MultiSell::List));
            XmlSerializer serializer = XmlSerializer.FromTypes(new[] { typeof(MultiSell::List) })[0];

            using (TextWriter writer = new StreamWriter(string.Format("{0}.xml", this.TextBoxMSName.Text)))
            {
                serializer.Serialize(writer, this._msList, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
            }
        }

        /**
         * Create MS Item and add it to MSList
         *
         */
        private void ButtonAddMSItemToMSGrid_Click(object sender, EventArgs e)
        {
            if (this.TableLayoutPanelMSItem.Controls.Count < 1)
            {
                MessageBox.Show("You can not add an empty item", "Item is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this._currentMSItem == null)
                this._currentMSItem = new MultiSell.Item();

            this._currentMSItem.ingredients.Clear();
            this._currentMSItem.productions.Clear();

            foreach (Control msItemView in this.TableLayoutPanelMSItem.Controls)
            {
                L2Item::Item item = ((MSDesignerContorls::MSProductView)msItemView).Item;
                decimal count = ((MSDesignerContorls::MSProductView)msItemView).NumericUpDownItemCount.Value;

                MultiSell::Product l2Item = new MultiSell.Product()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Count = count,
                    Icon = item.Icon
                };

                if (((MSDesignerContorls::MSProductView)msItemView).CheckBoxIsIngredient.Checked)
                    this._currentMSItem.ingredients.Add(l2Item);
                else
                    this._currentMSItem.productions.Add(l2Item);
            }

            if (this._currentMSItem.ingredients.Count < 1)
            {
                MessageBox.Show("You can not add item without ingredient", "Missing ingredients", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this._currentMSItem.productions.Count < 1)
            {
                MessageBox.Show("You can not add item without production", "Missing productions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this._msList.Items.Contains(this._currentMSItem))
                this.EditMSItemAtMS(this._currentMSItem);
            else
                this.AddMSItemToMSList(this._currentMSItem);

            this._currentMSItem = null;

            this.ButtonAddProductToMSItem.Text = "Add Item";
            this.ButtonAddProductToMSItem.Enabled = false;
            this.TableLayoutPanelMSItem.Controls.Clear();
        }

        /**
         * Edit MS Item from MS List
         */
        private void EditMSItemAtMS(MultiSell::Item msItem)
        {
            // TODO: Omfg place!
            foreach (MSDesignerContorls::MSItemPictureBox msItemPictureBox in this.TableLayoutMSList.Controls)
            {
                if (msItemPictureBox.MSItem == msItem)
                {
                    msItemPictureBox.MSItem = msItem;
                    msItemPictureBox.Image = msItem.productions[0].GetIconImage(this._package.Icons);
                }
            }
        }

        private void ShowCurrentMSItem()
        {
            this.TableLayoutPanelMSItem.Controls.Clear();

            if (this._currentMSItem == null)
                return;

            this._currentMSItem.productions.ForEach(i =>
            {
                Image itemImage = (this._package == null) ? Properties.Resources.no_icon : i.GetIconImage(this._package.Icons);
                
                MSDesignerContorls::MSProductView msItemView = new MSDesignerContorls.MSProductView(i, itemImage);
                msItemView.LableItemRemove.Click += RemoveL2ItemFromMSItem;

                this.TableLayoutPanelMSItem.Controls.Add(msItemView);
            });

            this._currentMSItem.ingredients.ForEach(i =>
            {
                Image itemImage = (this._package == null) ? Properties.Resources.no_icon : i.GetIconImage(this._package.Icons);

                MSDesignerContorls::MSProductView msItemView = new MSDesignerContorls.MSProductView(i, itemImage);
                msItemView.LableItemRemove.Click += RemoveL2ItemFromMSItem;

                this.TableLayoutPanelMSItem.Controls.Add(msItemView);
            });
        }

        private void EditMSItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSDesignerContorls::MSItemPictureBox msItemPictureBox = (MSDesignerContorls::MSItemPictureBox)this.ContextMenuMSItem.SourceControl;
            this._currentMSItem = msItemPictureBox.MSItem;
            this.ShowCurrentMSItem();
        }

        public MultiSell::Product CreateMSProduct(int id, decimal count = 1)
        {
            if (this._package != null)
            {
                L2Item.Item l2item = this._itemsLists[0].Items.Find(i => i.Id == id);

                if (l2item != null)
                {
                    MultiSell::Product msProduct = MultiSell::Product.CreateProductFromL2Item(l2item);
                    msProduct.Count = count;

                    return msProduct;
                }
            }

            return new MultiSell.Product
            {
                Id = id,
                Count = count
            };
        }

        private void ButtonDeleteCurrentMSItem_Click(object sender, EventArgs e)
        {
            this.RemoveCurrentMSItem();
            this.TableLayoutPanelMSItem.Controls.Clear();
        }

        private void RemoveCurrentMSItem()
        {
            if (this._currentMSItem == null) return;

            foreach (MSDesignerContorls.MSItemPictureBox p in this.TableLayoutMSList.Controls)
            {
                if (p.MSItem == this._currentMSItem)
                    this.TableLayoutMSList.Controls.Remove(p);
            }

            this._msList.Items.Remove(this._currentMSItem);
            this._currentMSItem = null;
        }

        private void ButtonAddProductToMSItem_Click(object sender, EventArgs e)
        {
            MSItemForm msForm = new MSItemForm(this.CreateMSProduct, this.AddProductToCurrentMSItem);
            msForm.Location = new Point((this.Location.X + (this.Width / 2)) - (msForm.Width / 2), (this.Location.Y + (this.Height / 2)) - (msForm.Height / 2));
            msForm.Show();
        }

        public void AddProductToCurrentMSItem(MultiSell.Product product)
        {
            if (this._currentMSItem == null)
                return;

            MSDesignerContorls.MSProductView productView = new MSDesignerContorls.MSProductView(
                product,
                (this._package == null) ? Properties.Resources.no_icon : product.GetIconImage(this._package.Icons)
            );

            productView.LableItemRemove.Click += RemoveL2ItemFromMSItem;

            this._currentMSItem.AddProductToProductions(product);
            this.TableLayoutPanelMSItem.Controls.Add(productView);
        }

        private void RemoveL2ItemFromMSItem(object sender, EventArgs e)
        {
            this.TableLayoutPanelMSItem.Controls.Remove(((Label)sender).Parent);

            if (this.TableLayoutPanelMSItem.Controls.Count < 1)
                this.RemoveCurrentMSItem();
        }

        #endregion

        #region Distractions events

        private void PictureBoxAddItem_Click(object sender, EventArgs e)
        {
            MSItemForm msForm = new MSItemForm(this.CreateMSProduct, this.AddMSItemToMSList);
            msForm.Location = new Point((this.Location.X + (this.Width / 2)) - (msForm.Width / 2), (this.Location.Y + (this.Height / 2)) - (msForm.Height / 2));
            msForm.Show();
        }

        private void ButtonClearMSItem_Click(object sender, EventArgs e)
        {
            this.TableLayoutPanelMSItem.Controls.Clear();
            // TODO: Bug
            //this.PanelMSItems.VerticalScroll.Visible = false;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TextBoxSearch.Text == "ID or Name")
                return;

            this.FilterCurrentList(this.TextBoxSearch.Text.Trim().ToLower());
        }

        private void ButtonCopyItemID_Click(object sender, EventArgs e)
        {
            if (this.textBoxItemId.Text != "")
                Clipboard.SetText(this.textBoxItemId.Text);
        }

        private void ButtonMSGridDown_Click(object sender, EventArgs e)
        {
            this.TableLayoutMSList.Top -= 36;

            if (this.TableLayoutMSList.Bottom == this.PanelMSGrid.Height)
                this.ButtonMSGridDown.Enabled = false;

            if (this.TableLayoutMSList.Top < 0)
                this.ButtonMSGridUp.Enabled = true;
            else
                this.ButtonMSGridUp.Enabled = false;
        }

        private void ButtonMSGridUp_Click(object sender, EventArgs e)
        {
            this.ButtonMSGridDown.Enabled = true;

            if (this.TableLayoutMSList.Top < 0)
                this.TableLayoutMSList.Top += 36;

            if (this.TableLayoutMSList.Top == 0)
                this.ButtonMSGridUp.Enabled = false;
        }

        private void TableLayoutMSGrid_Resize(object sender, EventArgs e)
        {
            if (this.TableLayoutMSList.Height > this.PanelMSGrid.Height)
                this.ButtonMSGridDown.Enabled = true;
        }

        // TODO: Refactor
        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '~')
            //{
            //    this.ListBoxFiltersTip.Show();

            //    this.ListBoxFiltersTip.Items.Add("~gr: [Grade]");
            //    this.ListBoxFiltersTip.Items.Add("~id: [ID]");

            //    this.ListBoxFiltersTip.Height = this.ListBoxFiltersTip.PreferredHeight;
            //}
        }

        // HACK: Dev env
        private void DEVBUTTON_CLICK(object sender, EventArgs e)
        {
            Image itemImage = Properties.Resources.no_icon;
            MSDesignerContorls::MSProductView msItemView = new MSDesignerContorls.MSProductView(this._currentMSItem.productions[0], itemImage);

            this.TableLayoutPanelMSItem.Controls.Add(msItemView);

            //ItemDetails itemDetailsForm = new ItemDetails();
            //itemDetailsForm.Show();
            //itemDetailsForm.Location = new Point(DEVBUTTON.Left, DEVBUTTON.Top);

            //for (int i = 0; i < 100; i++)
            //{
            //    MSDesignerContorls::MSItemPictureBox itemIcon = new MSDesignerContorls::MSItemPictureBox
            //    {
            //        Size = new Size(32, 32),
            //        Location = new Point(0, 0),
            //        Margin = new System.Windows.Forms.Padding(2, 1, 3, 3),
            //        Cursor = Cursors.Hand,
            //        Image = this._currentList.Items[i].GetIconImage(this._package.Icons)
            //    };

            //    this.TableLayoutMSList.Controls.Add(itemIcon);
            //}
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (this.TextBoxSearch.Text == "")
            {
                this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
                this.TextBoxSearch.Text = "ID or Name";
            }
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (this.TextBoxSearch.Text == "ID or Name")
                this.TextBoxSearch.Text = "";

            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void buttonNextItemList_Click(object sender, System.EventArgs e)
        {
            this.ComboBoxPager.SelectedIndex = this.ComboBoxPager.Items.IndexOf((++this._currentPage + 1).ToString());
        }

        private void buttonPrevItemList_Click(object sender, System.EventArgs e)
        {
            this.ComboBoxPager.SelectedIndex = this.ComboBoxPager.Items.IndexOf((--this._currentPage + 1).ToString());
        }

        // HACK: Remove tests!
        private void button1_Click(object sender, EventArgs e)
        {
            //var filteredItems = from Product::Item item in this._currentList.Items
            //                    where item.Id == 1000
            //                    select item;

            //this._currentList.Items.Clear();

            //foreach (Product::Item item in filteredItems)
            //{
            //    Debug.WriteLine(item.Name);
            //    this._currentList.Items.Add(item);
            //}


            //this._currentList.Items = this._currentList.Items.FindAll(i => i.Params.);
            //this.InitPagerComboBox();

            //for (int i = 0; i < 50; i++)
            //{
            //    Debug.WriteLine(this._currentList.Icons.Images[i].PropertyItems);
            //}
        }

        private void ButtonSearchClear_Click(object sender, EventArgs e)
        {
            this.ClearSearchQuery();
        }

        private void PictureBoxInvChangeView_Click(object sender, EventArgs e)
        {
            if (this.ItemsListView.View == View.Details)
            {
                this.ItemsIconList.ImageSize = new Size(32, 32);
                this.ItemsListView.View = View.LargeIcon;
            }
            else
            {
                this.ItemsIconList.ImageSize = new Size(16, 16);
                this.ItemsListView.View = View.Details;
            }

            this.DisplayItemsInListView(this._currentPage * this._maxPerPage);
        }

        void TableLayoutMSList_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (this._msList.Items.Count < 1)
            //    this.ButtonSaveMSList.Enabled = false;
        }

        void TableLayoutMSList_ControlAdded(object sender, ControlEventArgs e)
        {
            //if (this._msList.Items.Count > 0)
            //    this.ButtonSaveMSList.Enabled = true;
        }

        void TableLayoutPanelMSItem_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (this.TableLayoutPanelMSItem.Controls.Count < 1)
            //    this.ButtonClearMSItem.Enabled = false;
        }

        void TableLayoutPanelMSItem_ControlAdded(object sender, ControlEventArgs e)
        {
            //if (this.TableLayoutPanelMSItem.Controls.Count > 0)
            //{
            //    this.ButtonAddMSItemToMSList.Enabled = true;
            //    this.ButtonClearMSItem.Enabled = true;
            //}
        }

        void ComboBoxListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchQuery = string.Empty;

            if (this.TextBoxSearch.Text != "" && this.TextBoxSearch.Text != "ID or Name")
                searchQuery = this.TextBoxSearch.Text.ToLower();

            this.FilterCurrentList(searchQuery);
        }

        private void LinkStmol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://stmol.me");
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Visual Effects
        private void PictureBoxPlusBtn_MouseMove(object sender, MouseEventArgs e)
        {
            this.PictureBoxPlusBtn.Image = Properties.Resources.PlusBtnOver;
        }

        private void PictureBoxPlusBtn_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBoxPlusBtn.Image = Properties.Resources.PlusBtn;
        }

        private void PictureBoxPlusBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.PictureBoxPlusBtn.Image = Properties.Resources.PlusBtnDown;
        }

        private void PictureBoxAddItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.PictureBoxAddItem.Image = Properties.Resources.BtnAddItemOver2;
        }

        private void PictureBoxAddItem_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBoxAddItem.Image = Properties.Resources.BtnAddItem2;
        }

        private void PictureBoxAddItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.PictureBoxAddItem.Image = Properties.Resources.BtnAddItemDown2;
        }

        private void PictureBoxInvChangeView_MouseMove(object sender, MouseEventArgs e)
        {
            this.PictureBoxInvChangeView.Image = Properties.Resources.PostWndList_Over;
        }

        private void PictureBoxInvChangeView_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBoxInvChangeView.Image = Properties.Resources.PostWndList;
        }

        private void PictureBoxInvChangeView_MouseDown(object sender, MouseEventArgs e)
        {
            this.PictureBoxInvChangeView.Image = Properties.Resources.PostWndList_Down;
        }
        #endregion
    }
}
