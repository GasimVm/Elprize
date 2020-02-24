using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class Log
    {
        public int Id { get; set; }

        public bool LogStatus { get; set; }
        public DateTime StartDate { get; set; }
         
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [StringLength(150)]
        public string ActionName { get; set; }
    }
}
