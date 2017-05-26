using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class Journey
    {
        public double km_travelled { get; set; }

        public Journey (double kms)
        {
            km_travelled = kms;
        }

        public double returnKmTravelled()
        {
            return km_travelled;
        }
    }
}
