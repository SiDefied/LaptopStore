﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaptopStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LaptopStoreEntities1 : DbContext
    {
        public LaptopStoreEntities1()
            : base("name=LaptopStoreEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LaptopInfo> LaptopInfoes { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
