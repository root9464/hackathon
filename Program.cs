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
            Worker worker = new Worker();
            worker.AddWorker();
            //HR_Manager hR_Manager = new HR_Manager();
            //hR_Manager.Register_HR_Manager();
            //Admin admin = new Admin();
            //admin.Register_Admin();
            //Company company = new Company();
            //company.Register_Company();
        }
    }
}
