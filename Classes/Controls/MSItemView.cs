using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MSDesigner.Classes.Controls
{
    public partial class MSItemView : UserControl
    {
        public MultiSell.L2Item Item { get; private set; }

        private string _pathToItemIcon;

        public delegate void RemoveCallback(object sender, EventArgs e);

        public MSItemView(MultiSell.L2Item item, string pathToItemIcon, RemoveCallback removeCallback)
        {
            InitializeComponent();

            this.Item = item;
            this._pathToItemIcon = pathToItemIcon;

            this.LableItemRemove.Click += new System.EventHandler(removeCallback);
            this.LoadItemToForm();
        }

        private void LoadItemToForm()
        {
            this.LabelItemName.Text = this.Item.Name;
            this.LabelItemID.Text = this.Item.Id.ToString();
            this.NumericUpDownItemCount.Value = this.Item.Count;

            if (File.Exists(this._pathToItemIcon))
                this.PictureBoxItemIcon.Image = Image.FromFile(this._pathToItemIcon);
            else
                this.PictureBoxItemIcon.Image = Properties.Resources.no_icon;
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
