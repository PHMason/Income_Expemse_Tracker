using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpress
{
    public partial class Form1 : Form
    {
        private string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierce\Documents\expenseT.mdf;Integrated Security=True;Connect Timeout=30;";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signup_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        


        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_passowrd.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Succesful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mainForm mForm = new mainForm();
                        mForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or passowrd", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }

        }

        private void login_show_password_CheckedChanged(object sender, EventArgs e)
        {
            login_passowrd.PasswordChar = (login_show_password.Checked) ? '\0' : '*';
        }
    }
}
