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
    public partial class Pills : Form
    {
        public Pills()
        {
            InitializeComponent();
            Display();
            getStaffID();
            PillsPage.Enabled = false;
            if (Login.Roles == "Staff")
            {
                StaffPage.Enabled = false;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tuan\Documents\DBPhongKham.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            PillsName.Text = "";
            PillsPlace.Text = "";
            TypePills.Text = "";
            CostPill.Text = "";
            Staff_ID.SelectedIndex = 0;
            Staff_Name.Text = "";
        }
        private void Display()
        {
            Con.Open();
            string Query = "Select * from Pills";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ListPills.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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
            foreach(DataRow dr in dt.Rows)
            {
                Staff_Name.Text = dr["TenNV"].ToString();
            }
            Con.Close();
        }
        
        private void Staff_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStaffName();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PillsName.Text == "" || PillsPlace.Text == "" || TypePills.Text == "" || CostPill.Text == "" || Staff_Name.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Pills(TenThuoc,NoiXuatThuoc,LoaiThuoc,NgayXuatThuoc,NgayHetHanThuoc,Gia,MaNV,TenNV)values(@Pills_Name,@Pills_Place,@Pills_Type,@Use_Pills,@Expired_Pills,@Cost,@StaffID,@StaffName)", Con);
                    cmd.Parameters.AddWithValue("@Pills_Name", PillsName.Text);
                    cmd.Parameters.AddWithValue("@Pills_Place", PillsPlace.Text);
                    cmd.Parameters.AddWithValue("@Pills_Type", TypePills.Text);
                    cmd.Parameters.AddWithValue("@Use_Pills", UsePill.Value.Date);
                    cmd.Parameters.AddWithValue("@Expired_Pills", ExpiredPill.Value.Date);
                    cmd.Parameters.AddWithValue("@Cost", CostPill.Text);
                    cmd.Parameters.AddWithValue("@StaffID", Staff_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StaffName", Staff_Name.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pills Added");
                    Con.Close();
                    Display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void ListPills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PillsName.Text = ListPills.SelectedRows[0].Cells[1].Value.ToString();
            TypePills.Text = ListPills.SelectedRows[0].Cells[2].Value.ToString();
            PillsPlace.Text = ListPills.SelectedRows[0].Cells[3].Value.ToString();
            UsePill.Text = ListPills.SelectedRows[0].Cells[4].Value.ToString();
            ExpiredPill.Text = ListPills.SelectedRows[0].Cells[5].Value.ToString();
            CostPill.Text = ListPills.SelectedRows[0].Cells[6].Value.ToString();
            Staff_ID.Text = ListPills.SelectedRows[0].Cells[7].Value.ToString();
            Staff_Name.Text = ListPills.SelectedRows[0].Cells[8].Value.ToString();
            if (PillsName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ListPills.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PillsName.Text == "" || PillsPlace.Text == "" || TypePills.Text == "" || CostPill.Text == "" || Staff_Name.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Pills set TenThuoc=@Pills_Name,NoiXuatThuoc=@Pills_Place,LoaiThuoc=@Pills_Type,NgayXuatThuoc=@Use_Pills,NgayHetHanThuoc=@Expired_Pills,Gia=@Cost,MaNV=@StaffID,TenNV=@StaffName where MaThuoc=@Pills_ID", Con);
                    cmd.Parameters.AddWithValue("Pills_Name", PillsName.Text);
                    cmd.Parameters.AddWithValue("@Pills_Place", PillsPlace.Text);
                    cmd.Parameters.AddWithValue("@Pills_Type", TypePills.Text);
                    cmd.Parameters.AddWithValue("@Use_Pills", UsePill.Value.Date);
                    cmd.Parameters.AddWithValue("@Expired_Pills", ExpiredPill.Value.Date);
                    cmd.Parameters.AddWithValue("@Cost", CostPill.Text);
                    cmd.Parameters.AddWithValue("@StaffID", Staff_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StaffName", Staff_Name.Text);
                    cmd.Parameters.AddWithValue("@Pills_ID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pills Updated");
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
                MessageBox.Show("Select a Pill");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Pills where MaThuoc=@PillsID", Con);
                    cmd.Parameters.AddWithValue("@PillsID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted");
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
