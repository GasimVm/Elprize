using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class Country
    {
        public Country()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
