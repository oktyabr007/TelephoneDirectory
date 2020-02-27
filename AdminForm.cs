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
using TelephoneDirectory.Manager;

namespace TelephoneDirectory
{
    public partial class AdminForm : Form
    {
        TelephoneDirectoryDBContext db;
        MainManager manager;

        public AdminForm()
        {
            InitializeComponent();

            btnEditUser.Enabled = false;

            db = new TelephoneDirectoryDBContext();
            manager = new MainManager();

            if (db.Users.Count() == 0)
                return;

            manager.DataGridViewUserAdd(dataGridView1, db.Users);

            //int idUser = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());            
            int idUser = int.Parse(dataGridView1["Id",0].Value.ToString());            
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);
            
            lblFIO.Text = dataGridView1["FIO",0].Value.ToString();
            lblFIOInfo.Text = dataGridView1["FIO",0].Value.ToString();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }       

        private void BtnDelUser_Click(object sender, EventArgs e)
        {
            if (db.Users.Count() == 0)
                return;

            int idUser = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            User u = db.Users.Include(m=>m.MobilePhones).FirstOrDefault(m => m.UserId == idUser);
            db.Users.Remove(u);
            db.SaveChanges();

            //нужно, если не остается пользователя
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            if (db.Users.Count() == 0)
                return;

            manager.DataGridViewUserAdd(dataGridView1, db.Users);

            idUser = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());            
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);            

            lblFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
            lblFIOInfo.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.Users.Count() == 0)
                return;

            lblFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();           
            lblFIOInfo.Text= dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
            
            int IdPhone = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == IdPhone);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        int idEditUser;//для фикцсации изменения пользователя
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.Users.Count() == 0)
                return;

            btnEditUser.Enabled = true;

            idEditUser = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            User user = db.Users.First(m => m.UserId == idEditUser);

            txtBoxFIO.Text = user.FIO;
            maskedTextBoxAge.Text = user.Age.ToString();
            txtBoxPlaceOfWork.Text = user.PlaceOfWork;
            txtBoxRegistrationAddress.Text = user.RegistrationAddress;
            txtBoxResidentialAddress.Text = user.ResidentialAddress;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            btnEditUser.Enabled = false;

            User u = db.Users.First(m => m.UserId == idEditUser);

            u.FIO = txtBoxFIO.Text;
            u.Age = int.Parse(maskedTextBoxAge.Text);
            u.PlaceOfWork = txtBoxPlaceOfWork.Text;
            u.RegistrationAddress = txtBoxRegistrationAddress.Text;
            u.ResidentialAddress = txtBoxResidentialAddress.Text;

            db.Entry(u).State = EntityState.Modified;
            db.SaveChanges();

            //очистить поля
            txtBoxFIO.Clear(); maskedTextBoxAge.Clear(); txtBoxPlaceOfWork.Clear(); txtBoxRegistrationAddress.Clear();
            txtBoxResidentialAddress.Clear();
                        
            manager.DataGridViewUserAdd(dataGridView1, db.Users);
                        
            int idUser = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);
           
            lblFIOInfo.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
            lblFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnEditUser.Enabled = false;

            if (txtBoxFIO.Text == "")
            { MessageBox.Show("Пустое поле ФИО."); return; }
            else if (!maskedTextBoxAge.MaskFull)
            { MessageBox.Show("Пустое поле Возраст."); return; }
            else if (txtBoxPlaceOfWork.Text == "")
            { MessageBox.Show("Пустое поле место работы."); return; }
            else if (txtBoxResidentialAddress.Text == "")
            { MessageBox.Show("Пустое поле Адрес проживания."); return; }
            else if (txtBoxRegistrationAddress.Text == "")
            { MessageBox.Show("Пустое поле адрес регистрации."); return; }
            else
            {
                User user = new User()
                {
                    FIO = txtBoxFIO.Text,
                    Age = int.Parse(maskedTextBoxAge.Text),
                    PlaceOfWork = txtBoxPlaceOfWork.Text,
                    ResidentialAddress = txtBoxResidentialAddress.Text,
                    RegistrationAddress = txtBoxRegistrationAddress.Text
                };
                db.Users.Add(user);
                db.SaveChanges();
            }

            //очистить поля
            txtBoxFIO.Clear(); maskedTextBoxAge.Clear(); txtBoxPlaceOfWork.Clear(); txtBoxRegistrationAddress.Clear();
            txtBoxResidentialAddress.Clear();

            manager.DataGridViewUserAdd(dataGridView1, db.Users);
            
            int idUser = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            IEnumerable<MobilePhone> mobilePhone = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhone);

            lblFIOInfo.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
            lblFIO.Text = dataGridView1.CurrentRow.Cells["FIO"].Value.ToString();
        }

        private void btnDelTelephone_Click(object sender, EventArgs e)
        {
            if (db.MobilePhones.Count() == 0)
                return;

            int idPhone = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            int idUser = int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString());

            MobilePhone mobilePhone = db.MobilePhones.First(m => m.MobilePhoneId == idPhone);
            db.MobilePhones.Remove(mobilePhone);
            db.SaveChanges();
                       
            IEnumerable<MobilePhone> mobilePhoneList = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhoneList);
        }

        private void btnAddTelephone_Click(object sender, EventArgs e)
        {
            if (!maskedTextBoxTelephone.MaskFull)
                { MessageBox.Show("Некорректный ввод"); return; }

            if (db.Users.Count() == 0)
                { MessageBox.Show("Добавьте пользователя."); return; }

            int idUser = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            MobilePhone mobilePhone = new MobilePhone() { UserId = idUser, MobilePhoneUser = maskedTextBoxTelephone.Text };

            db.MobilePhones.Add(mobilePhone);
            db.SaveChanges();            

            IEnumerable<MobilePhone> mobilePhoneList = db.MobilePhones.Where(m => m.UserId == idUser);

            manager.DataGridViewPhoneAdd(dataGridView2, mobilePhoneList);

            maskedTextBoxTelephone.Clear();
        }
    }
}
