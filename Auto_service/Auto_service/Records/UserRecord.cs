using Auto_service.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Tables
{
    public class UserRecord : Record
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string address;
        private string email;
        //private int id;
        //public int Id
        //{
        //    get
        //    {
        //        return id;
        //    }
        //    set
        //    {
        //        id = value;
        //    }
        //}

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public UserRecord()
        {

        }
        public UserRecord(string username, string password, string FirstName, string Lastname
            , string Email, string Address)
            :base()
        {
            this.username = username;
            this.password = password;
            this.firstName = FirstName;
            this.lastName = Lastname;
            this.email = Email;
            this.address = Address;
        }

        public UserRecord(long? id)
            : base(id)
        {

        }
    }
}
