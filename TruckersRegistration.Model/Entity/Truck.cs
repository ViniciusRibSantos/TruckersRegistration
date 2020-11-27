using System;
using System.Collections.Generic;
using System.Text;

namespace TruckersRegistration.Model.Entity
{
    public class Truck
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }
        public string Axles { get; set; }
    }
}
