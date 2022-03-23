//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public string MovieID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public string Actor { get; set; }
        public string Description { get; set; }
        public string Directors { get; set; }
        public string Time { get; set; }
        public Nullable<int> Year { get; set; }
        public string Country { get; set; }
        public string MovieLink { get; set; }
        public string TrailerLink { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<double> Rate { get; set; }
        public int Viewed { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public bool Status { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Banner { get; set; }
        public Nullable<int> Isbanner { get; set; }
        public Nullable<int> Active { get; set; }
    }
}