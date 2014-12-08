namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherExpence")]
    public partial class OtherExpence
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("OE type")]
        [StringLength(10)]
        public string OE_type { get; set; }

        [StringLength(10)]
        public string Comment { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
