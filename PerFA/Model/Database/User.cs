namespace PerFA.Model.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
            TransactionUsers = new HashSet<TransactionUser>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Login { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

        public virtual ICollection<TransactionUser> TransactionUsers { get; set; }
    }
}
