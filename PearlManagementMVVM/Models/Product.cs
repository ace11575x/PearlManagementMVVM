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
    
    public partial class Product
    {
        public System.Guid Key { get; set; }
        public int Reference { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool Is_Lot { get; set; }
        public bool Is_Single { get; set; }
        public int Min_Order_Quantity { get; set; }
        public double Purchase_Price { get; set; }
        public double Sell_Price { get; set; }
    }
}
