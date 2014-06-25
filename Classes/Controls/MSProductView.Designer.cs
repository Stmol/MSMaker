namespace MSDesigner.Classes.Controls
{
    partial class MSProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelItemName = new System.Windows.Forms.Label();
            this.CheckBoxIsIngredient = new System.Windows.Forms.CheckBox();
            this.LabelItemID = new System.Windows.Forms.Label();
            this.NumericUpDownItemCount = new System.Windows.Forms.NumericUpDown();
            this.LableItemRemove = new System.Windows.Forms.Label();
            this.PictureBoxItemIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelItemName
            // 
            this.LabelItemName.AutoEllipsis = true;
            this.LabelItemName.Location = new System.Drawing.Point(50, 17);
            this.LabelItemName.MaximumSize = new System.Drawing.Size(115, 15);
            this.LabelItemName.Name = "LabelItemName";
            this.LabelItemName.Size = new System.Drawing.Size(115, 15);
            this.LabelItemName.TabIndex = 1;
            this.LabelItemName.Text = "Item";
            // 
            // CheckBoxIsIngredient
            // 
            this.CheckBoxIsIngredient.AutoSize = true;
            this.CheckBoxIsIngredient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckBoxIsIngredient.Location = new System.Drawing.Point(165, 38);
            this.CheckBoxIsIngredient.Name = "CheckBoxIsIngredient";
            this.CheckBoxIsIngredient.Size = new System.Drawing.Size(83, 18);
            this.CheckBoxIsIngredient.TabIndex = 2;
            this.CheckBoxIsIngredient.Text = "Ingredient";
            this.CheckBoxIsIngredient.UseVisualStyleBackColor = true;
            this.CheckBoxIsIngredient.CheckedChanged += new System.EventHandler(this.CheckBoxIsIngredient_CheckedChanged);
            // 
            // LabelItemID
            // 
            this.LabelItemID.AutoSize = true;
            this.LabelItemID.BackColor = System.Drawing.Color.Transparent;
            this.LabelItemID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LabelItemID.Location = new System.Drawing.Point(50, 34);
            this.LabelItemID.MaximumSize = new System.Drawing.Size(120, 0);
            this.LabelItemID.Name = "LabelItemID";
            this.LabelItemID.Size = new System.Drawing.Size(19, 14);
            this.LabelItemID.TabIndex = 3;
            this.LabelItemID.Text = "ID";
            // 
            // NumericUpDownItemCount
            // 
            this.NumericUpDownItemCount.Location = new System.Drawing.Point(164, 12);
            this.NumericUpDownItemCount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumericUpDownItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownItemCount.Name = "NumericUpDownItemCount";
            this.NumericUpDownItemCount.Size = new System.Drawing.Size(140, 22);
            this.NumericUpDownItemCount.TabIndex = 5;
            this.NumericUpDownItemCount.ThousandsSeparator = true;
            this.NumericUpDownItemCount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NumericUpDownItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LableItemRemove
            // 
            this.LableItemRemove.AutoSize = true;
            this.LableItemRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LableItemRemove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableItemRemove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LableItemRemove.Location = new System.Drawing.Point(253, 39);
            this.LableItemRemove.Name = "LableItemRemove";
            this.LableItemRemove.Size = new System.Drawing.Size(51, 14);
            this.LableItemRemove.TabIndex = 6;
            this.LableItemRemove.Text = "Remove";
            // 
            // PictureBoxItemIcon
            // 
            this.PictureBoxItemIcon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PictureBoxItemIcon.Image = global::MSDesigner.Properties.Resources.no_icon;
            this.PictureBoxItemIcon.Location = new System.Drawing.Point(12, 16);
            this.PictureBoxItemIcon.Name = "PictureBoxItemIcon";
            this.PictureBoxItemIcon.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxItemIcon.TabIndex = 0;
            this.PictureBoxItemIcon.TabStop = false;
            // 
            // MSItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.LableItemRemove);
            this.Controls.Add(this.NumericUpDownItemCount);
            this.Controls.Add(this.LabelItemID);
            this.Controls.Add(this.CheckBoxIsIngredient);
            this.Controls.Add(this.LabelItemName);
            this.Controls.Add(this.PictureBoxItemIcon);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Name = "MSItemView";
            this.Size = new System.Drawing.Size(320, 65);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItemIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox CheckBoxIsIngredient;
        public System.Windows.Forms.NumericUpDown NumericUpDownItemCount;
        public System.Windows.Forms.Label LableItemRemove;
        private System.Windows.Forms.PictureBox PictureBoxItemIcon;
        private System.Windows.Forms.Label LabelItemName;
        private System.Windows.Forms.Label LabelItemID;
    }
}
