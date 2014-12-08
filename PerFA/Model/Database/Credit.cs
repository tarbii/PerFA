namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Credit")]
    public partial class Credit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("Credit rate(%)", TypeName = "numeric")]
        public decimal? Credit_rate___ { get; set; }

        [Column("Credti body", TypeName = "money")]
        public decimal? Credti_body { get; set; }

        [Column("Monthly payment", TypeName = "money")]
        public decimal? Monthly_payment { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
