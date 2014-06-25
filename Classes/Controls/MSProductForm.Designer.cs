namespace MSDesigner.Classes.Controls
{
    partial class MSProductForm
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
            this.TextBoxItemID = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.NumericItemCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxItemID
            // 
            this.TextBoxItemID.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxItemID.Location = new System.Drawing.Point(3, 3);
            this.TextBoxItemID.MaxLength = 9;
            this.TextBoxItemID.Name = "TextBoxItemID";
            this.TextBoxItemID.Size = new System.Drawing.Size(194, 21);
            this.TextBoxItemID.TabIndex = 1;
            this.TextBoxItemID.Text = "ID";
            this.TextBoxItemID.Enter += new System.EventHandler(this.TextBoxItemID_Enter);
            this.TextBoxItemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxItemID_KeyPress);
            this.TextBoxItemID.Leave += new System.EventHandler(this.TextBoxItemID_Leave);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(3, 55);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(93, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.ForeColor = System.Drawing.Color.Gray;
            this.ButtonCancel.Location = new System.Drawing.Point(104, 55);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(93, 23);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // NumericItemCount
            // 
            this.NumericItemCount.Location = new System.Drawing.Point(3, 29);
            this.NumericItemCount.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NumericItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericItemCount.Name = "NumericItemCount";
            this.NumericItemCount.Size = new System.Drawing.Size(194, 21);
            this.NumericItemCount.TabIndex = 2;
            this.NumericItemCount.ThousandsSeparator = true;
            this.NumericItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MSProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumericItemCount);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxItemID);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MSItemForm";
            this.Size = new System.Drawing.Size(201, 81);
            this.VisibleChanged += new System.EventHandler(this.MSItemForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.NumericItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextBoxItemID;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.NumericUpDown NumericItemCount;
    }
}
