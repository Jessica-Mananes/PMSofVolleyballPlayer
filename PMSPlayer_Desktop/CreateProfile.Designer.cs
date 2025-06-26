namespace PMSPlayer_Desktop
{
    partial class CreateProfile
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
            Label3 = new Label();
            txbAge = new TextBox();
            txbName = new TextBox();
            cmbPosition = new ComboBox();
            lblPosition = new Label();
            lblAge = new Label();
            lblName = new Label();
            btnBack = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.CornflowerBlue;
            Label3.Font = new Font("Impact", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Navy;
            Label3.Location = new Point(203, 116);
            Label3.Name = "Label3";
            Label3.Size = new Size(284, 53);
            Label3.TabIndex = 21;
            Label3.Text = "CREATE PROFILE";
            // 
            // txbAge
            // 
            txbAge.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbAge.Location = new Point(240, 325);
            txbAge.Margin = new Padding(3, 4, 3, 4);
            txbAge.Name = "txbAge";
            txbAge.Size = new Size(402, 31);
            txbAge.TabIndex = 20;
            // 
            // txbName
            // 
            txbName.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbName.Location = new Point(242, 253);
            txbName.Margin = new Padding(3, 4, 3, 4);
            txbName.Name = "txbName";
            txbName.Size = new Size(400, 31);
            txbName.TabIndex = 19;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Libero", "Setter", "Blocker", "Opposite Spiker", "Opposite Hitter", "Middle Hitter" });
            cmbPosition.Location = new Point(240, 398);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(402, 32);
            cmbPosition.TabIndex = 18;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.BackColor = Color.Transparent;
            lblPosition.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.Navy;
            lblPosition.Location = new Point(56, 392);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(114, 35);
            lblPosition.TabIndex = 17;
            lblPosition.Text = "Position:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.Navy;
            lblAge.Location = new Point(56, 325);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(141, 35);
            lblAge.TabIndex = 16;
            lblAge.Text = "Player Age:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Navy;
            lblName.Location = new Point(56, 253);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 35);
            lblName.TabIndex = 15;
            lblName.Text = "Player Name: ";
            // 
            // btnBack
            // 
            btnBack.AccessibleRole = AccessibleRole.Sound;
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(77, 559);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 56);
            btnBack.TabIndex = 23;
            btnBack.Text = "Previous";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(426, 487);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            btnAdd.Size = new Size(177, 43);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add Player";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // CreateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 1049);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(Label3);
            Controls.Add(txbAge);
            Controls.Add(txbName);
            Controls.Add(cmbPosition);
            Controls.Add(lblPosition);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateProfile";
            Text = "CreateProfile";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txbAge;
        internal System.Windows.Forms.TextBox txbName;
        internal System.Windows.Forms.ComboBox cmbPosition;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label lblAge;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnAdd;
    }
}