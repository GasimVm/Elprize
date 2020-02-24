using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
