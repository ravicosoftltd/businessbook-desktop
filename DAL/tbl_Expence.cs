//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Expence
    {
        public int Id { get; set; }
        public Nullable<int> Amount { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> DatenTime { get; set; }
        public Nullable<int> ExpenseHead_Id { get; set; }
        public Nullable<int> ExpenceSubHead_Id { get; set; }
    
        public virtual tbl_ExpenceHead tbl_ExpenceHead { get; set; }
        public virtual tbl_ExpenceSubHead tbl_ExpenceSubHead { get; set; }
    }
}
