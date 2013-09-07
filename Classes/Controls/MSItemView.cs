using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MSDesigner.Classes.Controls
{
    public partial class MSItemView : UserControl
    {
        public MultiSell.L2Item Item { get; private set; }
        public delegate void RemoveCallback(object sender, EventArgs e);

        private Image _itemImage;

        public MSItemView(MultiSell.L2Item item, Image itemImage, RemoveCallback removeCallback)
        {
            InitializeComponent();

            this.Item = item;
            this._itemImage = itemImage;

            this.LableItemRemove.Click += new System.EventHandler(removeCallback);
            this.LoadItemToForm();
        }

        private void LoadItemToForm()
        {
            this.LabelItemName.Text = this.Item.Name;
            this.LabelItemID.Text = this.Item.Id.ToString();
            this.NumericUpDownItemCount.Value = this.Item.Count;
            this.PictureBoxItemIcon.Image = this._itemImage;
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
