﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FleetManager.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FleetManager.Databases
{
    public class FleetContext : DbContext
    {
        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<Make> makes { get; set; }
        public DbSet<BodyType> bodies { get; set; }
        public DbSet<FuelType> fuels { get; set; }
        public DbSet<VehicleType> vehicleTypes { get; set; }
        public DbSet<Transmission> transmissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            
        }
    }
}