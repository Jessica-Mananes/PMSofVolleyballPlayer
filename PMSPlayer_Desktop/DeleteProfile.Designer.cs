namespace PMSPlayer_Desktop
{
    partial class DeleteProfile
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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            dgvDeleteProfile = new DataGridView();
            Label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteProfile).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.AccessibleRole = AccessibleRole.Sound;
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(260, 566);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(143, 56);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleRole = AccessibleRole.Sound;
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(446, 566);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 56);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Delete ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.AccessibleRole = AccessibleRole.Sound;
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(68, 566);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 56);
            btnBack.TabIndex = 36;
            btnBack.Text = "Previous";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvDeleteProfile
            // 
            dgvDeleteProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteProfile.Location = new Point(119, 196);
            dgvDeleteProfile.Margin = new Padding(3, 4, 3, 4);
            dgvDeleteProfile.Name = "dgvDeleteProfile";
            dgvDeleteProfile.RowHeadersWidth = 51;
            dgvDeleteProfile.Size = new Size(436, 322);
            dgvDeleteProfile.TabIndex = 35;
            dgvDeleteProfile.CellClick += dgvDeleteProfile_CellClick;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.White;
            Label3.Font = new Font("Impact", 28F);
            Label3.ForeColor = Color.Navy;
            Label3.Location = new Point(195, 81);
            Label3.Name = "Label3";
            Label3.Size = new Size(303, 59);
            Label3.TabIndex = 34;
            Label3.Text = "DELETE PROFILE";
            // 
            // DeleteProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(696, 761);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(dgvDeleteProfile);
            Controls.Add(Label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteProfile";
            Text = "DeleteProfile";
            ((System.ComponentModel.ISupportInitialize)dgvDeleteProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.DataGridView dgvDeleteProfile;
        internal System.Windows.Forms.Label Label3;
    }
}