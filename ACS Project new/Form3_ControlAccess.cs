using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // модуль для работы с БД

namespace ACS_Project
{
    public partial class Form3_ControlAccess : Form
    {
        private DataBase db = null;
        private Arduino arduino = null;

        public Form3_ControlAccess(ref DataBase db)
        {
            arduino = Arduino.getInstance(ref db);
            InitializeComponent();
            this.db = db;
        }

        private void Form3_ControlAccess_Load(object sender, EventArgs e)
        {

        }

        private void button_gogogo_Click(object sender, EventArgs e) { // конпка Start - выводит инфо о сотруднике и вызывает метод отправки статуса карты на ардуино
            Person p = null;
            string card_id = arduino.wait_for_data();
           
            if (card_id != "") {
                var answer = db.get_person_by_card_id(card_id);
                if(answer.Item1) {
                    p = answer.Item2;
                    //Console.WriteLine("{0} {1} {2}", p.get_surname(), p.get_name(), p.get_lastname());
                    labelSName.Text = p.get_surname();
                    labelName.Text = p.get_name();
                    labelLname.Text = p.get_lastname();
                    var job_res = db.get_job_name_by_id(p.get_job_id());
                    string job_name = "unknown";
                    if(job_res.Item1) {
                        job_name = job_res.Item2;
                    }
                    labelJobT.Text = Convert.ToString(job_name);

                    var dep_res = db.get_department_name_by_id(p.get_department_id());
                    string dep_name = "unknown";
                    if(dep_res.Item1) {
                        dep_name = dep_res.Item2;
                    }
                    labelDep.Text = Convert.ToString(dep_name);

                    string status = p.get_status() ? "ACTIVE" : "BLOCKED"; // тер. оператор 
                    arduino.send_data(status); // отправка на ардуино

                    string label_status = p.get_status() ? "ACTIVE" : "BLOCKED"; // статус в лейбл
                    labelAccess.Text = label_status;

                } else {
                    Console.WriteLine("There no any person with this card id!");
                }
            }

        }

        private void labelSName_Click(object sender, EventArgs e) {

        }
    }
}
