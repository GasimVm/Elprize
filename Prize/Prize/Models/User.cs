using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
             Logs = new HashSet<Log>();
        }
        public int Id { get; set; }

        [StringLength(150)]
        public string Email { get; set; }
        [StringLength(150)]
        public string Firstame { get; set; }
        [StringLength(150)]
        public string Lastname { get; set; }
        [StringLength(150)]
        public string Username { get; set; }
        [StringLength(150)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public bool Acvited { get; set; }

        public int CountryId { get; set; }
        public virtual Country  Country { get; set; }
        public double Cash { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }



    }
}
