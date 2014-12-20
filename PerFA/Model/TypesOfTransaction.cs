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
           "Заробітня плата",
           "Дохід по депозиту",
           "Стипендія",
           "Інший дохід",
           "Побутові витрати",
           "Оренда житла",
           "Витрати по кредиту",
           "Довгострокові витрати",
           "Інші витрати"
        };
    }
}