using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.LSK.Symptom
{
    class Truck
    {

        public string PlateNumber { get; private set; }
        public double Odometer { get; protected set; }
        protected List<Trip> trips;

        public Truck(string plateNumber, double odometer) {
            PlateNumber = plateNumber;
            Odometer = odometer;
            trips = new List<Trip>();
        }

        public virtual void AddTrip(Trip newTrip) {
            trips.Add(newTrip);
        }

    }
}
