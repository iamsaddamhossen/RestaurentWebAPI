﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurentAPI.Models;

namespace RestaurentAPI.Migrations
{
    [DbContext(typeof(RestaurentDbContext))]
    partial class RestaurentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurentAPI.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RestaurentAPI.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodItemName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FoodItemId");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("RestaurentAPI.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("FoodItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("OrderMasterId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("FoodItemId");

                    b.HasIndex("OrderMasterId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("RestaurentAPI.Models.OrderMaster", b =>
                {
                    b.Property<long>("OrderMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("GTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("PMethod")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderMasterId");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderMasters");
                });

            modelBuilder.Entity("RestaurentAPI.Models.OrderDetail", b =>
                {
                    b.HasOne("RestaurentAPI.Models.FoodItem", "FoodItem")
                        .WithMany()
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurentAPI.Models.OrderMaster", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodItem");
                });

            modelBuilder.Entity("RestaurentAPI.Models.OrderMaster", b =>
                {
                    b.HasOne("RestaurentAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RestaurentAPI.Models.OrderMaster", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
