﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkDistrict.Models;

namespace ParkDistrict.Migrations
{
    [DbContext(typeof(ParkDistrictContext))]
    [Migration("20191101214230_BathroomField")]
    partial class BathroomField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkDistrict.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bathroom");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<bool>("PicnicArea");

                    b.Property<bool>("Playground");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Bathroom = true,
                            Location = "N Edison St. and Pittsburg Ave.",
                            Name = "Cathedral Park",
                            PicnicArea = true,
                            Playground = true
                        },
                        new
                        {
                            ParkId = 2,
                            Bathroom = true,
                            Location = "9360 N Columbia Blvd.",
                            Name = "Columbia Park",
                            PicnicArea = true,
                            Playground = true
                        },
                        new
                        {
                            ParkId = 3,
                            Bathroom = true,
                            Location = "N Fremont St. and Interstate Ave.",
                            Name = "Overlook Park",
                            PicnicArea = true,
                            Playground = true
                        },
                        new
                        {
                            ParkId = 4,
                            Bathroom = true,
                            Location = "N Marine Dr. and Lombard St.",
                            Name = "Kelley Point Park",
                            PicnicArea = true,
                            Playground = true
                        },
                        new
                        {
                            ParkId = 5,
                            Bathroom = true,
                            Location = "700 N Rosa Parks Way",
                            Name = "Peninsula Park",
                            PicnicArea = true,
                            Playground = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
