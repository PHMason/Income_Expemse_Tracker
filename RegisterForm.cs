using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace IncomeExpress
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierce\Documents\expenseT.mdf;Integrated Security=True;Connect Timeout=30;");

        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ?  true : false; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void reg_show_password_CheckedChanged(object sender, EventArgs e)
        {
            reg_password.PasswordChar = reg_show_password.Checked ? '\0' : '*';
            reg_confirmpass.PasswordChar = reg_show_password.Checked ? '\0' : '*';
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_password.Text == "" || reg_confirmpass.Text == "")
            {
                MessageBox.Show("Please fill in all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        // CHECK IF THE USERNAME YOU WANT TO REGISTER IS ALREADY THERE
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";

                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", reg_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                // MAKING FIRST LETTER CAPITAL
                                string tempUsern = reg_username.Text.Substring(0, 1).ToUpper() + reg_username.Text.Substring(1);
                                MessageBox.Show(tempUsern + "exists already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else if (reg_password.Text != reg_confirmpass.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (reg_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, date_create) VALUES(@usern, @pass,@date)";
                                
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", reg_password.Text.Trim());

                                    DateTime today = DateTime.Today; //TO GET TIDAYS DATE
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();


                                    

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }

                            }

                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection :" +ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
