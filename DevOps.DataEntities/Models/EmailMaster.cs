//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevOps.DataEntities.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmailMaster
    {
        public int EmailMasterId { get; set; }
        public string EmailId { get; set; }
        public Nullable<int> OrganisationId { get; set; }
    
        public virtual Organisation Organisation { get; set; }
    }
}