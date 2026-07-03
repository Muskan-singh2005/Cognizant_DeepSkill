
using System;

namespace Exercise2_EcommerceSearch
{
    class Program
    {
        // Linear Search
        static Product LinearSearch(Product[] products, string key)
        {
            foreach (Product product in products)
            {
                if (product.ProductName.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        // Binary Search
        static Product BinarySearch(Product[] products, string key)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int result = string.Compare(products[mid].ProductName, key,
                    StringComparison.OrdinalIgnoreCase);

                if (result == 0)
                    return products[mid];

                if (result < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Keyboard", "Electronics"),
                new Product(102, "Laptop", "Electronics"),
                new Product(103, "Mouse", "Electronics"),
                new Product(104, "Shoes", "Fashion"),
                new Product(105, "Watch", "Accessories")
            };

            Console.Write("Enter Product Name to Search: ");
            string searchKey = Console.ReadLine();

            Console.WriteLine("\n--- Linear Search ---");

            Product linearResult = LinearSearch(products, searchKey);

            if (linearResult != null)
                linearResult.Display();
            else
                Console.WriteLine("Product Not Found");

            // Sort array before Binary Search
            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            Console.WriteLine("\n--- Binary Search ---");

            Product binaryResult = BinarySearch(products, searchKey);

            if (binaryResult != null)
                binaryResult.Display();
            else
                Console.WriteLine("Product Not Found");
        }
    }
}