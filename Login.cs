using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class Login
    {
        internal void Login_User()
        {
            //String loginUser = LoginField.Text;//логин берется с сайта от пользователя
            //String passUser = PassField.Text;//пароль берется с сайтал от пользователя

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // "db.getConnectionWorker" - подключать бд от зависимости кто авторизуется
            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker` WHERE `Login` = @Login AND `Password` = @Password", db.getConnectionWorker());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "qwe";//loginUser;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "qwe";//passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //    Console.WriteLine("Вы вошли в систему");
            //}
            //else
            //    Console.WriteLine("Неверный логин или пароль");
            
        }
    }
}