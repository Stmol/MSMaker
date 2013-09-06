using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    public class MSConfig
    {
        [XmlAttribute("showall")]
        public bool ShowAll { get; set; }

        [XmlAttribute("notax")]
        public bool NoTax { get; set; }

        [XmlAttribute("ignoreprice")]
        public bool IgnorePrice { get; set; }

        [XmlAttribute("keepenchanted")]
        public bool KeepEnchanted { get; set; }

        public MSConfig()
        {
            this.ShowAll = false;
            this.NoTax = false;
            this.IgnorePrice = false;
            this.KeepEnchanted = false;
        }
    }
}
