using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsТrenajor
{
    public partial class CheckWindow : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<object> patientInfo = new List<object>();

        private List<int> selectedSensors = new List<int>();

        private DataWindow dataWindow;
        public CheckWindow()
        {
            InitializeComponent();
            
        }

        private void setSensorButton_Click(object sender, EventArgs e)
        {
            sensorsListBox.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sensorsListBox_ItemChecked(object sender, ItemCheckEventArgs e)
        {
            if (this.sensorsListBox.GetItemCheckState(e.Index) == CheckState.Unchecked)
            {
                this.selectedSensors.Add(e.Index);
                
            }
            else
            {
                this.selectedSensors.Remove(e.Index);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            isWork = new List<bool>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {   
                int random = rand.Next(1, 11);
                if (random >5)
                {
                    isWork.Add(true);
                }
                else
                {
                    isWork.Add(false);
                }
            }
            sensorTestLabel.Text = "";
            foreach(var index in selectedSensors)
            {
                sensorTestLabel.Text += sensorsListBox.GetItemText(sensorsListBox.Items[index]) + ": " + isWork[index].ToString() + "\n";
            }
            sensorTestLabel.Visible = true;
        }

        private void dataPrintButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();


            if (string.IsNullOrEmpty(patientIDTextBox.Text) || string.IsNullOrEmpty(workloadTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните пропущенное поле(ID пациента или тип физической нагрузки)");
            }
            else
            {
                string sqlSelectPatientById = "SELECT patient.first_name AS first_name," +
                " patient.last_name AS last_name, patient.patronymic AS patronymic," +
                $" patient.age AS age, patient.gender AS gender FROM training_center.patient WHERE patient.id = {patientIDTextBox.Text};";



                MySqlCommand command = new MySqlCommand(sqlSelectPatientById, connection);

                try
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            patientInfo.Add(reader.GetValue(i));
                        }
                    }
                    reader.Close();
                    dataWindow = new DataWindow(patientInfo, workloadTextBox.Text, selectedSensors, isWork);
                    dataWindow.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Нет такого пациента в базе данных");
                }
                finally
                {

                    connection.Close();
                }

            }
        }
    }
}
