using System.Collections.Generic;
using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    [XmlRoot("list")]
    public class List
    {
        [XmlElement("config")]
        public Config Config { get; set; }

        [XmlElement("item")]
        public List<Item> Items { get; set; }

        public List()
        {
            this.Config = new Config();
            this.Items = new List<Item>();
        }
    }
}
