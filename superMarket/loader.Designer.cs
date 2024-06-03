namespace superMarket
{
    partial class loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(36, 232, 166);
            guna2HtmlLabel1.Font = new Font("MV Boli", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(44, 43, 60);
            guna2HtmlLabel1.Location = new Point(195, 30);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(361, 51);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Market Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shopping_cart;
            pictureBox1.Location = new Point(222, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ProgressBar
            // 
            ProgressBar.BorderRadius = 5;
            ProgressBar.CustomizableEdges = customizableEdges1;
            ProgressBar.Location = new Point(-1, 343);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ProgressColor = Color.FromArgb(44, 43, 60);
            ProgressBar.ProgressColor2 = Color.FromArgb(44, 43, 60);
            ProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ProgressBar.Size = new Size(745, 10);
            ProgressBar.TabIndex = 4;
            ProgressBar.Text = "guna2ProgressBar1";
            ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // loader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 232, 166);
            ClientSize = new Size(743, 352);
            Controls.Add(ProgressBar);
            Controls.Add(pictureBox1);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loader";
            StartPosition = FormStartPosition.CenterScreen;
            Load += loader_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer2;
    }
}