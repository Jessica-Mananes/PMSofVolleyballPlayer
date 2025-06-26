namespace PMSPlayer_Desktop
{
    partial class EditProfile
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
            btnBack = new Button();
            dgvData = new DataGridView();
            btnSave = new Button();
            txbAge = new TextBox();
            txbName = new TextBox();
            cmbPosition = new ComboBox();
            lblPosition = new Label();
            lblAge = new Label();
            lblName = new Label();
            Label3 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AccessibleRole = AccessibleRole.Sound;
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(262, 403);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 46);
            btnBack.TabIndex = 44;
            btnBack.Text = "Previous";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(66, 476);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(529, 263);
            dgvData.TabIndex = 43;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(441, 403);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 45);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save Profile\r\n\r\n";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txbAge
            // 
            txbAge.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbAge.Location = new Point(245, 266);
            txbAge.Margin = new Padding(3, 4, 3, 4);
            txbAge.Name = "txbAge";
            txbAge.Size = new Size(400, 34);
            txbAge.TabIndex = 37;
            // 
            // txbName
            // 
            txbName.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbName.Location = new Point(245, 195);
            txbName.Margin = new Padding(3, 4, 3, 4);
            txbName.Name = "txbName";
            txbName.Size = new Size(400, 34);
            txbName.TabIndex = 36;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Libero", "Setter", "Blocker", "Opposite Spiker", "Opposite Hitter" });
            cmbPosition.Location = new Point(243, 322);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(402, 32);
            cmbPosition.TabIndex = 35;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.BackColor = Color.Transparent;
            lblPosition.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.Navy;
            lblPosition.Location = new Point(66, 316);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(114, 35);
            lblPosition.TabIndex = 33;
            lblPosition.Text = "Position:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.Navy;
            lblAge.Location = new Point(66, 250);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(64, 35);
            lblAge.TabIndex = 32;
            lblAge.Text = "Age:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Navy;
            lblName.Location = new Point(57, 189);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 35);
            lblName.TabIndex = 31;
            lblName.Text = "Player Name: ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.CornflowerBlue;
            Label3.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Navy;
            Label3.Location = new Point(220, 43);
            Label3.Name = "Label3";
            Label3.Size = new Size(259, 59);
            Label3.TabIndex = 30;
            Label3.Text = "EDIT PROFILE";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(96, 404);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(139, 44);
            btnRefresh.TabIndex = 45;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PMSPlayer_Desktop.Properties.Resources.bgLogin;
            ClientSize = new Size(696, 1049);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(txbAge);
            Controls.Add(txbName);
            Controls.Add(cmbPosition);
            Controls.Add(lblPosition);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(Label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditProfile";
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.DataGridView dgvData;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txbAge;
        internal System.Windows.Forms.TextBox txbName;
        internal System.Windows.Forms.ComboBox cmbPosition;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label lblAge;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label Label3;
        internal Button btnRefresh;
    }
}