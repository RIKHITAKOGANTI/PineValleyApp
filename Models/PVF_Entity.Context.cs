﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S5G5_PVFAPP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PineValleyEntities : DbContext
    {
        public PineValleyEntities()
            : base("name=PineValleyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductLine> ProductLine { get; set; }
        public virtual DbSet<RawMaterial> RawMaterial { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WorkCenter> WorkCenter { get; set; }
        public virtual DbSet<DoesBusinessIn> DoesBusinessIn { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<Uses> Uses { get; set; }
        public virtual DbSet<WorksIn> WorksIn { get; set; }
    }
}
