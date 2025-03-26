using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class MakeExam : Form
    {
        private string instructorEmail;
        public MakeExam(string instructorEmail)
        {
            InitializeComponent();
            this.instructorEmail = instructorEmail;
        }

        private void MakeExam_Load(object sender, EventArgs e)
        {
          
            LoadCourses();
            this.MaximizeBox = false;

        }
        private void LoadCourses()
        {
          

            var con = Sql_Configuration.getInstance().getConnection();
            Sql_Configuration.getInstance().OpenConnection(); 
            try
            {
                string query = "select CourseId,CourseName  from dbo.GetCourseByInsdutor WHERE Email = @Email";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Email", instructorEmail);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

              
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No courses found for the provided instructor email.");
                    }
                    else
                    {
                       
                        ComboxExamCourse.DataSource = dt;
                        ComboxExamCourse.DisplayMember = "CourseName";
                        ComboxExamCourse.ValueMember = "CourseName";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (InvalidOperationException opEx)
            {
                MessageBox.Show($"Operation Error: {opEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}");
            }
            finally
            {
                Sql_Configuration.getInstance().CloseConnection();  
            }
        }

        private void MakeExamBtn_Click(object sender, EventArgs e)
        {
            string courseName = ComboxExamCourse.SelectedValue.ToString(); 
            int numTF = int.Parse(NumTFQuestionTextBox.Text); 
            int numMCQ = int.Parse(NumMCQQuestionTextBox.Text); 

            var con = Sql_Configuration.getInstance().getConnection();
            try 
            {
                Sql_Configuration.getInstance().OpenConnection();

                using (SqlCommand command = new SqlCommand("Exam_generation", con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CourseName", courseName);
                    command.Parameters.AddWithValue("@NumTF", numTF);
                    command.Parameters.AddWithValue("@NumMCQ", numMCQ);
                    SqlParameter examIdParam = new SqlParameter("@ExamID", SqlDbType.Int);
                    examIdParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(examIdParam);

                    command.ExecuteNonQuery();
                    int generatedExamId = (int)examIdParam.Value;

                  
                    ExamIdLabel.Text = "id of Exam : " + generatedExamId.ToString();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
