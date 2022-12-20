namespace ACS_Project
{
    partial class Form3_ControlAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_ControlAccess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelJobT = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelAccess = new System.Windows.Forms.Label();
            this.button_gogogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(166, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(166, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Job Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(166, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(166, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSName.Location = new System.Drawing.Point(325, 25);
            this.labelSName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(19, 25);
            this.labelSName.TabIndex = 8;
            this.labelSName.Text = "-";
            this.labelSName.Click += new System.EventHandler(this.labelSName_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(325, 59);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(19, 25);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "-";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLname.Location = new System.Drawing.Point(325, 93);
            this.labelLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(19, 25);
            this.labelLname.TabIndex = 12;
            this.labelLname.Text = "-";
            // 
            // labelJobT
            // 
            this.labelJobT.AutoSize = true;
            this.labelJobT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelJobT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJobT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelJobT.Location = new System.Drawing.Point(325, 127);
            this.labelJobT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJobT.Name = "labelJobT";
            this.labelJobT.Size = new System.Drawing.Size(19, 25);
            this.labelJobT.TabIndex = 13;
            this.labelJobT.Text = "-";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDep.Location = new System.Drawing.Point(325, 161);
            this.labelDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(19, 25);
            this.labelDep.TabIndex = 14;
            this.labelDep.Text = "-";
            // 
            // labelAccess
            // 
            this.labelAccess.AutoSize = true;
            this.labelAccess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAccess.Location = new System.Drawing.Point(234, 212);
            this.labelAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(19, 25);
            this.labelAccess.TabIndex = 15;
            this.labelAccess.Text = "-";
            // 
            // button_gogogo
            // 
            this.button_gogogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_gogogo.Location = new System.Drawing.Point(436, 212);
            this.button_gogogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_gogogo.Name = "button_gogogo";
            this.button_gogogo.Size = new System.Drawing.Size(58, 28);
            this.button_gogogo.TabIndex = 16;
            this.button_gogogo.Text = "Start";
            this.button_gogogo.UseVisualStyleBackColor = true;
            this.button_gogogo.Click += new System.EventHandler(this.button_gogogo_Click);
            // 
            // Form3_ControlAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 258);
            this.Controls.Add(this.button_gogogo);
            this.Controls.Add(this.labelAccess);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.labelJobT);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3_ControlAccess";
            this.Text = "Access Control";
            this.Load += new System.EventHandler(this.Form3_ControlAccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelJobT;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label labelAccess;
        private System.Windows.Forms.Button button_gogogo;
    }
}