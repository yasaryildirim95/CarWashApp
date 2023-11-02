﻿// <auto-generated />
using System;
using CarWashApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarWashApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarWashApp.Entity.Concrete.DirtinessLevel", b =>
                {
                    b.Property<int>("DirtinessLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirtinessLevelID"));

                    b.Property<int>("AdditionalDuration")
                        .HasColumnType("int");

                    b.Property<string>("DirtinessLevelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirtinessLevelID");

                    b.ToTable("DirtinessLevels");

                    b.HasData(
                        new
                        {
                            DirtinessLevelID = 1,
                            AdditionalDuration = 5,
                            DirtinessLevelName = "Az"
                        },
                        new
                        {
                            DirtinessLevelID = 2,
                            AdditionalDuration = 15,
                            DirtinessLevelName = "Orta"
                        },
                        new
                        {
                            DirtinessLevelID = 3,
                            AdditionalDuration = 25,
                            DirtinessLevelName = "Çok"
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.LoginDetail", b =>
                {
                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelID");

                    b.ToTable("LoginDetails");

                    b.HasData(
                        new
                        {
                            PersonelID = 1,
                            IsAdmin = true,
                            Password = "admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"));

                    b.Property<bool>("IsWasher")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<int>("LeavesLeft")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("ShifTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelID");

                    b.HasIndex("ShifTypeID");

                    b.ToTable("Personels");

                    b.HasData(
                        new
                        {
                            PersonelID = 1,
                            IsWasher = false,
                            IsWorking = false,
                            LeavesLeft = 14,
                            Name = "admin",
                            Salary = 1,
                            ShifTypeID = 1,
                            Surname = "admin"
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.PersonelLeave", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("NumOfDays")
                        .HasColumnType("int");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PersonelID");

                    b.ToTable("PersonelLeaves");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockWarningThreshold")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            ProductName = "İç Deterjan",
                            Stock = 1,
                            StockWarningThreshold = 20
                        },
                        new
                        {
                            ProductID = 2,
                            ProductName = "Dış Deterjan",
                            Stock = 1,
                            StockWarningThreshold = 20
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Shift", b =>
                {
                    b.Property<int>("ShiftTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftTypeID"));

                    b.Property<string>("ShiftName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShiftTypeID");

                    b.ToTable("Shifts");

                    b.HasData(
                        new
                        {
                            ShiftTypeID = 1,
                            ShiftName = "Sabah"
                        },
                        new
                        {
                            ShiftTypeID = 2,
                            ShiftName = "Akşam"
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VehicleOwnerID")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeID")
                        .HasColumnType("int");

                    b.HasKey("VehicleID");

                    b.HasIndex("Plate")
                        .IsUnique();

                    b.HasIndex("VehicleOwnerID");

                    b.HasIndex("VehicleTypeID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.VehicleOwner", b =>
                {
                    b.Property<int>("VehicleOwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleOwnerID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleOwnerID");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("VehicleOwners");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.VehicleType", b =>
                {
                    b.Property<int>("VehicleTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleTypeID"));

                    b.Property<int>("PriceMultiplier")
                        .HasColumnType("int");

                    b.Property<string>("VehicleTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleTypeID");

                    b.ToTable("VehicleTypes");

                    b.HasData(
                        new
                        {
                            VehicleTypeID = 1,
                            PriceMultiplier = 1,
                            VehicleTypeName = "Sedan"
                        },
                        new
                        {
                            VehicleTypeID = 2,
                            PriceMultiplier = 2,
                            VehicleTypeName = "SUV"
                        },
                        new
                        {
                            VehicleTypeID = 3,
                            PriceMultiplier = 2,
                            VehicleTypeName = "Truck"
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Wash", b =>
                {
                    b.Property<int>("WashID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WashID"));

                    b.Property<int>("DirtinessLevelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("WashTypeID")
                        .HasColumnType("int");

                    b.HasKey("WashID");

                    b.HasIndex("DirtinessLevelID");

                    b.HasIndex("PersonelID");

                    b.HasIndex("VehicleId");

                    b.HasIndex("WashTypeID");

                    b.ToTable("Washes");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.WashType", b =>
                {
                    b.Property<int>("WashTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WashTypeID"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("WashTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WashTypeID");

                    b.ToTable("WashTypes");

                    b.HasData(
                        new
                        {
                            WashTypeID = 1,
                            Duration = 60,
                            Price = 150,
                            WashTypeName = "İç"
                        },
                        new
                        {
                            WashTypeID = 2,
                            Duration = 30,
                            Price = 100,
                            WashTypeName = "Dış"
                        },
                        new
                        {
                            WashTypeID = 3,
                            Duration = 90,
                            Price = 225,
                            WashTypeName = "İç&Dış"
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.WashTypeProduct", b =>
                {
                    b.Property<int>("WashTypeID")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("WashTypeID", "ProductTypeID");

                    b.HasIndex("ProductTypeID");

                    b.ToTable("WashTypeProducts");

                    b.HasData(
                        new
                        {
                            WashTypeID = 1,
                            ProductTypeID = 1,
                            Quantity = 1
                        },
                        new
                        {
                            WashTypeID = 2,
                            ProductTypeID = 2,
                            Quantity = 1
                        },
                        new
                        {
                            WashTypeID = 3,
                            ProductTypeID = 1,
                            Quantity = 1
                        },
                        new
                        {
                            WashTypeID = 3,
                            ProductTypeID = 2,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.LoginDetail", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Personel", "Personel")
                        .WithOne()
                        .HasForeignKey("CarWashApp.Entity.Concrete.LoginDetail", "PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Personel", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShifTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.PersonelLeave", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Vehicle", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.VehicleOwner", "VehicleOwner")
                        .WithMany()
                        .HasForeignKey("VehicleOwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleOwner");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.Wash", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.DirtinessLevel", "DirtinessLevel")
                        .WithMany()
                        .HasForeignKey("DirtinessLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.WashType", "WashType")
                        .WithMany()
                        .HasForeignKey("WashTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DirtinessLevel");

                    b.Navigation("Personel");

                    b.Navigation("Vehicle");

                    b.Navigation("WashType");
                });

            modelBuilder.Entity("CarWashApp.Entity.Concrete.WashTypeProduct", b =>
                {
                    b.HasOne("CarWashApp.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarWashApp.Entity.Concrete.WashType", "WashType")
                        .WithMany()
                        .HasForeignKey("WashTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("WashType");
                });
#pragma warning restore 612, 618
        }
    }
}
