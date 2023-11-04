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
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
            ShowMedicine();
            GetManufecturer();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\Pharmacy Management System\Pharmacy Management System\PMSDB.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowMedicine()
        {
            Con.Open();
            string Query = "Select * from MedicineTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVMedicine.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtMedicineName.Text = "";
            txtMedicineType.SelectedIndex = 0;
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtManufecturerName.Text = "";
            Key = 0;
        }
        private void GetManufecturer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select ManufecturerId from ManufecturerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ManufecturerId", typeof(int));
            dt.Load(Rdr);
            txtManufecturer.ValueMember = "ManufecturerId";
            txtManufecturer.DataSource = dt;
            Con.Close();
        }
        private void GetManufecturerName()
        {
            Con.Open();
            string Query = "Select * from ManufecturerTbl where ManufecturerId='" + txtManufecturer.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtManufecturerName.Text = dr["ManufecturerName"].ToString();
            }
            Con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == "" || txtMedicineType.SelectedIndex== -1 || txtQuantity.Text == "" || txtQuantity.Text == "" || txtManufecturer.SelectedIndex== -1 || txtManufecturerName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MedicineTbl(MedicineName,MedicineType,MedicineQnty,MedicinePrice,MedicineManuId,MedicineManufecturer)values(@MN,@MT,@MQ,@MP,@MMI,@MM)", Con);
                    cmd.Parameters.AddWithValue("@MN", txtMedicineName.Text);
                    cmd.Parameters.AddWithValue("@MT", txtMedicineType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@MP", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@MMI", txtManufecturer.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MM", txtManufecturerName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Added Successfully");
                    Con.Close();
                    ShowMedicine();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void txtManufecturer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetManufecturerName();
        }
        int Key = 0;
        private void DGVMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineName.Text = DGVMedicine.SelectedRows[0].Cells[1].Value.ToString();
            txtMedicineType.SelectedItem = DGVMedicine.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = DGVMedicine.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = DGVMedicine.SelectedRows[0].Cells[4].Value.ToString();
            txtManufecturer.SelectedValue = DGVMedicine.SelectedRows[0].Cells[5].Value.ToString();
            txtManufecturerName.Text = DGVMedicine.SelectedRows[0].Cells[6].Value.ToString();
            if (txtMedicineName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVMedicine.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Medicine");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from MedicineTbl where MedicineId=@MKey", Con);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Deleted Successfully");
                    Con.Close();
                    ShowMedicine();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == "" || txtMedicineType.SelectedIndex == -1 || txtQuantity.Text == "" || txtQuantity.Text == "" || txtManufecturer.SelectedIndex == -1 || txtManufecturerName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update MedicineTbl Set MedicineName=@MN,MedicineType=@MT,MedicineQnty=@MQ,MedicinePrice=@MP,MedicineManuId=@MMI,MedicineManufecturer=@MM where MedicineId=@MKey", Con);
                    cmd.Parameters.AddWithValue("@MN", txtMedicineName.Text);
                    cmd.Parameters.AddWithValue("@MT", txtMedicineType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@MP", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@MMI", txtManufecturer.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MM", txtManufecturerName.Text);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Updated Successfully");
                    Con.Close();
                    ShowMedicine();
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

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            Manufecturer Obj = new Manufecturer();
            Obj.Show();
            this.Hide();
        }

        private void GoManufacturer_Click(object sender, EventArgs e)
        {
            Manufecturer Obj = new Manufecturer();
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
    }
}
