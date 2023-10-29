using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class HR_Manager 
    {
        List<Worker> workers = new List<Worker>();
        internal void Register_HR_Manager()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `hr_manadger` (`Login`, `Password`, `FIO`, `NumberOfPhone`) VALUES (@Login,@Password,@FIO,@NumberOfPhone)", db.getConnectionHR_Manager());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "v";//инфа с сайта
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "vc";//инфа с сайта
            command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = "vcv";//инфа с сайта
            command.Parameters.Add("@NumberOfPhone", MySqlDbType.VarChar).Value = 123;//инфа с сайта


            db.openConnectionHR_Manager();

            if (command.ExecuteNonQuery() == 1)
                Console.WriteLine("Аккаунт был создан");
            else
                Console.WriteLine("Аккаунт НЕ был создан!!!");

            db.closeConnectionHR_Manager();
            Console.ReadKey();
        }
    }
}
