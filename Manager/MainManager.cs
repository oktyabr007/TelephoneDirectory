using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectory.Models;

namespace TelephoneDirectory.Manager
{
    class MainManager
    {
        public void DataGridViewUserAdd(DataGridView dataGridView, IEnumerable<User> user)
        {
            dataGridView.Rows.Clear();
            foreach (User u in user)
            {
                dataGridView.Rows.Add(u.UserId, u.FIO, u.Age, u.PlaceOfWork, u.ResidentialAddress, u.RegistrationAddress);
            }
        }
        public void DataGridViewUserAdd(DataGridView dataGridView, User user)
        {
            dataGridView.Rows.Clear();               
            dataGridView.Rows.Add(user.UserId, user.FIO, user.Age, user.PlaceOfWork, user.ResidentialAddress, user.RegistrationAddress);            
        }

        public void DataGridViewPhoneAdd(DataGridView dataGridView, IEnumerable<MobilePhone> mobilePhones)
        {
            dataGridView.Rows.Clear();
            foreach(MobilePhone m in mobilePhones)
            {
                dataGridView.Rows.Add(m.MobilePhoneId,m.UserId, m.MobilePhoneUser);
            }
        }
            
    }
}
