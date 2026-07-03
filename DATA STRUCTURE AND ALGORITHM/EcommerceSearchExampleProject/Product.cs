

using System;

namespace Exercise2_EcommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ProductId}");
            Console.WriteLine($"Name: {ProductName}");
            Console.WriteLine($"Category: {Category}");
        }
    }
}