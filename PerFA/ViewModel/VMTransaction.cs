using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class VMTransaction
    {
        public TransactionClass Transaction { get; set; }

        public VMTransaction()
        {
            Transaction = new TransactionClass();
        }

        public void LoadTransaction(int userId, int transactionId)
        {
            Transaction.LoadTransaction(userId, transactionId);
        }
    }
}
