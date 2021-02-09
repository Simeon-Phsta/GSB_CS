using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using pass;
namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = Passerelle.GetDBConnection("localhost", 3306, "ppe_gsb_cs", "root", "");
            string sql = "Select * from medicament";
            List<string[]> temp =Passerelle.Query(conn, sql);
            int counter = 0;
            int countera = 0;
            foreach (string[] t in temp)
            {
                counter++;
                countera = 0;
                Console.WriteLine("");
                Console.WriteLine("Ligne " + counter + " :-- ");
                Console.WriteLine("");
                foreach (string champ in t)
                {
                    countera++;
                    Console.WriteLine("Champ : " + champ);
                }
            }
            Console.ReadLine();
        }
    }
}
