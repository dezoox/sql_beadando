using Auto_service.Forms;
using Auto_service.Managers;
using Auto_service.Records;
using Auto_service.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_service
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            fillUsersAsUserRecordsFromRecords();
        }
        private UserManager userManager = new UserManager();
        

        private void button_login_Click(object sender, EventArgs e)
        {
            if (ValidateUser(textBox_Username.Text, textBox_Password.Text))
            {
                ValidLogin();
                
            }
            else
            {
                InvalidLogin();
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            var MyForm = new RegistrationForm();
            MyForm.Show();
            this.Hide();
        }
        private void fillUsersAsUserRecordsFromRecords()
        {
            List<Record> usersAsRecords = userManager.Select();

            foreach (var record in usersAsRecords)
            {
                UserRecord userRecord = new UserRecord();
                userRecord.Username = (record as UserRecord).Username;
                userRecord.Password = (record as UserRecord).Password;
                userRecord.Address = (record as UserRecord).Address;
                userRecord.Email = (record as UserRecord).Email;
                userRecord.FirstName = (record as UserRecord).FirstName;
                userRecord.LastName = (record as UserRecord).LastName;

                userManager.UsersAsUserRecords.Add(userRecord);
            }
        }

        private bool ValidateUser(string username, string password)
        {
            foreach (var user in userManager.UsersAsUserRecords)
            {
                return username == user.Username && password == user.Password;
            }
            return false;
        }

        private void InvalidLogin()
        {
            MessageBox.Show("Sikertelen bejelentkezés.");
            textBox_Username.Text = "";
            textBox_Password.Text = "";
        }
        private void ValidLogin()
        {
            MessageBox.Show("Sikeres bejelentkezés");
            var Myform = new CarForm();
            Myform.Show();
            this.Hide();
        }
       
    }
}
