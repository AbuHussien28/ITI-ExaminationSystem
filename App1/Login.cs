using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var con = Sql_Configuration.getInstance().getConnection();
            if (con == null)
            {
                MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = UserNameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            try
            {
                Sql_Configuration.getInstance().OpenConnection();
                string query = @"
                    SELECT 'Instructor' as UserType, [User Name] as Username 
                    FROM DisplayInstLogin 
                    WHERE [User Name] = @UserName AND Pass = @Password
                    UNION ALL
                    SELECT 'Student' as UserType, UserName as Username
                    FROM Student_login_Info
                    WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string userType = dt.Rows[0]["UserType"].ToString();
                            string username = dt.Rows[0]["Username"].ToString();

                            if (userType == "Instructor")
                            {
                                HomeForm home = new HomeForm(username);
                                home.Show();
                            }
                            else
                            {
                                Student std = new Student(username);
                                std.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        }
    }
}
