//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public int Id { get; set; }
        public string RNC { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
    }

    public enum Category
    {
        Regular,
        Premium
    }
}
