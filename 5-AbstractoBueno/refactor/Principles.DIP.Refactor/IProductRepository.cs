using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.DIP.Refactor
{
    interface IProductRepository
    {

        void Save(Product newProduct);

        List<Product> List();

    }
}
