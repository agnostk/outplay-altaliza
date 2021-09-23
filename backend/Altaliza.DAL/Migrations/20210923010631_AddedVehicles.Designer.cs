﻿// <auto-generated />
using System;
using Altaliza.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Altaliza.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210923010631_AddedVehicles")]
    partial class AddedVehicles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Altaliza.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Comerciais",
                            Name = "Commercial"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Compactos",
                            Name = "Compact"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Militares",
                            Name = "Military"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Motos",
                            Name = "Motorcycle"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Off-Roads",
                            Name = "Off-Road"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Sedans",
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Esportivos",
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Superesportivos",
                            Name = "Super"
                        },
                        new
                        {
                            Id = 9,
                            Description = "SUVs",
                            Name = "SUV"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Vans",
                            Name = "Van"
                        });
                });

            modelBuilder.Entity("Altaliza.Core.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Wallet")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Altaliza.Core.Entities.CharacterVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("VehicleId");

                    b.ToTable("CharacterVehicle");
                });

            modelBuilder.Entity("Altaliza.Core.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Price15Days")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("Price1Day")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("Price7Days")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Image = "/vehicles/commercial/terrorbyte.png",
                            Name = "Terrorbyte",
                            Price15Days = 76320m,
                            Price1Day = 6880m,
                            Price7Days = 41250m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Image = "/vehicles/commercial/pounder-custom.png",
                            Name = "Pounder Custom",
                            Price15Days = 17790m,
                            Price1Day = 1610m,
                            Price7Days = 9620m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Image = "/vehicles/commercial/phantom-custom.png",
                            Name = "Phantom Custom",
                            Price15Days = 68000m,
                            Price1Day = 6130m,
                            Price7Days = 36750m,
                            Stock = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Image = "/vehicles/compact/club.png",
                            Name = "Club",
                            Price15Days = 42630m,
                            Price1Day = 3840m,
                            Price7Days = 23040m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Image = "/vehicles/compact/weevil.png",
                            Name = "Weevil",
                            Price15Days = 28980m,
                            Price1Day = 2610m,
                            Price7Days = 15660m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Image = "/vehicles/compact/asbo.png",
                            Name = "Asbo",
                            Price15Days = 13590m,
                            Price1Day = 1230m,
                            Price7Days = 7350m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Image = "/vehicles/military/half-track.png",
                            Name = "Half-track",
                            Price15Days = 75070m,
                            Price1Day = 6770m,
                            Price7Days = 40580m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Image = "/vehicles/military/barrage.png",
                            Name = "Barrage",
                            Price15Days = 70640m,
                            Price1Day = 6370m,
                            Price7Days = 38190m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Image = "/vehicles/military/vetir.png",
                            Name = "Vetir",
                            Price15Days = 41620m,
                            Price1Day = 3750m,
                            Price7Days = 22500m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Image = "/vehicles/motorcycle/shotaro.png",
                            Name = "Shotaro",
                            Price15Days = 74100m,
                            Price1Day = 6680m,
                            Price7Days = 40060m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Image = "/vehicles/motorcycle/vindicator.png",
                            Name = "Vindicator",
                            Price15Days = 20980m,
                            Price1Day = 1890m,
                            Price7Days = 11340m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Image = "/vehicles/motorcycle/cliffhanger.png",
                            Name = "Cliffhanger",
                            Price15Days = 7500m,
                            Price1Day = 680m,
                            Price7Days = 4050m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 5,
                            Image = "/vehicles/off-road/brutus.png",
                            Name = "Brutus",
                            Price15Days = 88800m,
                            Price1Day = 8000m,
                            Price7Days = 48000m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Image = "/vehicles/off-road/insurgent.png",
                            Name = "Insurgent",
                            Price15Days = 29900m,
                            Price1Day = 2700m,
                            Price7Days = 16160m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Image = "/vehicles/off-road/verus.png",
                            Name = "Verus",
                            Price15Days = 6400m,
                            Price1Day = 576m,
                            Price7Days = 3460m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 6,
                            Image = "/vehicles/sedans/taligater-s.png",
                            Name = "Taligater S",
                            Price15Days = 49790m,
                            Price1Day = 4490m,
                            Price7Days = 26910m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 6,
                            Image = "/vehicles/sedans/warrener.png",
                            Name = "Warrener",
                            Price15Days = 4000m,
                            Price1Day = 360m,
                            Price7Days = 2160m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 6,
                            Image = "/vehicles/sedans/asterope.png",
                            Name = "Asterope",
                            Price15Days = 870m,
                            Price1Day = 78m,
                            Price7Days = 468m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 7,
                            Image = "/vehicles/sport/itali-rsx.png",
                            Name = "Itali RSX",
                            Price15Days = 115390m,
                            Price1Day = 10400m,
                            Price7Days = 62370m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 7,
                            Image = "/vehicles/sport/neo.png",
                            Name = "Neo",
                            Price15Days = 62440m,
                            Price1Day = 5630m,
                            Price7Days = 33750m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 7,
                            Image = "/vehicles/sport/rapid-gt.png",
                            Name = "Rapid GT",
                            Price15Days = 4400m,
                            Price1Day = 400m,
                            Price7Days = 2380m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 8,
                            Image = "/vehicles/super/krieger.png",
                            Name = "Krieger",
                            Price15Days = 95740m,
                            Price1Day = 8630m,
                            Price7Days = 51750m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 8,
                            Image = "/vehicles/super/osiris.png",
                            Name = "Osiris",
                            Price15Days = 65000m,
                            Price1Day = 5850m,
                            Price7Days = 35100m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 8,
                            Image = "/vehicles/super/infernus.png",
                            Name = "Infernus",
                            Price15Days = 14660m,
                            Price1Day = 1320m,
                            Price7Days = 7920m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 9,
                            Image = "/vehicles/suv/landstalker-xl.png",
                            Name = "Landstalker XL",
                            Price15Days = 40630m,
                            Price1Day = 3660m,
                            Price7Days = 21960m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 9,
                            Image = "/vehicles/suv/contender.png",
                            Name = "Contender",
                            Price15Days = 8330m,
                            Price1Day = 750m,
                            Price7Days = 4500m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 9,
                            Image = "/vehicles/suv/gresley.png",
                            Name = "Gresley",
                            Price15Days = 960m,
                            Price1Day = 90m,
                            Price7Days = 530m,
                            Stock = 3
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 10,
                            Image = "/vehicles/van/youga-classic-4x4.png",
                            Name = "Youga Classic 4x4",
                            Price15Days = 42890m,
                            Price1Day = 3870m,
                            Price7Days = 23190m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 10,
                            Image = "/vehicles/van/bison.png",
                            Name = "Bison",
                            Price15Days = 1000m,
                            Price1Day = 90m,
                            Price7Days = 540m,
                            Stock = 2
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 10,
                            Image = "/vehicles/van/surfer.png",
                            Name = "Surfer",
                            Price15Days = 370m,
                            Price1Day = 40m,
                            Price7Days = 200m,
                            Stock = 3
                        });
                });

            modelBuilder.Entity("Altaliza.Core.Entities.CharacterVehicle", b =>
                {
                    b.HasOne("Altaliza.Core.Entities.Character", "Character")
                        .WithMany("Vehicles")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Altaliza.Core.Entities.Vehicle", "Vehicle")
                        .WithMany("CharacterVehicles")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Altaliza.Core.Entities.Vehicle", b =>
                {
                    b.HasOne("Altaliza.Core.Entities.Category", "Category")
                        .WithMany("Vehicles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Altaliza.Core.Entities.Category", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Altaliza.Core.Entities.Character", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Altaliza.Core.Entities.Vehicle", b =>
                {
                    b.Navigation("CharacterVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
