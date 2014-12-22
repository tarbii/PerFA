using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PerFA.Annotations;
using PropertyChanged;

namespace PerFA.Model
{
    [ImplementPropertyChanged]
    class DetailedTransaction
    {
        private DatabaseContext db;
        private readonly TransactionUser transactionUser;
        public TransactionUser TransactionUser { get { return transactionUser; } }

        public DetailedTransaction(TransactionUser transactionUser, DatabaseContext db)
        {
            this.transactionUser = transactionUser;
            this.db = db;
            multiuserManager = new MultiuserManager(
                db, transactionUser.User, transactionUser.Transaction);
            if (transactionUser.Transaction.HouseholdExpence != null)
            {
                type = "Household expenses";
            }
            else if (transactionUser.Transaction.Wage != null)
            {
                type = "Wage";
            }
            else if (transactionUser.Transaction.Deposit != null)
            {
                type = "Income on deposit";
            }
            else if (transactionUser.Transaction.Grant != null)
            {
                type = "Scholarship";
            }
            else if (transactionUser.Transaction.OtherIncome != null)
            {
                type = "Other income";
            }
            else if (transactionUser.Transaction.Rent != null)
            {
                type = "Rent";
            }
            else if (transactionUser.Transaction.Credit != null)
            {
                type = "Credit expenses";
            }
            else if (transactionUser.Transaction.LongTermExpence != null)
            {
                type = "Long term expenses";
            }
            else if (transactionUser.Transaction.OtherExpence != null)
            {
                type = "Other expenses";
            }
        }
        
        private readonly MultiuserManager multiuserManager;
        public MultiuserManager MultiuserManager { get { return multiuserManager; } }

        private readonly string type;
        public string Type
        {
            get { return type; }
        }
    }
}
