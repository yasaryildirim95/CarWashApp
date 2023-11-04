using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseSqlServer(@"Data Source=Buraks_PC\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Initial Catalog=newDb; Application Intent=ReadWrite;Multi Subnet Failover=False");
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
                .HasForeignKey(w => w.WashTypeID);

            modelBuilder.Entity<Wash>()
                .HasOne(w => w.DirtinessLevel)
                .WithMany()
                .HasForeignKey(w => w.DirtinessLevelID);

            modelBuilder.Entity<WashTypeProduct>()
                .HasKey(wtp => new { wtp.WashTypeProductID });

            modelBuilder.Entity<WashTypeProduct>()
                .HasOne(wtp => wtp.WashType)
                .WithMany()
                .HasForeignKey(wtp => wtp.WashTypeID);

            modelBuilder.Entity<WashTypeProduct>()
                .HasOne(wtp => wtp.Product)
                .WithMany()
                .HasForeignKey(wtp => wtp.ProductTypeID);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.VehicleOwner)
                .WithMany()
                .HasForeignKey(v => v.VehicleOwnerID);

            modelBuilder.Entity<Vehicle>().HasIndex(x => x.Plate).IsUnique();

            modelBuilder.Entity<LoginDetail>()
                .HasOne(ld => ld.Personel)
                .WithOne()
                .HasForeignKey<LoginDetail>(ld => ld.PersonelID);

            modelBuilder.Entity<Personel>()
                .HasOne(p => p.Shift)
                .WithMany()
                .HasForeignKey(p => p.ShifTypeID);

            modelBuilder.Entity<Shift>()
                .HasKey(x => x.ShiftTypeID);

            modelBuilder.Entity<VehicleOwner>()
                .HasIndex(x => x.PhoneNumber)
                .IsUnique();

            modelBuilder.Entity<Shift>().HasData(
                new Shift { ShiftTypeID = 1, ShiftName = "Sabah" },
                new Shift { ShiftTypeID = 2, ShiftName = "Akşam" }
                );

            modelBuilder.Entity<WashType>().HasData(
                new WashType { WashTypeID = 1, WashTypeName = "İç", Duration = 60, Price = 150 },
                new WashType { WashTypeID = 2, WashTypeName = "Dış", Duration = 30, Price = 100 },
                new WashType { WashTypeID = 3, WashTypeName = "İç&Dış", Duration = 90, Price = 225 }
                );

            modelBuilder.Entity<DirtinessLevel>().HasData(
                new DirtinessLevel { DirtinessLevelID = 1, DirtinessLevelName = "Az", AdditionalDuration = 5 },
                new DirtinessLevel { DirtinessLevelID = 2, DirtinessLevelName = "Orta", AdditionalDuration = 15 },
                new DirtinessLevel { DirtinessLevelID = 3, DirtinessLevelName = "Çok", AdditionalDuration = 25 });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "İç Deterjan", Stock = 1, StockWarningThreshold = 20 },
                new Product { ProductID = 2, ProductName = "Dış Deterjan", Stock = 1, StockWarningThreshold = 20 }
                );

            modelBuilder.Entity<WashTypeProduct>().HasData(
                new WashTypeProduct { WashTypeProductID = 1, ProductTypeID = 1, WashTypeID = 1, Quantity = 1 },
                new WashTypeProduct { WashTypeProductID = 2, ProductTypeID = 2, WashTypeID = 2, Quantity = 1 },
                new WashTypeProduct { WashTypeProductID = 3, ProductTypeID = 1, WashTypeID = 3, Quantity = 1 },
                new WashTypeProduct { WashTypeProductID = 4, ProductTypeID = 2, WashTypeID = 3, Quantity = 1 }
                );

            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType
                {
                    VehicleTypeID = 1,
                    VehicleTypeName = "Sedan",
                    PriceMultiplier = 1
                },
                new VehicleType
                {
                    VehicleTypeID = 2,
                    VehicleTypeName = "SUV",
                    PriceMultiplier = 2
                },
                new VehicleType
                {
                    VehicleTypeID = 3,
                    VehicleTypeName = "Truck",
                    PriceMultiplier = 2
                });

            modelBuilder.Entity<Personel>().HasData(
                new Personel
                {
                    PersonelID = 1,
                    IsWasher = false,
                    IsWorking = false,
                    LeavesLeft = 14,
                    Name = "admin",
                    Surname = "admin",
                    Salary = 1,
                    ShifTypeID = 1
                }
            );

            modelBuilder.Entity<LoginDetail>().HasData(
                new LoginDetail { ID = 1, IsAdmin = true, Password = "admin", PersonelID = 1, Username = "admin", }
            );

        }
    }
}
