﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Business.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Serialization;
using Core.Common.Contracts;

namespace CarRental.Data
{
    public class CarRentalContext: DbContext
    {
        // Each Database requires a unique context
        public CarRentalContext()
            : base("name=CarRental")
        {
            Database.SetInitializer <CarRentalContext>(null);
        }

        public DbSet<Account> AccountSet { get; set; }

        public DbSet<Car> CarSet { get; set; }

        public DbSet<Rental> RentalSet { get; set; }

        public DbSet<Reservation> ReservationSet { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Explicitly tell EF that entites can have names other than pluralized class names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // We don't have any ExtensionData column in the tables, so we'll have to explicitly ignore
            // this inherited value
            modelBuilder.Ignore<ExtensionDataObject>();

            modelBuilder.Ignore<IIdentifiableEntity>();

            // Set table-key values
            // .Ignore() allows us to specity which columns not to include in specific tables
            modelBuilder.Entity<Account>().HasKey<int>(e => e.AccountId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Car>().HasKey<int>(e => e.CarId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Rental>().HasKey<int>(e => e.RentalId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Reservation>().HasKey<int>(e => e.ReservationId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Car>().Ignore(e => e.CurrentlyRented);

        }
    }
}
