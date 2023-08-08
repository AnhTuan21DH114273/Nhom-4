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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tuan\Documents\DBPhongKham.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Roles;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(Role.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a Role");
            } else if(Role.SelectedIndex == 0)
            {
                if (UserName.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Enter UserName and Password");
                } else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) From Admin Where TenUser = '" + UserName.Text + "' and PasswordUser= '" + Password.Text + "'",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Roles = "Admin";
                        Home obj = new Home();
                        obj.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Admin Not Found");
                    }
                    Con.Close();
                }
            } else if(Role.SelectedIndex == 1)
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) From Staff Where TenNV = '" + UserName.Text + "' and PassNV= '" + Password.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Roles = "Staff";
                    Home obj = new Home();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Admin Not Found");
                }
                Con.Close();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Role.SelectedIndex = 0;
            UserName.Text = "";
            Password.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
