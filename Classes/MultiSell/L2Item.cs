using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    public class L2Item : MSDesigner.Classes.L2Item.Item
    {
        [XmlAttribute("count")]
        public decimal Count { get; set; }

        public L2Item()
        {
            this.Count = 0;
        }
    }
}
