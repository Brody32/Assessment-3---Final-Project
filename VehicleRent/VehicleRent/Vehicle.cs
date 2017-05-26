using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRent
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
        public double total_litrespurchased { get; set; }
        public int total_services { get; set; }
        public double fuel_economy { get; set; }
        public bool service_required { get; set; }

        // Define other methods
        public void AddJourney(double kms)
        {
            Journey newJourney = new Journey(kms);
            total_km_travelled += newJourney.returnKmTravelled();
        }
        
        public void AddFuelPurchase(double ltrs)
        {
            //FuelPurchase newFuelPurchase = new FuelPurchase(ltrs);
            //fuel_economy 
        }

        public void PrintToScreen(string vehicle_name) // prints variables values to screen
        {
            // Display specifications to a messagebox
            MessageBox.Show(
                vehicle_name +
                "\n\nManufacturer: " + manufacturer +
                "\nModel: " + model +
                "\nProduction Date: " + production_date +
                "\nRegistration: " + registration +
                "\nTotal Km Travelled: " + total_km_travelled +
                "\nTotal Services: " + total_services +
                "\nFuel Economy: " + fuel_economy +
                "\nService Required: " + service_required);
        }
        
    }
}

    // Fuel economy calculation (total_litrespurchased * 100) \ total_km_travelled


