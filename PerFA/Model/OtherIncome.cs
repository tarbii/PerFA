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
    public partial class OtherIncome
    {
        public int ID { get; set; }
        public string OI_type { get; set; }
        public string Comment { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
