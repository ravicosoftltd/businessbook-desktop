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
    
    public partial class closing
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<double> expence { get; set; }
        public Nullable<double> income { get; set; }
        public Nullable<double> closingbalance { get; set; }
        public string comment { get; set; }
        public Nullable<int> fk_user_closing_user { get; set; }
    
        public virtual user user { get; set; }
    }
}