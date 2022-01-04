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
    public partial class MainForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private DataTable table = new DataTable();

        private string sql = "SELECT patient.id AS ID, patient.first_name AS first_name," +
                " patient.last_name AS last_name, patient.patronymic AS patronymic," +
                " patient.age AS age, patient.gender AS gender FROM training_center.patient";

        private MySqlConnection connection;


        public MainForm()
        {
            InitializeComponent();

            connection = new MySqlConnection(connectionString);

            
        }


        private void clientsListButton_Click(object sender, EventArgs e)
        {
            patientDataGridView.Visible = true;


            TableUpdate(sql);
            
        }

        private void TableUpdate(string sql)
        {
            
            connection.Open();

            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);


            DataTable data = new DataTable();
            adapter.Fill(data); 

            patientDataGridView.DataSource = data.DefaultView;

            connection.Close();
        }


        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void newCheckButton_Click(object sender, EventArgs e)
        {
            CheckWindow checkWindow = new CheckWindow();
            checkWindow.Show();
        }
    }
    
}
