using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11Project
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
            BindGrid();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True; User id = sa;password=pass@123";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand cmd = new SqlCommand("SELECT FIRST_NAME FROM [INSTRUCTOR_INFO] where ([USERNAME] = @USERNAME)", con);
            cmd.Parameters.AddWithValue("@USERNAME", int.Parse(Login_form.SetValueForText1));
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                label2.Text = myReader["FIRST_NAME"].ToString();

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(true)
            {
                this.Close();
                Login_form login_Form = new Login_form();
                login_Form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lect_Infor lect_Infor = new Lect_Infor();
            lect_Infor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stu_lect stu_Lect = new Stu_lect();
            stu_Lect.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mod_lect mod_Lect = new Mod_lect();
            mod_Lect.Show();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {

        }
    }
}
