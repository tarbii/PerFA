namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherIncome")]
    public partial class OtherIncome
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("OI type")]
        [StringLength(10)]
        public string OI_type { get; set; }

        [StringLength(10)]
        public string Comment { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
