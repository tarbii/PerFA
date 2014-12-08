namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deposit")]
    public partial class Deposit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("Deposit rate(%)", TypeName = "numeric")]
        public decimal? Deposit_rate___ { get; set; }

        [Column("Money on deposit", TypeName = "money")]
        public decimal? Money_on_deposit { get; set; }

        [Column("Expected income", TypeName = "money")]
        public decimal? Expected_income { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
