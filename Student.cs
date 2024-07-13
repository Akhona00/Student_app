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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(true)
            {
                this.Hide();
                Login_form login_Form   = new Login_form();
                login_Form.Show();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lect_Infor_Stud lect_Infor_Stud = new Lect_Infor_Stud();
            lect_Infor_Stud.Show();
        }
    }
}
