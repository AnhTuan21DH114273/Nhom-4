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

namespace QLPhongKhamTuNhan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if(Login.Roles == "Staff")
            {
                StaffPage.Enabled = false;
            }
            CountStaff();
            CountPatients();
            CountPills();
            CountMedReg();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tuan\Documents\DBPhongKham.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountStaff()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) From Staff", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StaffCount.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) From Patient", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatientCount.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountPills()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) From Pills", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PillsCount.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountMedReg()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) From MedicalRegister", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RegCount.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientPage_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
            Obj.Show();
            this.Hide();
        }

        private void StaffPage_Click(object sender, EventArgs e)
        {
            Staff Obj = new Staff();
            Obj.Show();
            this.Hide();
        }

        private void PillsPage_Click(object sender, EventArgs e)
        {
            Pills Obj = new Pills();
            Obj.Show();
            this.Hide();
        }

        private void RegisterPage_Click(object sender, EventArgs e)
        {
            MedicalRegister Obj = new MedicalRegister();
            Obj.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
