using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_Project {
    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            /*
            Arduino_tester tester = new Arduino_tester();
            tester.main_run_tests_2();
            */
            
            // получение экземпляра класса DataBase
            string path_to_DB = "D:\\vikto\\Documents\\Institute\\3 курс\\ООП\\ACS Project new\\ACS Project for Arduino.mdb";
            string provider = "Microsoft.ACE.OLEDB.12.0";
            DataBase db = DataBase.getInstance(ref path_to_DB, ref provider);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1(ref db);
            Application.Run(form1);
            
        }
    }
}
