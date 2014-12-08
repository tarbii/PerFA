namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Meters { get; set; }

        [Column("Public utilities", TypeName = "money")]
        public decimal? Public_utilities { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
