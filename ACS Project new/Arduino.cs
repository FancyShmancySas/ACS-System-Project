using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports; // for SerialPort class
using System.IO;
using System.Threading;
using System.Data.OleDb; // модуль для работы с БД

namespace ACS_Project {
    // реализуем методы взаимодействия с COM портом
    public  class Arduino {
        DataBase db = null;

        // connection info
        const string port_name = "COM3";
        const int speed = 9600;
        SerialPort port = null;
        private static Arduino instance = null; // для singleton 

        // constructor. creates SerialPort according to connection info above
        private Arduino(ref DataBase db) {
            try {
                port = new SerialPort(port_name, speed, Parity.None, 8, StopBits.One);
                this.db = db;
            }
            catch (IOException e) {
                Console.WriteLine(e.Message, Console.Error);
            }
            open_port();
        }


        // singleton
        public static Arduino getInstance(ref DataBase db) {
            if (instance == null) {
                instance = new Arduino(ref db);
            }
            return instance;
        }

        public string wait_for_data() { // слушаем порт
            //Thread.Sleep(1);
            string data = port.ReadExisting(); // ReadExisting - читает всё что есть в порту
            string good_data = "";
            for(int i = 0; i < data.Length; i++) {
                if (data[i] >= '0' && data[i] <= '9') {
                    good_data += data[i];
                }
            }
            Console.WriteLine("#" + good_data + "#");
            Console.WriteLine(data);
            return good_data;
        }

        private bool open_port() {
            try {
                port.Open();
            } catch(UnauthorizedAccessException e) {
                Console.WriteLine(e.Message, Console.Error);
                return false;
            } catch(ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message, Console.Error);
                return false;
            } catch(ArgumentException e) {
                Console.WriteLine(e.Message, Console.Error);
                return false;
            } catch(IOException e) {
                Console.WriteLine(e.Message, Console.Error);
                return false;
            } catch(InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                return false;
            }

            return true;
        }

        private bool close_port() {
            try {
                port.Close();
            } catch(IOException e) {
                Console.WriteLine(e.Message, Console.Error);
                return false;
            }
            return true;
        }

        private bool is_correct_data(string data) { 
            bool res = true;
            for(int i = 0; i < data.Length; i++) {
                if (data[i] < '0' || data[i] > '9') {
                    res = false;
                    break;
                }
            }
            return res;
        }

        private bool check_card_status(bool card_status_bool)
        {
           return false;
        }

        public void send_data(string data)
        {
            Console.WriteLine("data to send: #{0}#", data);
            port.Write(data);

            //string id_card = wait_for_data();
            //Console.WriteLine("card id from arduino: #{0}#", id_card);
            /*
            var DataForUSB = db.get_card_status_by_card_id(id_card);
            if (DataForUSB.Item1)
            {
                string DataForUSB1 = DataForUSB.Item2;
                port.Write(DataForUSB1);
            }
            */
        }
    
        ~Arduino() {
            close_port();
        }
    }
}
