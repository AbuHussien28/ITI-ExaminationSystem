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
    public partial class AssignExam : Form
    {
        private string instructorEmail;
        public AssignExam(string instructorEmail)
        {
            InitializeComponent();
            this.instructorEmail = instructorEmail;
        }

        private void AssignExam_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadStduents();
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
                        CourseIDAssignCombox.DataSource = dt;
                        CourseIDAssignCombox.DisplayMember = "CourseName";
                        CourseIDAssignCombox.ValueMember = "CourseId";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AssignExamBtn_Click(object sender, EventArgs e)
        {
            int selectedCourseName = (int)CourseIDAssignCombox.SelectedValue;
            int selectedStdName = (int)StdCombox.SelectedValue;
            int ExamID = int.Parse(ExamIDTextBox.Text);
            var con = Sql_Configuration.getInstance().getConnection();
            try
            {
                Sql_Configuration.getInstance().OpenConnection();
                
                using (SqlCommand command = new SqlCommand("insertAttendExam", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Exam_id", ExamID);
                    command.Parameters.AddWithValue("@STD_ID", selectedStdName);
                    command.Parameters.AddWithValue("@C_ID", selectedCourseName);    
                    command.ExecuteNonQuery();
 
                    MessageBox.Show("Exam assigned successfully." );
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
        private void LoadStduents()
        {

            var con = Sql_Configuration.getInstance().getConnection();
            Sql_Configuration.getInstance().OpenConnection(); 

            try
            {
                string query = "select StdId,CourseId,StdName  from dbo.GetStdCourses WHERE CourseId =@CourseId ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@CourseId", CourseIDAssignCombox.SelectedValue);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                 
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No courses found for the provided instructor email.");
                    }
                    else
                    {
               
                        StdCombox.DataSource = dt;
                        StdCombox.DisplayMember = "StdName";
                        StdCombox.ValueMember = "StdId";
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

    }
}
