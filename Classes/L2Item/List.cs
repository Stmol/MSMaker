using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MSDesigner.Classes.L2Item
{
    class List : ICloneable
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        /// <summary>
        /// Load Items property with JSON data from file
        /// </summary>
        /// <param name="pathToPackageFile"></param>
        public void ReadItemsToListFromPackage(string pathToPackageFile)
        {
            if (!File.Exists(pathToPackageFile))
                throw new FileNotFoundException(string.Format("File {1} for package {0} not found", pathToPackageFile, this.Name));

            string json = File.ReadAllText(pathToPackageFile);

            try
            {
                this.Items = JsonConvert.DeserializeObject<List<Item>>(json);
            } catch (JsonSerializationException) {
                throw new JsonSerializationException("Incorrect package file format");
            }
        }

        public void FillListViewByItems(ListView listView, string pathToIcons, int start = 0, int limit = 100)
        {
            if (this.Items.Count == 0)
                return;

            limit += start;

            if (limit > this.Items.Count)
                limit = (this.Items.Count - start) + start;

            int imageIndex = 0;

            for (int i = start; i < limit; i++)
            {
                Controls.ListViewItem listViewItem = new Controls.ListViewItem
                {
                    Text = this.Items[i].Name,
                    ToolTipText = this.Items[i].Id.ToString(),
                    ImageIndex = imageIndex++,
                    Item = this.Items[i]
                };

                if (listView.View == View.Details)
                    listViewItem.SubItems.Add(this.Items[i].Id.ToString());

                listView.LargeImageList.Images.Add(this.Items[i].GetIconImage(pathToIcons));
                listView.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// TODO: Learn about it!
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
