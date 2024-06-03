namespace superMarket
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            Button_login = new Guna.UI2.WinForms.Guna2Button();
            labelExit = new Label();
            roleCb = new ComboBox();
            clear_btn = new Label();
            SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(36, 232, 166);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-249, -16);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(512, 465);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(36, 232, 166);
            guna2HtmlLabel1.Font = new Font("MV Boli", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(44, 43, 60);
            guna2HtmlLabel1.Location = new Point(50, 169);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(127, 51);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Market";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.FromArgb(36, 232, 166);
            guna2HtmlLabel2.Font = new Font("MV Boli", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(44, 43, 60);
            guna2HtmlLabel2.Location = new Point(20, 226);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(219, 51);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Management";
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(620, 165);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 3;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(629, 241);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 4;
            label2.Text = "گذرواژه";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(36, 232, 166);
            label3.Location = new Point(390, 18);
            label3.Name = "label3";
            label3.Size = new Size(99, 37);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            label3.Click += label3_Click;
            // 
            // TextBox_username
            // 
            TextBox_username.BorderColor = Color.FromArgb(36, 232, 166);
            TextBox_username.BorderRadius = 18;
            TextBox_username.CustomizableEdges = customizableEdges2;
            TextBox_username.DefaultText = "";
            TextBox_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.FillColor = Color.FromArgb(50, 49, 69);
            TextBox_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_username.ForeColor = Color.White;
            TextBox_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Location = new Point(309, 160);
            TextBox_username.Margin = new Padding(3, 4, 3, 4);
            TextBox_username.Name = "TextBox_username";
            TextBox_username.PasswordChar = '\0';
            TextBox_username.PlaceholderText = "";
            TextBox_username.SelectedText = "";
            TextBox_username.ShadowDecoration.CustomizableEdges = customizableEdges3;
            TextBox_username.Size = new Size(282, 46);
            TextBox_username.TabIndex = 6;
            // 
            // TextBox_password
            // 
            TextBox_password.BorderColor = Color.FromArgb(36, 232, 166);
            TextBox_password.BorderRadius = 18;
            TextBox_password.CustomizableEdges = customizableEdges4;
            TextBox_password.DefaultText = "";
            TextBox_password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.FillColor = Color.FromArgb(50, 49, 69);
            TextBox_password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_password.ForeColor = Color.White;
            TextBox_password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Location = new Point(309, 237);
            TextBox_password.Margin = new Padding(3, 4, 3, 4);
            TextBox_password.Name = "TextBox_password";
            TextBox_password.PasswordChar = '\0';
            TextBox_password.PlaceholderText = "";
            TextBox_password.SelectedText = "";
            TextBox_password.ShadowDecoration.CustomizableEdges = customizableEdges5;
            TextBox_password.Size = new Size(282, 46);
            TextBox_password.TabIndex = 7;
            // 
            // Button_login
            // 
            Button_login.BorderRadius = 18;
            Button_login.CustomizableEdges = customizableEdges6;
            Button_login.DisabledState.BorderColor = Color.DarkGray;
            Button_login.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_login.FillColor = Color.FromArgb(36, 232, 166);
            Button_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Button_login.ForeColor = Color.White;
            Button_login.Location = new Point(346, 308);
            Button_login.Name = "Button_login";
            Button_login.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Button_login.Size = new Size(197, 50);
            Button_login.TabIndex = 8;
            Button_login.Text = "ورود";
            Button_login.Click += Button_login_Click;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Cursor = Cursors.Hand;
            labelExit.Font = new Font("Segoe UI", 26.25F);
            labelExit.ForeColor = Color.FromArgb(36, 232, 166);
            labelExit.Location = new Point(700, -16);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(55, 60);
            labelExit.TabIndex = 9;
            labelExit.Text = "×";
            labelExit.TextAlign = ContentAlignment.BottomRight;
            labelExit.Click += labelExit_Click;
            // 
            // roleCb
            // 
            roleCb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            roleCb.ForeColor = Color.FromArgb(44, 43, 60);
            roleCb.FormattingEnabled = true;
            roleCb.Items.AddRange(new object[] { "Admin", "seller" });
            roleCb.Location = new Point(309, 86);
            roleCb.Margin = new Padding(5);
            roleCb.Name = "roleCb";
            roleCb.RightToLeft = RightToLeft.Yes;
            roleCb.Size = new Size(282, 36);
            roleCb.TabIndex = 10;
            roleCb.Text = " نقش را انتخاب کنید";
            roleCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // clear_btn
            // 
            clear_btn.AutoSize = true;
            clear_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_btn.ForeColor = Color.FromArgb(36, 232, 166);
            clear_btn.Location = new Point(399, 361);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(87, 28);
            clear_btn.TabIndex = 11;
            clear_btn.Text = "پاک کردن";
            clear_btn.Click += clear_btn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ClientSize = new Size(743, 423);
            Controls.Add(clear_btn);
            Controls.Add(roleCb);
            Controls.Add(labelExit);
            Controls.Add(Button_login);
            Controls.Add(TextBox_password);
            Controls.Add(TextBox_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2CircleButton1);
            ForeColor = Color.FromArgb(14, 21, 58);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private Label labelExit;
        private ComboBox roleCb;
        private Label clear_btn;
    }
}
