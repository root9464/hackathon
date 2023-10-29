using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mysql
{
    internal class Worker
    {
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

        public void AddWorker()
        {

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `stack_workers`(`Login`, `Password`, `FIO`, `Post`, `Department`, `Division`, `NumberOfPhone`) VALUES(@Login,@Password,@FIO,@Post,@Department,@Division,@NumberOfPhone)", db.getConnectionAddWorker());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = "ва";//инфа с сайта
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = "выа2";//инфа с сайта
            command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = "ыва";//инфа с сайта
            command.Parameters.Add("@Post", MySqlDbType.VarChar).Value = "выа";//инфа с сайта
            command.Parameters.Add("@Department", MySqlDbType.VarChar).Value = "ва";//инфа с сайта
            command.Parameters.Add("@Division", MySqlDbType.VarChar).Value = "в";//инфа с сайта
            command.Parameters.Add("@NumberOfPhone", MySqlDbType.VarChar).Value = "аыв";//инфа с сайта


            db.openConnectionAddWorker();

            if (command.ExecuteNonQuery() == 1)
                Console.WriteLine("Аккаунт был создан");
            else
                Console.WriteLine("Аккаунт НЕ был создан!!!");

            db.closeConnectionAddWorker();
            Console.ReadKey();


            
        }
    }
}
