using System.Collections.Generic;
using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    [XmlRoot("list")]
    public class List
    {
        [XmlElement("config")]
        public MSConfig Config { get; set; }

        [XmlElement("item")]
        public List<MSItem> Items { get; set; }

        public List()
        {
            this.Config = new MSConfig();
            this.Items = new List<MSItem>();
        }
    }
}
