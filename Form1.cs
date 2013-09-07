using System;
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
        private MultiSell::MSItem _currentMSItem;

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

            // If defined some items
            if (this._package.Items.Count > 0)
            {
                this._itemsLists = new List<L2Item.List>();

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

                // Make "All" tab
                this._itemsLists.Insert(0, allItems);
            }
            else
            {
                // TODO: Catch it!
                throw new Exception("Package does not contain any data");
            }

            // Init events
            this.ComboBoxListName.SelectedIndexChanged += new EventHandler(ComboBoxListName_SelectedIndexChanged);
            this.TableLayoutPanelMSItem.ControlAdded += new ControlEventHandler(TableLayoutPanelMSItem_ControlAdded);
            this.TableLayoutPanelMSItem.ControlRemoved += new ControlEventHandler(TableLayoutPanelMSItem_ControlRemoved);
            this.TableLayoutMSList.ControlAdded += new ControlEventHandler(TableLayoutMSList_ControlAdded);
            this.TableLayoutMSList.ControlRemoved += new ControlEventHandler(TableLayoutMSList_ControlRemoved);

            this.ComboBoxListName.DataSource = this._itemsLists;
        }

        private void DisplayItemsInListView(int start)
        {
            this.ItemsListView.Items.Clear();
            this.ItemsListView.LargeImageList.Images.Clear();

            this._currentList.FillListViewByItems(this.ItemsListView, this._package.Icons, start, this._maxPerPage);
        }

        private void InitControls()
        {
            int maxPagesCount = (int)Math.Ceiling((decimal)this._currentList.Items.Count / (decimal)this._maxPerPage);

            this.ComboBoxPager.Items.Clear();
            this.ComboBoxPager.Enabled = true;

            this.buttonNextItemList.Enabled = true;
            this.buttonPrevItemList.Enabled = true;

            if (maxPagesCount <= 1)
            {
                maxPagesCount = 1;

                this.buttonNextItemList.Enabled = false;
                this.buttonPrevItemList.Enabled = false;
                this.ComboBoxPager.Enabled = false;
            }

            for (int i = 1; i <= maxPagesCount; i++)
                this.ComboBoxPager.Items.Add(i.ToString());

            this.ComboBoxPager.SelectedIndex = 0;
        }

        private void ComboBoxPager_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._currentPage = this.ComboBoxPager.SelectedIndex;

            DisplayItemsInListView(this._currentPage * this._maxPerPage);

            if (this._currentPage > 0)
                this.buttonPrevItemList.Enabled = true;
            else
                this.buttonPrevItemList.Enabled = false;

            int maxPagesCount = (int)Math.Ceiling((decimal)this._currentList.Items.Count / (decimal)this._maxPerPage);

            if (this._currentPage >= maxPagesCount - 1)
                this.buttonNextItemList.Enabled = false;
            else
                this.buttonNextItemList.Enabled = true;
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

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TextBoxSearch.Text == "ID or Name")
                return;

            string searchQuery = this.TextBoxSearch.Text.Trim().ToLower();
            double id;

            // TODO: Make single refresh method!
            this._currentList = (L2Item.List)this._itemsLists.Find(i => i.Name == this.ComboBoxListName.SelectedValue.ToString()).Clone();

            if (double.TryParse(searchQuery, out id))
                this._currentList.Items = this._currentList.Items.Where(i => i.Id == id).ToList();
            else
                this._currentList.Items = this._currentList.Items
                                                           .FindAll(i => i.Name.ToLower().Contains(searchQuery))
                                                           .ToList();

            this.InitControls();
        }

        private void ClearSearchQuery()
        {
            this.TextBoxSearch.Clear();
            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxSearch.Text = "ID or Name";
        }

        private void AddItemToMS(MultiSell::MSItem msItem)
        {
            MSDesignerContorls::MSItemPictureBox itemIcon = new MSDesignerContorls::MSItemPictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(0, 0),
                Margin = new System.Windows.Forms.Padding(2, 1, 3, 3),
                Cursor = Cursors.Hand,
                ContextMenuStrip = this.ContextMenuMSItem,
                MSItem = msItem,
                Image = msItem.productions[0].GetIconImage(this._package.Icons)
            };

            itemIcon.Click += new EventHandler(this.PictureBoxInMSList_Click);

            this._msList.Items.Add(msItem);
            this.TableLayoutMSList.Controls.Add(itemIcon);
        }

        private void PictureBoxInMSList_Click(object sender, EventArgs e)
        {
            MSDesignerContorls::MSItemPictureBox msItemPictureBox = sender as MSDesignerContorls::MSItemPictureBox;

            this.EditMSItemFromMSList(msItemPictureBox.MSItem);
        }

        private void ItemsListView_DoubleClick(object sender, EventArgs e)
        {
            MSDesignerContorls::ListViewItem lvi = (MSDesignerContorls::ListViewItem)this.ItemsListView.SelectedItems[0];

            MultiSell::L2Item l2Item = new MultiSell.L2Item()
            {
                Id = lvi.Item.Id,
                Name = lvi.Item.Name,
                Count = 1,
                Icon = lvi.Item.Icon
            };

            MSDesignerContorls::MSItemView msItemView = new MSDesignerContorls::MSItemView(
                l2Item, 
                l2Item.GetIconImage(this._package.Icons),
                this.RemoveL2ItemFromMSItem);

            this.TableLayoutPanelMSItem.Controls.Add(msItemView);
        }

        private void RemoveMSItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._msList.Items.Remove(((MSDesignerContorls::MSItemPictureBox)this.ContextMenuMSItem.SourceControl).MSItem);
            this._currentMSItem = null;

            this.ButtonAddMSItemToMSList.Text = "Add Item";
            this.ButtonAddMSItemToMSList.Enabled = false;

            this.TableLayoutPanelMSItem.Controls.Clear();
            this.TableLayoutMSList.Controls.Remove(this.ContextMenuMSItem.SourceControl);
        }

        /**
         * Save MS List to XML file
         *
         */
        private void SaveMSGridToXML_Click(object sender, EventArgs e)
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

            XmlSerializer serializer = new XmlSerializer(typeof(MultiSell::List));

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
                this._currentMSItem = new MultiSell.MSItem();

            this._currentMSItem.ingredients.Clear();
            this._currentMSItem.productions.Clear();

            foreach (Control msItemView in this.TableLayoutPanelMSItem.Controls)
            {
                L2Item::Item item = ((MSDesignerContorls::MSItemView)msItemView).Item;
                decimal count = ((MSDesignerContorls::MSItemView)msItemView).NumericUpDownItemCount.Value;

                MultiSell::L2Item l2Item = new MultiSell.L2Item()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Count = count,
                    Icon = item.Icon
                };

                if (((MSDesignerContorls::MSItemView)msItemView).CheckBoxIsIngredient.Checked)
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
                this.AddItemToMS(this._currentMSItem);

            this._currentMSItem = null;

            this.ButtonAddMSItemToMSList.Text = "Add Item";
            this.ButtonAddMSItemToMSList.Enabled = false;
            this.TableLayoutPanelMSItem.Controls.Clear();
        }

        /**
         * Edit MS Item from MS List
         */
        private void EditMSItemAtMS(MultiSell::MSItem msItem)
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

        private void EditMSItemFromMSList(MultiSell::MSItem msItem)
        {
            this.TableLayoutPanelMSItem.Controls.Clear();
            this.ButtonAddMSItemToMSList.Text = "Save Item";

            this._currentMSItem = msItem;

            foreach (MultiSell::L2Item l2Item in msItem.productions)
            {
                MSDesignerContorls::MSItemView msItemView = new MSDesignerContorls::MSItemView(
                    l2Item,
                    l2Item.GetIconImage(this._package.Icons),
                    this.RemoveL2ItemFromMSItem);

                this.TableLayoutPanelMSItem.Controls.Add(msItemView);
            }

            // TODO: Dirty place - look at code above
            foreach (MultiSell::L2Item l2Item in msItem.ingredients)
            {
                MSDesignerContorls::MSItemView msItemView = new MSDesignerContorls::MSItemView(
                    l2Item,
                    l2Item.GetIconImage(this._package.Icons),
                    this.RemoveL2ItemFromMSItem);

                msItemView.CheckBoxIsIngredient.Checked = true;

                this.TableLayoutPanelMSItem.Controls.Add(msItemView);
            }
        }

        private void ButtonClearMSItem_Click(object sender, EventArgs e)
        {
            this.TableLayoutPanelMSItem.Controls.Clear();
            // TODO: Bug
            //this.PanelMSItems.VerticalScroll.Visible = false;
        }

        private void EditMSItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSDesignerContorls::MSItemPictureBox msItemPictureBox = (MSDesignerContorls::MSItemPictureBox)this.ContextMenuMSItem.SourceControl;
            this.EditMSItemFromMSList(msItemPictureBox.MSItem);
        }

        #endregion

        #region Distractions events

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

        private void RemoveL2ItemFromMSItem(object sender, EventArgs e)
        {
            this.TableLayoutPanelMSItem.Controls.Remove(((Label)sender).Parent);
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
            //var filteredItems = from L2Item::Item item in this._currentList.Items
            //                    where item.Id == 1000
            //                    select item;

            //this._currentList.Items.Clear();

            //foreach (L2Item::Item item in filteredItems)
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

        private void ChangeViewInItemList_Click(object sender, EventArgs e)
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
            if (this._msList.Items.Count < 1)
                this.ButtonSaveMSList.Enabled = false;
        }

        void TableLayoutMSList_ControlAdded(object sender, ControlEventArgs e)
        {
            if (this._msList.Items.Count > 0)
                this.ButtonSaveMSList.Enabled = true;
        }

        void TableLayoutPanelMSItem_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (this.TableLayoutPanelMSItem.Controls.Count < 1)
                this.ButtonClearMSItem.Enabled = false;
        }

        void TableLayoutPanelMSItem_ControlAdded(object sender, ControlEventArgs e)
        {
            if (this.TableLayoutPanelMSItem.Controls.Count > 0)
            {
                this.ButtonAddMSItemToMSList.Enabled = true;
                this.ButtonClearMSItem.Enabled = true;
            }
        }

        void ComboBoxListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._currentList = (L2Item.List)this._itemsLists.Find(i => i.Name == this.ComboBoxListName.SelectedValue.ToString()).Clone();

            this.ClearSearchQuery();
            this.InitControls();
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
    }
}
