using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class Company
    {
        internal void Register_Company()
        {
            //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=company");


            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `company`(`NameOfCompany`, `INN`, `Address`) VALUES (@NameOfCompany,@INN,@Address)", db.getConnectionCompany());

            command.Parameters.Add("@NameOfCompany", MySqlDbType.VarChar).Value = "ddsf";//инфа с сайта
            command.Parameters.Add("@INN", MySqlDbType.VarChar).Value = 12356;//инфа с сайта

            command.Parameters.Add("@Address", MySqlDbType.VarChar).Value = "ddsf";//инфа с сайта



            db.openConnectionCompany();

            if (command.ExecuteNonQuery() == 1)
                Console.WriteLine("Аккаунт был создан");
            else
                Console.WriteLine("Аккаунт НЕ был создан!!!");

            db.closeConnectionCompany();
            Console.ReadKey();
        }
    }
}
