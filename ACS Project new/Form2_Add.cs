using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb; // модуль для работы с БД


namespace ACS_Project
{
    public partial class Form2_Add : Form
    {
        private DataBase db;
        private Arduino arduino = null;
        public Form2_Add(ref DataBase db)
        {
            InitializeComponent();
            arduino = Arduino.getInstance(ref db);
            this.db = db;
        }


        private void AddBut2_Click(object sender, EventArgs e)
        {
            string name = textbox_name.Text;
            string surname = textbox_surname.Text;
            string lastname = textbox_lastname.Text;


            uint holder_id = db.get_holder_id(); // корректное значение выставляется в методе класса DB
            string card_id = textbox_card_id.Text;

            uint job_id = 1;
            // получаем ID должности по её называнию из выпадающего списка
            var job_res =  db.get_job_id_by_name(combo_job_title.Text);
            if (job_res.Item1)
            {
                job_id = job_res.Item2;
                Console.WriteLine("still ok1");
            }
            uint department_id = 1;

            var res_dep = db.get_department_id_by_name(combo_department.Text);
            if(res_dep.Item1)
            {
                department_id = res_dep.Item2;
                Console.WriteLine("still ok2");
            }
            bool card_status = combo_status.Text.Equals("Active");

            Person p = new Person(holder_id, card_id, job_id, department_id, surname, name, lastname, "", card_status);

            //Console.WriteLine("still ok");
            string message = "The employee has been added successfully.";
            if(!db.AddPerson(ref p))
            {
                message = "The employee has not been added.";
            }

            // уведомление об обновлении
            MessageBox.Show(message);
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSurN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCardID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_scan_card_add_Click(object sender, EventArgs e) {
            // кнопка для скана карты и получения ID
            Person p = null;
            string card_id = arduino.wait_for_data();
            if (card_id != "") {
                textbox_card_id.Text = card_id.Trim();
            }
        }
    }
}
