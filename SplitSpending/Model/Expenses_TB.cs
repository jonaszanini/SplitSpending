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
    
    public partial class Expenses_TB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Expenses_TB()
        {
            this.Expenditure_TB = new HashSet<Expenditure_TB>();
        }
    
        public int Cod_Expense { get; set; }
        public Nullable<int> Cod_User { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expenditure_TB> Expenditure_TB { get; set; }
        public virtual User_TB User_TB { get; set; }
    }
}