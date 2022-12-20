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
    public partial class Form5_Delete : Form
    {
        private DataBase db; // объект класса DataBase, вместо него и конструктора можно использовать
                            // метод getInstance (так можно потому что класс DataBase синглтон)
        public Form5_Delete(ref DataBase db1) // конструктор
        {
            InitializeComponent();
            db = db1;
        }

        private void buttonDelEmloyee_Click(object sender, EventArgs e)
        {

            string card_id = textBoxCardIDforDel.Text;
            var pers_res = db.get_person_by_card_id(card_id);
            Person p = null;
            if (pers_res.Item1)
            {
                p = pers_res.Item2;
            }

            uint holder_id = p.get_holder_id();

            string message = "The employee has been deletted successfully.";
            if (!db.DeletePerson(holder_id))
            {
                message = "The employee has not been deletted.";
            }

            // уведомление об обновлении
            MessageBox.Show(message);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
