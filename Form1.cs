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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Group11Project
{
    public partial class Login_form : Form
    {
        public static string SetValueForText1 = "";
        public Login_form()
        {
            InitializeComponent();
        }
        private void bttnShow_Click(object sender, EventArgs e)
        {
        }

        private void bttnHide_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(true)
            {
                this.Hide();
                Application_form _Form = new Application_form();
                _Form.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CMbox.SelectedItem.ToString() == "Staff")
            {
                SetValueForText1 = txtUsername.Text;
                SqlConnection sqlConnection = new SqlConnection("Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT * FROM [INST_CONFIRM] WHERE ([USERNAME] = @USERNAME)and ([PASSWORD]) = @PASSWORD", sqlConnection);
                check_User_Name.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                check_User_Name.Parameters.AddWithValue("@PASSWORD", txtPass.Text);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                if (UserExist > 0)
                {
                    this.Hide();
                    Instructor instructor = new Instructor();
                    instructor.Show();
                }
                else
                {
                    MessageBox.Show("Please try again!");
                }
                sqlConnection.Close();
            }
            if (CMbox.SelectedItem.ToString() == "Student")
            {
                SetValueForText1 = txtUsername.Text;
                SqlConnection sqlConnection = new SqlConnection("Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT * FROM [STUD_LOGIN] WHERE ([USERNAME] = @USERNAME)and ([PASSWORD]) = @PASSWORD", sqlConnection);
                check_User_Name.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                check_User_Name.Parameters.AddWithValue("@PASSWORD", txtPass.Text);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                if (UserExist > 0)
                {
                    this.Hide();
                    Student student = new Student();
                    student.Show();
                }
                else
                {
                    MessageBox.Show("Please try again!");
                }
                sqlConnection.Close();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
