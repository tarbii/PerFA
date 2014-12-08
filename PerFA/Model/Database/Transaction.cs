namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        public Transaction()
        {
            TransactionUsers = new HashSet<TransactionUser>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(10)]
        public string Description { get; set; }

        public int Author_ID { get; set; }

        public virtual Credit Credit { get; set; }

        public virtual Deposit Deposit { get; set; }

        public virtual Grant Grant { get; set; }

        public virtual HouseholdExpence HouseholdExpence { get; set; }

        public virtual LongTermExpence LongTermExpence { get; set; }

        public virtual OtherExpence OtherExpence { get; set; }

        public virtual OtherIncome OtherIncome { get; set; }

        public virtual Rent Rent { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<TransactionUser> TransactionUsers { get; set; }

        public virtual Wage Wage { get; set; }
    }
}
