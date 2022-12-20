namespace ACS_Project
{
    partial class Form5_Delete
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
            this.textBoxCardIDforDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelEmloyee = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCardIDforDel
            // 
            this.textBoxCardIDforDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCardIDforDel.Location = new System.Drawing.Point(178, 86);
            this.textBoxCardIDforDel.Name = "textBoxCardIDforDel";
            this.textBoxCardIDforDel.Size = new System.Drawing.Size(661, 30);
            this.textBoxCardIDforDel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(458, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan the card ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card ID:";
            // 
            // buttonDelEmloyee
            // 
            this.buttonDelEmloyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelEmloyee.Location = new System.Drawing.Point(178, 144);
            this.buttonDelEmloyee.Name = "buttonDelEmloyee";
            this.buttonDelEmloyee.Size = new System.Drawing.Size(289, 42);
            this.buttonDelEmloyee.TabIndex = 3;
            this.buttonDelEmloyee.Text = "Delete the employee";
            this.buttonDelEmloyee.UseVisualStyleBackColor = true;
            this.buttonDelEmloyee.Click += new System.EventHandler(this.buttonDelEmloyee_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(546, 144);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(293, 42);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form5_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 311);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelEmloyee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCardIDforDel);
            this.Name = "Form5_Delete";
            this.Text = "Form5_Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCardIDforDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelEmloyee;
        private System.Windows.Forms.Button buttonCancel;
    }
}