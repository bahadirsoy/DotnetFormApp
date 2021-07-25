using System.Collections.Generic;

namespace DotnetFormApp.Models
{
    public static class ProductRepository
    {
        private static IEnumerable<Product> _products { get; set; }
        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "Mouse",
                    Description = "Logitech USB Mouse",
                    Price = 109,
                    isApproved = true
                },

                new Product()
                {
                    Id = 2,
                    Name = "Laptop",
                    Description = "Excalibur I7 10750H Laptop",
                    Price = 11000,
                    isApproved = true
                },

                new Product()
                {
                    Id = 3,
                    Name = "Phone",
                    Description = "TCL 6GB Ram Phone",
                    Price = 2399.50,
                    isApproved = false
                },

                new Product()
                {
                    Id = 4,
                    Name = "Cable",
                    Description = "Ethernet Cable",
                    Price = 39.99,
                    isApproved = true
                }
            };
        }

        public static IEnumerable<Product> GetProducts()
        {
            return _products;
        }

    }
}