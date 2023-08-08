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

namespace QLPhongKhamTuNhan
{
    public partial class MedicalRegister : Form
    {
        public MedicalRegister()
        {
            InitializeComponent();
            Display();
            getStaffID();
            getPatientID();
            RegPage.Enabled = false;
            if (Login.Roles == "Staff")
            {
                StaffPage.Enabled = false;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tuan\Documents\DBPhongKham.mdf;Integrated Security=True;Connect Timeout=30");
        private void getStaffID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select MaNV from Staff", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV", typeof(int));
            dt.Load(rdr);
            Staff_ID.ValueMember = "MaNV";
            Staff_ID.DataSource = dt;
            Con.Close();
        }
        private void getStaffName()
        {
            Con.Open();
            string Query = "Select * from Staff Where MaNV=" + Staff_ID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StaffName.Text = dr["TenNV"].ToString();
            }
            Con.Close();
        }
        private void getPatientID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select MaBN from Patient", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaBN", typeof(int));
            dt.Load(rdr);
            Patient_ID.ValueMember = "MaBN";
            Patient_ID.DataSource = dt;
            Con.Close();
        }
        private void getPatientName()
        {
            Con.Open();
            string Query = "Select * from Patient Where MaBN=" + Patient_ID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientName.Text = dr["PatientName"].ToString();
            }
            Con.Close();
        }
        private void Display()
        {
            Con.Open();
            string Query = "Select * from MedicalRegister";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ListReg.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            StaffName.Text = "";
            PatientName.Text = "";
            Staff_ID.SelectedIndex = 0;
            Cost.Text = "";
            Patient_ID.SelectedIndex = 0;
            Medicines.Text = "";
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PatientName.Text == "" || StaffName.Text == "" || Medicines.Text == "" || Cost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MedicalRegister(MaNV,TenNV,MaBN,TenBN,Thuoc,GiaDangKy)values(@MaNV,@Ten_NV,@Ma_BN,@Ten_BN,@Thuoc,@Cost)", Con);
                    cmd.Parameters.AddWithValue("@MaNV", Staff_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ten_NV", StaffName.Text);
                    cmd.Parameters.AddWithValue("@Ma_BN", Patient_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ten_BN", PatientName.Text);
                    cmd.Parameters.AddWithValue("@Thuoc", Medicines.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medical Register Successful");
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
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PatientName.Text == "" || StaffName.Text == "" || Medicines.Text == "" || Cost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update MedicalRegister set MaNV=@MaNV,TenNV=@Ten_NV,MaBN=@Ma_BN,TenBN=@Ten_BN,Thuoc=@Thuoc,GiaDangKy=@Cost Where MedicalID=@MaDangKy", Con);
                    cmd.Parameters.AddWithValue("@MaNV", Staff_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ten_NV", StaffName.Text);
                    cmd.Parameters.AddWithValue("@Ma_BN", Patient_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ten_BN", PatientName.Text);
                    cmd.Parameters.AddWithValue("@Thuoc", Medicines.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.Parameters.AddWithValue("@MaDangKy", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medical Register Edited");
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
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Medical Register");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from MedicalRegister where MedicalID=@MaDangKy", Con);
                    cmd.Parameters.AddWithValue("@MaDangKy", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medical Register Deleted");
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

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Staff_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStaffName();
        }

        private void Patient_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getPatientName();
        }
        int Key = 0;
        private void ListReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff_ID.Text = ListReg.SelectedRows[0].Cells[1].Value.ToString();
            StaffName.Text = ListReg.SelectedRows[0].Cells[2].Value.ToString();
            Patient_ID.Text = ListReg.SelectedRows[0].Cells[3].Value.ToString();
            PatientName.Text = ListReg.SelectedRows[0].Cells[4].Value.ToString();
            Medicines.Text = ListReg.SelectedRows[0].Cells[5].Value.ToString();
            Cost.Text = ListReg.SelectedRows[0].Cells[6].Value.ToString();
            if (StaffName.Text == "" && PatientName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ListReg.SelectedRows[0].Cells[0].Value.ToString());
            }
            RegisterTxt.Text = "";
            RegisterTxt.Text = "                                       Medical Register \n\n" + "\n************************************************"
                +"\n"+ DateTime.Today.Date + 
                "\n\n\n\n    StaffName:" + ListReg.SelectedRows[0].Cells[2].Value.ToString() +
                "\n\n\n\n    PatientName:" + ListReg.SelectedRows[0].Cells[4].Value.ToString()+ 
                "\n\n\n\n    Medicines:" + ListReg.SelectedRows[0].Cells[5].Value.ToString() +
                "\n\n\n\n    Cost:" + ListReg.SelectedRows[0].Cells[6].Value.ToString() + 
                "\n\n\n\n\n\n\n\n\n Please Sign Here "+ "\n "+ ListReg.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RegisterTxt.Text + "\n", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));
        }

        private void PrtButton_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void PatientPage_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
