﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PicnicPlanner3.Contexts;

namespace PicnicPlanner3.Migrations
{
    [DbContext(typeof(HomeContext))]
    partial class HomeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PicnicPlanner3.Models.Airport", b =>
                {
                    b.Property<string>("AirportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ident");

                    b.Property<string>("Latitude_deg");

                    b.Property<string>("Longitude_deg");

                    b.Property<string>("Municipality");

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.Property<string>("Type");

                    b.HasKey("AirportId");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("PicnicPlanner3.Models.Runway", b =>
                {
                    b.Property<string>("RunwayId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirportId");

                    b.Property<int>("He_Heading_deg");

                    b.Property<int>("Le_Heading_deg");

                    b.HasKey("RunwayId");

                    b.ToTable("Runways");
                });
#pragma warning restore 612, 618
        }
    }
}
