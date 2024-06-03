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

namespace superMarket
{
    public partial class sellerReport : Form
    {
        public sellerReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = smarketdb; Integrated Security = true");

        private void sellerReport_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from " + sellerForm.sellerNameForReport + "";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVseller.DataSource = dataTable;
            con.Close();

        }
    }
}
