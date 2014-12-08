namespace PerFA.Model.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<Grant> Grants { get; set; }
        public virtual DbSet<HouseholdExpence> HouseholdExpences { get; set; }
        public virtual DbSet<LongTermExpence> LongTermExpences { get; set; }
        public virtual DbSet<OtherExpence> OtherExpences { get; set; }
        public virtual DbSet<OtherIncome> OtherIncomes { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionUser> TransactionUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wage> Wages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credit>()
                .Property(e => e.Credit_rate___)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Credit>()
                .Property(e => e.Credti_body)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Credit>()
                .Property(e => e.Monthly_payment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Deposit>()
                .Property(e => e.Deposit_rate___)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Deposit>()
                .Property(e => e.Money_on_deposit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Deposit>()
                .Property(e => e.Expected_income)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Grant>()
                .Property(e => e.Grant_type)
                .IsFixedLength();

            modelBuilder.Entity<Grant>()
                .Property(e => e.Grant_rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HouseholdExpence>()
                .Property(e => e.HE_type)
                .IsFixedLength();

            modelBuilder.Entity<HouseholdExpence>()
                .Property(e => e.Comment)
                .IsFixedLength();

            modelBuilder.Entity<LongTermExpence>()
                .Property(e => e.LtE_type)
                .IsFixedLength();

            modelBuilder.Entity<LongTermExpence>()
                .Property(e => e.Comment)
                .IsFixedLength();

            modelBuilder.Entity<OtherExpence>()
                .Property(e => e.OE_type)
                .IsFixedLength();

            modelBuilder.Entity<OtherExpence>()
                .Property(e => e.Comment)
                .IsFixedLength();

            modelBuilder.Entity<OtherIncome>()
                .Property(e => e.OI_type)
                .IsFixedLength();

            modelBuilder.Entity<OtherIncome>()
                .Property(e => e.Comment)
                .IsFixedLength();

            modelBuilder.Entity<Rent>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Meters)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Public_utilities)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.Credit)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.Deposit)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.Grant)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.HouseholdExpence)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.LongTermExpence)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.OtherExpence)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.OtherIncome)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.Rent)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.TransactionUsers)
                .WithRequired(e => e.Transaction)
                .HasForeignKey(e => e.ID_transaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasOptional(e => e.Wage)
                .WithRequired(e => e.Transaction);

            modelBuilder.Entity<TransactionUser>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Author_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TransactionUsers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ID_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wage>()
                .Property(e => e.Workplace)
                .IsFixedLength();

            modelBuilder.Entity<Wage>()
                .Property(e => e.Wage_rate)
                .HasPrecision(19, 4);
        }
    }
}
