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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace superMarket
{
    public partial class categoies : Form
    {
        public categoies()
        {
            InitializeComponent();
        }
        private void clear()
        {
            catIdTb.Text = "";
            catDescTb.Text = "";
            catNameTb.Text = "";

        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = smarketdb; Integrated Security = true");
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into categoryTable values (" + catIdTb.Text + ",'" + catNameTb.Text + "','" + catDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("دسته با موفقیت اضافه شد");
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
        private void populate()
        {
            con.Open();
            string query = "select * from categoryTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVcategory.DataSource = dataTable;
            con.Close();
        }
        private void categoies_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DGVcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DGVcategory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVcategory_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DGVcategory_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            catIdTb.Text = DGVcategory.SelectedRows[0].Cells[0].Value.ToString();
            catNameTb.Text = DGVcategory.SelectedRows[0].Cells[1].Value.ToString();
            catDescTb.Text = DGVcategory.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catIdTb.Text == "")
                {
                    MessageBox.Show("یک دسته را برای حذف انتخاب کنید");
                }
                else
                {
                    con.Open();
                    string query = "Delete from categoryTable where catd =" + catIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("دسته با موفقیت حذف شد");
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

        private void etid_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catIdTb.Text == "" || catIdTb.Text == "" || catDescTb.Text == "")
                {
                    MessageBox.Show("ابتدا یک دسته را برای ویرایش انتخاب کنید");
                }
                else
                {
                    con.Open();
                    string query = "update categoryTable set catName='" + catNameTb.Text + "', catDesc='" + catDescTb.Text + "' where catd=" + catIdTb.Text + ";";
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

        private void sellers_btn_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.Show();
            this.Hide();
        }

        private void gategor_btn_Click(object sender, EventArgs e)
        {
            sellerForm seller = new sellerForm();
            seller.Show();
            this.Hide();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
