using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YashSolution.Data.Entities;

namespace yash.Data.EF
{
    public class YashDbContext : DbContext
    {
        public YashDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Diamond> Diamonds { get; set; }
        public DbSet<Gold> Golds { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
