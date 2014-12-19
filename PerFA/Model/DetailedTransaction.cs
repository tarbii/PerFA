using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model.TransactionTypes;

namespace PerFA.Model
{
    class DetailedTransaction
    {
        public int UserId;
        public int TransactionId;

        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public decimal? Sum { get; set; }
        public string AuthorName { get; set; }
        public Dictionary<string, decimal?> UsersSumsDictionary { get; set; }
        public string Type { get; set; }
        public DTHouseholdExpenses HouseholdExpensesDetails { get; set; }
    }
}
