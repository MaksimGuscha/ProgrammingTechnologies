using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsТrenajor;


namespace WindowsFormsТrenajor
{
    public partial class DataWindow : Form
    {
        private List<object> patientInfo;
        public DataWindow(List<object> patient, string workloadType,List<int> selected, List<bool> sensors)
        {
            InitializeComponent();
            
            patientInfo = patient;

            nameLabel.Text = patient[0] + " " + patient[1] + " " + patient[2];
            ageLabel.Text = patient[3].ToString();
            if(patient[4].ToString() == "m")
            {
                sexLabel.Text = "Мужской";
            }
            else
            {
                sexLabel.Text = "Женский";
            }

            dateLabel.Text = DateTime.Now.ToShortDateString();
            workloadLabel.Text = workloadType;

            foreach (var item in selected)
            {
                switch (item)
                {
                    case 0:
                        {
                            if (sensors[0])
                            {

                                bloodLabel.Visible = true;
                                bloodChart.Visible = true;
                                var random = new Random();
                                for (int i = 1; i <= 10; i++)
                                {
                                    bloodChart.Series[0].Points.AddXY(i, random.Next(50, 200));
                                }

                                
                            }
                            break;
                        }
                    case 1:
                        {
                            if (sensors[1])
                            {
                                temperatureLabel.Visible = true;
                                temperatureChart.Visible = true;
                                var random = new Random();
                                for (int i = 1; i <= 10; i++)
                                {
                                    temperatureChart.Series[0].Points.AddXY(i, random.Next(30, 36));
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            if (sensors[2])
                            {
                                humidityLabel.Visible = true;
                                humidityChart.Visible = true;
                                var random = new Random();
                                for (int i = 1; i <= 10; i++)
                                {
                                    humidityChart.Series[0].Points.AddXY(i, random.Next(10, 20));
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            if (sensors[3])
                            {
                                conductivityLabel.Visible = true;
                                conductivityChart.Visible = true;
                                var random = new Random();
                                for (int i = 1; i <= 10; i++)
                                {
                                    conductivityChart.Series[0].Points.AddXY(i, random.Next(10000, 100000));
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            if (sensors[4])
                            {
                                heartRateLabel.Visible = true;
                                heartRateChart.Visible = true;
                                var random = new Random();
                                for (int i = 1; i <= 10; i++)
                                {
                                    heartRateChart.Series[0].Points.AddXY(i, random.Next(90, 160));
                                }
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

        }

        
    }
}
