//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PearlManagementMVVM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSale
    {
        public System.Guid Key { get; set; }
        public System.Guid Product_Key { get; set; }
        public System.Guid SaleDate_Key { get; set; }
        public bool Delete_Flag { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
