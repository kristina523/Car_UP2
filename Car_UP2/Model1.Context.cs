﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_UP2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarDealership_BD2Entities : DbContext
    {
        public CarDealership_BD2Entities()
            : base("name=CarDealership_BD2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }
    }
}