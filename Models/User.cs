using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Models
{
    public class User
    {        
        public int UserId { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public string PlaceOfWork { get; set; }//место работы
        public string ResidentialAddress { get; set; }//Адрес проживания
        public string RegistrationAddress { get; set; }//Адрес регистрации

        public Role Role { get; set; }

        public ICollection<MobilePhone> MobilePhones { get; set; }
        public User ()
        {
            MobilePhones = new List<MobilePhone>();
        }
    }
}
