using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class Admin
    {
        internal void Register_Admin()
        {
            //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=admin");


            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `admin`(`Login`, `Password`) VALUES(@Login,@Password)", db.getConnectionAdmin());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "3";//инфа с сайта
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "3";//инфа с сайта

            db.openConnectionAdmin();

            if (command.ExecuteNonQuery() == 1)
                Console.WriteLine("Аккаунт был создан");
            else
                Console.WriteLine("Аккаунт НЕ был создан!!!");

            db.closeConnectionAdmin();
            Console.ReadKey();
        }

        internal void Login_Admin()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `Login` = @Login AND `Password` = @Password", db.getConnectionAdmin());


            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "admin";//loginUser;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "root";//passUser;

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
