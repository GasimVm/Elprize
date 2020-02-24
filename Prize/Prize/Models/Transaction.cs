using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string TransactionNubmer { get; set; }

        public double Amount { get; set; }

        public DateTime SendDate { get; set; }
        //get user
        public int UserId { get; set; }

        public virtual User User { get; set; }
        [Column("SendUserId")]
        public int SendUserId { get; set; }

        public int StatusTransId { get; set; }

        public virtual StatusTrans StatusTrans { get; set; }
    }
}
