using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class FuelPurchase
    {
        public double litres_purchased { get; set; }
        public double total_cost { get; set; }
        
        public void calculateFuelCost(double ltrs)
        {

            total_cost += (litres_purchased * 1.30);
        }
    }
}
