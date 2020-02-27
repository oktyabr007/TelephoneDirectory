using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectory.Models;
using System.Data.Entity;
using System.Data.Sql;
using TelephoneDirectory.Manager;

namespace TelephoneDirectory
{
    public partial class Form1 : Form
    {
        TelephoneDirectoryDBContext db;
        MainManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new MainManager();
            db = new TelephoneDirectoryDBContext();

            if (db.Users.Count() == 0)            
                return;         

            manager.DataGridViewUserAdd(dataGridView1, db.Users);
            
            labFIO.Text = dataGridView1["FIO", 0].Value.ToString();     

            int idUser = int.Parse( dataGridView1["Id", 0].Value.ToString());
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {            
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "admin123")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            IEnumerable<User> users = db.Users.Include(m=>m.MobilePhones).Where(m => m.FIO.Contains(txtBoxSearch.Text)
                                                    | m.PlaceOfWork.Contains(txtBoxSearch.Text)
                                                    | m.RegistrationAddress.Contains(txtBoxSearch.Text)
                                                    | m.ResidentialAddress.Contains(txtBoxSearch.Text)
                                                    | m.Age.ToString().Contains(txtBoxSearch.Text)                                                    
                                                );
            
            IEnumerable<MobilePhone> phones = db.MobilePhones.Where(m => m.MobilePhoneUser.Contains(txtBoxSearch.Text));
            manager.DataGridViewPhoneAdd(dataGridView2, phones); 

            manager.DataGridViewUserAdd(dataGridView1, users);

            labFIO.Text = "Выберите номер или пользователя.";
        }

        private void dataGridView2_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.Users.Count() == 0)
                return;

            int IdUser = Convert.ToInt16(dataGridView2.CurrentRow.Cells["IdUser"].Value.ToString());
            User user = db.Users.FirstOrDefault(m => m.UserId == IdUser);            

            manager.DataGridViewUserAdd(dataGridView1, user);

            labFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.Users.Count() == 0)
                return;

            labFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();           

            int IdRow = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            IEnumerable<MobilePhone> phone = db.MobilePhones.Where(m => m.UserId == IdRow);

            manager.DataGridViewPhoneAdd(dataGridView2, phone);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (db.Users.Count() == 0)
                return;

            manager.DataGridViewUserAdd(dataGridView1, db.Users);

            labFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();

            txtBoxSearch.Text = "";
            
            int idUser = int.Parse(dataGridView1["Id", 0].Value.ToString());
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);
        }
    }
}
