using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Worker worker = new Worker();
            //worker.Login_Worker();
            //HR_Manager hR_Manager = new HR_Manager();
            //hR_Manager.Login_HR_Manager();
            //Admin admin = new Admin();
            //admin.Login_Admin();
            Company company = new Company();
            company.Login_Company();
        }
    }
}
