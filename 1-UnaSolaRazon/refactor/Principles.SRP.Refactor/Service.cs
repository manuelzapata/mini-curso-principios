using System.Collections.Generic;

namespace Principles.SRP.Refactor
{
    class Service
    {

        private ProductRepository repository;

        public Service() {
            repository = new ProductRepository();
        }

        public double CalculateProductTax(Product product) {

            //Validate product.
            if (product == null) return 0;

            const double Tax = 0.19;
            double productTax = product.Price * Tax;
            return productTax;
        }

        public bool SaveProduct(Product newProduct) {

            //Validate product
            if (newProduct == null || newProduct.ProductId < 0 || string.IsNullOrEmpty(newProduct.Name)) {
                return false;
            }

            repository.Save(newProduct);
            return true;
        }

        public List<Product> ListProducts() {

            var products = repository.List();
            return products;
        }

        

    }
}
