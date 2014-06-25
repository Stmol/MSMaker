namespace MSDesigner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ItemsListView = new System.Windows.Forms.ListView();
            this.ColumnItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemsIconList = new System.Windows.Forms.ImageList(this.components);
            this.ButtonNextItemListPage = new System.Windows.Forms.Button();
            this.ButtonPrevItemListPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonCopyItemID = new System.Windows.Forms.Button();
            this.TextBoxItemParams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxItemDesc = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.labelItemDesc = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.ComboBoxPackageItemName = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxPager = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearchClear = new System.Windows.Forms.Button();
            this.LinkStmol = new System.Windows.Forms.LinkLabel();
            this.LabelBy = new System.Windows.Forms.Label();
            this.DEVBUTTON = new System.Windows.Forms.Button();
            this.PanelMSGrid = new System.Windows.Forms.Panel();
            this.TableLayoutMSList = new MSDesigner.Classes.Controls.DBLayoutPanel();
            this.PictureBoxPlusBtn = new System.Windows.Forms.PictureBox();
            this.ContextMenuMSItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonMSGridUp = new System.Windows.Forms.Button();
            this.ButtonMSGridDown = new System.Windows.Forms.Button();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.ButtonSaveMSList = new System.Windows.Forms.Button();
            this.ButtonLoadMSFromXML = new System.Windows.Forms.Button();
            this.GroupBoxMultiSell = new System.Windows.Forms.GroupBox();
            this.CheckBoxMSConfigKeepEnchanted = new System.Windows.Forms.CheckBox();
            this.CheckBoxMSConfigIgnorePrice = new System.Windows.Forms.CheckBox();
            this.CheckBoxMSConfigNoTax = new System.Windows.Forms.CheckBox();
            this.CheckBoxMSConfigShowAll = new System.Windows.Forms.CheckBox();
            this.LabelXMLExt = new System.Windows.Forms.Label();
            this.TextBoxMSName = new System.Windows.Forms.TextBox();
            this.TableLayoutPanelMSItem = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAddProductToMSItem = new System.Windows.Forms.Button();
            this.PanelMSItems = new System.Windows.Forms.Panel();
            this.ButtonClearMSItem = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelDataPackageDisable = new System.Windows.Forms.Label();
            this.PictureBoxMSListMid = new System.Windows.Forms.PictureBox();
            this.PictureBoxMSListImageTop = new System.Windows.Forms.PictureBox();
            this.PictureBoxAddItem = new System.Windows.Forms.PictureBox();
            this.PictureBoxMSListBot = new System.Windows.Forms.PictureBox();
            this.PictureBoxInvChangeView = new System.Windows.Forms.PictureBox();
            this.ButtonDeleteCurrentMSItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.PanelMSGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlusBtn)).BeginInit();
            this.ContextMenuMSItem.SuspendLayout();
            this.GroupBoxMultiSell.SuspendLayout();
            this.PanelMSItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSListMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSListImageTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSListBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInvChangeView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsListView
            // 
            this.ItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnItemName,
            this.ColumnItemId});
            this.ItemsListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsListView.FullRowSelect = true;
            this.ItemsListView.GridLines = true;
            this.ItemsListView.LargeImageList = this.ItemsIconList;
            this.ItemsListView.Location = new System.Drawing.Point(14, 67);
            this.ItemsListView.Margin = new System.Windows.Forms.Padding(1);
            this.ItemsListView.MultiSelect = false;
            this.ItemsListView.Name = "ItemsListView";
            this.ItemsListView.ShowItemToolTips = true;
            this.ItemsListView.Size = new System.Drawing.Size(325, 563);
            this.ItemsListView.SmallImageList = this.ItemsIconList;
            this.ItemsListView.TabIndex = 1;
            this.ItemsListView.UseCompatibleStateImageBehavior = false;
            this.ItemsListView.SelectedIndexChanged += new System.EventHandler(this.ItemsListView_SelectedIndexChanged);
            this.ItemsListView.DoubleClick += new System.EventHandler(this.ItemsListView_DoubleClick);
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.Text = "Name";
            this.ColumnItemName.Width = 250;
            // 
            // ColumnItemId
            // 
            this.ColumnItemId.Text = "ID";
            this.ColumnItemId.Width = 61;
            // 
            // ItemsIconList
            // 
            this.ItemsIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ItemsIconList.ImageSize = new System.Drawing.Size(32, 32);
            this.ItemsIconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ButtonNextItemListPage
            // 
            this.ButtonNextItemListPage.Location = new System.Drawing.Point(257, 633);
            this.ButtonNextItemListPage.Name = "ButtonNextItemListPage";
            this.ButtonNextItemListPage.Size = new System.Drawing.Size(81, 40);
            this.ButtonNextItemListPage.TabIndex = 3;
            this.ButtonNextItemListPage.Text = "Next »";
            this.ButtonNextItemListPage.UseVisualStyleBackColor = true;
            this.ButtonNextItemListPage.Click += new System.EventHandler(this.buttonNextItemList_Click);
            // 
            // ButtonPrevItemListPage
            // 
            this.ButtonPrevItemListPage.Location = new System.Drawing.Point(14, 633);
            this.ButtonPrevItemListPage.Name = "ButtonPrevItemListPage";
            this.ButtonPrevItemListPage.Size = new System.Drawing.Size(81, 40);
            this.ButtonPrevItemListPage.TabIndex = 4;
            this.ButtonPrevItemListPage.Text = "« Prev";
            this.ButtonPrevItemListPage.UseVisualStyleBackColor = true;
            this.ButtonPrevItemListPage.Click += new System.EventHandler(this.buttonPrevItemList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonCopyItemID);
            this.groupBox1.Controls.Add(this.TextBoxItemParams);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxItemDesc);
            this.groupBox1.Controls.Add(this.textBoxItemName);
            this.groupBox1.Controls.Add(this.textBoxItemId);
            this.groupBox1.Controls.Add(this.labelItemId);
            this.groupBox1.Controls.Add(this.labelItemDesc);
            this.groupBox1.Controls.Add(this.labelItemName);
            this.groupBox1.Location = new System.Drawing.Point(14, 718);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details";
            this.groupBox1.Visible = false;
            // 
            // ButtonCopyItemID
            // 
            this.ButtonCopyItemID.Location = new System.Drawing.Point(184, 21);
            this.ButtonCopyItemID.Name = "ButtonCopyItemID";
            this.ButtonCopyItemID.Size = new System.Drawing.Size(45, 23);
            this.ButtonCopyItemID.TabIndex = 6;
            this.ButtonCopyItemID.Text = "Copy";
            this.ButtonCopyItemID.UseVisualStyleBackColor = true;
            this.ButtonCopyItemID.Click += new System.EventHandler(this.ButtonCopyItemID_Click);
            // 
            // TextBoxItemParams
            // 
            this.TextBoxItemParams.Location = new System.Drawing.Point(85, 157);
            this.TextBoxItemParams.Multiline = true;
            this.TextBoxItemParams.Name = "TextBoxItemParams";
            this.TextBoxItemParams.ReadOnly = true;
            this.TextBoxItemParams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxItemParams.Size = new System.Drawing.Size(144, 151);
            this.TextBoxItemParams.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parameters";
            // 
            // textBoxItemDesc
            // 
            this.textBoxItemDesc.Location = new System.Drawing.Point(84, 88);
            this.textBoxItemDesc.Multiline = true;
            this.textBoxItemDesc.Name = "textBoxItemDesc";
            this.textBoxItemDesc.ReadOnly = true;
            this.textBoxItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxItemDesc.Size = new System.Drawing.Size(145, 62);
            this.textBoxItemDesc.TabIndex = 3;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(84, 51);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.ReadOnly = true;
            this.textBoxItemName.Size = new System.Drawing.Size(145, 22);
            this.textBoxItemName.TabIndex = 2;
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Location = new System.Drawing.Point(84, 22);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.ReadOnly = true;
            this.textBoxItemId.Size = new System.Drawing.Size(94, 22);
            this.textBoxItemId.TabIndex = 1;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Location = new System.Drawing.Point(56, 25);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(19, 14);
            this.labelItemId.TabIndex = 0;
            this.labelItemId.Text = "ID";
            // 
            // labelItemDesc
            // 
            this.labelItemDesc.AutoSize = true;
            this.labelItemDesc.Location = new System.Drawing.Point(7, 88);
            this.labelItemDesc.Name = "labelItemDesc";
            this.labelItemDesc.Size = new System.Drawing.Size(67, 14);
            this.labelItemDesc.TabIndex = 0;
            this.labelItemDesc.Text = "Description";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(37, 54);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(38, 14);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Name";
            // 
            // ComboBoxPackageItemName
            // 
            this.ComboBoxPackageItemName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxPackageItemName.DataSource = this.itemBindingSource;
            this.ComboBoxPackageItemName.DisplayMember = "Name";
            this.ComboBoxPackageItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPackageItemName.FormattingEnabled = true;
            this.ComboBoxPackageItemName.ItemHeight = 14;
            this.ComboBoxPackageItemName.Location = new System.Drawing.Point(14, 13);
            this.ComboBoxPackageItemName.MaxDropDownItems = 10;
            this.ComboBoxPackageItemName.Name = "ComboBoxPackageItemName";
            this.ComboBoxPackageItemName.Size = new System.Drawing.Size(325, 22);
            this.ComboBoxPackageItemName.TabIndex = 9;
            this.ComboBoxPackageItemName.ValueMember = "Name";
            this.ComboBoxPackageItemName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListName_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MSDesigner.Classes.DataPackage.Item);
            // 
            // ComboBoxPager
            // 
            this.ComboBoxPager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPager.Location = new System.Drawing.Point(152, 643);
            this.ComboBoxPager.Name = "ComboBoxPager";
            this.ComboBoxPager.Size = new System.Drawing.Size(48, 22);
            this.ComboBoxPager.TabIndex = 10;
            this.ComboBoxPager.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPager_SelectedIndexChanged);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxSearch.Location = new System.Drawing.Point(14, 41);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(232, 22);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.Text = "ID or Name";
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.TextBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // ButtonSearchClear
            // 
            this.ButtonSearchClear.Location = new System.Drawing.Point(250, 40);
            this.ButtonSearchClear.Name = "ButtonSearchClear";
            this.ButtonSearchClear.Size = new System.Drawing.Size(67, 23);
            this.ButtonSearchClear.TabIndex = 14;
            this.ButtonSearchClear.Text = "Clear";
            this.ButtonSearchClear.UseVisualStyleBackColor = true;
            this.ButtonSearchClear.Click += new System.EventHandler(this.ButtonSearchClear_Click);
            // 
            // LinkStmol
            // 
            this.LinkStmol.AutoSize = true;
            this.LinkStmol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkStmol.Location = new System.Drawing.Point(1005, 683);
            this.LinkStmol.Name = "LinkStmol";
            this.LinkStmol.Size = new System.Drawing.Size(33, 13);
            this.LinkStmol.TabIndex = 15;
            this.LinkStmol.TabStop = true;
            this.LinkStmol.Text = "Stmol";
            this.LinkStmol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkStmol_LinkClicked);
            // 
            // LabelBy
            // 
            this.LabelBy.AutoSize = true;
            this.LabelBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBy.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelBy.Location = new System.Drawing.Point(867, 683);
            this.LabelBy.Name = "LabelBy";
            this.LabelBy.Size = new System.Drawing.Size(141, 13);
            this.LabelBy.TabIndex = 16;
            this.LabelBy.Text = "MSDesigner is developed by";
            // 
            // DEVBUTTON
            // 
            this.DEVBUTTON.Location = new System.Drawing.Point(838, 13);
            this.DEVBUTTON.Name = "DEVBUTTON";
            this.DEVBUTTON.Size = new System.Drawing.Size(75, 23);
            this.DEVBUTTON.TabIndex = 18;
            this.DEVBUTTON.Text = "dev";
            this.DEVBUTTON.UseVisualStyleBackColor = true;
            this.DEVBUTTON.Click += new System.EventHandler(this.DEVBUTTON_CLICK);
            // 
            // PanelMSGrid
            // 
            this.PanelMSGrid.BackColor = System.Drawing.Color.Transparent;
            this.PanelMSGrid.Controls.Add(this.TableLayoutMSList);
            this.PanelMSGrid.Location = new System.Drawing.Point(403, 69);
            this.PanelMSGrid.Name = "PanelMSGrid";
            this.PanelMSGrid.Size = new System.Drawing.Size(222, 504);
            this.PanelMSGrid.TabIndex = 23;
            // 
            // TableLayoutMSList
            // 
            this.TableLayoutMSList.AutoSize = true;
            this.TableLayoutMSList.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutMSList.BackgroundImage = global::MSDesigner.Properties.Resources.GridLineTile;
            this.TableLayoutMSList.ColumnCount = 6;
            this.TableLayoutMSList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutMSList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutMSList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutMSList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutMSList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutMSList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutMSList.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMSList.Name = "TableLayoutMSList";
            this.TableLayoutMSList.RowCount = 13;
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutMSList.Size = new System.Drawing.Size(222, 504);
            this.TableLayoutMSList.TabIndex = 24;
            this.TableLayoutMSList.Resize += new System.EventHandler(this.TableLayoutMSGrid_Resize);
            // 
            // PictureBoxPlusBtn
            // 
            this.PictureBoxPlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxPlusBtn.Image = global::MSDesigner.Properties.Resources.PlusBtn;
            this.PictureBoxPlusBtn.Location = new System.Drawing.Point(275, 718);
            this.PictureBoxPlusBtn.Name = "PictureBoxPlusBtn";
            this.PictureBoxPlusBtn.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxPlusBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxPlusBtn.TabIndex = 34;
            this.PictureBoxPlusBtn.TabStop = false;
            this.PictureBoxPlusBtn.Visible = false;
            this.PictureBoxPlusBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxPlusBtn_MouseDown);
            this.PictureBoxPlusBtn.MouseLeave += new System.EventHandler(this.PictureBoxPlusBtn_MouseLeave);
            this.PictureBoxPlusBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxPlusBtn_MouseMove);
            // 
            // ContextMenuMSItem
            // 
            this.ContextMenuMSItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ContextMenuMSItem.Name = "ContextMenuMSItem";
            this.ContextMenuMSItem.ShowImageMargin = false;
            this.ContextMenuMSItem.Size = new System.Drawing.Size(93, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditMSItemToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveMSItemToolStripMenuItem_Click);
            // 
            // ButtonMSGridUp
            // 
            this.ButtonMSGridUp.Enabled = false;
            this.ButtonMSGridUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMSGridUp.Location = new System.Drawing.Point(432, 633);
            this.ButtonMSGridUp.Name = "ButtonMSGridUp";
            this.ButtonMSGridUp.Size = new System.Drawing.Size(81, 40);
            this.ButtonMSGridUp.TabIndex = 24;
            this.ButtonMSGridUp.Text = "↑";
            this.ButtonMSGridUp.UseVisualStyleBackColor = true;
            this.ButtonMSGridUp.Click += new System.EventHandler(this.ButtonMSGridUp_Click);
            // 
            // ButtonMSGridDown
            // 
            this.ButtonMSGridDown.Enabled = false;
            this.ButtonMSGridDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMSGridDown.Location = new System.Drawing.Point(519, 633);
            this.ButtonMSGridDown.Name = "ButtonMSGridDown";
            this.ButtonMSGridDown.Size = new System.Drawing.Size(81, 40);
            this.ButtonMSGridDown.TabIndex = 24;
            this.ButtonMSGridDown.Text = "↓";
            this.ButtonMSGridDown.UseVisualStyleBackColor = true;
            this.ButtonMSGridDown.Click += new System.EventHandler(this.ButtonMSGridDown_Click);
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCopyright.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelCopyright.Location = new System.Drawing.Point(12, 683);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(551, 13);
            this.LabelCopyright.TabIndex = 25;
            this.LabelCopyright.Text = "Lineage II is a trademark of NCsoft Corporation. Copyright © NCsoft Corporation 2" +
    "005-2013. All rights reserved.";
            // 
            // ButtonSaveMSList
            // 
            this.ButtonSaveMSList.Location = new System.Drawing.Point(779, 637);
            this.ButtonSaveMSList.Name = "ButtonSaveMSList";
            this.ButtonSaveMSList.Size = new System.Drawing.Size(162, 32);
            this.ButtonSaveMSList.TabIndex = 26;
            this.ButtonSaveMSList.Text = "Save MultiSell";
            this.ButtonSaveMSList.UseVisualStyleBackColor = true;
            this.ButtonSaveMSList.Click += new System.EventHandler(this.SaveMSListToXML_Click);
            // 
            // ButtonLoadMSFromXML
            // 
            this.ButtonLoadMSFromXML.Enabled = false;
            this.ButtonLoadMSFromXML.Location = new System.Drawing.Point(41, 210);
            this.ButtonLoadMSFromXML.Name = "ButtonLoadMSFromXML";
            this.ButtonLoadMSFromXML.Size = new System.Drawing.Size(162, 32);
            this.ButtonLoadMSFromXML.TabIndex = 26;
            this.ButtonLoadMSFromXML.Text = "Load MultiSell";
            this.ButtonLoadMSFromXML.UseVisualStyleBackColor = true;
            // 
            // GroupBoxMultiSell
            // 
            this.GroupBoxMultiSell.Controls.Add(this.CheckBoxMSConfigKeepEnchanted);
            this.GroupBoxMultiSell.Controls.Add(this.CheckBoxMSConfigIgnorePrice);
            this.GroupBoxMultiSell.Controls.Add(this.CheckBoxMSConfigNoTax);
            this.GroupBoxMultiSell.Controls.Add(this.CheckBoxMSConfigShowAll);
            this.GroupBoxMultiSell.Controls.Add(this.ButtonLoadMSFromXML);
            this.GroupBoxMultiSell.Location = new System.Drawing.Point(403, 718);
            this.GroupBoxMultiSell.Name = "GroupBoxMultiSell";
            this.GroupBoxMultiSell.Size = new System.Drawing.Size(257, 249);
            this.GroupBoxMultiSell.TabIndex = 27;
            this.GroupBoxMultiSell.TabStop = false;
            this.GroupBoxMultiSell.Text = "MultiSell";
            // 
            // CheckBoxMSConfigKeepEnchanted
            // 
            this.CheckBoxMSConfigKeepEnchanted.AutoSize = true;
            this.CheckBoxMSConfigKeepEnchanted.Location = new System.Drawing.Point(17, 101);
            this.CheckBoxMSConfigKeepEnchanted.Name = "CheckBoxMSConfigKeepEnchanted";
            this.CheckBoxMSConfigKeepEnchanted.Size = new System.Drawing.Size(117, 18);
            this.CheckBoxMSConfigKeepEnchanted.TabIndex = 27;
            this.CheckBoxMSConfigKeepEnchanted.Text = "Keep Enchanted";
            this.CheckBoxMSConfigKeepEnchanted.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMSConfigIgnorePrice
            // 
            this.CheckBoxMSConfigIgnorePrice.AutoSize = true;
            this.CheckBoxMSConfigIgnorePrice.Location = new System.Drawing.Point(17, 77);
            this.CheckBoxMSConfigIgnorePrice.Name = "CheckBoxMSConfigIgnorePrice";
            this.CheckBoxMSConfigIgnorePrice.Size = new System.Drawing.Size(92, 18);
            this.CheckBoxMSConfigIgnorePrice.TabIndex = 27;
            this.CheckBoxMSConfigIgnorePrice.Text = "Ignore Price";
            this.CheckBoxMSConfigIgnorePrice.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMSConfigNoTax
            // 
            this.CheckBoxMSConfigNoTax.AutoSize = true;
            this.CheckBoxMSConfigNoTax.Location = new System.Drawing.Point(17, 53);
            this.CheckBoxMSConfigNoTax.Name = "CheckBoxMSConfigNoTax";
            this.CheckBoxMSConfigNoTax.Size = new System.Drawing.Size(65, 18);
            this.CheckBoxMSConfigNoTax.TabIndex = 27;
            this.CheckBoxMSConfigNoTax.Text = "No Tax";
            this.CheckBoxMSConfigNoTax.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMSConfigShowAll
            // 
            this.CheckBoxMSConfigShowAll.AutoSize = true;
            this.CheckBoxMSConfigShowAll.Checked = true;
            this.CheckBoxMSConfigShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxMSConfigShowAll.Location = new System.Drawing.Point(17, 29);
            this.CheckBoxMSConfigShowAll.Name = "CheckBoxMSConfigShowAll";
            this.CheckBoxMSConfigShowAll.Size = new System.Drawing.Size(73, 18);
            this.CheckBoxMSConfigShowAll.TabIndex = 27;
            this.CheckBoxMSConfigShowAll.Text = "Show All";
            this.CheckBoxMSConfigShowAll.UseVisualStyleBackColor = true;
            // 
            // LabelXMLExt
            // 
            this.LabelXMLExt.AutoSize = true;
            this.LabelXMLExt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LabelXMLExt.Location = new System.Drawing.Point(943, 612);
            this.LabelXMLExt.Name = "LabelXMLExt";
            this.LabelXMLExt.Size = new System.Drawing.Size(29, 14);
            this.LabelXMLExt.TabIndex = 29;
            this.LabelXMLExt.Text = ".xml";
            // 
            // TextBoxMSName
            // 
            this.TextBoxMSName.Location = new System.Drawing.Point(779, 609);
            this.TextBoxMSName.Name = "TextBoxMSName";
            this.TextBoxMSName.Size = new System.Drawing.Size(162, 22);
            this.TextBoxMSName.TabIndex = 28;
            this.TextBoxMSName.Text = "multisell";
            // 
            // TableLayoutPanelMSItem
            // 
            this.TableLayoutPanelMSItem.AutoSize = true;
            this.TableLayoutPanelMSItem.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelMSItem.ColumnCount = 1;
            this.TableLayoutPanelMSItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.TableLayoutPanelMSItem.Location = new System.Drawing.Point(2, 0);
            this.TableLayoutPanelMSItem.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelMSItem.Name = "TableLayoutPanelMSItem";
            this.TableLayoutPanelMSItem.RowCount = 1;
            this.TableLayoutPanelMSItem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMSItem.Size = new System.Drawing.Size(320, 5);
            this.TableLayoutPanelMSItem.TabIndex = 28;
            // 
            // ButtonAddProductToMSItem
            // 
            this.ButtonAddProductToMSItem.Location = new System.Drawing.Point(690, 470);
            this.ButtonAddProductToMSItem.Name = "ButtonAddProductToMSItem";
            this.ButtonAddProductToMSItem.Size = new System.Drawing.Size(159, 32);
            this.ButtonAddProductToMSItem.TabIndex = 26;
            this.ButtonAddProductToMSItem.Text = "New item";
            this.ButtonAddProductToMSItem.UseVisualStyleBackColor = true;
            this.ButtonAddProductToMSItem.Click += new System.EventHandler(this.ButtonAddProductToMSItem_Click);
            // 
            // PanelMSItems
            // 
            this.PanelMSItems.AutoScroll = true;
            this.PanelMSItems.BackColor = System.Drawing.Color.Transparent;
            this.PanelMSItems.Controls.Add(this.TableLayoutPanelMSItem);
            this.PanelMSItems.Location = new System.Drawing.Point(688, 69);
            this.PanelMSItems.Name = "PanelMSItems";
            this.PanelMSItems.Size = new System.Drawing.Size(350, 395);
            this.PanelMSItems.TabIndex = 29;
            // 
            // ButtonClearMSItem
            // 
            this.ButtonClearMSItem.Enabled = false;
            this.ButtonClearMSItem.Location = new System.Drawing.Point(666, 730);
            this.ButtonClearMSItem.Name = "ButtonClearMSItem";
            this.ButtonClearMSItem.Size = new System.Drawing.Size(162, 32);
            this.ButtonClearMSItem.TabIndex = 30;
            this.ButtonClearMSItem.Text = "Clear";
            this.ButtonClearMSItem.UseVisualStyleBackColor = true;
            this.ButtonClearMSItem.Click += new System.EventHandler(this.ButtonClearMSItem_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(919, 13);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(119, 50);
            this.ButtonExit.TabIndex = 31;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelDataPackageDisable
            // 
            this.LabelDataPackageDisable.AutoSize = true;
            this.LabelDataPackageDisable.BackColor = System.Drawing.SystemColors.Control;
            this.LabelDataPackageDisable.Enabled = false;
            this.LabelDataPackageDisable.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelDataPackageDisable.Location = new System.Drawing.Point(106, 341);
            this.LabelDataPackageDisable.Name = "LabelDataPackageDisable";
            this.LabelDataPackageDisable.Size = new System.Drawing.Size(140, 14);
            this.LabelDataPackageDisable.TabIndex = 32;
            this.LabelDataPackageDisable.Text = "Data Package not found";
            this.LabelDataPackageDisable.Visible = false;
            // 
            // PictureBoxMSListMid
            // 
            this.PictureBoxMSListMid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxMSListMid.BackgroundImage")));
            this.PictureBoxMSListMid.Location = new System.Drawing.Point(388, 80);
            this.PictureBoxMSListMid.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxMSListMid.Name = "PictureBoxMSListMid";
            this.PictureBoxMSListMid.Size = new System.Drawing.Size(253, 504);
            this.PictureBoxMSListMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxMSListMid.TabIndex = 2;
            this.PictureBoxMSListMid.TabStop = false;
            // 
            // PictureBoxMSListImageTop
            // 
            this.PictureBoxMSListImageTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxMSListImageTop.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMSListImageTop.Image")));
            this.PictureBoxMSListImageTop.Location = new System.Drawing.Point(388, 13);
            this.PictureBoxMSListImageTop.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxMSListImageTop.Name = "PictureBoxMSListImageTop";
            this.PictureBoxMSListImageTop.Size = new System.Drawing.Size(253, 68);
            this.PictureBoxMSListImageTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxMSListImageTop.TabIndex = 0;
            this.PictureBoxMSListImageTop.TabStop = false;
            // 
            // PictureBoxAddItem
            // 
            this.PictureBoxAddItem.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAddItem.Image = global::MSDesigner.Properties.Resources.BtnAddItem2;
            this.PictureBoxAddItem.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxAddItem.Name = "PictureBoxAddItem";
            this.PictureBoxAddItem.Size = new System.Drawing.Size(197, 29);
            this.PictureBoxAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxAddItem.TabIndex = 36;
            this.PictureBoxAddItem.TabStop = false;
            this.PictureBoxAddItem.Click += new System.EventHandler(this.PictureBoxAddItem_Click);
            this.PictureBoxAddItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxAddItem_MouseDown);
            this.PictureBoxAddItem.MouseLeave += new System.EventHandler(this.PictureBoxAddItem_MouseLeave);
            this.PictureBoxAddItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxAddItem_MouseMove);
            // 
            // PictureBoxMSListBot
            // 
            this.PictureBoxMSListBot.Image = global::MSDesigner.Properties.Resources.MSListBottomBig;
            this.PictureBoxMSListBot.Location = new System.Drawing.Point(388, 584);
            this.PictureBoxMSListBot.Name = "PictureBoxMSListBot";
            this.PictureBoxMSListBot.Size = new System.Drawing.Size(253, 47);
            this.PictureBoxMSListBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxMSListBot.TabIndex = 37;
            this.PictureBoxMSListBot.TabStop = false;
            // 
            // PictureBoxInvChangeView
            // 
            this.PictureBoxInvChangeView.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxInvChangeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxInvChangeView.Image = global::MSDesigner.Properties.Resources.PostWndList;
            this.PictureBoxInvChangeView.Location = new System.Drawing.Point(321, 44);
            this.PictureBoxInvChangeView.Name = "PictureBoxInvChangeView";
            this.PictureBoxInvChangeView.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxInvChangeView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxInvChangeView.TabIndex = 39;
            this.PictureBoxInvChangeView.TabStop = false;
            this.PictureBoxInvChangeView.Click += new System.EventHandler(this.PictureBoxInvChangeView_Click);
            this.PictureBoxInvChangeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxInvChangeView_MouseDown);
            this.PictureBoxInvChangeView.MouseLeave += new System.EventHandler(this.PictureBoxInvChangeView_MouseLeave);
            this.PictureBoxInvChangeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxInvChangeView_MouseMove);
            // 
            // ButtonDeleteCurrentMSItem
            // 
            this.ButtonDeleteCurrentMSItem.Location = new System.Drawing.Point(851, 470);
            this.ButtonDeleteCurrentMSItem.Name = "ButtonDeleteCurrentMSItem";
            this.ButtonDeleteCurrentMSItem.Size = new System.Drawing.Size(159, 32);
            this.ButtonDeleteCurrentMSItem.TabIndex = 26;
            this.ButtonDeleteCurrentMSItem.Text = "Delete";
            this.ButtonDeleteCurrentMSItem.UseVisualStyleBackColor = true;
            this.ButtonDeleteCurrentMSItem.Click += new System.EventHandler(this.ButtonDeleteCurrentMSItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1054, 706);
            this.Controls.Add(this.LabelXMLExt);
            this.Controls.Add(this.TextBoxMSName);
            this.Controls.Add(this.PictureBoxInvChangeView);
            this.Controls.Add(this.ComboBoxPager);
            this.Controls.Add(this.ButtonPrevItemListPage);
            this.Controls.Add(this.ButtonNextItemListPage);
            this.Controls.Add(this.PanelMSGrid);
            this.Controls.Add(this.ButtonSaveMSList);
            this.Controls.Add(this.PictureBoxPlusBtn);
            this.Controls.Add(this.PictureBoxMSListImageTop);
            this.Controls.Add(this.PictureBoxMSListMid);
            this.Controls.Add(this.LabelDataPackageDisable);
            this.Controls.Add(this.ButtonMSGridUp);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.PictureBoxMSListBot);
            this.Controls.Add(this.ButtonClearMSItem);
            this.Controls.Add(this.ButtonMSGridDown);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.PanelMSItems);
            this.Controls.Add(this.ButtonDeleteCurrentMSItem);
            this.Controls.Add(this.ButtonAddProductToMSItem);
            this.Controls.Add(this.GroupBoxMultiSell);
            this.Controls.Add(this.ButtonSearchClear);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ComboBoxPackageItemName);
            this.Controls.Add(this.ItemsListView);
            this.Controls.Add(this.DEVBUTTON);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelBy);
            this.Controls.Add(this.LinkStmol);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MSDesigner - Lineage 2 MultiSell Editor [Beta]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.PanelMSGrid.ResumeLayout(false);
            this.PanelMSGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlusBtn)).EndInit();
            this.ContextMenuMSItem.ResumeLayout(false);
            this.GroupBoxMultiSell.ResumeLayout(false);
            this.GroupBoxMultiSell.PerformLayout();
            this.PanelMSItems.ResumeLayout(false);
            this.PanelMSItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSListMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSListImageTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMSListBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInvChangeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemsListView;
        private System.Windows.Forms.Button ButtonNextItemListPage;
        private System.Windows.Forms.Button ButtonPrevItemListPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.TextBox textBoxItemDesc;
        private System.Windows.Forms.Label labelItemDesc;
        private System.Windows.Forms.ComboBox ComboBoxPackageItemName;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.ImageList ItemsIconList;
        private System.Windows.Forms.ComboBox ComboBoxPager;
        private System.Windows.Forms.TextBox TextBoxItemParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearchClear;
        private System.Windows.Forms.LinkLabel LinkStmol;
        private System.Windows.Forms.Label LabelBy;
        private System.Windows.Forms.ColumnHeader ColumnItemName;
        private System.Windows.Forms.ColumnHeader ColumnItemId;
        private System.Windows.Forms.Button DEVBUTTON;
        private System.Windows.Forms.Panel PanelMSGrid;
        private Classes.Controls.DBLayoutPanel TableLayoutMSList;
        private System.Windows.Forms.ContextMenuStrip ContextMenuMSItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button ButtonMSGridUp;
        private System.Windows.Forms.Button ButtonMSGridDown;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.Button ButtonCopyItemID;
        private System.Windows.Forms.Button ButtonSaveMSList;
        private System.Windows.Forms.Button ButtonLoadMSFromXML;
        private System.Windows.Forms.GroupBox GroupBoxMultiSell;
        private System.Windows.Forms.CheckBox CheckBoxMSConfigKeepEnchanted;
        private System.Windows.Forms.CheckBox CheckBoxMSConfigIgnorePrice;
        private System.Windows.Forms.CheckBox CheckBoxMSConfigNoTax;
        private System.Windows.Forms.CheckBox CheckBoxMSConfigShowAll;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMSItem;
        private System.Windows.Forms.Button ButtonAddProductToMSItem;
        private System.Windows.Forms.Panel PanelMSItems;
        private System.Windows.Forms.Button ButtonClearMSItem;
        private System.Windows.Forms.TextBox TextBoxMSName;
        private System.Windows.Forms.Label LabelXMLExt;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelDataPackageDisable;
        private System.Windows.Forms.PictureBox PictureBoxPlusBtn;
        private System.Windows.Forms.PictureBox PictureBoxMSListImageTop;
        private System.Windows.Forms.PictureBox PictureBoxMSListMid;
        private System.Windows.Forms.PictureBox PictureBoxAddItem;
        private System.Windows.Forms.PictureBox PictureBoxMSListBot;
        private System.Windows.Forms.PictureBox PictureBoxInvChangeView;
        private System.Windows.Forms.Button ButtonDeleteCurrentMSItem;

    }
}

