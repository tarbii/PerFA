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
                db, transactionUser.ID_user, transactionUser.ID_transaction);
            if (transactionUser.Transaction.HouseholdExpence != null)
            {
                type = "Побутові витрати";
            }
            else if (transactionUser.Transaction.Wage != null)
            {
                type = "Заробітня плата";
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
