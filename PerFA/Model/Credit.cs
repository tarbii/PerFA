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
    public partial class Credit
    {
        public int ID { get; set; }
        public Nullable<double> Credit_rate___ { get; set; }
        public Nullable<decimal> Credti_body { get; set; }
        public Nullable<decimal> Monthly_payment { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
