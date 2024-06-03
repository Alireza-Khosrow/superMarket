using System.Data;
using System.Data.SqlClient;

namespace superMarket
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        static public string sellerName = "";



        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = smarketdb; Integrated Security = true");

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
                if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("نام کاربری و گذرواژه و نقش را وارد کنید");
            }
            else
            {
                if (roleCb.SelectedIndex > -1)
                {
                    if (roleCb.SelectedItem.ToString() == "Admin")
                    {
                        if (TextBox_username.Text == "Admin" && TextBox_password.Text == "Admin")
                        {
                            product product = new product();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا گذروازه اشتباه است");
                        }
                    }
                    else
                    {
                    
                        con.Open();
                        string query = "select count(8) from sellerTable where sellerName='"+TextBox_username.Text+"' and sellerPass='"+TextBox_password.Text+"'"; 
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query , con);
                        DataTable dataTable = new DataTable(); 
                        sqlDataAdapter.Fill(dataTable); ;
                        if (dataTable.Rows[0][0].ToString() == "1")
                        {
                            sellerName = TextBox_username.Text;
                            selling selling = new selling();
                            selling.Show();
                            this.Hide();
                            con.Close();

                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا گذروازه اشتباه است");
                        }
                        con.Close();
                    }
                }

                else

                {
                    MessageBox.Show("نقش خود را مشخص کنید");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            TextBox_username.Text = "";
            TextBox_password.Text = "";

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
