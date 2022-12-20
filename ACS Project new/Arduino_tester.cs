using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // for File.WriteAllText
using System.IO.Ports;

namespace ACS_Project {
    public class Arduino_tester {

        private SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);


        [STAThread]
        public void main_run_tests_2() {
            run_tests();
        }

        public void run_tests() {
           
        }

    }
}
