using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetManager.Models
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}