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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            DisplayRec();
            StaffPage.Enabled = false;
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tuan\Documents\DBPhongKham.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from Staff";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ListStaff.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (StaffName.Text == "" || StaffPass.Text == "" || StaffNumPhone.Text == "" || StaffEmail.Text == ""|| StaffRole.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Staff(TenNV,SDT_NV,PassNV,Email_NV,VaiTro_NV)values(@NV_Name,@Phone_NV,@Pass_NV,@Email_NV,@VaiTro_NV)",Con);
                    cmd.Parameters.AddWithValue("@NV_Name", StaffName.Text);
                    cmd.Parameters.AddWithValue("@Pass_NV", StaffPass.Text);
                    cmd.Parameters.AddWithValue("@Phone_NV", StaffNumPhone.Text);
                    cmd.Parameters.AddWithValue("@Email_NV", StaffEmail.Text);
                    cmd.Parameters.AddWithValue("@VaiTro_NV", StaffRole.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Added");
                    Con.Close();
                    DisplayRec();
                    Clear();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        int Key = 0;
        private void ListStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffName.Text = ListStaff.SelectedRows[0].Cells[1].Value.ToString();
            StaffNumPhone.Text = ListStaff.SelectedRows[0].Cells[2].Value.ToString();
            StaffPass.Text = ListStaff.SelectedRows[0].Cells[3].Value.ToString();           
            StaffEmail.Text = ListStaff.SelectedRows[0].Cells[4].Value.ToString();
            StaffRole.SelectedItem = ListStaff.SelectedRows[0].Cells[5].Value.ToString();
            if (StaffName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ListStaff.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (StaffName.Text == "" || StaffPass.Text == "" || StaffNumPhone.Text == "" || StaffEmail.Text == "" || StaffRole.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Staff set TenNV=@NV_Name,SDT_NV=@Phone_NV,PassNV=@Pass_NV,Email_NV=@Email_NV,VaiTro_NV=@VaiTro_NV where MaNV=@StaffID", Con);
                    cmd.Parameters.AddWithValue("@NV_Name", StaffName.Text);
                    cmd.Parameters.AddWithValue("@Pass_NV", StaffPass.Text);
                    cmd.Parameters.AddWithValue("@Phone_NV", StaffNumPhone.Text);
                    cmd.Parameters.AddWithValue("@Email_NV", StaffEmail.Text);
                    cmd.Parameters.AddWithValue("@VaiTro_NV", StaffRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@StaffID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Updated");
                    Con.Close();
                    DisplayRec();
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
                MessageBox.Show("Select a Staff");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Staff where MaNV=@StaffID", Con);
                    cmd.Parameters.AddWithValue("@StaffID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted");
                    Con.Close();
                    DisplayRec();
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
            StaffName.Text = "";
            StaffPass.Text = "";
            StaffNumPhone.Text = "";
            StaffEmail.Text = "";
            Key = 0;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientPage_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
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
