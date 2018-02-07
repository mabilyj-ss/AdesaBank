using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int Name { get; set; }       
    }
}
