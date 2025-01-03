﻿// <auto-generated />
using System;
using CandyServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CandyServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CandyServer.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1bdbb187-88d0-477c-bb57-5b11fc0cfbad"),
                            JobTitle = "Admin",
                            PersonId = new Guid("00000000-0000-0000-0000-000000000001")
                        });
                });

            modelBuilder.Entity("CandyServer.Models.Candy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Candies");
                });

            modelBuilder.Entity("CandyServer.Models.Component", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("CandyServer.Models.Composition", b =>
                {
                    b.Property<Guid>("CandyId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ComponentId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("CandyId", "ComponentId");

                    b.HasIndex("ComponentId");

                    b.ToTable("Compositions");
                });

            modelBuilder.Entity("CandyServer.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CandyServer.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CandyServer.Models.OrderCompaund", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CandyId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "CandyId");

                    b.HasIndex("CandyId");

                    b.ToTable("OrderCompaunds");
                });

            modelBuilder.Entity("CandyServer.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Address = "",
                            Email = "",
                            Login = "admin",
                            Name = "Admin",
                            Password = "admin",
                            Phone = "",
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("CandyServer.Models.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("CandyServer.Models.Supply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("CandyServer.Models.SupplyCompaund", b =>
                {
                    b.Property<Guid>("ComponentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SupplyId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("ComponentId", "SupplyId");

                    b.HasIndex("SupplyId");

                    b.ToTable("SupplyCompaunds");
                });

            modelBuilder.Entity("CandyServer.Models.Admin", b =>
                {
                    b.HasOne("CandyServer.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("CandyServer.Models.Composition", b =>
                {
                    b.HasOne("CandyServer.Models.Candy", "Candy")
                        .WithMany("Compositions")
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyServer.Models.Component", "Component")
                        .WithMany("Compositions")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candy");

                    b.Navigation("Component");
                });

            modelBuilder.Entity("CandyServer.Models.Customer", b =>
                {
                    b.HasOne("CandyServer.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("CandyServer.Models.Order", b =>
                {
                    b.HasOne("CandyServer.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CandyServer.Models.OrderCompaund", b =>
                {
                    b.HasOne("CandyServer.Models.Candy", "Candy")
                        .WithMany("OrderCompaunds")
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyServer.Models.Order", "Order")
                        .WithMany("OrderCompaunds")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candy");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CandyServer.Models.Supply", b =>
                {
                    b.HasOne("CandyServer.Models.Provider", "Provider")
                        .WithMany("Supplies")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("CandyServer.Models.SupplyCompaund", b =>
                {
                    b.HasOne("CandyServer.Models.Component", "Component")
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyServer.Models.Supply", "Supply")
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("SupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("CandyServer.Models.Candy", b =>
                {
                    b.Navigation("Compositions");

                    b.Navigation("OrderCompaunds");
                });

            modelBuilder.Entity("CandyServer.Models.Component", b =>
                {
                    b.Navigation("Compositions");

                    b.Navigation("SupplyCompaunds");
                });

            modelBuilder.Entity("CandyServer.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CandyServer.Models.Order", b =>
                {
                    b.Navigation("OrderCompaunds");
                });

            modelBuilder.Entity("CandyServer.Models.Provider", b =>
                {
                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("CandyServer.Models.Supply", b =>
                {
                    b.Navigation("SupplyCompaunds");
                });
#pragma warning restore 612, 618
        }
    }
}
