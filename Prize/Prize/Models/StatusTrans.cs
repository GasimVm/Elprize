using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class StatusTrans
    {
        public StatusTrans()
        {
            Transactions = new HashSet<Transaction>();
        }
        public int Id { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Transaction>  Transactions { get; set; }
    }

}
