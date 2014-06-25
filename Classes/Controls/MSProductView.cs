using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MSDesigner.Classes.Controls
{
    public partial class MSProductView : UserControl
    {
        public MultiSell.Product Item { get; set; }
        public Image ItemImage { get; set; }

        //public delegate void RemoveCallback(object sender, EventArgs e);


        public MSProductView(MultiSell.Product item, Image itemImage)
        {
            InitializeComponent();

            this.Item = item;
            this.ItemImage = itemImage;

            this.LoadItemToForm();
            //this.LableItemRemove.Click += new System.EventHandler(removeCallback);
        }

        private void LoadItemToForm()
        {
            this.LabelItemName.Text = (this.Item.Name != null) ? this.Item.Name : this.Item.Id.ToString();
            this.LabelItemID.Text = this.Item.Id.ToString();
            this.NumericUpDownItemCount.Value = this.Item.Count;
            this.PictureBoxItemIcon.Image = this.ItemImage;
        }

        private void CheckBoxIsIngredient_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxIsIngredient.Checked)
                this.BackColor = Color.Beige;
            else
                this.BackColor = Color.Gainsboro;
        }
    }
}
