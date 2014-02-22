using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FleetManager.Models;

namespace FleetManager.Databases
{
    public class FleetInitializer : DropCreateDatabaseAlways<FleetContext>
    {
        protected override void Seed(FleetContext context)
        {
            var make = new List<Make>
            {
                new Make{ Type="Ford" },
                new Make{ Type="Vauxhall" },
                new Make{ Type="Smart" },
                new Make{ Type="Audi" },
                new Make{ Type="Mercedes" },
                new Make{ Type="BMW" },
                new Make{ Type="Volkswagen" },
                new Make{ Type="Seat" },

            };
            make.ForEach(m => context.makes.Add(m));
            context.SaveChanges();

            var body = new List<BodyType>
            {
                new BodyType{ Type="Coupe" },
                new BodyType{ Type="Saloon" },
                new BodyType{ Type="Estate" },
                new BodyType{ Type="Convertible" },
                new BodyType{ Type="Hatchback" },
            };
            body.ForEach(m => context.bodies.Add(m));
            context.SaveChanges();

            var fuel = new List<FuelType>
            {
                new FuelType{ Type="Petrol" },
                new FuelType{ Type="Diesel" },
                new FuelType{ Type="Hybrid" },
                new FuelType{ Type="Electric" },
            };
            fuel.ForEach(m => context.fuels.Add(m));
            context.SaveChanges();

            var vehicleTypes = new List<VehicleType>
            {
                new VehicleType { Type="Car" },
                new VehicleType { Type="MPV" },
                new VehicleType { Type="Combi Van" },
                new VehicleType { Type="Van" },
                new VehicleType { Type="Luton Box Van" },
                new VehicleType { Type="7.5 tonne Van" },
                new VehicleType { Type="11 tonne Van" },
                new VehicleType { Type="Lorry" },
            };
            vehicleTypes.ForEach(m => context.vehicleTypes.Add(m));
            context.SaveChanges();

            var transmissions = new List<Transmission>
            {
                new Transmission{ Type="Manual" },
                new Transmission{ Type="Automatic" },
                new Transmission{ Type="Semi-Auto" },
                
            };
            transmissions.ForEach(m => context.transmissions.Add(m));
            context.SaveChanges();

            var vehicles = new List<Vehicle>
            {
                new Vehicle{ Reg="G979 TUS", MakeId = 2, Model="Cavalier", Description="Pool car", 
                    VehicleTypeId= 1, BodyTypeId= 2, FuelTypeId=1, Base="Harlow", Colour="Red",
                    EngineSize=1600, TankSize=60, TransmissionId=1, RoadTaxDue="1/5/2014", 
                    MotDue="1/5/2014", ServiceDue="1/5/2014", TaxClass="L1" },
                new Vehicle{ Reg="EO10 BXB", MakeId = 1, Model="Mondeo", Description="Pool car", 
                    VehicleTypeId=1, BodyTypeId=3, FuelTypeId=2, Base="Harlow", Colour="Grey",
                    EngineSize=2000, TankSize=70, TransmissionId=1, RoadTaxDue="1/5/2014", 
                    MotDue="1/5/2014", ServiceDue="1/5/2014", TaxClass="L1" },
                new Vehicle{ Reg="T623 WGK", MakeId = 3, Model="ForTwo", Description="Pool car", 
                    VehicleTypeId=1, BodyTypeId=1, FuelTypeId=1, Base="Epping", Colour="Black/Grey",
                    EngineSize=700, TankSize=20, TransmissionId=3, RoadTaxDue="1/5/2014", 
                    MotDue="1/5/2014", ServiceDue="1/5/2014", TaxClass="L1" },
                new Vehicle{ Reg="S642 AEC", MakeId = 4, Model="A3", Description="Pool car", 
                    VehicleTypeId=1, BodyTypeId=5, FuelTypeId=1, Base="Epping", Colour="Silver",
                    EngineSize=1800, TankSize=70, TransmissionId=1, RoadTaxDue="1/5/2014", 
                    MotDue="1/5/2014", ServiceDue="1/5/2014", TaxClass="L1" },
            };
            vehicles.ForEach(v => context.vehicles.Add(v));
            context.SaveChanges();
        }
    }
}