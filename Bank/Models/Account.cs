using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public float Balance { get; set; }
        public BankEnums.AccountType AccountType { get; set; }
    }
}
