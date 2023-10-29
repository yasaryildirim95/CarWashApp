using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wash> Washes { get; set; }
        public DbSet<DirtinessLevel> DirtinessLevels { get; set; }
        public DbSet<WashTypeProduct> WashTypeProducts { get; set; }
        public DbSet<WashType> WashTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleOwner> VehicleOwners { get; set; }
        public DbSet<PersonelLeave> PersonelLeaves { get; set; }
        public DbSet<LoginDetail> LoginDetails { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Personel> Personels { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Gaming-PC\SQLEXPRESS;Initial Catalog=CarWashApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wash>()
                .HasOne(w => w.Vehicle)
                .WithMany()
                .HasForeignKey(w => w.VehicleId);

            modelBuilder.Entity<Wash>()
                .HasOne(w => w.WashType)
                .WithMany()
                .HasForeignKey(w => w.WashTypeId);

            modelBuilder.Entity<Wash>()
                .HasOne(w => w.DirtinessLevel)
                .WithMany()
                .HasForeignKey(w => w.DirtinessLevelId);

            modelBuilder.Entity<WashTypeProduct>()
                .HasKey(wtp => new { wtp.WashTypeId, wtp.ProductTypeId });

            modelBuilder.Entity<WashTypeProduct>()
                .HasOne(wtp => wtp.WashType)
                .WithMany()
                .HasForeignKey(wtp => wtp.WashTypeId);

            modelBuilder.Entity<WashTypeProduct>()
                .HasOne(wtp => wtp.Product)
                .WithMany()
                .HasForeignKey(wtp => wtp.ProductTypeId);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.VehicleOwner)
                .WithMany()
                .HasForeignKey(v => v.VehicleOwnerId);

            modelBuilder.Entity<LoginDetail>()
                .HasOne(ld => ld.Personel)
                .WithOne()
                .HasForeignKey<LoginDetail>(ld => ld.PersonelId);

            modelBuilder.Entity<Personel>()
                .HasOne(p => p.Shift)
                .WithMany()
                .HasForeignKey(p => p.ShifTypeId);

            modelBuilder.Entity<LoginDetail>()
                .HasKey(x=>x.PersonelId);
            modelBuilder.Entity<Shift>()
                .HasKey(x => x.ShiftTypeId);

            modelBuilder.Entity<VehicleOwner>()
                .HasIndex(x=>x.PhoneNumber)
                .IsUnique();

            modelBuilder.Entity<Shift>().HasData(
                new Shift { ShiftTypeId = 0, Name = "Sabah" },
                new Shift { ShiftTypeId = 1, Name = "Akşam" }
                );

            modelBuilder.Entity<WashType>().HasData(
                new WashType { WashTypeId = 0, Name = "İç", Duration = 60, Price = 150 },
                new WashType { WashTypeId = 1, Name = "Dış", Duration = 30, Price = 100 },
                new WashType { WashTypeId = 2, Name = "İç&Dış", Duration = 90, Price = 225 }
                );

            modelBuilder.Entity<DirtinessLevel>().HasData(
                new DirtinessLevel { DirtinessLevelId = 0, Name = "Az", Duration=5 },
                new DirtinessLevel { DirtinessLevelId = 1, Name = "Orta", Duration=15 },
                new DirtinessLevel { DirtinessLevelId = 2, Name = "Çok", Duration=25 });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 0, Name = "İç Deterjan", Stock = 1, WarningStock = 20 },
                new Product { ProductId = 1, Name = "Dış Deterjan", Stock = 1, WarningStock = 20 }
                );

            modelBuilder.Entity<WashTypeProduct>().HasData(
                new WashTypeProduct { ProductTypeId = 0, WashTypeId=0, Quantity=1 },
                new WashTypeProduct { ProductTypeId = 1, WashTypeId=1, Quantity=1 },
                new WashTypeProduct { ProductTypeId = 0, WashTypeId=2, Quantity=1 },
                new WashTypeProduct { ProductTypeId = 1, WashTypeId=2, Quantity=1 }
                );

            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType
                {
                    VehicleTypeId = 0,
                    VehicleName = "Sedan",
                    PriceMultiplier = 1
                },
                new VehicleType
                {
                    VehicleTypeId = 1,
                    VehicleName = "SUV",
                    PriceMultiplier = 2
                },
                new VehicleType
                {
                    VehicleTypeId = 2,
                    VehicleName = "Truck",
                    PriceMultiplier = 2
                });


            base.OnModelCreating(modelBuilder);
        }
    }
}
