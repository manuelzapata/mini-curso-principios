using System;

namespace Principles.LSK.Symptom
{
    class Program
    {
        static void Main(string[] args)
        {

            const double InitialDistance = 10000;
            //Change the instantiated class to SpecializedTruck to see LSK violation.
            Truck truck = new Truck("ABC123", InitialDistance);

            truck.AddTrip(new Trip
            {
                OriginLatitude = 0,
                OriginLongitude = 0,
                DestinationLatitude = 0,
                DestinationLongitude = 0,
                Distance = 60
            });

            if (truck.Odometer == InitialDistance)
            {
                Console.WriteLine("Odometer is correct.");
            }
            else {
                Console.WriteLine("Odometer has been modified.");
            }

            Console.ReadLine();
        }
    }
}
