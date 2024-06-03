using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace superMarket
{
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = smarketdb; Integrated Security = true");
        static public string sellerNameForReport = "";
    
        private void populate()
        {
            con.Open();
            string query = "select * from sellerTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVseller.DataSource = dataTable;
            con.Close();
        }
        private void clear()
        {
            TextBox_sellerId.Text = "";
            TextBox_sellerName.Text = "";
            TextBox_sellerAge.Text = "";
            TextBox_sellerPhone.Text = "";
            TextBox_sellerPass.Text = "";
            TextBox_sellerState.Text = "";
            TextBox_sellerCity.Text = "";
        }

        private void sellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void sellers_btn_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void categor_btn_Click(object sender, EventArgs e)
        {
            categoies categoies = new categoies();
            categoies.Show();
            this.Hide();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into sellerTable values (" + TextBox_sellerId.Text + ",'" + TextBox_sellerName.Text + "','" + TextBox_sellerAge.Text + "','" + TextBox_sellerState.Text + "','" + TextBox_sellerCity.Text + "' ,'" + TextBox_sellerPhone.Text + "' ,'" + TextBox_sellerPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("فروشنده با موفقیت اضافه شد");
                con.Close();

                con.Open();
                string query2 = "CREATE TABLE [dbo].[" + TextBox_sellerName.Text + "] \r\n " +
                    "(\r\n [TId] INT NOT NULL PRIMARY KEY IDENTITY, \r\n [BillId] INT NOT NULL, " +
                    "\r\n [NameP] NVARCHAR(50) NOT NULL,\r\n [QtyP] INT NOT NULL, \r\n [CostP] INT NOT NULL \r\n ) \r\n ";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                populate();
                clear();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_sellerId.Text == "" || TextBox_sellerName.Text == "" || TextBox_sellerAge.Text == "" || TextBox_sellerPhone.Text == "" || TextBox_sellerPass.Text == "")
                {
                    MessageBox.Show("ابتدا یک شخص را برای ویرایش انتخاب کنید");
                }
                else
                {
                    con.Open();
                    string query = "update sellerTable set sellerName='" + TextBox_sellerName.Text + "', sellerAge='" + TextBox_sellerAge.Text + "' , sellerPhone='" + TextBox_sellerState.Text + "', sellerState='" + TextBox_sellerCity.Text + "', sellerCity='" + TextBox_sellerPhone.Text + "', sellerPass='" + TextBox_sellerPass.Text + "' where sellerId=" + TextBox_sellerId.Text + ";";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("با موفقیت به روزسانی شد");
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                populate();
                clear();
            }
        }
        
        private void DGVseller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_sellerId.Text = DGVseller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_sellerName.Text = DGVseller.SelectedRows[0].Cells[1].Value.ToString();
            sellerNameForReport = DGVseller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_sellerAge.Text = DGVseller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_sellerCity.Text = DGVseller.SelectedRows[0].Cells[4].Value.ToString();
            TextBox_sellerState.Text = DGVseller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_sellerPhone.Text = DGVseller.SelectedRows[0].Cells[5].Value.ToString();
            TextBox_sellerPass.Text = DGVseller.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_sellerId.Text == "")
                {
                    MessageBox.Show("یک شخص را برای حذف انتخاب کنید");
                }
                else
                {
                    con.Open();
                    string query = "Delete from sellerTable where sellerId =" + TextBox_sellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("شخص با موفقیت حذف شد");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                populate();
                clear();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from sellerTable ORDER BY\r\n" +
                "(CASE\r\n    WHEN sellerCity IS NULL THEN sellerState\r\n  " +
                "  ELSE sellerCity\r\nEND);";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVseller.DataSource = dataTable;
            con.Close();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();

        }

        private void report_btn_Click(object sender, EventArgs e)
        {
           

            sellerReport sellerReport = new sellerReport();
            sellerReport.ShowDialog();
        }
    }
}
