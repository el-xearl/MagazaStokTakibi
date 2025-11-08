using System;
using System.Collections.Generic;

namespace MagazaStokTakibi
{
    public class Inventory
    {
        public List<Product> Products { get; set; } = new List<Product>();

        // Ürün ekleme
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Ürün silme
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        // Stok artırma
        public void IncreaseStock(Product product, int amount)
        {
            product.Stock += amount;
        }

        // Stok azaltma
        public void DecreaseStock(Product product, int amount)
        {
            if (product.Stock >= amount)
                product.Stock -= amount;
        }
    }
}
