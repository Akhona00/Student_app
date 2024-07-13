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
    public partial class Application_form : Form
    {
        public static int ID = 0;
        public static string Fname = "";
        public static string Lname = "";
        public static string initial = "";
        public static string gender = "";
        public static string DOB = "";
        public static string M_S = "";
        public static string email = "";
        public static int Cell = 0;
        public static string H_A = "";
        public static string City = "";
        public static int Z_C = 0;
        public static string Fund = "";
        public static string F_Name = "";
        public static string EMAIL = "";
        public static int cells = 0;
        public Application_form()
        {
            InitializeComponent();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            if(true)
            {
                this.Close();
                Login_form login_ = new Login_form();
                login_.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID = int.Parse(textBox1.Text);
            Fname = textBox2.Text;
            Lname = textBox3.Text;
            initial = textBox4.Text;
            gender = GenderCmb.Text;
            DOB = textBox5.Text;
            M_S = comboBox2.Text;
            email = textBox6.Text;
            Cell = int.Parse(textBox7.Text);
            H_A = textBox8.Text;
            City = textBox9.Text;
            Z_C = int.Parse(textBox10.Text);
            Fund = comboBox1.Text;
            F_Name = textBox11.Text;
            EMAIL = textBox12.Text;
            cells = int.Parse(textBox13.Text);

            DateTime date = DateTime.Now;
            int id = int.Parse(textBox1.Text);
            int cell = int.Parse(textBox7.Text);
            int code = int.Parse(textBox10.Text);
            int cell_nok = int.Parse(textBox13.Text);
            Connect_DB connect_DB = new Connect_DB();
            connect_DB.addprofile(id, textBox2.Text, textBox3.Text, textBox4.Text, GenderCmb.Text, textBox5.Text, comboBox2.Text, textBox6.Text,
                cell, textBox8.Text,textBox9.Text, code, comboBox1.Text, textBox11.Text, textBox12.Text, cell_nok, date.ToString());
            if(true)
            {
                this.Close();
                Results_form results_ = new Results_form();
                results_.Show();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Application_form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
