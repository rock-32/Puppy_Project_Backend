﻿using Microsoft.EntityFrameworkCore;
using Puppy_Project.Depandancies;
using Puppy_Project.Models;

namespace Puppy_Project.Dbcontext
{
    public class PuppyDb:DbContext
    {
        private readonly string _connection_string;
        public PuppyDb(IConfiguration configuration)
        {
            _connection_string = configuration["ConnectionStrings:DefaultConnection"];
        }

        public DbSet<UserDTO> UsersTb { get; set; }
        public DbSet<CategoryDTO> CategoryTB { get; set; }
        public DbSet<ProductDTO> ProductsTb { get; set; }
        public DbSet<CartDTO> CartTb { get; set; }
        public DbSet<CartItemDTO> CartItemTb { get; set; }
        public DbSet<OrderDTO> OrderTb { get; set; }
        public DbSet<OrderItemDTO> OrderItemTb { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDTO>()
                .Property(u=>u.Role)
                .HasDefaultValue("user");
            modelBuilder.Entity<ProductDTO>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Category_id);
            modelBuilder.Entity<CartDTO>()
                .HasOne(c => c.userid)
                .WithOne(u => u.cartuser)
                .HasForeignKey<CartDTO>(c => c.UserId);
            modelBuilder.Entity<CartItemDTO>()
                .HasOne(ci => ci.cart)
                .WithMany(c => c.cartItemDTOs)
                .HasForeignKey(ci => ci.Cart_id);
            modelBuilder.Entity<CartItemDTO>()
                .HasOne(ci => ci.product)
                .WithMany(p => p.cartItems)
                .HasForeignKey(ci => ci.Product_Id);
            modelBuilder.Entity<CartItemDTO>()
                .Property(ci=>ci.Qty)
                .HasDefaultValue(1);
            modelBuilder.Entity<OrderDTO>()
                .HasOne(o => o.user)
                .WithOne(u => u.userorder)
                .HasForeignKey<OrderDTO>(o => o.User_Id);
            modelBuilder.Entity<OrderItemDTO>()
                .HasOne(oi => oi.order)
                .WithMany(o => o.orderItems)
                .HasForeignKey(oi => oi.Order_Id);
            modelBuilder.Entity<OrderItemDTO>()
                .HasOne(oi => oi.product)
                .WithMany(p => p.orderItems)
                .HasForeignKey(oi => oi.Product_Id);
                
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connection_string);
            }
        }

    }
}
