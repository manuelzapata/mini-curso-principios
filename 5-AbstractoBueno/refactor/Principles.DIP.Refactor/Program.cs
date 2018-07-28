using System;

namespace Principles.DIP.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {

            var repository = Factory.Instance.Get("default");
            var service = new Service(repository);

            var product = new Product
            {
                ProductId = 1,
                Name = "Product One",
                Price = 10
            };

            Console.WriteLine(service.CalculateProductTax(product));

            service.SaveProduct(product);

            var products = service.ListProducts();
            foreach (var currentProduct in products)
            {
                Console.WriteLine($"Id: {currentProduct.ProductId}, name: {currentProduct.Name}");
            }

            Console.ReadKey();
        }
    }
}
