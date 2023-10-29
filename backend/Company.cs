using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class Company
    {
        internal void Register_Company()
        {
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
        internal void Login_Company()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `company` WHERE `Login` = @Login AND `Password` = @Password", db.getConnectionCompany());


            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "company";//loginUser;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "company123";//passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Console.WriteLine("Вы вошли в систему");
            }
            else
                Console.WriteLine("Неверный логин или пароль");
            Console.ReadKey();
        }
    }
}
