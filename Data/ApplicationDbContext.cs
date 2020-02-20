﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjTrashCollection.Models;

namespace ProjTrashCollection.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                   new IdentityRole
                   {
                       Name = "Admin",
                       NormalizedName = "ADMIN"
                   }
                );
        }
        public DbSet<ProjTrashCollection.Models.Service> Service { get; set; }
        public DbSet<ProjTrashCollection.Models.Address> Address { get; set; }
    }
}
