using Auto_service.Interfaces;
using Auto_service.Records;
using Auto_service.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Managers
{
    class UserManager: DBManager, IQL, IDML
    {
        private List<UserRecord> usersAsUserRecords = new List<UserRecord>();
        public List<UserRecord> UsersAsUserRecords
        {
            get
            {
                return usersAsUserRecords;
            }
            set
            {
                usersAsUserRecords = value;
            }
        }

        public int Insert(Record record)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"INSERT INTO Users(username, password)
                                    VALUES (@username, @password)
                                    INSERT INTO Users_details(user_id, address, firstName, lastname, email)
                                    VALUES ((SELECT TOP 1 id FROM Users ORDER BY id DESC), @address, @firstname, @lastName, @email);";
                                    
            SqlParameter p_username = new SqlParameter();
            p_username.ParameterName = "@username";
            p_username.SqlDbType = System.Data.SqlDbType.Char;
            p_username.Direction = System.Data.ParameterDirection.Input;
            p_username.Value = (record as UserRecord).Username;
            command.Parameters.Add(p_username);

            SqlParameter p_password = new SqlParameter();
            p_password.ParameterName = "@password";
            p_password.SqlDbType = System.Data.SqlDbType.VarChar;
            p_password.Direction = System.Data.ParameterDirection.Input;
            p_password.Value = (record as UserRecord).Password;
            command.Parameters.Add(p_password);

            SqlParameter p_email = new SqlParameter();
            p_email.ParameterName = "@email";
            p_email.SqlDbType = System.Data.SqlDbType.VarChar;
            p_email.Direction = System.Data.ParameterDirection.Input;
            p_email.Value = (record as UserRecord).Email;
            command.Parameters.Add(p_email);

            SqlParameter p_firstName = new SqlParameter();
            p_firstName.ParameterName = "@firstName";
            p_firstName.SqlDbType = System.Data.SqlDbType.VarChar;
            p_firstName.Direction = System.Data.ParameterDirection.Input;
            p_firstName.Value = (record as UserRecord).FirstName;
            command.Parameters.Add(p_firstName);

            SqlParameter p_lastName = new SqlParameter();
            p_lastName.ParameterName = "@lastName";
            p_lastName.SqlDbType = System.Data.SqlDbType.VarChar;
            p_lastName.Direction = System.Data.ParameterDirection.Input;
            p_lastName.Value = (record as UserRecord).LastName;
            command.Parameters.Add(p_lastName);

            SqlParameter p_address = new SqlParameter();
            p_address.ParameterName = "@address";
            p_address.SqlDbType = System.Data.SqlDbType.VarChar;
            p_address.Direction = System.Data.ParameterDirection.Input;
            p_address.Value = (record as UserRecord).Address;
            command.Parameters.Add(p_address);


            command.Connection = getConnection();

            int affectedRows = command.ExecuteNonQuery();
            command.Connection.Close();

            return affectedRows;
        }

        public List<Record> Select()
        {
            List<Record> records = new List<Record>();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * FROM Users INNER JOIN Users_details ON Users_details.user_id = Users.id ORDER BY Username";
            command.Connection = getConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserRecord nextRecord = new UserRecord
                (
                    long.Parse(reader["id"].ToString())
                );
                nextRecord.Username = reader["username"].ToString();
                nextRecord.Password = reader["password"].ToString();
                nextRecord.Email = reader["email"].ToString();
                nextRecord.FirstName = reader["firstName"].ToString();
                nextRecord.LastName = reader["lastName"].ToString();
                nextRecord.Address = reader["address"].ToString();

                records.Add(nextRecord);
            }

            return records;
        }

        public Record Select(Record record)
        {
            throw new NotImplementedException();
        }

        public int Update(Record record)
        {
            throw new NotImplementedException();
        }
        public int Delete(Record record)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"DELETE FROM Users 
                                    WHERE id = @id";

            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.SqlDbType = System.Data.SqlDbType.BigInt;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = record.Id;
            command.Parameters.Add(pId);

            command.Connection = getConnection();
            int affectedRows = command.ExecuteNonQuery();

            command.Connection.Close();

            return affectedRows;
        }
    }
}
