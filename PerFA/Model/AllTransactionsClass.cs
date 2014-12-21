using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PropertyChanged;

namespace PerFA.Model
{
    [ImplementPropertyChanged]
    class AllTransactionsClass
    {
        private int? userId;
        public AllTransactionsClass()
        {
            NamesOfTransaction = new NamesOfTransaction().NamesList;
            SelectedNameOfTransaction = NamesOfTransaction.FirstOrDefault();
            TypeFilter.Changed += Update;
            DateFilter.PropertyChanged += DateFilter_PropertyChanged;
            TextFilter.PropertyChanged += TextFilter_PropertyChanged;
        }

        void TextFilter_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Update();
        }

        void DateFilter_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Update();
        }

        private readonly Filters.DateFilter dateFilter = new Filters.DateFilter();
        public Filters.DateFilter DateFilter { get { return dateFilter; } }
        
        private readonly Filters.TypeFilter typeFilter = new Filters.TypeFilter(true);
        public Filters.TypeFilter TypeFilter { get { return typeFilter; } }

        private readonly Filters.TextFilter textFilter = new Filters.TextFilter();
        public Filters.TextFilter TextFilter { get { return textFilter; } }

        public TransactionUser SelectedTransaction { get; set; }

        public ObservableCollection<TransactionUser> Transactions { get; set; }

        public decimal Income { get; set; }
        public decimal Expences { get; set; }
        public decimal Balance { get; set; }


        public void Initialize(int uId)
        {
            userId = uId;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            if (userId == null)
            {
                throw new Exception("Cannot load transatcions: user is not set");
            }

            var uId = userId.Value;

            Debug.WriteLine("Loading transactions for {0}", uId);
            var db = new DatabaseContext();

            var df = DateFilter;
            var tf = TextFilter;
            Transactions = new ObservableCollection<TransactionUser>(db.TransactionUsers
                    .Where(x => (x.ID_user == uId) 
                        
                        // filter by date
                        && (df.From == null || x.Transaction.Date >= df.From)
                        && (df.To == null || x.Transaction.Date <= df.To)
                        
                        // filtetr by text
                        && (!tf.DescriptionChecked || tf.SearchTerm == null
                        || x.Transaction.Description.Contains(tf.SearchTerm))
                        && (!tf.EverywhereChecked || tf.SearchTerm == null
                        || x.Transaction.Description.Contains(tf.SearchTerm)
                        || x.Transaction.User.Name.Contains(tf.SearchTerm)
                        || x.Transaction.Grant.Grant_type.Contains(tf.SearchTerm)
                        || x.Transaction.HouseholdExpence.Comment.Contains(tf.SearchTerm)
                        || x.Transaction.HouseholdExpence.HE_type.Contains(tf.SearchTerm)
                        || x.Transaction.LongTermExpence.LtE_type.Contains(tf.SearchTerm)
                        || x.Transaction.LongTermExpence.Comment.Contains(tf.SearchTerm)
                        || x.Transaction.OtherExpence.Comment.Contains(tf.SearchTerm)
                        || x.Transaction.OtherExpence.OE_type.Contains(tf.SearchTerm)
                        || x.Transaction.OtherIncome.Comment.Contains(tf.SearchTerm)
                        || x.Transaction.OtherIncome.OI_type.Contains(tf.SearchTerm)
                        || x.Transaction.Wage.Workplace.Contains(tf.SearchTerm))

                        // filter by type
                        &&
                        ((  TypeFilter.WageChecked && x.Transaction.Wage != null)
                                
                                || (TypeFilter.HouseholdExpensesChecked && 
                                x.Transaction.HouseholdExpence != null)
                                
                                || (TypeFilter.IncomeOnDepositChecked &&
                                x.Transaction.Deposit != null)
                                
                                || (TypeFilter.ScholarshipChecked &&
                                x.Transaction.Grant != null)
                                
                                || (TypeFilter.OtherIncomeChecked &&
                                x.Transaction.OtherIncome != null) 
                                
                                || (TypeFilter.RentChecked &&
                                x.Transaction.Rent != null) 
                                
                                || (TypeFilter.CreditExpensesChecked &&
                                x.Transaction.Credit != null) 
                                
                                || (TypeFilter.LongTermldExpensesChecked &&
                                x.Transaction.LongTermExpence != null) 
                                
                                || (TypeFilter.OtherdExpensesChecked &&
                                x.Transaction.OtherExpence != null)
                         ))
                    .Select(x => x));

            Income = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Where(s => s > 0).Sum();
            Expences = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Where(s => s < 0).Sum();
            Balance = Transactions.Select(t => t.Sum != null ? t.Sum.Value : 0).Sum();
            
        }

        public event Action<int, int> TransactionLoadSucceed;
        private void OnTransactionLoadSucceed(int userId, int transactionId)
        {
            var handler = TransactionLoadSucceed;
            if (handler != null) handler(userId, transactionId);
        }

        public event Action<string> TransactionLoadFailed;
        private void OnTransactionLoadFailed(string message)
        {
            var handler = TransactionLoadFailed;
            if (handler != null) handler(message);
        }

        public void TryLoadTransaction()
        {
            if (SelectedTransaction != null)
            {
                OnTransactionLoadSucceed(
                    SelectedTransaction.ID_user, SelectedTransaction.ID_transaction);
            }
            else
            {
                OnTransactionLoadFailed("Select transaction.");
            }
        }

        public List<string> NamesOfTransaction { get; private set; }

        public string SelectedNameOfTransaction { get; set; }

        public event Action<string> TransactionCreationucceed;
        private void OnTransactionCreationSucceed(string typeOfTransaction)
        {
            var handler = TransactionCreationucceed;
            if (handler != null) handler(typeOfTransaction);
        }

        public event Action<string> TransactionCreationFailed;
        private void OnTransactionCreationFailed(string message)
        {
            var handler = TransactionCreationFailed;
            if (handler != null) handler(message);
        }

        public void TryCreateTransaction()
        {
            if (SelectedNameOfTransaction != null)
            {
                OnTransactionCreationSucceed(SelectedNameOfTransaction);
            }
            else
            {
                OnTransactionCreationFailed("Виберіть тип транзакції для створення");
            }
        }

        public void DeleteTransaction()
        {
            if (SelectedTransaction != null)
            {
                using (var db = new DatabaseContext())
                {
                    db.TransactionUsers.Remove(db.TransactionUsers.First(x =>
                        x.ID_transaction == SelectedTransaction.ID_transaction &&
                        x.ID_user == SelectedTransaction.ID_user));
                    db.SaveChanges();
                }
                LoadTransactions();
            }
        }


        public void Update()
        {
            LoadTransactions();
        }
    }
}
