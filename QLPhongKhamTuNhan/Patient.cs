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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            Display();
            PatientPage.Enabled = false;
            if (Login.Roles == "Staff")
            {
                StaffPage.Enabled = false;
            }
        }
        private void Display()
        {
            Con.Open();
            string Query = "Select * from Patient";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ListPatient.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tuan\Documents\DBPhongKham.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PatientName.Text == "" || PatientPhone.Text == "" || PatientEmail.Text == "" || PatientAddress.Text == "" || PatientGen.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Patient(PatientName,PatientDate,PatientNumPhone,PatientAddress,PatientEmail,PatientGender) " +
                        "values(@BN_Name,@BN_DOB,@BN_Phone,@BN_Address,@BN_Email,@BN_Gender)", Con);
                    cmd.Parameters.AddWithValue("@BN_Name", PatientName.Text);
                    cmd.Parameters.AddWithValue("@BN_DOB", PatientDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@BN_Phone", PatientPhone.Text);
                    cmd.Parameters.AddWithValue("@BN_Address", PatientAddress.Text);
                    cmd.Parameters.AddWithValue("@BN_Email", PatientEmail.Text);
                    cmd.Parameters.AddWithValue("@BN_Gender", PatientGen.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                    Con.Close();
                    Display();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void ListPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientName.Text = ListPatient.SelectedRows[0].Cells[1].Value.ToString();
            PatientPhone.Text = ListPatient.SelectedRows[0].Cells[2].Value.ToString();
            PatientDOB.Text= ListPatient.SelectedRows[0].Cells[3].Value.ToString();
            PatientAddress.Text = ListPatient.SelectedRows[0].Cells[4].Value.ToString();
            PatientEmail.Text = ListPatient.SelectedRows[0].Cells[5].Value.ToString();
            PatientGen.SelectedItem = ListPatient.SelectedRows[0].Cells[6].Value.ToString();
            if (PatientName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ListPatient.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PatientName.Text == "" || PatientPhone.Text == "" || PatientEmail.Text == "" || PatientAddress.Text == "" || PatientGen.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Patient set PatientName=@BN_Name,PatientDate=@BN_DOB,PatientNumPhone=@BN_Phone,PatientEmail=@BN_Email,PatientAddress=@BN_Address,PatientGender=@BN_Gender where MaBN=@PatientID", Con);
                    cmd.Parameters.AddWithValue("@BN_Name", PatientName.Text);
                    cmd.Parameters.AddWithValue("@BN_DOB", PatientDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@BN_Phone", PatientPhone.Text);
                    cmd.Parameters.AddWithValue("@BN_Address", PatientAddress.Text);
                    cmd.Parameters.AddWithValue("@BN_Email", PatientEmail.Text);
                    cmd.Parameters.AddWithValue("@BN_Gender", PatientGen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PatientID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated");
                    Con.Close();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Patient");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Patient where MaBN=@PatientID", Con);
                    cmd.Parameters.AddWithValue("@PatientID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
                    Con.Close();
                    Display();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Clear()
        {
            PatientName.Text = "";
            PatientPhone.Text = "";
            PatientAddress.Text = "";
            PatientEmail.Text = "";
            PatientGen.SelectedIndex = 0;
            Key = 0;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void StaffPage_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            obj.Show();
            this.Hide();
        }

        private void PillsPage_Click(object sender, EventArgs e)
        {
            Pills obj = new Pills();
            obj.Show();
            this.Hide();
        }

        private void RegPage_Click(object sender, EventArgs e)
        {
            MedicalRegister obj = new MedicalRegister();
            obj.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
