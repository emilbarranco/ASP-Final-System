﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_Final_System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SystemModelContainer : DbContext
    {
        public SystemModelContainer()
            : base("name=SystemModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Activities> Activities1 { get; set; }
    }
}
