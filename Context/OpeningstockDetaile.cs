//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuitappRest.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class OpeningstockDetaile
    {
        public int openingID { get; set; }
        public int ItemID { get; set; }
        public int Itemcode { get; set; }
        public int Itemcategory { get; set; }
        public int UnitId { get; set; }
        public Nullable<System.DateTime> DateTimeExpiridate { get; set; }
        public decimal Quantity { get; set; }
        public Nullable<decimal> purchaserate { get; set; }
        public Nullable<decimal> Salesrate { get; set; }
        public Nullable<decimal> Totalpurchaserate { get; set; }
        public Nullable<int> BatchId { get; set; }
        public Nullable<int> ItemScategory { get; set; }
        public string ItemMode { get; set; }
    }
}
