//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SplitSpending.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expenditure_TB
    {
        public int Cod_Expenditure { get; set; }
        public Nullable<int> Cod_User_Pay { get; set; }
        public Nullable<int> Cod_User_Used { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Cod_Expense { get; set; }
    
        public virtual User_TB User_TB { get; set; }
        public virtual User_TB User_TB1 { get; set; }
    }
}
