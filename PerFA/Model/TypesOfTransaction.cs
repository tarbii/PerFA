using System.Collections.Generic;
using System.Windows.Documents;

namespace PerFA.Model
{
    public enum TypesOfTransaction
    {
        Wage,
        Deposit,
        Grant,
        OtherIncome,
        HouseholdExpence,
        Rent,
        Credit,
        LongTermExpence,
        OtherExpence
    }

    class NamesOfTransaction
    {
        public List<string> NamesList = new List<string>
        {
           "Wage",
           "Income on deposit",
           "Scholarship",
           "Other income",
           "Household expenses",
           "Rent",
           "Credit expenses",
           "Long term expenses",
           "Other expences"
        };
    }
}