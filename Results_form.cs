using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group11Project
{
    public partial class Results_form : Form
    {
        public static int colsum = 0;
        public Results_form()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnDone_Click(object sender, EventArgs e)
        {
            if (true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    colsum += Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
                }

            }
            if (true)
            {
                this.Close();
                Course_form course_ = new Course_form();
                course_.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                colsum += Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
            }
        }
    }
}
