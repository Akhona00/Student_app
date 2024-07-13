using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11Project
{
    public partial class Password : Form
    {

        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(true && textBox1.Text == textBox2.Text)
            {
                string[] strings = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                Random ran = new Random();
                string num = "";
                for (int x = 0; x < 5; x++)
                {
                    string password = strings[ran.Next(strings.Length)];
                    num += password;
                }
                textBox3.Text = "20"+num;
            }
            else
            {
                MessageBox.Show("Passwords must be the same!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application_form app = new Application_form();
            int usern = int.Parse(textBox3.Text);
            Connect_DB connect_DB = new Connect_DB();
            connect_DB.addprofile2(usern, textBox2.Text, Application_form.ID, Application_form.Fname, Application_form.Lname,
                Application_form.initial, Application_form.gender, Application_form.DOB, Application_form.M_S, Application_form.email,
                Application_form.Cell, Application_form.H_A, Application_form.City, Application_form.Z_C, Application_form.Fund,
                Application_form.F_Name, Application_form.EMAIL, Application_form.cells);
            connect_DB.reg_stud(textBox2.Text, usern);

            if(Course_form.COURSE_NAME_SET == "Higher Certificate in Education in Senoir Phase Teaching ")
            {
                connect_DB.HCESPT_PROC(1234500, usern, "Higher Certificate in Education in Senoir Phase Teaching ", "Higher education policy and context");
                connect_DB.HCESPT_PROC(1234500, usern, "Higher Certificate in Education in Senoir Phase Teaching ", "Practice, reflection & portfolio development in higher education'");
                connect_DB.HCESPT_PROC(1234500, usern, "Higher Certificate in Education in Senoir Phase Teaching ", "Research in higher education");
            }
            else if(Course_form.COURSE_NAME_SET == "Diploma in Higher Education")
            {
                connect_DB.HCESPT_PROC(1234501, usern, Course_form.COURSE_NAME_SET, "Academic Literacy ");
                connect_DB.HCESPT_PROC(1234501, usern, Course_form.COURSE_NAME_SET, "Child Development");
                connect_DB.HCESPT_PROC(1234501, usern, Course_form.COURSE_NAME_SET, "Life Skills");

            }
            else if (Course_form.COURSE_NAME_SET == "Bachelor of Education in Intermediate Phase Teaching'")
            {
                connect_DB.HCESPT_PROC(1234502, usern, Course_form.COURSE_NAME_SET, "Comunication Languages 1A");
                connect_DB.HCESPT_PROC(1234502, usern, Course_form.COURSE_NAME_SET, "Digital and academical Literacies");
                connect_DB.HCESPT_PROC(1234502, usern, Course_form.COURSE_NAME_SET, "Management,Development and Professionalism in ECD");
            }
            else if (Course_form.COURSE_NAME_SET == "Bachelor of Arts in Law'")
            {
                connect_DB.HCESPT_PROC(1234503, usern, Course_form.COURSE_NAME_SET, "Academic and Creative Writing");
                connect_DB.HCESPT_PROC(1234503, usern, Course_form.COURSE_NAME_SET, "Family Law");
                connect_DB.HCESPT_PROC(1234503, usern, Course_form.COURSE_NAME_SET, "Politics and Government");
            }
            else if (Course_form.COURSE_NAME_SET == "Higher Certificate in Legal Studies")
            {
                connect_DB.HCESPT_PROC(1234504, usern, Course_form.COURSE_NAME_SET, "Business Communication 1A");
                connect_DB.HCESPT_PROC(1234504, usern, Course_form.COURSE_NAME_SET, "Economics 1A");
                connect_DB.HCESPT_PROC(1234504, usern, Course_form.COURSE_NAME_SET, "Family Law");
            }
            else if (Course_form.COURSE_NAME_SET == "Diploma in Legal Office Support")
            {
                connect_DB.HCESPT_PROC(1234505, usern, Course_form.COURSE_NAME_SET, "Language and Communication Skills Acqusition in African Language");
                connect_DB.HCESPT_PROC(1234505, usern, Course_form.COURSE_NAME_SET, "Citizenship, Public Participation and democracy");
                connect_DB.HCESPT_PROC(1234505, usern, Course_form.COURSE_NAME_SET, "Introduction to General Principles of Crimal law");
            }
            else if (Course_form.COURSE_NAME_SET == "Medicine")
            {
                connect_DB.HCESPT_PROC(1234506, usern, Course_form.COURSE_NAME_SET, "Academic Literacy and reasoning");
                connect_DB.HCESPT_PROC(1234506, usern, Course_form.COURSE_NAME_SET, "Basic Medical Science");
                connect_DB.HCESPT_PROC(1234506, usern, Course_form.COURSE_NAME_SET, "Practice of Medicine");
            }
            else if (Course_form.COURSE_NAME_SET == "Nursing")
            {
                connect_DB.HCESPT_PROC(1234507, usern, Course_form.COURSE_NAME_SET, "Primary Health Care 122");
                connect_DB.HCESPT_PROC(1234507, usern, Course_form.COURSE_NAME_SET, "Human Biology 128");
                connect_DB.HCESPT_PROC(1234507, usern, Course_form.COURSE_NAME_SET, "Intro to Philosophy of Care");
            }
            else if (Course_form.COURSE_NAME_SET == "Actuarial Sciences")
            {
                connect_DB.HCESPT_PROC(1234508, usern, Course_form.COURSE_NAME_SET, "Economics 1");
                connect_DB.HCESPT_PROC(1234508, usern, Course_form.COURSE_NAME_SET, "Financial Mathesmatics for Actual science 1");
                connect_DB.HCESPT_PROC(1234508, usern, Course_form.COURSE_NAME_SET, "Mathematical Foundation & Analysis");
            }
            else if (Course_form.COURSE_NAME_SET == "Bachelor of Arts in Psychology")
            {
                connect_DB.HCESPT_PROC(1234509, usern, Course_form.COURSE_NAME_SET, "Human Behaviour");
                connect_DB.HCESPT_PROC(1234509, usern, Course_form.COURSE_NAME_SET, "Human Psychology");
                connect_DB.HCESPT_PROC(1234509, usern, Course_form.COURSE_NAME_SET, "Psychology of Individual Differences");
            }
            else if (Course_form.COURSE_NAME_SET == "Higher Certifate in Communication Practices")
            {
                connect_DB.HCESPT_PROC(1234510, usern, Course_form.COURSE_NAME_SET, "Academic Literacy and Communication Studies");
                connect_DB.HCESPT_PROC(1234510, usern, Course_form.COURSE_NAME_SET, "Numeracy");
                connect_DB.HCESPT_PROC(1234510, usern, Course_form.COURSE_NAME_SET, "Digital Literacy");
            }
            else if (Course_form.COURSE_NAME_SET == "Diploma in Business Communication")
            {
                connect_DB.HCESPT_PROC(1234511, usern, Course_form.COURSE_NAME_SET, "Cultural Anthropology");
                connect_DB.HCESPT_PROC(1234511, usern, Course_form.COURSE_NAME_SET, "Economics");
                connect_DB.HCESPT_PROC(1234511, usern, Course_form.COURSE_NAME_SET, "Political Science");
            }
            else if (Course_form.COURSE_NAME_SET == "Bachelor of Commerce in Management")
            {
                connect_DB.HCESPT_PROC(1234512, usern, Course_form.COURSE_NAME_SET, "Applied Communication Techniques");
                connect_DB.HCESPT_PROC(1234512, usern, Course_form.COURSE_NAME_SET, "Business Management 1A");
                connect_DB.HCESPT_PROC(1234512, usern, Course_form.COURSE_NAME_SET, "Economics 1A");
            }
            else if (Course_form.COURSE_NAME_SET == "Diploma in Sport Development and Mangement")
            {
                connect_DB.HCESPT_PROC(1234513, usern, Course_form.COURSE_NAME_SET, "Communication for Academic Purposes");
                connect_DB.HCESPT_PROC(1234513, usern, Course_form.COURSE_NAME_SET, "Computer Literacy");
                connect_DB.HCESPT_PROC(1234513, usern, Course_form.COURSE_NAME_SET, "Information Literacy");
            }
            else if (Course_form.COURSE_NAME_SET == "Higher Certification in Event Management'")
            {
                connect_DB.HCESPT_PROC(1234514, usern, Course_form.COURSE_NAME_SET, "Business Communication");
                connect_DB.HCESPT_PROC(1234514, usern, Course_form.COURSE_NAME_SET, "Event Administation");
                connect_DB.HCESPT_PROC(1234514, usern, Course_form.COURSE_NAME_SET, "Event Managemant 1A");
            }
            else if (Course_form.COURSE_NAME_SET == "Diploma in Data Analytics")
            {
                connect_DB.HCESPT_PROC(1234515, usern, Course_form.COURSE_NAME_SET, "Fundamentals of Data Analytics 1A");
                connect_DB.HCESPT_PROC(1234515, usern, Course_form.COURSE_NAME_SET, "Statical Analytics using R Language 1A");
                connect_DB.HCESPT_PROC(1234515, usern, Course_form.COURSE_NAME_SET, "Python Programming for Data Analytics 1A");
            }
            else if (Course_form.COURSE_NAME_SET == "Higher Certificate in Mobile Applications and web Development")
            {
                connect_DB.HCESPT_PROC(1234516, usern, Course_form.COURSE_NAME_SET, "Programme Logic and Design");
                connect_DB.HCESPT_PROC(1234516, usern, Course_form.COURSE_NAME_SET, "Mathematical Principals for Computer Science");
                connect_DB.HCESPT_PROC(1234516, usern, Course_form.COURSE_NAME_SET, "Network Engineering 1A");
            }
            else if (Course_form.COURSE_NAME_SET == "Bachelor of Computer and Information Sciences in Information Systems")
            {
                connect_DB.HCESPT_PROC(1234517, usern, Course_form.COURSE_NAME_SET, "Introduction to Computer Science 1A");
                connect_DB.HCESPT_PROC(1234517, usern, Course_form.COURSE_NAME_SET, "Programming Fundamentals");
                connect_DB.HCESPT_PROC(1234517, usern, Course_form.COURSE_NAME_SET, "Web Development");
            }
            else if (Course_form.COURSE_NAME_SET == "Mechanical Engeneering'")
            {
                connect_DB.HCESPT_PROC(1234518, usern, Course_form.COURSE_NAME_SET, "Physics IA");
                connect_DB.HCESPT_PROC(1234518, usern, Course_form.COURSE_NAME_SET, "Mathematics 1A");
                connect_DB.HCESPT_PROC(1234518, usern, Course_form.COURSE_NAME_SET, "Proffessional Communication Language");
            }
            else if (Course_form.COURSE_NAME_SET == "Civil Engineering")
            {
                connect_DB.HCESPT_PROC(1234519, usern, Course_form.COURSE_NAME_SET, "Mathematics 1A");
                connect_DB.HCESPT_PROC(1234519, usern, Course_form.COURSE_NAME_SET, "Engineering Science 1A");
                connect_DB.HCESPT_PROC(1234519, usern, Course_form.COURSE_NAME_SET, "Plating and St6ructural Steel Drawing");
            }
            else if (Course_form.COURSE_NAME_SET == "Electrical Engineering")
            {
                connect_DB.HCESPT_PROC(1234520, usern, Course_form.COURSE_NAME_SET, "Communication Skills");
                connect_DB.HCESPT_PROC(1234520, usern, Course_form.COURSE_NAME_SET, "Computer Literacy");
                connect_DB.HCESPT_PROC(1234520, usern, Course_form.COURSE_NAME_SET, "Electrical Engineering 1A");
            }

            this.Close();
            Login_form login_Form = new Login_form();
            login_Form.Show();
        }
    }
}
