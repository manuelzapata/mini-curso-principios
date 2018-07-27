namespace Principles.OCP.Refactor.Delivery
{
    class ColombiaDelivery : IDelivery
    {
        public double CalculateCost(Order order)
        {
            double result = order.Total * 0.01;
            if (order.Weight <= 2)
            {
                result += 9900;
            }
            else
            {
                result += order.Weight * 5000;
            }
            return result;
        }
    }
}
