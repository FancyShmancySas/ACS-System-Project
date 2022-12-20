namespace ACS_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardHoldersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCSProjectforArduinoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCS_Project_for_ArduinoDataSet = new ACS_Project.ACS_Project_for_ArduinoDataSet();
            this.card_HoldersTableAdapter = new ACS_Project.ACS_Project_for_ArduinoDataSetTableAdapters.Card_HoldersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardHoldersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCSProjectforArduinoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCS_Project_for_ArduinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cardHoldersBindingSource
            // 
            this.cardHoldersBindingSource.DataMember = "Card Holders";
            this.cardHoldersBindingSource.DataSource = this.aCSProjectforArduinoDataSetBindingSource;
            // 
            // aCSProjectforArduinoDataSetBindingSource
            // 
            this.aCSProjectforArduinoDataSetBindingSource.DataSource = this.aCS_Project_for_ArduinoDataSet;
            this.aCSProjectforArduinoDataSetBindingSource.Position = 0;
            // 
            // aCS_Project_for_ArduinoDataSet
            // 
            this.aCS_Project_for_ArduinoDataSet.DataSetName = "ACS_Project_for_ArduinoDataSet";
            this.aCS_Project_for_ArduinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // card_HoldersTableAdapter
            // 
            this.card_HoldersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(438, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(351, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(132, 86);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(613, 53);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add new employee";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(132, 225);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(613, 56);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update emloyee\'s data";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButton.Location = new System.Drawing.Point(132, 153);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(613, 58);
            this.DelButton.TabIndex = 7;
            this.DelButton.Text = "Delete employee";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.ForeColor = System.Drawing.Color.Green;
            this.buttonGo.Location = new System.Drawing.Point(132, 334);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(613, 56);
            this.buttonGo.TabIndex = 8;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(903, 433);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ACS Project Card Holders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardHoldersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCSProjectforArduinoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCS_Project_for_ArduinoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource aCSProjectforArduinoDataSetBindingSource;
        private ACS_Project_for_ArduinoDataSet aCS_Project_for_ArduinoDataSet;
        private System.Windows.Forms.BindingSource cardHoldersBindingSource;
        private ACS_Project_for_ArduinoDataSetTableAdapters.Card_HoldersTableAdapter card_HoldersTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button buttonGo;
    }
}

