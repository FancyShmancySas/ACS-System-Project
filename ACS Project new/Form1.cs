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
    
    public partial class Form1 : Form
    {
        private DataBase db;

        public Form1(ref DataBase db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aCS_Project_for_ArduinoDataSet.Card_Holders". При необходимости она может быть перемещена или удалена.
            this.card_HoldersTableAdapter.Fill(this.aCS_Project_for_ArduinoDataSet.Card_Holders);

        }

        /*
        private void button1_Click(object sender, EventArgs e) // DeleteButtton
        {
            
            uint IDHolder = Convert.ToUInt32(DismText.Text);

            if(!db.DeletePerson(IDHolder))
            {
                Console.WriteLine("Card holder " + IDHolder + " was not deleted!", Console.Error);
            }
        }
        */

        private void Update_Click(object sender, EventArgs e)
        {
            //int IDHolder = Convert.ToInt32(UpdateIDText.Text);

            // обновление данных сотрудника, запрос
            //string query = "UPDATE [Card Holders] SET Nomen = '" + UpdateText.Text + "' WHERE [ID Holder] = "+ IDHolder;
            //OleDbCommand cmd = new OleDbCommand(query, MyConnection);

            // исполнение запроса на обновление
            //cmd.ExecuteNonQuery();

            // уведомление об обновлении
            MessageBox.Show("Cardholder is update");

            // обновление данных таблицы
            this.card_HoldersTableAdapter.Fill(this.aCS_Project_for_ArduinoDataSet.Card_Holders);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // разрыв соединения с БД по закрытии формы
            //MyConnection.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpAll_Click(object sender, EventArgs e)
        {
            this.card_HoldersTableAdapter.Fill(this.aCS_Project_for_ArduinoDataSet.Card_Holders);
        }

        private void DismText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form2_Add f2 = new Form2_Add(ref db);
            f2.Owner = this;
            f2.Show();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            Form3_ControlAccess f3 = new Form3_ControlAccess(ref db);
            f3.Owner = this;
            f3.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Form4_Update f4 = new Form4_Update(ref db);
            f4.Owner = this;
            f4.Show();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            Delete_Form5 f5 = new Delete_Form5(ref db);
            f5.Owner = this;
            f5.Show();
            
        }
    }
}
