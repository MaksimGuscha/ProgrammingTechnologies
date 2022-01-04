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
    public partial class RegisterForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private DataTable table = new DataTable();

        private string sql = "SELECT patient.id AS ID, patient.first_name AS first_name," +
                " patient.last_name AS last_name, patient.patronymic AS patronymic," +
                " patient.age AS age, patient.gender AS gender FROM training_center.patient";

        private MySqlConnection connection;
        public RegisterForm()
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        private void patientDeleteButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(patientDataGridView.CurrentCell.Value);



            connection.Open();
            string sqlDeelete = $"DELETE FROM training_center.patient WHERE patient.id = {a}";

            MySqlCommand deleteCommand = new MySqlCommand(sqlDeelete, connection);

            deleteCommand.ExecuteNonQuery();

            connection.Close();

            TableUpdate(sql);
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            string name = NameField.Text;
            string surname = SurnameField.Text;
            string otchestvo = OtchestvoField.Text;
            string age = AgeField.Text;
            string gender = SexField.Text;

            string registerSql = "SELECT patient.first_name FROM training_center.patient WHERE patient.first_name = '" + name + "'";

            try
            {
                connection = new MySqlConnection(connectionString);
                MySqlCommand registercommand = new MySqlCommand(registerSql, connection);
                connection.Open();

                object registerCheck = registercommand.ExecuteScalar();

                if (registerCheck == null)
                {
                    string registerInsert = "INSERT INTO training_center.patient(first_name, last_name, patronymic, age, gender) " +
                        "VALUES ('" + name + "', '" + surname + "', '" + otchestvo + "', '" + age + "', '" + gender + "')";
                    MySqlCommand insertCommand = new MySqlCommand(registerInsert, connection);
                    insertCommand.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            TableUpdate(sql);


            NameField.Text = "";
            SurnameField.Text = "";
            OtchestvoField.Text = "";
            AgeField.Text = "";
            SexField.Text = "";
        }
    }
}
