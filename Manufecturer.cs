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
namespace Pharmacy_Management_System
{
    public partial class Manufecturer : Form
    {
        public Manufecturer()
        {
            InitializeComponent();
            ShowManufecturer();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\Pharmacy Management System\Pharmacy Management System\PMSDB.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowManufecturer()
        {
            Con.Open();
            string Query = "Select * from ManufecturerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVManufecturer.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtManufecturerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManufecturerTbl(ManufecturerName,ManufecturerAddress,ManufecturerMobileNo,ManufecturerDate)values(@MN,@MA,@MMN,@MD)", Con);
                    cmd.Parameters.AddWithValue("@MN", txtManufecturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@MD", txtJoinDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufecturer Added Successfully");
                    Con.Close();
                    ShowManufecturer();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void DGVManufecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManufecturerName.Text = DGVManufecturer.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = DGVManufecturer.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVManufecturer.SelectedRows[0].Cells[3].Value.ToString();
            txtJoinDate.Text = DGVManufecturer.SelectedRows[0].Cells[4].Value.ToString();
            if(txtManufecturerName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVManufecturer.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Manufecturer");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ManufecturerTbl where ManufecturerId=@MKey", Con);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufecturer Deleted Successfully");
                    Con.Close();
                    ShowManufecturer();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            txtManufecturerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            Key = 0;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtManufecturerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ManufecturerTbl Set ManufecturerName=@MN,ManufecturerAddress=@MA,ManufecturerMobileNo=@MMN,ManufecturerDate=@MD where ManufecturerId=@MKey", Con);
                    cmd.Parameters.AddWithValue("@MN", txtManufecturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@MD", txtJoinDate.Value.Date);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufecturer Updated Successfully");
                    Con.Close();
                    ShowManufecturer();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void GoDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            Obj.Show();
            this.Hide();
        }

        private void GoMedicines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            Obj.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void GoCustomers_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Sellers Obj = new Sellers();
            Obj.Show();
            this.Hide();
        }

        private void GoSellers_Click(object sender, EventArgs e)
        {
            Sellers Obj = new Sellers();
            Obj.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Sellings Obj = new Sellings();
            Obj.Show();
            this.Hide();
        }

        private void GoSelling_Click(object sender, EventArgs e)
        {
            Sellings Obj = new Sellings();
            Obj.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
