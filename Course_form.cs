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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Group11Project
{
    public partial class Course_form : Form
    {
        public static string COURSE_NAME_SET = "";
        public Course_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text.ToUpper() == "NOT APPLICABLE" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please Try Again!");
            }
            else
            {
                COURSE_NAME_SET = (this.comboBox2.SelectedItem.ToString());
                this.Close();
                Password password = new Password();
                password.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Faculty of Humanities and Social Sciences")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if(lbl >= 27)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Bachelor of Arts in Psycology");
                    comboBox2.Items.Add("Higher Certicate in Communication Practices");
                    comboBox2.Items.Add("Diploma in Business Communication");
                }
                else if (lbl < 27)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }
            }
            else if(comboBox1.SelectedItem.ToString() == "Faculty of Commerce")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if(lbl >= 23)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Bachelor of Commerce in Management");
                    comboBox2.Items.Add("Diploma in Sport Development and Management ");
                    comboBox2.Items.Add("Higher Certificate in Event Management");
                }
                else if (lbl < 23)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }
            }
            else if(comboBox1.SelectedItem.ToString() == "Faculty of Information and Communications Technology")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if(lbl >= 27)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Diploma in Data Analytics");
                    comboBox2.Items.Add("Higher Certificate in Mobile Applications and Web Development");
                    comboBox2.Items.Add("Bachelor of Computer and Information Sciences in Information Systems");
                }
                else if (lbl < 27)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }
            }
            else if(comboBox1.SelectedItem.ToString() == "Faculty of Education")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if(lbl >=23)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Higher Certificate in Education in Senoir Phase Teaching");
                    comboBox2.Items.Add("Diploma in Higher Education");
                    comboBox2.Items.Add("Bachelor of Education in Intermediate Phase Teaching");
                }
                else if (lbl < 23)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }
            }
            else if(comboBox1.SelectedItem.ToString() == "Faculty of Law")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if(lbl >=27)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Bachelor of Arts in Law");
                    comboBox2.Items.Add("Higher Certificate in Legal Studies");
                    comboBox2.Items.Add("Diploma in Legal Office Support");
                }
                else if (lbl < 27)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }
            }
            else if(comboBox1.SelectedItem.ToString() == "Faculty of Science")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if(lbl >= 31)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Medicine");
                    comboBox2.Items.Add("Nursing");
                    comboBox2.Items.Add("Actuarial Sciences");
                }
                else if (lbl < 31)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }

            }
            else if(comboBox1.SelectedItem.ToString() == "Faculty of Engineering")
            {
                int lbl = 0;
                lbl = Results_form.colsum;
                if (lbl >= 32)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Mechanical Engineering");
                    comboBox2.Items.Add("Civil Engineering");
                    comboBox2.Items.Add("Electrical Engineering");
                }
                else if(lbl < 32)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Not Applicable");
                }
            }

        }

        private void Course_form_Load(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results_form results_Form = new Results_form();
            results_Form.Show();
        }
    }
}
