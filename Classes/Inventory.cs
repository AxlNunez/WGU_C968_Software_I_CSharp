﻿using System.ComponentModel;
using System.Linq;

namespace C968.Classes
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; } = new BindingList<Part>();

        public static void AddProduct(Product product) => Products.Add(product);
        public static bool RemoveProduct(Product product) => Products.Remove(product);
        public static Product LookupProduct(int productID) => Products.FirstOrDefault(p => p.ProductID == productID);
        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            var productIndex = Products.ToList().FindIndex(p => p.ProductID == productID);
            if (productIndex != -1)
            {
                Products[productIndex].Name = updatedProduct.Name;
                Products[productIndex].Price = updatedProduct.Price;
                Products[productIndex].InStock = updatedProduct.InStock;
                Products[productIndex].Min = updatedProduct.Min;
                Products[productIndex].Max = updatedProduct.Max;

                Products[productIndex].AssociatedParts.Clear();
                foreach (var part in updatedProduct.AssociatedParts)
                {
                    Products[productIndex].addAssociatedPart(part);
                }
            }
        }

        public static void AddPart(Part part) => AllParts.Add(part);
        public static bool DeletePart(Part part) => AllParts.Remove(part);
        public static Part LookupPart(int partID) => AllParts.FirstOrDefault(p => p.PartID == partID);
        public static void UpdatePart(int partID, Part updatedPart)
        {
            var partIndex = AllParts.ToList().FindIndex(p => p.PartID == partID);
            if (partIndex != -1) AllParts[partIndex] = updatedPart;
        }
    }
}
