//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerFA.Model
{
    using System;
    using System.Collections.Generic;
    using PropertyChanged;
    
    [ImplementPropertyChanged]
    public partial class TransactionUser
    {
        public int ID_transaction { get; set; }
        public int ID_user { get; set; }
        public Nullable<decimal> Sum { get; set; }
    
        public virtual Transaction Transaction { get; set; }
        public virtual User User { get; set; }
    }
}