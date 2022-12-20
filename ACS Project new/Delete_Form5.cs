using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_Project {
    public partial class Delete_Form5 : Form {
        private DataBase db; // объект класса DataBase, вместо него и конструктора можно использовать
                             // метод getInstance (так можно потому что класс DataBase синглтон)
        private Arduino arduino = null;
        public Delete_Form5(ref DataBase db1) // конструктор
        {
            InitializeComponent();
            arduino = Arduino.getInstance(ref db1);
            db = db1;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void DelEmployee_Click(object sender, EventArgs e) {
            string card_id = textBoxCardIDforDel.Text.Trim();
            if(card_id.Length >= 7) {
                card_id = card_id.Substring(0, 6);
            }
            
            // проверка на существование сотрудника с заданным id карты
            var pers_res = db.get_person_by_card_id(card_id);
            Person p = null;
            if (pers_res.Item1) {
                p = pers_res.Item2;
            } else {
                // error message
                string message_0 = "There are no any employees with Card Id " + card_id;
                MessageBox.Show(message_0);
                return;
            }
            // находим id сотрудника, которого хотим удалить
            uint holder_id = 0; 
            var holder_res = db.get_holder_id_by_card_id(card_id);
            if(holder_res.Item1) {
                holder_id = holder_res.Item2;
            } else {
                string message_1 = "Something went wrong!";
                MessageBox.Show(message_1);
                return;
            }



            string message = "The employee has been deletted successfully.";
            if (!db.DeletePerson(holder_id, card_id)) {
                message = "The employee has not been deleted.";
            }

            // уведомление об удалении
            MessageBox.Show(message);
        }



        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void Button_ScanCardIDforDel_Click(object sender, EventArgs e) {
            Person p = null;
            string card_id = arduino.wait_for_data();
            if (card_id != "") {
                textBoxCardIDforDel.Text = card_id.Trim();
            }
        }
    }
}
