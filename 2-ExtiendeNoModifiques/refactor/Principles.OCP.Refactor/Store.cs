using Principles.OCP.Refactor.Delivery;

namespace Principles.OCP.Refactor
{
    class Store
    {

        public double CalculateDeliveryCost(Order order) {

            if (order == null) return -1;

            IDelivery delivery = Factory.Instance.Get(order.Country);
            double result = delivery.CalculateCost(order);

            return result;

        }

    }
}
