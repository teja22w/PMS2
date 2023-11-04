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
    public partial class Sellings : Form
    {
        public Sellings()
        {
            InitializeComponent();
            ShowMedicine();
            ShowBill();
            GetCustomer();
            LblSellerName.Text = Login.User;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Full Projects\Pharmacy Management System\Pharmacy Management System\PMSDB.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetCustomer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerId from CustomerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Load(Rdr);
            txtCustomerID.ValueMember = "CustomerId";
            txtCustomerID.DataSource = dt;
            Con.Close();
        }
        private void GetCustomerName()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl where CustomerId='" + txtCustomerID.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtCustomerName.Text = dr["CustomerName"].ToString();
            }
            Con.Close();
        }
        private void UpdateQnty()
        {
            try
            {
                int NewQnty = Stock - Convert.ToInt32(txtQuantity.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update MedicineTbl Set MedicineQnty=@MQ where MedicineId=@MKey", Con);
                cmd.Parameters.AddWithValue("@MQ", NewQnty);
                cmd.Parameters.AddWithValue("@MKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Updated Successfully");
                Con.Close();
                ShowMedicine();
                //Reset();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        private void InsertBill()
        {
            if(txtCustomerName.Text == "")
            {

            }else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTbl(SellerName,CustomerId,CustomerName,BillDate,BillAmount)values(@SN,@CI,@CN,@BD,@BA)", Con);
                    cmd.Parameters.AddWithValue("@SN", LblSellerName.Text);
                    cmd.Parameters.AddWithValue("@CI", txtCustomerID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@BA", GrdTotal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();
                    ShowBill();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void ShowBill()
        {
            Con.Open();
            string Query = "Select * from BillTbl where SellerName='"+LblSellerName.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVTransactions.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ShowMedicine()
        {
            Con.Open();
            string Query = "Select * from MedicineTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVMedicineStock.DataSource = ds.Tables[0];
            Con.Close();
        }
        int n = 0,GrdTotal=0;
        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text)> Stock)
            {
                MessageBox.Show("Enter Correct Quantity");
            }else
            {
                int total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtMedicine.Text;
                newRow.Cells[2].Value = txtQuantity.Text;
                newRow.Cells[3].Value = txtPrice.Text;
                newRow.Cells[4].Value = total;
                DGVBill.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                LblTotal.Text = "Rs " + GrdTotal;
                n++;
                UpdateQnty();
            }
        }
        int Key = 0,Stock;
        int MedId, MedPrice, MedQty, MedTot;

        private void txtCustomerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
           GetCustomerName();
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

        string MedName;
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pacify Pharmacy", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID Medicine Price Quantity Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in DGVBill.Rows)
            {
                MedId = Convert.ToInt32(row.Cells["Column1"].Value);
                MedName = "" + row.Cells["Column2"].Value;
                MedPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                MedQty = Convert.ToInt32(row.Cells["Column4"].Value);
                MedTot = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + MedId, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, Pos));
                e.Graphics.DrawString("" + MedName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, Pos));
                e.Graphics.DrawString("" + MedPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(128, Pos));
                e.Graphics.DrawString("" + MedQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, Pos));
                e.Graphics.DrawString("" + MedTot, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, Pos));
                Pos = Pos + 20;
            }
            e.Graphics.DrawString("Grand Total:Rs" + GrdTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(50, Pos + 50));
            e.Graphics.DrawString("***********Pacify Pharmacy**********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(10, Pos + 85));
            DGVBill.Rows.Clear();
            DGVBill.Refresh();
            Pos = 100;
            GrdTotal = 0;
            n = 0;
        }

        int Pos = 60;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm",285,600);
            if(PrintPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument.Print();
            }
            InsertBill();
        }

        private void DGVMedicineStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicine.Text = DGVMedicineStock.SelectedRows[0].Cells[1].Value.ToString();
            //txtMedicineType.SelectedItem = DGVMedicineStock.SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(DGVMedicineStock.SelectedRows[0].Cells[3].Value.ToString());
            txtPrice.Text = DGVMedicineStock.SelectedRows[0].Cells[4].Value.ToString();
            //txtManufecturer.SelectedValue = DGVMedicineStock.SelectedRows[0].Cells[5].Value.ToString();
            //txtManufecturerName.Text = DGVMedicineStock.SelectedRows[0].Cells[6].Value.ToString();
            if (txtMedicine.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVMedicineStock.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
