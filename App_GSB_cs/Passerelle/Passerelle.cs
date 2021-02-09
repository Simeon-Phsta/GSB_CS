using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace pass
{
    public class Passerelle
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static List<string[]> Query (MySqlConnection conn, string sql)
        {

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;
            conn.Open();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    List<string[]>temp = new List<string[]>();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = 0;
                        string[] tempe = new string[reader.FieldCount];
                        for(int i = 0;i < reader.FieldCount ; i++)
                        {
                            tempe[count] = reader.GetString(i);
                            count ++;
                        }
                        temp.Add(tempe);
                    }
                    return temp;
                }
                else { return null; }
            }
        }
        static public void InsertUpdateDel(MySqlConnection conn , string sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}