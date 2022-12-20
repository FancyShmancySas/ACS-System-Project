namespace ACS_Project
{
    partial class Form2_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.AddBut2 = new System.Windows.Forms.Button();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_card_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.combo_department = new System.Windows.Forms.ComboBox();
            this.CloseBut = new System.Windows.Forms.Button();
            this.combo_job_title = new System.Windows.Forms.ComboBox();
            this.button_scan_card_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // AddBut2
            // 
            this.AddBut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBut2.Location = new System.Drawing.Point(34, 329);
            this.AddBut2.Name = "AddBut2";
            this.AddBut2.Size = new System.Drawing.Size(156, 43);
            this.AddBut2.TabIndex = 1;
            this.AddBut2.Text = "Add";
            this.AddBut2.UseVisualStyleBackColor = true;
            this.AddBut2.Click += new System.EventHandler(this.AddBut2_Click);
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_name.Location = new System.Drawing.Point(194, 54);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(152, 30);
            this.textbox_name.TabIndex = 2;
            this.textbox_name.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textbox_surname
            // 
            this.textbox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_surname.Location = new System.Drawing.Point(545, 54);
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(161, 30);
            this.textbox_surname.TabIndex = 3;
            this.textbox_surname.TextChanged += new System.EventHandler(this.textSurN_TextChanged);
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_lastname.Location = new System.Drawing.Point(366, 54);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(156, 30);
            this.textbox_lastname.TabIndex = 5;
            this.textbox_lastname.TextChanged += new System.EventHandler(this.textLastN_TextChanged);
            // 
            // textbox_card_id
            // 
            this.textbox_card_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textbox_card_id.Location = new System.Drawing.Point(193, 244);
            this.textbox_card_id.Name = "textbox_card_id";
            this.textbox_card_id.Size = new System.Drawing.Size(513, 26);
            this.textbox_card_id.TabIndex = 6;
            this.textbox_card_id.TextChanged += new System.EventHandler(this.textCardID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(773, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 179);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(540, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(362, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(769, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Photo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Card ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Job Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(24, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Department";
            // 
            // combo_status
            // 
            this.combo_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Items.AddRange(new object[] {
            "Active",
            "Blocked"});
            this.combo_status.Location = new System.Drawing.Point(194, 105);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(158, 28);
            this.combo_status.TabIndex = 20;
            this.combo_status.Text = "Choose";
            this.combo_status.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // combo_department
            // 
            this.combo_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combo_department.FormattingEnabled = true;
            this.combo_department.Items.AddRange(new object[] {
            "Bookkeeping",
            "IT",
            "Information Security",
            "Management"});
            this.combo_department.Location = new System.Drawing.Point(193, 198);
            this.combo_department.Name = "combo_department";
            this.combo_department.Size = new System.Drawing.Size(158, 28);
            this.combo_department.TabIndex = 21;
            this.combo_department.Text = "Choose";
            this.combo_department.SelectedIndexChanged += new System.EventHandler(this.comboDep_SelectedIndexChanged);
            // 
            // CloseBut
            // 
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.Location = new System.Drawing.Point(773, 329);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(156, 43);
            this.CloseBut.TabIndex = 22;
            this.CloseBut.Text = "Exit";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // combo_job_title
            // 
            this.combo_job_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_job_title.FormattingEnabled = true;
            this.combo_job_title.Items.AddRange(new object[] {
            "Job1",
            "Job2",
            "Job3",
            "Job4",
            "Job5"});
            this.combo_job_title.Location = new System.Drawing.Point(194, 151);
            this.combo_job_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_job_title.Name = "combo_job_title";
            this.combo_job_title.Size = new System.Drawing.Size(157, 28);
            this.combo_job_title.TabIndex = 23;
            this.combo_job_title.Text = "Choose";
            this.combo_job_title.SelectedIndexChanged += new System.EventHandler(this.combo_jobs_SelectedIndexChanged);
            // 
            // button_scan_card_add
            // 
            this.button_scan_card_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_scan_card_add.Location = new System.Drawing.Point(376, 329);
            this.button_scan_card_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_scan_card_add.Name = "button_scan_card_add";
            this.button_scan_card_add.Size = new System.Drawing.Size(214, 43);
            this.button_scan_card_add.TabIndex = 24;
            this.button_scan_card_add.Text = "Scan Card";
            this.button_scan_card_add.UseVisualStyleBackColor = true;
            this.button_scan_card_add.Click += new System.EventHandler(this.button_scan_card_add_Click);
            // 
            // Form2_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 468);
            this.Controls.Add(this.button_scan_card_add);
            this.Controls.Add(this.combo_job_title);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.combo_department);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textbox_card_id);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.textbox_surname);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.AddBut2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_Add";
            this.Text = "Add New Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBut2;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_surname;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.TextBox textbox_card_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.ComboBox combo_department;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.ComboBox combo_job_title;
        private System.Windows.Forms.Button button_scan_card_add;
    }
}