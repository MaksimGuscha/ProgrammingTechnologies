using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsТrenajor
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            const string loginDoctor = "doctor";
            const string loginAdmin = "admin";
            const string passwordDoctor = "doctor";
            const string passwordAdmin = "admin";

            String login = LoginField.Text;
            String password = passwordField.Text;

            MainForm mainForm = new MainForm();

            RegisterForm registerForm = new RegisterForm();


            if(login == loginDoctor && password == passwordDoctor)
            {
                this.Hide();
                mainForm.Show();
            }else
            {
                if (login == loginAdmin && password == passwordAdmin)
                {
                    this.Hide();
                    registerForm.Show();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введения логина либо пароля!");
                }
            }

        }
    }
}
