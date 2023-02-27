﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test.DAL;

#nullable disable

namespace test.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20230227200702_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("test.Models.House", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OwnerID")
                        .IsUnique();

                    b.ToTable("Houses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Aarhus",
                            OwnerID = 1
                        },
                        new
                        {
                            ID = 2,
                            Address = "København",
                            OwnerID = 2
                        });
                });

            modelBuilder.Entity("test.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Lukas Knudsen"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Mads Bjerg"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Berta Vazquez"
                        });
                });

            modelBuilder.Entity("test.Models.Pet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Bailey",
                            OwnerID = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "Cody",
                            OwnerID = 3
                        },
                        new
                        {
                            ID = 3,
                            Name = "Maggie",
                            OwnerID = 3
                        });
                });

            modelBuilder.Entity("test.Models.House", b =>
                {
                    b.HasOne("test.Models.Person", "Owner")
                        .WithOne("House")
                        .HasForeignKey("test.Models.House", "OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("test.Models.Pet", b =>
                {
                    b.HasOne("test.Models.Person", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("test.Models.Person", b =>
                {
                    b.Navigation("House")
                        .IsRequired();

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
