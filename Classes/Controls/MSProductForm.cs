using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MSDesigner.Classes.Controls
{
    public partial class MSProductForm : UserControl
    {
        public MSProductForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void MSItemForm_VisibleChanged(object sender, EventArgs e)
        {
            this.TextBoxItemID.Focus();
            this.TextBoxItemID.Clear();
            this.NumericItemCount.Value = 1;
        }

        private void TextBoxItemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void TextBoxItemID_Enter(object sender, EventArgs e)
        {
            if (this.TextBoxItemID.Text == "ID")
                this.TextBoxItemID.Clear();

            this.TextBoxItemID.ForeColor = Color.Black;
        }

        private void TextBoxItemID_Leave(object sender, EventArgs e)
        {
            if (this.TextBoxItemID.Text == "")
            {
                this.TextBoxItemID.ForeColor = Color.Gray;
                this.TextBoxItemID.Text = "ID";
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (this.TextBoxItemID.Text.Length > 9 ||
                this.TextBoxItemID.Text == "ID")
                return;

            int itemID = Convert.ToInt32(this.TextBoxItemID.Text);
            decimal count = (this.NumericItemCount.Value < 1) ? 1 : this.NumericItemCount.Value;

            MultiSell.Product newProduct = ((MSDesigner.Form1)this.Parent).CreateMSProduct(itemID, count);
            MultiSell.Item msItem = new MultiSell.Item();

            msItem.AddProductToProductions(newProduct);

            ((MSDesigner.Form1)this.Parent).AddMSItemToMSList(msItem);
            this.Visible = false;
        }
    }
}
