using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentSystem
{
    public class Vehicle
    {
        // First constructor
        public Vehicle() { }

        // Properties
        public string manufacturer { get; set; }
        public string model { get; set; }
        public int production_date { get; set; }
        public string registration { get; set; }

        public double total_km_travelled { get; set; }
        public double total_km_travelled_since_service { get; set; }
        public double total_litrespurchased { get; set; }
        public int total_services { get; set; }
        public double fuel_economy { get; set; }
        public bool service_required { get; set; }
        public double revenue { get; set; }

    }
}
