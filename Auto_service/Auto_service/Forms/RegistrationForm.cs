using Auto_service.Managers;
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

namespace Auto_service.Forms
{
    public partial class RegistrationForm : Form
    {
        private UserManager userManager = new UserManager();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox_username.Text;
                string password = textBox_password.Text;
                string email = textBox_email.Text;
                string firstname = textBox_firstName.Text;
                string lastName = textBox_lastName.Text;
                string address = textBox_address.Text;

                if (!UserNameAlreadyExists(username))
                {
                    UserRecord user = new UserRecord(username, password, firstname, lastName, email, address);
                    userManager.Insert(user);
                    userManager.UsersAsUserRecords.Add(user);
                    MessageBox.Show("Sikeres regisztráció.");
                    var Myform = new LoginForm();
                    Myform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Már létezik ilyen felhasználó.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen regisztráció. " + ex.Message);
            }
        }
        private bool UserNameAlreadyExists(string username)
        {
            bool exists = false;
            foreach (var item in userManager.UsersAsUserRecords)
            {
                if (item.Username == username)
                {
                    exists = true;
                    break;
                }
                else
                {
                    exists = false;
                    break;
                }
            }
            return exists;
        }
    }
}
