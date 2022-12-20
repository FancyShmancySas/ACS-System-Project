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

    public partial class Form4_Update : Form
    {
        private DataBase db;
        private Arduino arduino = null;
        public Form4_Update(ref DataBase db)
        {
            InitializeComponent();
            arduino = Arduino.getInstance(ref db);
            this.db = db;
        }

        private void Form4_Update_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string old_card_id = textCardID.Text.Trim();
            string new_name = textName.Text.Trim();
            string new_surname = textSurN.Text.Trim();
            string new_lastname = textLastN.Text.Trim();
            bool new_status = comboStatus.Text.Trim().Equals("Active");
            uint new_job_id = db.get_job_id_by_name(combo_jobs.Text.Trim()).Item2;
            uint new_dep_id = db.get_department_id_by_name(comboDep.Text.Trim()).Item2;

            Person p = db.get_person_by_card_id(old_card_id).Item2;
            // собираем нового person
            Person p_updated = new Person(p.get_holder_id(), old_card_id, new_job_id, new_dep_id, new_surname, new_name, new_lastname, p.get_path_to_photo(), new_status);

            if (!db.UpdateFieldsPerson(old_card_id, ref p_updated, true)) {
                Console.WriteLine("46, form4");
            }
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textCardID_TextChanged(object sender, EventArgs e) {

        }

        private void button_scan_new_card_Click(object sender, EventArgs e) {
            string card_id = arduino.wait_for_data().Trim();
            if(card_id.Length >= 7) {
                card_id = card_id.Substring(0, 6);
            }
            textCardID.Text = card_id;
            var res = db.get_person_by_card_id(card_id);
            Person p = new Person();
            if(res.Item1) {
                p = res.Item2;
            }

            textName.Text = p.get_name();
            textSurN.Text = p.get_surname();
            textLastN.Text = p.get_lastname();
            comboStatus.Text = (p.get_status() == true) ? "Active" : "Inactive";
            var job = db.get_job_name_by_id(p.get_job_id());
            string job_name = "";
            if(job.Item1) {
                job_name = job.Item2;
            }
            combo_jobs.Text = job_name;

            var dep = db.get_department_name_by_id(p.get_department_id());
            string dep_name = "";
            if(dep.Item1) {
                dep_name = dep.Item2;
            }

            comboDep.Text = dep_name;
        }
    }
}
