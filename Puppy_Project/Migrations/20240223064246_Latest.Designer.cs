﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Puppy_Project.Dbcontext;

#nullable disable

namespace Puppy_Project.Migrations
{
    [DbContext(typeof(PuppyDb))]
    [Migration("20240223064246_Latest")]
    partial class Latest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Puppy_Project.Depandancies.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile_Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("user");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Active");

                    b.HasKey("Id");

                    b.ToTable("UsersTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CartTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cart_id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cart_id");

                    b.HasIndex("Product_Id");

                    b.ToTable("CartItemTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ctg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryTB");
                });

            modelBuilder.Entity("Puppy_Project.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("OrderTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DelivaryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("OrderItemTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Category_id");

                    b.ToTable("ProductsTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("WishListTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.WishListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("WishList_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Product_Id");

                    b.HasIndex("WishList_Id");

                    b.ToTable("WishListItemTb");
                });

            modelBuilder.Entity("Puppy_Project.Models.Cart", b =>
                {
                    b.HasOne("Puppy_Project.Depandancies.User", "userid")
                        .WithOne("cartuser")
                        .HasForeignKey("Puppy_Project.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userid");
                });

            modelBuilder.Entity("Puppy_Project.Models.CartItem", b =>
                {
                    b.HasOne("Puppy_Project.Models.Cart", "cart")
                        .WithMany("cartItemDTOs")
                        .HasForeignKey("Cart_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Puppy_Project.Models.Product", "product")
                        .WithMany("cartItems")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cart");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Puppy_Project.Models.Order", b =>
                {
                    b.HasOne("Puppy_Project.Depandancies.User", "user")
                        .WithOne("userorder")
                        .HasForeignKey("Puppy_Project.Models.Order", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Puppy_Project.Models.OrderItem", b =>
                {
                    b.HasOne("Puppy_Project.Models.Order", "order")
                        .WithMany("orderItems")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Puppy_Project.Models.Product", "product")
                        .WithMany("orderItems")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Puppy_Project.Models.Product", b =>
                {
                    b.HasOne("Puppy_Project.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Puppy_Project.Models.WishList", b =>
                {
                    b.HasOne("Puppy_Project.Depandancies.User", "user")
                        .WithOne("wishList")
                        .HasForeignKey("Puppy_Project.Models.WishList", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Puppy_Project.Models.WishListItem", b =>
                {
                    b.HasOne("Puppy_Project.Models.Product", "product")
                        .WithMany("wishListitems")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Puppy_Project.Models.WishList", "wishList")
                        .WithMany("wishListItems")
                        .HasForeignKey("WishList_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("wishList");
                });

            modelBuilder.Entity("Puppy_Project.Depandancies.User", b =>
                {
                    b.Navigation("cartuser")
                        .IsRequired();

                    b.Navigation("userorder")
                        .IsRequired();

                    b.Navigation("wishList")
                        .IsRequired();
                });

            modelBuilder.Entity("Puppy_Project.Models.Cart", b =>
                {
                    b.Navigation("cartItemDTOs");
                });

            modelBuilder.Entity("Puppy_Project.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Puppy_Project.Models.Order", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("Puppy_Project.Models.Product", b =>
                {
                    b.Navigation("cartItems");

                    b.Navigation("orderItems");

                    b.Navigation("wishListitems");
                });

            modelBuilder.Entity("Puppy_Project.Models.WishList", b =>
                {
                    b.Navigation("wishListItems");
                });
#pragma warning restore 612, 618
        }
    }
}
