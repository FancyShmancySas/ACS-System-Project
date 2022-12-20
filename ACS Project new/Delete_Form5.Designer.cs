namespace ACS_Project {
    partial class Delete_Form5 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Form5));
            this.textBoxCardIDforDel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DelEmployee = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Button_ScanCardIDforDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCardIDforDel
            // 
            this.textBoxCardIDforDel.Location = new System.Drawing.Point(147, 92);
            this.textBoxCardIDforDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCardIDforDel.Name = "textBoxCardIDforDel";
            this.textBoxCardIDforDel.Size = new System.Drawing.Size(486, 22);
            this.textBoxCardIDforDel.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DelEmployee
            // 
            this.DelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelEmployee.Location = new System.Drawing.Point(147, 158);
            this.DelEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelEmployee.Name = "DelEmployee";
            this.DelEmployee.Size = new System.Drawing.Size(144, 40);
            this.DelEmployee.TabIndex = 3;
            this.DelEmployee.Text = "Delete";
            this.DelEmployee.UseVisualStyleBackColor = true;
            this.DelEmployee.Click += new System.EventHandler(this.DelEmployee_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(489, 226);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(144, 41);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Button_ScanCardIDforDel
            // 
            this.Button_ScanCardIDforDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ScanCardIDforDel.Location = new System.Drawing.Point(488, 158);
            this.Button_ScanCardIDforDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_ScanCardIDforDel.Name = "Button_ScanCardIDforDel";
            this.Button_ScanCardIDforDel.Size = new System.Drawing.Size(144, 40);
            this.Button_ScanCardIDforDel.TabIndex = 5;
            this.Button_ScanCardIDforDel.Text = "Scan";
            this.Button_ScanCardIDforDel.UseVisualStyleBackColor = true;
            this.Button_ScanCardIDforDel.Click += new System.EventHandler(this.Button_ScanCardIDforDel_Click);
            // 
            // Delete_Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 278);
            this.Controls.Add(this.Button_ScanCardIDforDel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DelEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCardIDforDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Delete_Form5";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCardIDforDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DelEmployee;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Button_ScanCardIDforDel;
    }
}