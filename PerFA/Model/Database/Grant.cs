namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grant")]
    public partial class Grant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("Grant type")]
        [StringLength(10)]
        public string Grant_type { get; set; }

        [Column("Grant-rate", TypeName = "money")]
        public decimal? Grant_rate { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
