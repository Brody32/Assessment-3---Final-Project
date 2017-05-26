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
        
        public FuelPurchase(double ltrs)
        {
            litres_purchased = ltrs;
            total_cost = (litres_purchased * 1.30);
            
        }
        
        public double returnlitres_purchased()
        {
            return litres_purchased;
        }
    }
}
