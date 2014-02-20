using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManager.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Reg { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public string TaxClass { get; set; }
        public string Transmission { get; set; }
        public int EngineSize { get; set; }
        public string Colour { get; set; }
        public string Base { get; set; }
        public int TankSize { get; set; }
        public string RoadTaxDue { get; set; }
        public string MotDue { get; set; }
        //public int Co2Level { get; set; }
        public string ServiceDue { get; set; }

    }
}