using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Models
{
    public class Role
    {
        [Key]        
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string RoleUser { get; set; }//роли: Админ, гость
        public string Login { get; set; }
        public string Password { get; set; }

        public User User { get; set; }

       
    }
}
