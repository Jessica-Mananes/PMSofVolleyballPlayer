namespace PMSPlayer_Desktop
{
    partial class Login
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
            btnLogin = new Button();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            lblPassword = new Label();
            lblUserName = new Label();
            lblSystemName = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(424, 577);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 53);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(301, 451);
            tbxPassword.Margin = new Padding(3, 4, 3, 4);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(311, 40);
            tbxPassword.TabIndex = 10;
            // 
            // tbxUsername
            // 
            tbxUsername.Cursor = Cursors.IBeam;
            tbxUsername.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.Location = new Point(301, 381);
            tbxUsername.Margin = new Padding(3, 4, 3, 4);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(311, 40);
            tbxUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(135, 451);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(134, 35);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "password:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(135, 381);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(138, 35);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "username:";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.BackColor = Color.CornflowerBlue;
            lblSystemName.Font = new Font("Britannic Bold", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSystemName.ForeColor = Color.Navy;
            lblSystemName.ImageAlign = ContentAlignment.BottomCenter;
            lblSystemName.Location = new Point(53, 139);
            lblSystemName.Margin = new Padding(4, 0, 4, 0);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(611, 104);
            lblSystemName.TabIndex = 6;
            lblSystemName.Text = "          Volleyball Player\r\n Profile Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            //BackgroundImage = Properties.Resources.bgLogin;
            ClientSize = new Size(696, 731);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblSystemName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.TextBox tbxPassword;
        internal System.Windows.Forms.TextBox tbxUsername;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Label lblSystemName;
    }
}

