using System.Collections.Generic;
using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    [XmlRoot("item")]
    public class Item
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("ingredient")]
        public List<Product> ingredients { get; set; }

        [XmlElement("production")]
        public List<Product> productions { get; set; }

        public Item()
        {
            this.ingredients = new List<Product>();
            this.productions = new List<Product>();
        }

        public void AddProductToProductions(Product p)
        {
            this.productions.Add(p);
        }
    }
}
