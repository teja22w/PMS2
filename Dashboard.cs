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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountMedicine();
            CountCustomer();
            CountSeller();
            SumAmount();
            GetSeller();
            SumAmountBySellers();
            GetBestCustomer();
            GetBestSeller();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\Pharmacy Management System\Pharmacy Management System\PMSDB.mdf;Integrated Security=True");
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void CountMedicine()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from MedicineTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblMedicines.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountCustomer()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblCustomers.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountSeller()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellers.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumAmount()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BillAmount) from BillTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellAmount.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumAmountBySellers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BillAmount) from BillTbl where SellerName='" + SelectSeller.SelectedValue.ToString() +"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellAmountBySeller.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetSeller()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select SellerName from SellerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SellerName", typeof(string));
            dt.Load(Rdr);
            SelectSeller.ValueMember = "SellerName";
            SelectSeller.DataSource = dt;
            Con.Close();
        }
        private void GetBestCustomer()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select CustomerName from BillTbl where BillAmount = '"+ dt1.Rows[0][0].ToString() +"'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblBestCustomer.Text = dt.Rows[0][0].ToString();
                Con.Close();

            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }
        private void GetBestSeller()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select SellerName from BillTbl where BillAmount = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblBestSeller.Text = dt.Rows[0][0].ToString();
                Con.Close();

            }
            catch (Exception Ex)
            {
                Con.Close();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void SelectSeller_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumAmountBySellers();
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

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
