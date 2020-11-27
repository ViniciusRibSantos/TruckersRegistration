using System;
using System.Collections.Generic;
using System.Text;

namespace TruckersRegistration.Model.Entity
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Truck Truck { get; set; }
        public Address Address { get; set; }
    }
}
