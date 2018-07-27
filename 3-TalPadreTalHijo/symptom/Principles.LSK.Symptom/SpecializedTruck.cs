using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.LSK.Symptom
{
    class SpecializedTruck : Truck
    {

        public SpecializedTruck(string plateNumber, double odometer) : base(plateNumber, odometer)
        {
        }

        public override void AddTrip(Trip newTrip)
        {
            base.AddTrip(newTrip);

            //Update odometer.
            foreach (var trip in trips)
            {
                Odometer += trip.Distance;
            }

        }
    }
}
