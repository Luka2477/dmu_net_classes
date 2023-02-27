﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using task3.DAL;

#nullable disable

namespace task3.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20230227135439_v1_init")]
    partial class v1_init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("task2.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Make = "Volkswagen",
                            Model = "Golf GTI",
                            Wheels = 4
                        },
                        new
                        {
                            ID = 2,
                            Make = "Mercedes",
                            Model = "C300",
                            Wheels = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
