using System;

namespace Principles.OCP.Symptom
{
    class Program
    {
        static void Main(string[] args)
        {

            var store = new Store();

            var orderOne = new Order
            {
                Country = CountryEnum.Mexico,
                Total = 8000,
                Weight = 1
            };

            var orderTwo = new Order
            {
                Country = CountryEnum.Colombia,
                Total = 100000,
                Weight = 10
            };

            double costOne = store.CalculateDeliveryCost(orderOne);
            Console.WriteLine($"Order One cost: {costOne} pesos mexicanos");

            double costTwo = store.CalculateDeliveryCost(orderTwo);
            Console.WriteLine($"Order Two cost: {costTwo} pesos colombianos");

            Console.ReadLine();
        }
    }
}
