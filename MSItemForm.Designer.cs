namespace MSDesigner
{
    partial class MSItemForm
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
            this.TextBoxItemID = new System.Windows.Forms.TextBox();
            this.TextBoxItemCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBoxSubmit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxItemID
            // 
            this.TextBoxItemID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBoxItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxItemID.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxItemID.Location = new System.Drawing.Point(57, 9);
            this.TextBoxItemID.MaxLength = 9;
            this.TextBoxItemID.Name = "TextBoxItemID";
            this.TextBoxItemID.Size = new System.Drawing.Size(170, 22);
            this.TextBoxItemID.TabIndex = 1;
            this.TextBoxItemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TextBoxItemCount
            // 
            this.TextBoxItemCount.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBoxItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxItemCount.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxItemCount.Location = new System.Drawing.Point(57, 37);
            this.TextBoxItemCount.MaxLength = 11;
            this.TextBoxItemCount.Name = "TextBoxItemCount";
            this.TextBoxItemCount.Size = new System.Drawing.Size(170, 22);
            this.TextBoxItemCount.TabIndex = 2;
            this.TextBoxItemCount.Text = "1";
            this.TextBoxItemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count";
            // 
            // PictureBoxSubmit
            // 
            this.PictureBoxSubmit.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSubmit.Image = global::MSDesigner.Properties.Resources.BtnSubmit;
            this.PictureBoxSubmit.Location = new System.Drawing.Point(77, 65);
            this.PictureBoxSubmit.Name = "PictureBoxSubmit";
            this.PictureBoxSubmit.Size = new System.Drawing.Size(92, 24);
            this.PictureBoxSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxSubmit.TabIndex = 6;
            this.PictureBoxSubmit.TabStop = false;
            this.PictureBoxSubmit.Click += new System.EventHandler(this.PictureBoxSubmit_Click);
            this.PictureBoxSubmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.PictureBoxSubmit.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.PictureBoxSubmit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxSubmit_MouseMove);
            // 
            // MSItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(242, 94);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBoxSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxItemCount);
            this.Controls.Add(this.TextBoxItemID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MSItemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MSItemForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxItemID;
        private System.Windows.Forms.TextBox TextBoxItemCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureBoxSubmit;
    }
}