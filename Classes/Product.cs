using System.ComponentModel;
using System.Linq;

namespace C968.Classes
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            Part partToRemove = lookupAssociatedPart(partID);
            if (partToRemove != null)
            {
                return AssociatedParts.Remove(partToRemove);
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartID == partID);
        }
    }
}
