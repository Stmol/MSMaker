using System.Collections.Generic;
using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    [XmlRoot("item")]
    public class MSItem
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("ingredient")]
        public List<L2Item> ingredients { get; set; }

        [XmlElement("production")]
        public List<L2Item> productions { get; set; }

        public MSItem()
        {
            this.ingredients = new List<L2Item>();
            this.productions = new List<L2Item>();
        }
    }
}
