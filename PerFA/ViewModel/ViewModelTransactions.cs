using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class ViewModelTransactions
    {
        public TransactionsClass TransactionsClass { get; set; }

        public ViewModelTransactions(Login login)
        {
            TransactionsClass = new TransactionsClass(login);
        }
    }
}
