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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Entries> Entries1 { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
    
        public virtual int StockCheck(Nullable<int> quantity, string productName, string providerName, Nullable<System.DateTime> timeStamp)
        {
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var providerNameParameter = providerName != null ?
                new ObjectParameter("ProviderName", providerName) :
                new ObjectParameter("ProviderName", typeof(string));
    
            var timeStampParameter = timeStamp.HasValue ?
                new ObjectParameter("TimeStamp", timeStamp) :
                new ObjectParameter("TimeStamp", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StockCheck", quantityParameter, productNameParameter, providerNameParameter, timeStampParameter);
        }
    
        public virtual int CreateBill(string clientName, string productName, Nullable<int> quantity, string totalPrice, Nullable<System.DateTime> saleDate)
        {
            var clientNameParameter = clientName != null ?
                new ObjectParameter("ClientName", clientName) :
                new ObjectParameter("ClientName", typeof(string));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var totalPriceParameter = totalPrice != null ?
                new ObjectParameter("TotalPrice", totalPrice) :
                new ObjectParameter("TotalPrice", typeof(string));
    
            var saleDateParameter = saleDate.HasValue ?
                new ObjectParameter("SaleDate", saleDate) :
                new ObjectParameter("SaleDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateBill", clientNameParameter, productNameParameter, quantityParameter, totalPriceParameter, saleDateParameter);
        }
    
        public virtual int AuditLog(string desc, Nullable<System.DateTime> date)
        {
            var descParameter = desc != null ?
                new ObjectParameter("Desc", desc) :
                new ObjectParameter("Desc", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AuditLog", descParameter, dateParameter);
        }
    }
}
