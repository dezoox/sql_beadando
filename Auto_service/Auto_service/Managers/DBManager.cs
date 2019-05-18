using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Auto_service.Managers
{
    public class DBManager
    {
        protected DBManager () { }
        protected SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();

            string connectionString = @"Data Source=193.225.33.22;
                                        Initial Catalog=LP6478_ORAI;
                                        User Id=LP6478;
                                        Password=aA123456;";
            connection.ConnectionString = connectionString;

            //connection.ConnectionString = ConfigurationManager.ConnectionStrings["EKE-DB"].ConnectionString;
            connection.Open();

            return connection;
        }

    }
}
