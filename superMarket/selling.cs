using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superMarket
{
    public partial class selling : Form
    {
        public selling()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = smarketdb; Integrated Security = true");

        private void clear()
        {
            billIdTb.Text = "";
            proNameTb.Text = "";
            proQtyTb.Text = "";
            proCostTb.Text = "";

        }
        private void populate()
        {
            con.Open();
            string query = "select prodName, prodQty , prodCost ,pordId from productTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVproduct1.DataSource = dataTable;
            con.Close();
        }
        private void populateBill()
        {
            con.Open();
            string query = "select * from BillTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVbill.DataSource = dataTable;
            con.Close();
        }

        private void selling_Load(object sender, EventArgs e)
        {
            sellerLb.Text = login.sellerName;
            populate();
            populateBill();
            dateLb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void proCostTb_TextChanged(object sender, EventArgs e)
        {

        }
        int re_id, re_Qty, re_cost = 0;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            re_id = Convert.ToInt32(DGVproduct2.SelectedRows[0].Cells[0].Value.ToString());
            re_Qty = Convert.ToInt32(DGVproduct2.SelectedRows[0].Cells[3].Value.ToString());
            re_cost = Convert.ToInt32(DGVproduct2.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void proNameTb_TextChanged(object sender, EventArgs e)
        {

        }
        int id, Qty = 0;
        private void DGVproduct1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            proNameTb.Text = DGVproduct1.SelectedRows[0].Cells[0].Value.ToString();
            proCostTb.Text = DGVproduct1.SelectedRows[0].Cells[2].Value.ToString();
            Qty = Convert.ToInt32(DGVproduct1.SelectedRows[0].Cells[1].Value.ToString());
            id = Convert.ToInt32(DGVproduct1.SelectedRows[0].Cells[3].Value.ToString());
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Grdtotal = 0;
        int n;
        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            if (proNameTb.Text == "")
            {
                MessageBox.Show("یک محصول را برای فروش انتخاب کنید");

            }
            else if (proQtyTb.Text == "")
            {
                MessageBox.Show("تعداد را برای فروش مشخص کنید");
            }
            else
            {

                int total = Convert.ToInt32(proCostTb.Text) * Convert.ToInt32(proQtyTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVproduct2);
                newRow.Cells[0].Value = id;
                newRow.Cells[1].Value = proNameTb.Text;
                newRow.Cells[2].Value = proCostTb.Text;
                newRow.Cells[3].Value = proQtyTb.Text;
                newRow.Cells[4].Value = Convert.ToInt32(proCostTb.Text) * Convert.ToInt32(proQtyTb.Text);
                DGVproduct2.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                totalLb.Text = "T " + Grdtotal;
                try
                {

                    con.Open();
                    string query = "update productTable set prodQty='" + (Qty - Convert.ToInt32(proQtyTb.Text)) + "' where pordId=" + id + ";";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    
                    con.Open();
                    string query2 = "INSERT INTO "+sellerLb.Text+" (BillId, NameP, QtyP, CostP) \r\n VALUES('"+billIdTb.Text +"', '"+proNameTb.Text +"', '"+proQtyTb.Text +"', '"+proCostTb.Text +"')";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    populate();
                }
            }
        }

        private void prpAdd_btn_Click(object sender, EventArgs e)
        {
            if (billIdTb.Text == "")
            {
                MessageBox.Show("شماره فاکتور را وارد کنید");
            }
            else
            {

                try
                {
                    con.Open();
                    string query = "insert into billTable values (" + billIdTb.Text + ",'" + sellerLb.Text + "','" + dateLb.Text + "','" + Grdtotal.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تراکنش با موفیقت ثبت شد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    populateBill();
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = DGVproduct2.CurrentCell.RowIndex;
            try
            {

                con.Open();
                string query = "update productTable set prodQty= (prodQty + '" + re_Qty + "') where pordId=" + re_id + ";";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                populate();
            }
            Grdtotal = Grdtotal - re_cost;
            totalLb.Text = "T " + Grdtotal;
            DGVproduct2.Rows.RemoveAt(rowIndex);
        }

        private void filter_tb_TextChanged(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = DGVproduct.DataSource;
            //bs.Filter = "proCat like '%" + filter_tb.Text + "%' OR prodName like '%" + filter_tb.Text + "%'";
            //DGVproduct.DataSource = bs.DataSource;
            con.Open();
            string query = "select prodName, prodQty , prodCost ,pordId from productTable where proCat like '%" + filter_tb.Text + "%' OR prodName like '%" + filter_tb.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVproduct1.DataSource = dataTable;
            con.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
