using System.Xml.Serialization;

namespace MSDesigner.Classes.MultiSell
{
    public class Product : MSDesigner.Classes.L2Item.Item
    {
        [XmlAttribute("count")]
        public decimal Count { get; set; }

        public Product()
        {
            this.Count = 0;
        }

        public static Product CreateProductFromL2Item(L2Item.Item l2Item)
        {
            if (l2Item == null)
                return new Product();

            return new Product
            {
                Id = l2Item.Id,
                Name = l2Item.Name,
                Icon = l2Item.Icon,
                Count = 1
            };
        }
    }
}
