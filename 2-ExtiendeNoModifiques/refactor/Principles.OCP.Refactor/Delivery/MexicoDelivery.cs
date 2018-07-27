namespace Principles.OCP.Refactor.Delivery
{
    class MexicoDelivery : IDelivery
    {
        public double CalculateCost(Order order)
        {
            double result = 98;
            return result;
        }
    }
}
