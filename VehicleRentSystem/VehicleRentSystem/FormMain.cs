using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            loadVehicles();
        }

        public Vehicle[] Vehicles = new Vehicle[3]; // holds the vehicle objects

        public void loadVehicles() // Initialize the Vehicles
        {
            // temp object to add variables to. Honestly this seems like a terrible way of doing it but i can't do it any other way because it wont let me :x also i know nuffin
            Vehicle VehicleTemp = new Vehicle();

            // Initialize values for Vehicle 0
            VehicleTemp.manufacturer = "Audi";
            VehicleTemp.model = "A6";
            VehicleTemp.production_date = 2003;
            VehicleTemp.registration = "1 ABC 221";

            VehicleTemp.total_km_travelled = 0;
            VehicleTemp.total_litrespurchased = 0;
            VehicleTemp.total_services = 0;
            VehicleTemp.fuel_economy = 0;
            VehicleTemp.service_required = false;
            VehicleTemp.revenue = 0;

            Vehicles[0] = VehicleTemp; // add to the array

            // Initialize values for Vehicle 1
            VehicleTemp.manufacturer = "Ford";
            VehicleTemp.model = "T812";
            VehicleTemp.production_date = 2014;
            VehicleTemp.registration = "1 ABD 760";

            VehicleTemp.total_km_travelled = 0;
            VehicleTemp.total_litrespurchased = 0;
            VehicleTemp.total_services = 0;
            VehicleTemp.fuel_economy = 0;
            VehicleTemp.service_required = false;
            VehicleTemp.revenue = 0;

            Vehicles[1] = VehicleTemp; // add to the array

            // Initialize vaues for Vehicle 2
            VehicleTemp.manufacturer = "Jaguar";
            VehicleTemp.model = "X200";
            VehicleTemp.production_date = 2003;
            VehicleTemp.registration = "1 ABG 432";

            VehicleTemp.total_km_travelled = 0;
            VehicleTemp.total_litrespurchased = 0;
            VehicleTemp.total_services = 0;
            VehicleTemp.fuel_economy = 0;
            VehicleTemp.service_required = false;
            VehicleTemp.revenue = 0;

            Vehicles[2] = VehicleTemp; // add to the array
        }

    }
}
