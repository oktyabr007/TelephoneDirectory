using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelephoneDirectory.Models
{
    public class MobilePhone
    {
        public int MobilePhoneId { get; set; }  
        public string MobilePhoneUser { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

      
    }
}
