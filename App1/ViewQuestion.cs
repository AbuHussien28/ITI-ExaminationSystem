using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class ViewQuestion : Form
    {
        string userName;
        public ViewQuestion(string UserName)
        {
            InitializeComponent();
            userName = UserName;
        }

        private void ViewQuestion_Load(object sender, EventArgs e)
        {
            LoadInstructorQuestions();

        }
        private void LoadInstructorQuestions()
        {
            string instructorEmail =userName; 
            DataTable questions = GetInstructorQuestions(instructorEmail);

            if (questions.Rows.Count > 0)
            {
                dataGridView1.DataSource = questions;
            }
            else
            {
                MessageBox.Show("No questions found for this instructor.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataTable GetInstructorQuestions(string email)
        {
            var con = Sql_Configuration.getInstance().getConnection();
            DataTable result = new DataTable();

            try
            {
                Sql_Configuration.getInstance().OpenConnection();
                string query = @"
            SELECT q.*, e.*, I.* 
            FROM Question q 
            INNER JOIN Exam e ON q.Exam_ID = e.E_ID 
            INNER JOIN Instructor I ON e.Instructor_ID = I.I_ID
            WHERE I.Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Sql_Configuration.getInstance().CloseConnection();
            }

            return result;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GOHome_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
