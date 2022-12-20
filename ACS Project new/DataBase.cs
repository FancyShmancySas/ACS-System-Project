using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // модуль для работы с БД
using System.Xml.Linq;
using System.Data.Common;
using System.Collections;
using System.CodeDom;

namespace ACS_Project {
    public class DataBase {
        // info to connect to DB
        private readonly string path_to_DB; //= "ACS Project for Arduino.mdb";
        private readonly string provider; // = "Microsoft.ACE.OLEDB.12.0";
        private readonly string StringConnection; //= "Provider=" + provider + "; Data Source=" + path_to_DB;
        // connection
        private OleDbConnection MyConnection; // переменная для соединения с БД
        private static DataBase instance;

        // constructor
        private DataBase(ref string path_to_DB_, ref string provider_)
        {
            path_to_DB = path_to_DB_;
            provider = provider_;
            StringConnection = "Provider=" + provider + "; Data Source=" + path_to_DB; // строка соединения с БД
            if (ExistsDB())
            {
                MyConnection = new OleDbConnection(StringConnection);
                // обработать исключение!!!!
            } else
            {
                string message = "DataBase \"" + path_to_DB_ + "\" doesn't exist!";
                Console.WriteLine(message, Console.Error);
            }
            
        }

        // возвращает ссылку на существующий экземпляр, либо создает новый.
        public static DataBase getInstance(ref string path_to_DB_, ref string provider_) {
            if (instance == null) {
                instance = new DataBase(ref path_to_DB_, ref provider_);
            }
            return instance;
        }

        /*
         1. добавление сотрудника в БД              [done]
         2. удаление сотрудника из БД               [done]
         3. обновление данных сотрудника            [done]
         4. получение списка всех сотрудников       [done]
         5. проверка существования БД               [done]
         */

        // проверка существования БД
        private bool ExistsDB()
        {
            return File.Exists(path_to_DB);
        }

        private bool open_connection()
        {
            try
            {
                MyConnection.Open(); // открыли соединение с БД
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("72, DataBase");
                Console.WriteLine(e.Message, Console.Error);
                return false;
            }
            catch (OleDbException e)
            {
                Console.WriteLine("78, DataBase");
                Console.WriteLine(e.Message, Console.Error);
                return false;
            }
            return true;
        }
        // добавление сотрудника в БД
        private bool AddIdCard(string card_id) {
            card_id = preprocess_card_id(card_id);
            if (!open_connection()) {
                 Console.WriteLine("87, DataBase");
                return false;
            }

            string isue_date = "1.1.2013";
            string end_date = "1.1.2030";
            string phis_num = card_id;
            string query = "INSERT INTO [Identification Card] ([ID Card], [Issue Date], [End Date], [Card PhisNum]) VALUES (\'" + card_id + "\', \'" + isue_date + "\', \'" + end_date + "\', \'" + phis_num + "\')";
            Console.WriteLine(query);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            try {
                cmd.ExecuteNonQuery();
            } catch (InvalidOperationException e) {
                Console.WriteLine("101, DataBase");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
             Console.WriteLine("107, DataBase - OK");
            return true;
        }


        private bool is_new_cardholder(string card_id) {
            // защита от "падаем при попытке добавления существующего card id"
            if (!open_connection())
            {
                Console.WriteLine("connection failed!");
                return false;
            }

            // проверка отсутствия сотрудника, которого хотим добавить
            string query_CheckExist = "SELECT COUNT(*) FROM [Card Holders] Where [Card ID] = " + card_id;
            //Console.WriteLine(query_CheckExist);
            OleDbCommand cmd_check_exist = new OleDbCommand(query_CheckExist, MyConnection);
            int cnt1 = 0;
            Console.WriteLine(query_CheckExist);
            try
            {
                cnt1 = (int)cmd_check_exist.ExecuteScalar();
            }
            catch (InvalidOperationException e)
            {
                 Console.WriteLine("132, DataBase");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }

            // проверка отсутствия сотрудника, которого хотим добавить
            string query_CheckExist2 = "SELECT COUNT(*) FROM [Identification Card] Where [ID Card] = " + card_id;
            //Console.WriteLine(query_CheckExist);
            OleDbCommand cmd_check_exist2 = new OleDbCommand(query_CheckExist2, MyConnection);
            int cnt2 = 0;
            Console.WriteLine(query_CheckExist);
            try
            {
                cnt2 = (int)cmd_check_exist.ExecuteScalar();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("150, DataBase");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return cnt1 == 0 && cnt2 == 0;
        }


        public bool AddPerson(ref Person p)
        {
            p.set_card_id(preprocess_card_id(p.get_card_id()));
            if (!open_connection())
            {
                Console.WriteLine("161, DataBase");
                return false;
            }
            // проверка существования записи в таблице [Identification Card] и в таблице [Card Holders] с [ID Card] ([Card ID]) = p.get_card_id()
            if (!is_new_cardholder(p.get_card_id()))
            {
                Console.WriteLine("Cardholder with card id \"{0}\" already exists!", p.get_card_id());
                MyConnection.Close();
                return false;
            }
            if (!AddIdCard(p.get_card_id())) // добавление соотв. записи в таблицу [Identification Card]
            {
                 Console.WriteLine("173, DataBase");
                return false;
            }
            string query = "INSERT INTO [Card Holders] ([ID Holder], Surname, Nomen, Lastname, Foto, [Card ID], Status, [Job Title ID], [Department ID]) VALUES (\'" 
                            + p.get_holder_id() + "\',\'" + p.get_surname() 
                            + "\' ,\'" + p.get_name() + "\', \'" + p.get_lastname() 
                            + "\', \'" + p.get_path_to_photo() + "\', \'" + p.get_card_id() 
                            + "\', \'" + p.get_status() + "\', \'" + p.get_job_id() + "\', \'" 
                            + p.get_department_id() + "\')";
            //Console.WriteLine(query);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            try
            {
                cmd.ExecuteNonQuery();
            } catch(InvalidOperationException e)
            {
                Console.WriteLine("189, DataBase");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return true;
        }

        public bool DeletePerson(uint holder_id, string card_id = "bebra")
        {
            if(card_id == "bebra") { // проверка на передачу id карты
                return false;
            }
            if (!open_connection())
            {
                Console.WriteLine("connection failed!");
                return false;
            }

            // проверка существования сотрудника, которого хотим удалить
            string query_CheckExist = "SELECT COUNT(*) FROM [Card Holders] Where [ID Holder] = " + holder_id;
            //Console.WriteLine(query_CheckExist);
            OleDbCommand cmd_check_exist = new OleDbCommand(query_CheckExist, MyConnection);
            int cnt = 0;
            Console.WriteLine(query_CheckExist);
            try
            {
                cnt = (int) cmd_check_exist.ExecuteScalar();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("225 DataBase");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }


            if (cnt == 0)
            {
                MyConnection.Close();
                Console.WriteLine("There are no any persons with Holder ID" + holder_id, Console.Error);
                return false;
            }

            // проверка наличия соотв. card_id в таблице [Identification Card]
            string query_CheckExist_2 = "SELECT COUNT(*) FROM [Identification Card] WHERE [ID Card] = " + card_id;
            OleDbCommand cmd_check_exist_2 = new OleDbCommand(query_CheckExist_2, MyConnection);
            int cnt_2 = 0;
            Console.WriteLine(query_CheckExist_2);
            try {
                cnt_2 = (int)cmd_check_exist_2.ExecuteScalar();
            } catch (InvalidOperationException e) {
                Console.WriteLine("247 DataBase");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }

            if (cnt_2 == 0) {
                MyConnection.Close();
                Console.WriteLine("There are no any persons with Card ID in [Identification Card] " + card_id, Console.Error);
                return false;
            }

            // удаление сотрудника
            string query_del = "DELETE FROM [Card Holders] WHERE [ID Holder] = " + holder_id;
            OleDbCommand cmd_del = new OleDbCommand(query_del, MyConnection);
            Console.WriteLine(query_del);
            try
            {
                cmd_del.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("wfighwivhijef;efjobjefojefefbj");
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }



            // удаление соотв. записи из [Identification Card]
            string query_del_2 = "DELETE FROM [Identification Card] WHERE [ID Card] = " + card_id;
            OleDbCommand cmd_del_2 = new OleDbCommand(query_del_2, MyConnection);
            Console.WriteLine(query_del_2);
            try {
                cmd_del_2.ExecuteNonQuery();
            } catch (InvalidOperationException e) {
                //Console.WriteLine("wfighwivhijef;efjobjefojefefbj"); 
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return true;
        }

        public bool DeletePerson(string card_id) {
            if (!open_connection()) {
                return false;
            }

            // проверка существования сотрудника, которого хотим удалить
            string query_CheckExist = "SELECT COUNT(*) FROM [Card Holders] Where [Card ID] = \'" + card_id + "\'";
            OleDbCommand cmd_check_exist = new OleDbCommand(query_CheckExist, MyConnection);
            int cnt = 0;
            try {
                cnt = (int)cmd_check_exist.ExecuteScalar();
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }

            if (cnt == 0) {
                MyConnection.Close();
                Console.WriteLine("There are no any persons with Holder ID \'" + card_id + "\'", Console.Error);
                return false;
            }

            // удаление сотрудника
            string query_del = "DELETE FROM [Card Holders] WHERE [Card ID] = \'" + card_id + "\'";
            OleDbCommand cmd_del = new OleDbCommand(query_del, MyConnection);
            try {
                cmd_del.ExecuteNonQuery();
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return true;
        }

        public bool UpdatePerson(uint holder_id_old, ref Person p_updated)
        {
            if (DeletePerson(holder_id_old))
            {
                return AddPerson(ref p_updated);
            }

            return false;
        }
        public bool UpdatePerson_2(string card_id, ref Person p_updated) {
            if (DeletePerson(card_id)) {
                return AddPerson(ref p_updated);
            }

            return false;
        }
        private bool update_field_by_card_id_str(string card_id, string field_name, string val) {
            if (!open_connection()) {
                return false;
            }
            string table_name = "[Card Holders]";
            string query = "UPDATE " + table_name + " SET " + field_name + " = \'" + val + "\' WHERE [Card ID] = " + card_id;
            //Console.WriteLine(query);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            try {
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("field_name: {0}, value: {1}, rows affected: {2}", field_name, val, rows);
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return true;
        }
        private bool update_field_by_card_id_uint(string card_id, string field_name, uint val) {
            if (!open_connection()) {
                return false;
            }
            string table_name = "[Card Holders]";
            string query = "UPDATE " + table_name + " SET " + field_name + " = " + Convert.ToString(val) + " WHERE [Card ID] = " + card_id;
            Console.WriteLine(query);
            //Console.WriteLine(query);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            try {
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("field_name: {0}, value: {1}, rows affected: {2}", field_name, val, rows);
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return true;
        }

        // обновление полей в таблице
        private bool update_field_by_card_id(string card_id, string field_name, bool val) { 
            if (!open_connection()) {
                return false;
            }
            string table_name = "[Card Holders]";
            string query = "UPDATE " + table_name + " SET " + field_name + " = \'" + ((val) ? "Active" : "Inactive") + "\' WHERE [Card ID] = " + card_id;
            //Console.WriteLine(query);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            try {
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("field_name: {0}, value: {1}, rows affected: {2}", field_name, val, rows);
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return false;
            }
            MyConnection.Close();
            return true;
        }
        
        //метод для обновления каждого поля person 
        public bool UpdateFieldsPerson(string card_id, ref Person p_new, bool update_status) {
            uint holder_id = 0;
            //holder_id = 
            var res = get_person_by_card_id(card_id);
            Person p_old = null;
            if(res.Item1) {
                p_old = res.Item2;
            } else {
                return false;
            }

            holder_id = p_old.get_holder_id();
            
            if(p_old.get_job_id() != p_new.get_job_id()) {
                if(!update_field_by_card_id_uint(card_id, "[Job Title ID]", p_new.get_job_id())) {
                    return false;
                }
            }
        

            if(p_old.get_department_id() != p_new.get_department_id()) {
                if (!update_field_by_card_id_uint(card_id, "[Department ID]", p_new.get_department_id())) {
                    return false;
                }
            }

            if(p_old.get_surname() != p_new.get_surname()) {
                if (!update_field_by_card_id_str(card_id, "[Surname]", p_new.get_surname())) {
                    return false;
                }
            }

            if(p_old.get_name() != p_new.get_name()) {
                if(!update_field_by_card_id_str(card_id, "[Nomen]", p_new.get_name())) {
                    return false;
                }
            }

            if(p_old.get_lastname() != p_new.get_lastname()) {
                if (!update_field_by_card_id_str(card_id, "[Lastname]", p_new.get_lastname())) {
                    return false;
                }
            }

            if(p_old.get_path_to_photo() != p_new.get_path_to_photo()) {
                if(!update_field_by_card_id_str(card_id, "[Foto]", p_new.get_path_to_photo())) {
                    return false;
                }
            }

            if(p_old.get_status() != p_new.get_status()) {
                if(!update_field_by_card_id(card_id, "[Status]", p_new.get_status())) {
                    return false;
                }
            }
            return true;
        }

        public Tuple<bool, List<Person>> AllPersons()
        {
            List<Person> persons = new List<Person>();

            if (!open_connection())
            {
                return Tuple.Create(false, persons);
            }

            //string query = "SELECT * FROM [Card Holders]";
            string query = "SELECT * FROM [Card Holders]";
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, persons);
            }
            MyConnection.Close();



            while (reader.Read())
            {
                uint holder_id = Convert.ToUInt32(reader[0].ToString());
                string surname = reader[1].ToString();
                string name = reader[2].ToString();
                string lastname = reader[3].ToString();
                string path_to_photo = reader[4].ToString();
                string card_id = reader[5].ToString();
                bool status = reader[6].ToString().Equals("Active");
                uint job_id = Convert.ToUInt32(reader[7].ToString());
                uint department_id = Convert.ToUInt32(reader[8].ToString());
                Person p = new Person(holder_id, card_id, job_id, department_id, surname, name, lastname, path_to_photo, status);
                persons.Add(p);
            }
            reader.Close();

            return Tuple.Create(true, persons);
        }
    
        // Получение ID должности по её называнию (нужно для других методов)
        
        public Tuple<bool, uint> get_job_id_by_name(string job_name)
        {
            uint job_id = 0;
            string table_name = "[Job Titiles]";

            if (!open_connection())
            {
                return Tuple.Create(false, job_id);
            }

            string query = "SELECT * FROM " + table_name + " WHERE [JobName] = \'" + job_name + "\'";
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, job_id);
            }

            while (reader.Read())
            {
                job_id = Convert.ToUInt32(reader[0].ToString());
            }
            reader.Close();
            MyConnection.Close();
            return Tuple.Create(true, job_id);
        }
    
        public Tuple<bool, string> get_job_name_by_id(uint id) {
            string name = "";
            string table_name = "[Job Titiles]";

            if (!open_connection()) {
                return Tuple.Create(false, "");
            }

            string query = "SELECT * FROM " + table_name + " WHERE [ID Job] = " + Convert.ToString(id);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try {
                reader = cmd.ExecuteReader();
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, "");
            }

            reader.Read();
            name = reader[1].ToString();
            reader.Close();
            MyConnection.Close();
            return Tuple.Create(true, name);
        }

        public Tuple<bool, Person> get_person_by_card_id(string card_id)
        {
            card_id = preprocess_card_id(card_id);
            Person person = new Person();
            string table_name = "[Card Holders]";

            if (!open_connection())
            {
                Console.WriteLine("connection failed!");
                return Tuple.Create(false, person);
            }

            string query = "SELECT * FROM " + table_name + " WHERE [Card ID] = " + card_id;
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, person);
            }

            while (reader.Read())
            {
                //reader[0].ToString();
                person.set_holder_id(Convert.ToUInt32(reader[0].ToString()));
                person.set_surname(reader[1].ToString());
                person.set_name(reader[2].ToString());
                person.set_lastname(reader[3].ToString());
                person.set_path_to_photo(reader[4].ToString());
                person.set_card_id(reader[5].ToString());
                person.set_status(reader[6].ToString().Equals("Active") || reader[6].ToString().Equals("True")); // т.е. теперь статус - лог. перем.
                person.set_job_id(Convert.ToUInt32(reader[7].ToString()));
                person.set_department_id(Convert.ToUInt32(reader[8].ToString()));
            }
            reader.Close();
            MyConnection.Close();
            if(person.get_lastname() == "" || person.get_name() == "") {
                return Tuple.Create(false, person);
            }

            return Tuple.Create(true, person);
        }

        public Tuple<bool, uint> get_holder_id_by_card_id(string card_id) 
        {
            string table_name = "[Card Holders]";
            //string card_id = "";
            uint holder_id = 0;

            if (!open_connection()) {
                return Tuple.Create(false, holder_id);
            }

            string query = "SELECT * FROM " + table_name + " WHERE [Card ID] = " + card_id;
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try {
                reader = cmd.ExecuteReader();
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, holder_id);
            }

            
            while(reader.Read()) {
                holder_id = Convert.ToUInt32(reader[0].ToString());
            }
            reader.Close();
            MyConnection.Close();

            return Tuple.Create(true, holder_id);
        }
        
        public Tuple<bool, uint> get_department_id_by_name(string dep_name)
        {
            string table_name = "Departments";
            uint id = 0;
            if (!open_connection())
            {
                return Tuple.Create(false, id);
            }

            string query = "SELECT * FROM " + table_name + " WHERE [DepName] = \'" + dep_name + "\'";
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, id);
            }

            while(reader.Read())
            {
                id = Convert.ToUInt32(reader[0].ToString());
            }
            reader.Close();
            MyConnection.Close();

            return Tuple.Create(true, id);
        }

        public Tuple<bool, string> get_department_name_by_id(uint id) {
            string table_name = "Departments";
            string name = "";
            if (!open_connection()) {
                return Tuple.Create(false, "");
            }

            string query = "SELECT * FROM " + table_name + " WHERE [ID Department] = " + Convert.ToString(id);
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try {
                reader = cmd.ExecuteReader();
            } catch (InvalidOperationException e) {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return Tuple.Create(false, "");
            }

            while (reader.Read()) {
                name = reader[1].ToString();
            }
            reader.Close();
            MyConnection.Close();

            return Tuple.Create(true, name);
        }

        public uint get_holder_id()
        {
            List<uint> ids = new List<uint>();
            string table_name = "[Card Holders]";

            if (!open_connection())
            {
                return 0;
            }

            string query = "SELECT * FROM " + table_name;
            OleDbCommand cmd = new OleDbCommand(query, MyConnection);
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, Console.Error);
                MyConnection.Close();
                return 0;
            }

           
            while (reader.Read())
            {
                uint id = Convert.ToUInt32(reader[0].ToString());
                //Console.WriteLine(id);
                ids.Add(id);
            }
            reader.Close();
            MyConnection.Close();

            return ids.Max() + 1;
        }

        private string preprocess_card_id(string card_id) {
            if(card_id.Length >= 7) {
                return card_id.Substring(0, 6);
            }
            return card_id;
        }

    }
}
