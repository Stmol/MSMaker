using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MultiSell = MSDesigner.Classes.MultiSell;

namespace MSDesigner
{
    public partial class MSItemForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Func<int, decimal, MultiSell::Product> _createNewProduct;
        private Action<object> _addProductAction;

        public MSItemForm(Func<int, decimal, MultiSell::Product> createNewProduct, Action<object> addProductAction)
        {
            InitializeComponent();

            this._createNewProduct = createNewProduct;
            this._addProductAction = addProductAction;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MSItemForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(this.Parent);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBoxSubmit.Image = Properties.Resources.BtnSubmit;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.PictureBoxSubmit.Image = Properties.Resources.BtnSubmitDown;
        }

        private void PictureBoxSubmit_MouseMove(object sender, MouseEventArgs e)
        {
            this.PictureBoxSubmit.Image = Properties.Resources.BtnSubmitOver;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void PictureBoxSubmit_Click(object sender, EventArgs e)
        {
            if (this.TextBoxItemID.Text == "" || this.TextBoxItemCount.Text == "")
                return;

            int itemID = Convert.ToInt32(this.TextBoxItemID.Text);
            decimal itemCount = Convert.ToDecimal(this.TextBoxItemCount.Text);

            MultiSell.Product newProduct = this._createNewProduct(itemID, itemCount);

            //MultiSell.Item msItem = new MultiSell.Item();
            //msItem.AddProductToProductions(newProduct);

            this._addProductAction(newProduct);
            this.Close();
        }
    }
}
