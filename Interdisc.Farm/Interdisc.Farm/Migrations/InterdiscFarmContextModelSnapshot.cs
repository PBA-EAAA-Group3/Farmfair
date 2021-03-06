﻿// <auto-generated />
using System;
using Interdisc.Farm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Interdisc.Farm.Migrations
{
    [DbContext(typeof(InterdiscFarmContext))]
    partial class InterdiscFarmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Interdisc.Farm.Models.CustomerModel", b =>
                {
                    b.Property<int>("CustomerModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerModelId");

                    b.ToTable("CustomerModel");
                });

            modelBuilder.Entity("Interdisc.Farm.Models.FarmModel", b =>
                {
                    b.Property<int>("FarmModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FarmModelId");

                    b.ToTable("FarmModel");
                });

            modelBuilder.Entity("Interdisc.Farm.Models.InvoiceModel", b =>
                {
                    b.Property<int>("InvoiceModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceModelId");

                    b.HasIndex("CustomerModelId");

                    b.ToTable("InvoiceModel");
                });

            modelBuilder.Entity("Interdisc.Farm.Models.OrderItemsModel", b =>
                {
                    b.Property<int>("OrderItemsModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceModelId")
                        .HasColumnType("int");

                    b.Property<int>("ProductModelId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemsModelId");

                    b.HasIndex("InvoiceModelId");

                    b.HasIndex("ProductModelId");

                    b.ToTable("OrderItemsModel");
                });

            modelBuilder.Entity("Interdisc.Farm.Models.ProductGroupModel", b =>
                {
                    b.Property<int>("ProductGroupModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductGroupName")
                        .HasColumnType("int");

                    b.HasKey("ProductGroupModelId");

                    b.ToTable("ProductGroupModel");
                });

            modelBuilder.Entity("Interdisc.Farm.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Batch")
                        .HasColumnType("int");

                    b.Property<int>("FarmModelId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductGroupModelId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductModelId");

                    b.HasIndex("FarmModelId");

                    b.HasIndex("ProductGroupModelId");

                    b.ToTable("ProductModel");
                });

            modelBuilder.Entity("Interdisc.Farm.Models.InvoiceModel", b =>
                {
                    b.HasOne("Interdisc.Farm.Models.CustomerModel", "CustomerModel")
                        .WithMany()
                        .HasForeignKey("CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interdisc.Farm.Models.OrderItemsModel", b =>
                {
                    b.HasOne("Interdisc.Farm.Models.InvoiceModel", "InvoiceModel")
                        .WithMany("OrderItems")
                        .HasForeignKey("InvoiceModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interdisc.Farm.Models.ProductModel", "ProductModel")
                        .WithMany()
                        .HasForeignKey("ProductModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interdisc.Farm.Models.ProductModel", b =>
                {
                    b.HasOne("Interdisc.Farm.Models.FarmModel", "FarmModel")
                        .WithMany()
                        .HasForeignKey("FarmModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interdisc.Farm.Models.ProductGroupModel", "ProductGroupModel")
                        .WithMany("ProductModel")
                        .HasForeignKey("ProductGroupModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
