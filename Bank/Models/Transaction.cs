using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int TransactionType { get; set; }
        public int AccountId { get; set; }
        public float Amount { get; set; }

       
    }
}
