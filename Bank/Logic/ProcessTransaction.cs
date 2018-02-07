using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Logic
{
    public class ProcessTransaction
    {
        private Account _account ;
        public ProcessTransaction(Account account)
        {
            _account = account;
        }

        public Account Execute(Transaction transaction)
        {
            
            switch (transaction.TransactionType)
            {
                case (int)BankEnums.TransactionType.Deposit:
                    _account.Balance += transaction.Amount;
                    break;
                case (int)BankEnums.TransactionType.Withdrawl:
                    if(transaction.Amount > 1000)
                    {
                        throw new Exception("Can not withdrawl Amount greater than or equal to 1000 dollars");
                    }
                    _account.Balance -= transaction.Amount;
                    break;
                case (int)BankEnums.TransactionType.Transfer:
                    _account.Balance += transaction.Amount;
                    break;
            }

            return _account;
        }
    }
}
