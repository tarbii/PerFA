namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LongTermExpence")]
    public partial class LongTermExpence
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("LtE type")]
        [StringLength(10)]
        public string LtE_type { get; set; }

        [StringLength(10)]
        public string Comment { get; set; }

        [Column("Term of usage")]
        public double? Term_of_usage { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
