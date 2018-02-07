using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class BankEnums
    {
        public enum AccountType
        {
            Checking = 1,
            Saving = 2
        }

        public enum CheckingType
        {
            Individual = 1,
            MoneyMarket = 2
        }

        public enum TransactionType
        {
            Deposit = 1,
            Withdrawl = 2,
            Transfer = 3
        }
    }
}
