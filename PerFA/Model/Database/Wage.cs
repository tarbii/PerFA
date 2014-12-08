namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wage")]
    public partial class Wage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Workplace { get; set; }

        [Column("Wage-rate", TypeName = "money")]
        public decimal? Wage_rate { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
