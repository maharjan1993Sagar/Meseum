﻿// <auto-generated />
using System;
using Meseum.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Meseum.Migrations
{
    [DbContext(typeof(MeseumContext))]
    [Migration("20200120100356_inventory")]
    partial class inventory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Meseum.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LongDetail");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortDetail");

                    b.Property<string>("ShortName");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Meseum.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("DetailStatus");

                    b.Property<decimal>("Latit");

                    b.Property<int>("LocationId");

                    b.Property<decimal>("Long");

                    b.Property<string>("LongDetail");

                    b.Property<string>("MadeBy");

                    b.Property<string>("Material");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ObjectCode");

                    b.Property<string>("OriginOf");

                    b.Property<bool>("PhotoStatus");

                    b.Property<string>("ShortDetail");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.Property<string>("size");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LocationId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Meseum.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LongDetail");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortDetail");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Meseum.Models.Posture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Postures");
                });

            modelBuilder.Entity("Meseum.Models.Inventory", b =>
                {
                    b.HasOne("Meseum.Models.Category", "Category")
                        .WithMany("CategoryLocations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Meseum.Models.Location", "Location")
                        .WithMany("CategoryLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
