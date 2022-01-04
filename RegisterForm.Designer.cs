namespace WindowsFormsТrenajor
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OtchestvoField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientDeleteButton = new System.Windows.Forms.Button();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.clientsListButton = new System.Windows.Forms.Button();
            this.registrButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SexField = new System.Windows.Forms.TextBox();
            this.AgeField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.OtchestvoField);
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.patientDeleteButton);
            this.panel1.Controls.Add(this.patientDataGridView);
            this.panel1.Controls.Add(this.clientsListButton);
            this.panel1.Controls.Add(this.registrButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SexField);
            this.panel1.Controls.Add(this.AgeField);
            this.panel1.Controls.Add(this.SurnameField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 457);
            this.panel1.TabIndex = 0;
           
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // OtchestvoField
            // 
            this.OtchestvoField.Location = new System.Drawing.Point(123, 180);
            this.OtchestvoField.Name = "OtchestvoField";
            this.OtchestvoField.Size = new System.Drawing.Size(165, 20);
            this.OtchestvoField.TabIndex = 15;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(123, 142);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(165, 20);
            this.NameField.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя:";
            // 
            // patientDeleteButton
            // 
            this.patientDeleteButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.patientDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.patientDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.patientDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.patientDeleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientDeleteButton.Location = new System.Drawing.Point(323, 324);
            this.patientDeleteButton.Name = "patientDeleteButton";
            this.patientDeleteButton.Size = new System.Drawing.Size(187, 30);
            this.patientDeleteButton.TabIndex = 11;
            this.patientDeleteButton.Text = "Удалить пациента";
            this.patientDeleteButton.UseVisualStyleBackColor = false;
            this.patientDeleteButton.Click += new System.EventHandler(this.patientDeleteButton_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(323, 138);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.Size = new System.Drawing.Size(483, 180);
            this.patientDataGridView.TabIndex = 10;
            this.patientDataGridView.Visible = false;
            // 
            // clientsListButton
            // 
            this.clientsListButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clientsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsListButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.clientsListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clientsListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clientsListButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsListButton.Location = new System.Drawing.Point(323, 102);
            this.clientsListButton.Name = "clientsListButton";
            this.clientsListButton.Size = new System.Drawing.Size(187, 30);
            this.clientsListButton.TabIndex = 9;
            this.clientsListButton.Text = "Список пациентов";
            this.clientsListButton.UseVisualStyleBackColor = false;
            this.clientsListButton.Click += new System.EventHandler(this.clientsListButton_Click);
            // 
            // registrButton
            // 
            this.registrButton.BackColor = System.Drawing.Color.Lime;
            this.registrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.registrButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.registrButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.registrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrButton.Location = new System.Drawing.Point(83, 305);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(205, 49);
            this.registrButton.TabIndex = 8;
            this.registrButton.Text = "Зарегестрировать";
            this.registrButton.UseVisualStyleBackColor = false;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия:";
            // 
            // SexField
            // 
            this.SexField.Location = new System.Drawing.Point(123, 253);
            this.SexField.Name = "SexField";
            this.SexField.Size = new System.Drawing.Size(121, 20);
            this.SexField.TabIndex = 3;
            // 
            // AgeField
            // 
            this.AgeField.Location = new System.Drawing.Point(123, 216);
            this.AgeField.Name = "AgeField";
            this.AgeField.Size = new System.Drawing.Size(121, 20);
            this.AgeField.TabIndex = 2;
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(123, 108);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(165, 20);
            this.SurnameField.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 87);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(779, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 26);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SexField;
        private System.Windows.Forms.TextBox AgeField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button clientsListButton;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button patientDeleteButton;
        private System.Windows.Forms.TextBox OtchestvoField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}