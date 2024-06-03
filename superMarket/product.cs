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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Windows.Forms;
using BindingSource = System.Windows.Forms.BindingSource;

namespace superMarket
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = smarketdb; Integrated Security = true");
        private void fill_combo()
        {
            con.Open();
            string query = "select catName from categoryTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            catCb.DataSource = dt;
            catCb.ValueMember = "catname";
            con.Close();

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void product_Load(object sender, EventArgs e)
        {
            fill_combo();
            populate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gategor_btn_Click(object sender, EventArgs e)
        {
            categoies categoies = new categoies();
            categoies.Show();
            this.Hide();
        }
        private void populate()
        {


            con.Open();
            string query = "select * from productTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVproduct.DataSource = dataTable;
            con.Close();





        }
        private void prpAdd_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into productTable values (" + proIdTb.Text + ",'" + proNameTb.Text + "','" + proQtyTb.Text + "','" + proCostTb.Text + "','" + catCb.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("محصول با موفقیت اضافه شد");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DGVproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            proIdTb.Text = DGVproduct.SelectedRows[0].Cells[0].Value.ToString();
            proNameTb.Text = DGVproduct.SelectedRows[0].Cells[1].Value.ToString();
            proQtyTb.Text = DGVproduct.SelectedRows[0].Cells[2].Value.ToString();
            proCostTb.Text = DGVproduct.SelectedRows[0].Cells[3].Value.ToString();
            catCb.SelectedValue = DGVproduct.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void proEdit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (proIdTb.Text == "" || proNameTb.Text == "" || proQtyTb.Text == "" || proCostTb.Text == "")
                {
                    MessageBox.Show("ابتدا یک محصول را برای ویرایش انتخاب کنید");
                }
                else
                {
                    con.Open();
                    string query = "update productTable set prodName='" + proNameTb.Text + "', prodQty='" + proQtyTb.Text + "', prodCost='" + proCostTb.Text + "' , proCat='" + catCb.SelectedValue.ToString() + 
                        "' where pordId=" + proIdTb.Text + ";";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("با موفقیت به روزسانی شد");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void proDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (proIdTb.Text == "")
                {
                    MessageBox.Show("یک دسته را برای حذف انتخاب کنید");
                }
                else
                {
                    con.Open();
                    string query = "Delete from productTable where pordId =" + proIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("محصول با موفقیت حذف شد");
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

            }
        }

        private void cat2Cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cat2Cb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void catCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void catCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filter_tb_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DGVproduct.DataSource;
            bs.Filter = "proCat like '%" + filter_tb.Text + "%' OR prodName like '%" + filter_tb.Text + "%'";
            DGVproduct.DataSource = bs.DataSource;

        }

        private void sellers_btn_Click(object sender, EventArgs e)
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
