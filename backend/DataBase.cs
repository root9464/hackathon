using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class DataBase
    {
        /////Worker 
        MySqlConnection connection_worker = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=worker");      
        public void openConnectionWorker()
        {
            if (connection_worker.State == System.Data.ConnectionState.Closed)
                connection_worker.Open();

            //если мы не подключены, то мы подключимся к базе данных
        }
        public void closeConnectionWorker()
        {
            if (connection_worker.State == System.Data.ConnectionState.Open)
                connection_worker.Close();
            //если мы подключены, то мы отключимся от базы данных
        }
        public MySqlConnection getConnectionWorker()
        {
            return connection_worker;
        }

        /////Add_Worker 
        string path = "SELECT * FROM hr_manadger.stack_workers";
        MySqlConnection connection_add_worker = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=path");
        public void openConnectionAddWorker()
        {
            if (connection_add_worker.State == System.Data.ConnectionState.Closed)
                connection_add_worker.Open();

            //если мы не подключены, то мы подключимся к базе данных
        }
        public void closeConnectionAddWorker()
        {
            if (connection_add_worker.State == System.Data.ConnectionState.Open)
                connection_add_worker.Close();
            //если мы подключены, то мы отключимся от базы данных
        }
        public MySqlConnection getConnectionAddWorker()
        {
            return connection_add_worker;
        }


        /////HR_Manager 
        MySqlConnection connection_hr_manager = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=hr_manadger");
        public void openConnectionHR_Manager()
        {
            if (connection_hr_manager.State == System.Data.ConnectionState.Closed)
                connection_hr_manager.Open();

            //если мы не подключены, то мы подключимся к базе данных
        }
        public void closeConnectionHR_Manager()
        {
            if (connection_hr_manager.State == System.Data.ConnectionState.Open)
                connection_hr_manager.Close();
            //если мы подключены, то мы отключимся от базы данных
        }
        public MySqlConnection getConnectionHR_Manager()
        {
            return connection_hr_manager;
        }


        /////Admin 
        MySqlConnection connection_admin = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=admin");
        public void openConnectionAdmin()
        {
            if (connection_admin.State == System.Data.ConnectionState.Closed)
                connection_admin.Open();

            //если мы не подключены, то мы подключимся к базе данных
        }
        public void closeConnectionAdmin()
        {
            if (connection_admin.State == System.Data.ConnectionState.Open)
                connection_admin.Close();
            //если мы подключены, то мы отключимся от базы данных
        }
        public MySqlConnection getConnectionAdmin()
        {
            return connection_admin;
        }


        /////Company 
        MySqlConnection connection_company = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=company");
        public void openConnectionCompany()
        {
            if (connection_company.State == System.Data.ConnectionState.Closed)
                connection_company.Open();

            //если мы не подключены, то мы подключимся к базе данных
        }
        public void closeConnectionCompany()
        {
            if (connection_company.State == System.Data.ConnectionState.Open)
                connection_company.Close();
            //если мы подключены, то мы отключимся от базы данных
        }
        public MySqlConnection getConnectionCompany()
        {
            return connection_company;
        }
    }
}
