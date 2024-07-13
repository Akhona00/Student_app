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
    public partial class Stud_Infor : Form
    {
        public Stud_Infor()
        {
            InitializeComponent();
            BindGrid();
            BindGrid2();
            BindGrid3();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True; User id = sa;password=pass@123";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [student_info1] where ([USERNAME] = @USERNAME)", con);
            cmd.Parameters.AddWithValue("@USERNAME", int.Parse(Login_form.SetValueForText1));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void BindGrid2()
        {
            string constring = @"Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True; User id = sa;password=pass@123";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [student_info2] where ([USERNAME] = @USERNAME)", con);
            cmd.Parameters.AddWithValue("@USERNAME", int.Parse(Login_form.SetValueForText1));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void BindGrid3()
        {
            string constring = @"Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True; User id = sa;password=pass@123";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [student_info3] where ([USERNAME] = @USERNAME)", con);
            cmd.Parameters.AddWithValue("@USERNAME", int.Parse(Login_form.SetValueForText1));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mod_Stud mod_Stud = new Mod_Stud();
            mod_Stud.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lect_Infor_Stud lect_Infor_Stud = new Lect_Infor_Stud();
            lect_Infor_Stud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login_Form = new Login_form();
            login_Form.Show();
        }

        private void Stud_Infor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet1.NOF' table. You can move, or remove it, as needed.
            this.nOFTableAdapter.Fill(this.gROUP11_DB_2DataSet1.NOF);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet1.CONT_INFO' table. You can move, or remove it, as needed.
            this.cONT_INFOTableAdapter1.Fill(this.gROUP11_DB_2DataSet1.CONT_INFO);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet1.NOK_STUDENT' table. You can move, or remove it, as needed.
            this.nOK_STUDENTTableAdapter.Fill(this.gROUP11_DB_2DataSet1.NOK_STUDENT);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet1.CONT_STUDENT' table. You can move, or remove it, as needed.
            this.cONT_STUDENTTableAdapter.Fill(this.gROUP11_DB_2DataSet1.CONT_STUDENT);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet1.ENROLLMENT' table. You can move, or remove it, as needed.
            this.eNROLLMENTTableAdapter.Fill(this.gROUP11_DB_2DataSet1.ENROLLMENT);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet.CONT_INFO' table. You can move, or remove it, as needed.
            this.cONT_INFOTableAdapter.Fill(this.gROUP11_DB_2DataSet.CONT_INFO);

        }
    }
}
