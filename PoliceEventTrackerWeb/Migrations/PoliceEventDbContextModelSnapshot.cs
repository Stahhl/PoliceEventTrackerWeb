﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceEventTrackerWeb.Data.Models;

namespace PoliceEventTrackerWeb.Migrations
{
    [DbContext(typeof(PoliceEventDbContext))]
    partial class PoliceEventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PoliceEventTrackerWeb.Domain.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coordinate");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("EventId");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<string>("Summary");

                    b.Property<string>("Type");

                    b.Property<int?>("UpdateId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("UpdateId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PoliceEventTrackerWeb.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PoliceEventTrackerWeb.Domain.Models.Update", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<DateTime>("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("PoliceEventTrackerWeb.Domain.Models.Event", b =>
                {
                    b.HasOne("PoliceEventTrackerWeb.Domain.Models.Location", "Location")
                        .WithMany("Events")
                        .HasForeignKey("LocationId");

                    b.HasOne("PoliceEventTrackerWeb.Domain.Models.Update")
                        .WithMany("Events")
                        .HasForeignKey("UpdateId");
                });
#pragma warning restore 612, 618
        }
    }
}
