using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superMarket
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            startpoint = (startpoint + 3);
            ProgressBar.Value = startpoint;
            if (ProgressBar.Value == 100)
            {
                ProgressBar.Value = 0;
                timer2.Stop();
                Form log = new login();
                this.Hide();
                log.Show();
            }
        }

        private void loader_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
