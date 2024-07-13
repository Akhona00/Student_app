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
    public partial class Mod_lect : Form
    {
        public Mod_lect()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True; User id = sa;password=pass@123";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [COURSE_INFO_LECT] where ([USERNAME] = @USERNAME)", con);
            cmd.Parameters.AddWithValue("@USERNAME", int.Parse(Login_form.SetValueForText1));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stu_lect stu_Lect = new Stu_lect();
            stu_Lect.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lect_Infor lect_Infor = new Lect_Infor();
            lect_Infor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login_Form = new Login_form();
            login_Form.Show();
        }

        private void Mod_lect_Load(object sender, EventArgs e)
        {

        }
    }
}
