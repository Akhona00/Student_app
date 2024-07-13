using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Group11Project.Login_form;

namespace Group11Project
{
    public partial class Lect_Infor : Form
    {
        public Lect_Infor()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM [INSTRUCTOR_INFO] where ([USERNAME] = @USERNAME)", con);
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
            SqlCommand cmd = new SqlCommand("SELECT EMAIL, CELL_NO, HOME_ADDRESS, CITY,  ZIP_CODE FROM [CONT_INFO] where ([USERNAME] = @USERNAME)", con);
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
            SqlCommand cmd = new SqlCommand("SELECT FULL_NAME,  EMAIL_NOK, CELL_NOK, HIRE_DATE, SALARY  FROM [NOF] where ([USERNAME] = @USERNAME)", con);
            cmd.Parameters.AddWithValue("@USERNAME", int.Parse(Login_form.SetValueForText1));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login_Form = new Login_form();
            login_Form.Show();
        }

        private void Lect_Infor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet.NOF' table. You can move, or remove it, as needed.
            this.nOFTableAdapter.Fill(this.gROUP11_DB_2DataSet.NOF);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet.CONT_INFO' table. You can move, or remove it, as needed.
            this.cONT_INFOTableAdapter.Fill(this.gROUP11_DB_2DataSet.CONT_INFO);
            // TODO: This line of code loads data into the 'gROUP11_DB_2DataSet.INSTRUCTOR_INFO' table. You can move, or remove it, as needed.
            this.iNSTRUCTOR_INFOTableAdapter1.Fill(this.gROUP11_DB_2DataSet.INSTRUCTOR_INFO);
            // TODO: This line of code loads data into the 'gROUP11_DBDataSet.INSTRUCTOR_INFO' table. You can move, or remove it, as needed.
            this.iNSTRUCTOR_INFOTableAdapter.Fill(this.gROUP11_DBDataSet.INSTRUCTOR_INFO);

        }
    }
}
