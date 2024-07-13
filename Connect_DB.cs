using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Group11Project
{
    internal class Connect_DB
    {

        private static string connect = "Data Source=KEVIN;Initial Catalog=GROUP11_DB_2;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connect);
        public void addprofile(int id, string first_name, string last_name, string initial, string gender, string dob, string m_s, string email,
            int cell_no, string h_a, string city, int z_c, string funding, string nok_name, string nok_email, int nok_cell, string Date)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("ENR_INFO", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_NUMBER", id);
                sqlCommand.Parameters.AddWithValue("@FIRST_NAME", first_name);
                sqlCommand.Parameters.AddWithValue("@LAST_NAME", last_name);
                sqlCommand.Parameters.AddWithValue("@INITIAL", initial);
                sqlCommand.Parameters.AddWithValue("@GENDER", gender);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_BIRTH", dob);
                sqlCommand.Parameters.AddWithValue("@MARITAL_STATUS", m_s);
                sqlCommand.Parameters.AddWithValue("@EMAIL", email);
                sqlCommand.Parameters.AddWithValue("@CELL_NO", cell_no);
                sqlCommand.Parameters.AddWithValue("@HOME_ADDRESS", h_a);
                sqlCommand.Parameters.AddWithValue("@CITY", city);
                sqlCommand.Parameters.AddWithValue("@ZIP_CODE", z_c);
                sqlCommand.Parameters.AddWithValue("@FUNDING", funding);
                sqlCommand.Parameters.AddWithValue("@FULL_NAME", nok_name);
                sqlCommand.Parameters.AddWithValue("@EMAIL_NOK", nok_email);
                sqlCommand.Parameters.AddWithValue("@CELL_NOK", nok_cell);
                sqlCommand.Parameters.AddWithValue("@APPLICATION_DATE", Date);
                con.Open();
                int run = sqlCommand.ExecuteNonQuery();
                con.Close();
                if (run > 0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void reg_stud(string password, int username)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("STUD_LOGIN_CHECK", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@PASSWORD", password);
                sqlCommand.Parameters.AddWithValue("USERNAME", username);
                con.Open();
                int run = sqlCommand.ExecuteNonQuery();
                con.Close();
                if (run > 0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void addprofile2(int usern, string passd, int id, string first_name, string last_name, string initial, string gender, string dob, string m_s, string email,
    int cell_no, string h_a, string city, int z_c, string funding, string nok_name, string nok_email, int nok_cell)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("STUDENT_INFORM", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
                sqlCommand.Parameters.AddWithValue("@PASSWORD", passd);
                sqlCommand.Parameters.AddWithValue("@ID_NUMBER", id);
                sqlCommand.Parameters.AddWithValue("@FIRST_NAME", first_name);
                sqlCommand.Parameters.AddWithValue("@LAST_NAME", last_name);
                sqlCommand.Parameters.AddWithValue("@INITIAL", initial);
                sqlCommand.Parameters.AddWithValue("@GENDER", gender);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_BIRTH", dob);
                sqlCommand.Parameters.AddWithValue("@MARITAL_STATUS", m_s);
                sqlCommand.Parameters.AddWithValue("@EMAIL", email);
                sqlCommand.Parameters.AddWithValue("@CELL_NO", cell_no);
                sqlCommand.Parameters.AddWithValue("@HOME_ADDRESS", h_a);
                sqlCommand.Parameters.AddWithValue("@CITY", city);
                sqlCommand.Parameters.AddWithValue("@ZIP_CODE", z_c);
                sqlCommand.Parameters.AddWithValue("@FUNDING", funding);
                sqlCommand.Parameters.AddWithValue("@FULL_NAME", nok_name);
                sqlCommand.Parameters.AddWithValue("@EMAIL_NOK", nok_email);
                sqlCommand.Parameters.AddWithValue("@CELL_NOK", nok_cell);
                con.Open();
                int run = sqlCommand.ExecuteNonQuery();
                con.Close();
                if (run > 0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void HCESPT_PROC(int usern, int st_no, string course, string mod)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("HCESPT_PROC", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
                sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
                sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
                sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
                con.Open();
                int run = sqlCommand.ExecuteNonQuery();
                con.Close();
                if (run > 0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //public void DHE_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("DHE_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void BEIPT_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("BEIPT_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void BAL_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("BAL_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void HCLS_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("HCLS_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void DLOS_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("DLOS_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void MED_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("MED_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void NUR_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("NUR_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void ACT_SC_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("ACT_SC_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void BAP_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("BAP_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void HCP_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("HCP_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void DBC_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("DBC_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void BCM_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("BCM_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void DSDM_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("DSDM_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void HCEM_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("HCEM_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void DDA_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("DDA_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void HCMAWD_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("HCMAWD_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void BCISIS_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("BCISIS_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void ME_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("ME_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void CE_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("CE_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void EE_PROC(int usern, int st_no, string course, string mod)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("EE_PROC", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@USERNAME", usern);
        //        sqlCommand.Parameters.AddWithValue("@STUDENT_NUMBER", st_no);
        //        sqlCommand.Parameters.AddWithValue("@COURSE_NAME", course);
        //        sqlCommand.Parameters.AddWithValue("@MODULE_NAME", mod);
        //        con.Open();
        //        int run = sqlCommand.ExecuteNonQuery();
        //        con.Close();
        //        if (run > 0)
        //        {
        //            MessageBox.Show("Success");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
