
using System.Collections.Generic;
namespace WindowsFormsТrenajor
{
    partial class CheckWindow
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
            this.setSensorButton = new System.Windows.Forms.Button();
            this.sensorsListBox = new System.Windows.Forms.CheckedListBox();
            this.clientsListButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataPrintButton = new System.Windows.Forms.Button();
            this.sensorTestLabel = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.workloadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setSensorButton
            // 
            this.setSensorButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.setSensorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setSensorButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.setSensorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.setSensorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setSensorButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setSensorButton.Location = new System.Drawing.Point(13, 13);
            this.setSensorButton.Name = "setSensorButton";
            this.setSensorButton.Size = new System.Drawing.Size(187, 30);
            this.setSensorButton.TabIndex = 0;
            this.setSensorButton.Text = "Установка датчиков";
            this.setSensorButton.UseVisualStyleBackColor = false;
            this.setSensorButton.Click += new System.EventHandler(this.setSensorButton_Click);
            // 
            // sensorsListBox
            // 
            this.sensorsListBox.FormattingEnabled = true;
            this.sensorsListBox.Items.AddRange(new object[] {
            "Измерение кровяного давления",
            "Измерение температуры кожи",
            "Измерение влажности кожи",
            "Измерение электрической проводимости кожи",
            "Измерение частоты пульса сердечного ритма"});
            this.sensorsListBox.Location = new System.Drawing.Point(12, 49);
            this.sensorsListBox.Name = "sensorsListBox";
            this.sensorsListBox.Size = new System.Drawing.Size(266, 94);
            this.sensorsListBox.TabIndex = 1;
            this.sensorsListBox.Visible = false;
            this.sensorsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.sensorsListBox_ItemChecked);
           
            // 
            // clientsListButton
            // 
            this.clientsListButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clientsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsListButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.clientsListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clientsListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clientsListButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsListButton.Location = new System.Drawing.Point(13, 293);
            this.clientsListButton.Name = "clientsListButton";
            this.clientsListButton.Size = new System.Drawing.Size(187, 30);
            this.clientsListButton.TabIndex = 5;
            this.clientsListButton.Text = "Старт";
            this.clientsListButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(13, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Тест";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // dataPrintButton
            // 
            this.dataPrintButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dataPrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataPrintButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.dataPrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataPrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPrintButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataPrintButton.Location = new System.Drawing.Point(601, 293);
            this.dataPrintButton.Name = "dataPrintButton";
            this.dataPrintButton.Size = new System.Drawing.Size(187, 30);
            this.dataPrintButton.TabIndex = 8;
            this.dataPrintButton.Text = "Вывод данных";
            this.dataPrintButton.UseVisualStyleBackColor = false;
            this.dataPrintButton.Click += new System.EventHandler(this.dataPrintButton_Click);
            // 
            // sensorTestLabel
            // 
            this.sensorTestLabel.AutoSize = true;
            this.sensorTestLabel.Location = new System.Drawing.Point(13, 192);
            this.sensorTestLabel.Name = "sensorTestLabel";
            this.sensorTestLabel.Size = new System.Drawing.Size(0, 13);
            this.sensorTestLabel.TabIndex = 9;
            this.sensorTestLabel.Visible = false;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(328, 20);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(120, 20);
            this.patientIDTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID пациент:";
            // 
            // workloadTextBox
            // 
            this.workloadTextBox.Location = new System.Drawing.Point(328, 88);
            this.workloadTextBox.Name = "workloadTextBox";
            this.workloadTextBox.Size = new System.Drawing.Size(220, 20);
            this.workloadTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тип нагрузки:";
            // 
            // CheckWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workloadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.sensorTestLabel);
            this.Controls.Add(this.dataPrintButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clientsListButton);
            this.Controls.Add(this.sensorsListBox);
            this.Controls.Add(this.setSensorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckWindow";
            this.Text = "CheckWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setSensorButton;
        private System.Windows.Forms.CheckedListBox sensorsListBox;
        private System.Windows.Forms.Button clientsListButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dataPrintButton;
        private List<bool> isWork;
        private System.Windows.Forms.Label sensorTestLabel;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workloadTextBox;
        private System.Windows.Forms.Label label2;
    }
}