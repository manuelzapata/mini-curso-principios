using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.OCP.Symptom
{
    class Order
    {

        public CountryEnum Country { get; set; }

        public double Weight { get; set; }

        public double Total { get; set; }

    }
}
