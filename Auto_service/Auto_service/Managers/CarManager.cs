using Auto_service.Interfaces;
using Auto_service.Records;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Managers
{
    class CarManager : DBManager, IQL, IDML
    {
        private List<CarRecord> carsAsCarRecords = new List<CarRecord>();
        public List<CarRecord> CarsAsCarRecords
        {
            get
            {
                return carsAsCarRecords;
            }
            set
            {
                carsAsCarRecords = value;
            }
        }
        public int Delete(Record record)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"DELETE FROM Cars 
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

        public int Insert(Record record)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"INSERT INTO Cars(userId)
                                    VALUES ((SELECT id FROM Users WHERE id = Users.id));
                                    INSERT INTO Car_details(id, name, body_type, fuel_type, motor_power, manufacture_year)
                                    VALUES ((SELECT TOP 1 id FROM Cars ORDER BY id DESC), @name, @body_type, @fuel_type, @motor_power, @manufacture_year);";

            //SqlParameter p_id = new SqlParameter();
            //p_id.ParameterName = "@id";
            //p_id.SqlDbType = System.Data.SqlDbType.Int;
            //p_id.Direction = System.Data.ParameterDirection.Input;
            //p_id.Value = (record as CarRecord).Id;
            //command.Parameters.Add(p_id);

            SqlParameter p_name = new SqlParameter();
            p_name.ParameterName = "@name";
            p_name.SqlDbType = System.Data.SqlDbType.Char;
            p_name.Direction = System.Data.ParameterDirection.Input;
            p_name.Value = (record as CarRecord).Name;
            command.Parameters.Add(p_name);

            SqlParameter p_body_type = new SqlParameter();
            p_body_type.ParameterName = "@body_type";
            p_body_type.SqlDbType = System.Data.SqlDbType.VarChar;
            p_body_type.Direction = System.Data.ParameterDirection.Input;
            p_body_type.Value = (record as CarRecord).Body_type;
            command.Parameters.Add(p_body_type);

            SqlParameter p_fuel_type = new SqlParameter();
            p_fuel_type.ParameterName = "@fuel_type";
            p_fuel_type.SqlDbType = System.Data.SqlDbType.VarChar;
            p_fuel_type.Direction = System.Data.ParameterDirection.Input;
            p_fuel_type.Value = (record as CarRecord).Fuel_type;
            command.Parameters.Add(p_fuel_type);

            SqlParameter p_motor_power = new SqlParameter();
            p_motor_power.ParameterName = "@motor_power";
            p_motor_power.SqlDbType = System.Data.SqlDbType.Int;
            p_motor_power.Direction = System.Data.ParameterDirection.Input;
            p_motor_power.Value = (record as CarRecord).Motor_power;
            command.Parameters.Add(p_motor_power);

            SqlParameter p_manufactrue_year = new SqlParameter();
            p_manufactrue_year.ParameterName = "@manufacture_year";
            p_manufactrue_year.SqlDbType = System.Data.SqlDbType.Int;
            p_manufactrue_year.Direction = System.Data.ParameterDirection.Input;
            p_manufactrue_year.Value = (record as CarRecord).Manufacture_year;
            command.Parameters.Add(p_manufactrue_year);


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
            command.CommandText = @"SELECT * FROM Cars INNER JOIN Car_details ON Car_Details.id = Cars.id ORDER BY name";
            command.Connection = getConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CarRecord nextRecord = new CarRecord
                (
                    long.Parse(reader["id"].ToString())
                );
                nextRecord.Name = reader["name"].ToString();
                nextRecord.Body_type = reader["body_type"].ToString();
                nextRecord.Fuel_type = reader["fuel_type"].ToString();
                nextRecord.Motor_power = Convert.ToInt32(reader["motor_power"]);
                nextRecord.Manufacture_year = Convert.ToInt32(reader["manufacture_year"]);

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
    }
}
