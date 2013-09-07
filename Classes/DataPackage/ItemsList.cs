using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using DPackage = MSDesigner.Classes.DataPackage;
using L2Item = MSDesigner.Classes.L2Item;

namespace MSDesigner.Classes.DataPackage
{
    /**
     * 
     * TODO: Learn about ICloneable interface!
     */
    [System.Obsolete("Use L2Item.List", true)]
    class ItemsList : ICloneable
    {
        public string Name { get; set; }
        public DPackage::Item ItemFromConfig { private get; set; }
        public List<L2Item::Item> Items { get; set; }

        public void LoadItemsList()
        {
            if (!File.Exists(this.ItemFromConfig.Path))
                throw new Exception(string.Format(@"File for item {0} not found", this.ItemFromConfig.Name));

            string json = File.ReadAllText(this.ItemFromConfig.Path);

            try
            {
                this.Items = JsonConvert.DeserializeObject<List<L2Item::Item>>(json);
            }
            catch (JsonSerializationException e)
            {
                MessageBox.Show(e.Message.ToString(), "Incorrect package file format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
