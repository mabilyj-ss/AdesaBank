using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class CheckingAccount: Account
    {
        public BankEnums.CheckingType CheckingAccountType { get; set; }

    }
}
