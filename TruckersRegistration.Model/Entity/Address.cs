using System;
using System.Collections.Generic;
using System.Text;

namespace TruckersRegistration.Model.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
