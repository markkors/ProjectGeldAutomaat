using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library.Models
{
    public class dbConnection
    {
        // create a connection string to mysql database
        string connectionString = "Server=localhost;Database=personen;User ID=personen_user;Password=12345678;";
        MySqlConnection _connection;

        public dbConnection()
        {
            using (_connection = new MySqlConnection(connectionString))
            {
                try
                {
                    _connection.Open();

                }
                catch (Exception ex)
                {
                    // handle the error
                }
            }
        }

        public MySqlConnection Conn
        {
            get { return _connection; }
        }

        public void GetPersons()
        {
            // create a command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM person", _connection);
            // execute the command
            MySqlDataReader reader = cmd.ExecuteReader();
            // read the data
            while (reader.Read())
            {

            }
            // close the reader
            reader.Close();
        }
    }
}
