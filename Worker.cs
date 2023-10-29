using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mysql
{
    internal class Worker
    {
        /// <summary>
        /// Статическое поле staticId
        /// </summary>
        private int staticId;


        /// <summary>
        /// логин
        /// </summary>
        private string login;


        /// <summary>
        /// пароль
        /// </summary>
        private string password;

        /// <summary>
        /// фио
        /// </summary>        
        private string fio;


        /// <summary>
        /// должность
        /// </summary>
        private string post;


        /// <summary>
        /// департамент
        /// </summary>
        private string departament;


        /// <summary>
        /// отдел
        /// </summary>        
        private string division;


        /// <summary>
        /// номер телефона
        /// </summary>
        private int number_of_phone;

        internal void Register_Worker()
        {

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `worker`(`Login`, `Password`, `FIO`, `Post`, `Department`, `Division`, `NumberOfPhone`) VALUES(@Login,@Password,@FIO,@Post,@Department,@Division,@NumberOfPhone)", db.getConnectionWorker());


            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "2";//инфа с сайта
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "2";//инфа с сайта
            command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = "2";//инфа с сайта
            command.Parameters.Add("@Post", MySqlDbType.VarChar).Value = "21";//инфа с сайта
            command.Parameters.Add("@Department", MySqlDbType.VarChar).Value = "21";//инфа с сайта
            command.Parameters.Add("@Division", MySqlDbType.VarChar).Value = "2";//инфа с сайта
            command.Parameters.Add("@NumberOfPhone", MySqlDbType.VarChar).Value = "2";//инфа с сайта


            db.openConnectionWorker();

            if (command.ExecuteNonQuery() == 1)
                Console.WriteLine("Аккаунт был создан");
            else
                Console.WriteLine("Аккаунт НЕ был создан!!!");

            db.openConnectionWorker();
            Console.ReadKey();
        }

        internal void Login_Worker()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker` WHERE `Login` = @Login AND `Password` = @Password", db.getConnectionWorker());


            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "worker";//loginUser;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "123";//passUser;

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

        //public void AddWorker()
        //{

        //    DataBase db = new DataBase();
        //    DataTable table = new DataTable();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `worker` WHERE `Login` = @Login AND `Password` = @Password", db.getConnectionWorker());


        //    command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "worker";//loginUser;
        //    command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "123";//passUser;

        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);

        //    if (table.Rows.Count > 0)
        //    {
        //        Console.WriteLine("Вы вошли в систему");
        //    }
        //    else
        //        Console.WriteLine("Неверный логин или пароль");
        //    Console.ReadKey();



        //}


    

    internal void GetDataFromDb()
        {
            DataTable table = new DataTable();

        }
    }
}
