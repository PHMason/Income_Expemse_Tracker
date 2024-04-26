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
    public partial class CatergoryForm : UserControl
    {
        string stringConnection = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierce\Documents\expenseT.mdf;Integrated Security=True;Connect Timeout=30;");
        public CatergoryForm()
        {
            InitializeComponent();

            displayCategoryList();
        }

        public void displayCategoryList()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listData = cData.CategoryListData();

            dataGridView1.DataSource = listData;
        }

        private void Category_addBtn_Click(object sender, EventArgs e)
        {
            if(Category_Catergory.Text == "" || Category_Type.SelectedIndex == -1 || catergory_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO categories (category, type, status, date_inser) " +
                        "VALUES (@cat, @type, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Category_Catergory.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", Category_Type.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", catergory_status.SelectedItem);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Added Successfuly", "Infomration Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    connect.Close();
                }
            }
            displayCategoryList();
        }
        private int getID = 0;
        private void Category_Catergory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);

                Category_Catergory.Text = row.Cells[1].Value.ToString();
                Category_Type.SelectedItem = row.Cells[2].Value.ToString();
                catergory_status.SelectedItem = row.Cells[3].Value.ToString();

            }
        }

        private void Category_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Category_Catergory.Text == "" || Category_Type.SelectedIndex == -1 || catergory_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure want to Update ID:" + getID + "?" , "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE categories  SET category = @cat, type = @type, status = @status WHERE id = @ id"                       "VALUES (@cat, @type, @status, @date)";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@cat", Category_Catergory.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", Category_Type.SelectedItem);
                            cmd.Parameters.AddWithValue("@status", catergory_status.SelectedItem);

                
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Updated Successfuly", "Infomration Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        connect.Close();
                    }
                }
            }
            displayCategoryList();
        }
    }
}
