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
    public partial class Student : Form
    {
        private string stdEmail;
        public Student(string email)
        {
            InitializeComponent();
            stdEmail = email;
        }
        private void LoadCoursesSloved()
        {

            var con = Sql_Configuration.getInstance().getConnection();
            Sql_Configuration.getInstance().OpenConnection();
            try
            {
                string query = "SELECT ExamID,course_name,exam_date,Marks FROM StudentExamDetailsSlove WHERE Username =@Username";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Username", stdEmail);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"No courses Exam Sloved for this UserName.{stdEmail}");
                    }
                    else
                    {
                        StdNameLb.Text ="Welcome "+ stdEmail;
                        examSlovedCB.DataSource = dt;
                        examSlovedCB.DisplayMember = "course_name";
                        examSlovedCB.ValueMember = "course_name";
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
        private void LoadCoursesNotSloved()
        {

            var con = Sql_Configuration.getInstance().getConnection();
            Sql_Configuration.getInstance().OpenConnection();
            try
            {
                string query = "select course_name,exam_date,Marks,StdID,ExamID from ExamNotSlovedCourse where UserName=@Username";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Username", stdEmail);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    if (dt.Rows.Count == 0)
                    {
                        ExamIDNotSlovedLb.Text = "No courses Exam Sloved for this UserName";
                        sloveBtn.Hide();
                    }
                    else
                    {
                        examNotSlovedCB.DataSource = dt;
                        examNotSlovedCB.DisplayMember = "course_name";
                        examNotSlovedCB.ValueMember = "course_name";
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

        private void Student_Load(object sender, EventArgs e)
        {
            LoadCoursesSloved();
            LoadCoursesNotSloved();
            examSlovedCB.SelectedIndexChanged += examSlovedCB_SelectedIndexChanged;
            examNotSlovedCB.SelectedIndexChanged += examNotSlovedCB_SelectedIndexChanged;
        }

        private void examSlovedCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (examSlovedCB.SelectedItem is DataRowView selectedRow)
            {
                string examId= selectedRow["ExamID"].ToString();
                ExamIDSlovedLb.Text = "Id: "+examId;
                string examDate = selectedRow["exam_date"].ToString();
                dateLb.Text = "Date: "+examDate;
                string examMark= selectedRow["Marks"].ToString();
                ScoreLb.Text = "Score: " + examMark;
            }
        }

        private void examNotSlovedCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (examNotSlovedCB.SelectedItem is DataRowView selectedRow)
            {
                string examId = selectedRow["ExamID"].ToString();
                ExamIDNotSlovedLb.Text = "Id: " + examId;
                string examDate = selectedRow["exam_date"].ToString();
                dateNotSlovedLb.Text = "Date: " + examDate;
            }
        }

        private void sloveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Assigend yet");
        }
    }
}
