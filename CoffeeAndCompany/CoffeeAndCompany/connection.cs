using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace CoffeeAndCompany
{
    class connection
    {
        string con_string = "server=localhost;user=root;password=tanki_online123;database=cc";

        public void queryExecute(string q)
        {
            MySqlConnection con = new MySqlConnection(con_string);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader viewData(string q)
        {
            MySqlConnection con = new MySqlConnection(con_string);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
