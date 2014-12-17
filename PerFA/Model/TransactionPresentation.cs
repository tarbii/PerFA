using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFA.Model
{
    class TransactionPresentation
    {
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public decimal? Sum { get; set; }
        public DateTime? Date { get; set; }

        public TransactionPresentation(string description, string authorName, decimal? sum, DateTime? date)
        {
            Description = description;
            AuthorName = authorName;
            Sum = sum;
            Date = date;
        }

        public TransactionPresentation()
        {
            
        }
    }
}
