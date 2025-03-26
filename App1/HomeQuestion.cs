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
    public partial class HomeForm : Form
    {
        private string instructorEmail;
        public HomeForm(string email)
        {
            InitializeComponent();
            instructorEmail = email;
        }
        public string getEmail() { return instructorEmail; }
        private void HomeForm_Load(object sender, EventArgs e)
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

                        CourseComboxAdd.DataSource = dt;
                        CourseComboxAdd.DisplayMember = "CourseName";
                        CourseComboxAdd.ValueMember = "CourseId";
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

        private void AddQuestion_Click(object sender, EventArgs e)
        {

            string questionContent = ContentQuestionAddTextBox.Text;
            string QuestionChoice = ChooiceAddTextBox.Text;
            string AnswerQuestion = CorrectQuestionAddTextBox.Text;
            string questionType;
            int courseId = (int)CourseComboxAdd.SelectedValue;
            var con = Sql_Configuration.getInstance().getConnection();
          
            try
            {
                Sql_Configuration.getInstance().OpenConnection();

                string query = "EXEC AddQuestionWithChoices @Question_Type, @Content, @QAnswer, @QDegree, @CourseID, @ExamID, @Choices";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (MCQType.Checked)
                    {
                        questionType = "MCQ";
                    }
                    else if (TrueFalseType.Checked)
                    {
                        questionType = "True/False";
                    }
                    else
                    {
                       
                        MessageBox.Show("Please select a question type.");
                        return;
                    }
                    cmd.Parameters.Add(new SqlParameter("@Question_Type", questionType));
                    cmd.Parameters.Add(new SqlParameter("@Content", questionContent)); 
                    cmd.Parameters.Add(new SqlParameter("@QAnswer", AnswerQuestion));
                    cmd.Parameters.Add(new SqlParameter("@QDegree", 5));
                    cmd.Parameters.Add(new SqlParameter("@CourseID", courseId));
                    cmd.Parameters.Add(new SqlParameter("@ExamID", DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@Choices", QuestionChoice));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question added successfully!");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ContentQuestionAddTextBox.Clear();
            ChooiceAddTextBox.Clear();
            CorrectQuestionAddTextBox.Clear();
            TrueFalseType.Checked = false;
            MCQType.Checked = false;
        }

        private void viewQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewQuestion viewQues = new ViewQuestion(instructorEmail);
            viewQues.Show();
            
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructorEmail = this.getEmail(); 
            MakeExam makeExam = new MakeExam(instructorEmail);
            makeExam.Show();
        }

        private void assignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructorEmail = this.getEmail(); 

            AssignExam assignExam = new AssignExam(instructorEmail);
            assignExam.Show();
        }
    }
   
}
