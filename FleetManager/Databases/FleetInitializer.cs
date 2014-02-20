using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FleetManager.Models;

namespace FleetManager.Databases
{
    public class FleetInitializer : DropCreateDatabaseIfModelChanges<FleetContext>
    {
        protected override void Seed(FleetContext context)
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle{ Reg="G979 TUS", Make="Vauxhall", Model="Cavalier", Description="Pool car", VehicleType="Car", BodyType="Saloon", FuelType="Petrol", Base="Harlow", Colour="Red",
                    EngineSize=1600, TankSize=60, Transmission="Manual", RoadTaxDue="1/5/2014", MotDue="1/5/2014", ServiceDue="1/5/2014", TaxClass="L1" },
                new Vehicle{ Reg="EO10 BXB", Make="Ford", Model="Mondeo", Description="Pool car", VehicleType="Car", BodyType="Estate", FuelType="Diesel", Base="Harlow", Colour="Grey",
                    EngineSize=2000, TankSize=70, Transmission="Manual", RoadTaxDue="1/5/2014", MotDue="1/5/2014", ServiceDue="1/5/2014", TaxClass="L1" },
            };
            vehicles.ForEach(v => context.vehicles.Add(v));
            context.SaveChanges();
        }
    }
}