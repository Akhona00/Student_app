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

namespace Group11Project
{
    public partial class Lect_Infor_Stud : Form
    {
        public Lect_Infor_Stud()
        {
            InitializeComponent();
            BindGrid();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True; User id = sa;password=pass@123";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT LAST_NAME, COURSE_NAME, EMAIL, CELL_NO\r\nFROM INSTRUCTOR_INFO\r\nINNER JOIN CONT_INFO\r\nON CONT_INFO.USERNAME = INSTRUCTOR_INFO.USERNAME\r\nINNER JOIN HCESPT\r\nON HCESPT.USERNAME = INSTRUCTOR_INFO.USERNAME WHERE ([STUDENT_NUMBER] = @STUDENT_NUMBER)", con);
            cmd.Parameters.AddWithValue("@STUDENT_NUMBER", int.Parse(Login_form.SetValueForText1));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stud_Infor stud_Infor = new Stud_Infor();
            stud_Infor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mod_Stud mod_Stud = new Mod_Stud();
            mod_Stud.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login_Form = new Login_form();
            login_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Lect_Infor_Stud_Load(object sender, EventArgs e)
        {

        }
    }
}
