using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.OCP.Symptom
{
    class Store
    {

        public double CalculateDeliveryCost(Order order) {

            if (order == null) return -1;

            double result = 0;

            switch (order.Country)
            {
                case CountryEnum.Colombia:

                    result = order.Total * 0.01;
                    if (order.Weight <= 2)
                    {
                        result += 9900;
                    }
                    else {
                        result += order.Weight * 5000;
                    }

                    break;
                case CountryEnum.Mexico:
                    result = 98;
                    break;
            }

            return result;

        }

    }
}
