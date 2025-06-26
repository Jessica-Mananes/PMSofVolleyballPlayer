namespace PMSPlayer_Desktop
{
    partial class ViewProfile
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
            Label3 = new Label();
            dgbViewProfile = new DataGridView();
            Label1 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbViewProfile).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AccessibleRole = AccessibleRole.Sound;
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(63, 844);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 56);
            btnBack.TabIndex = 35;
            btnBack.Text = "Previous";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.CornflowerBlue;
            Label3.Font = new Font("Impact", 28F);
            Label3.ForeColor = Color.Navy;
            Label3.Location = new Point(220, 76);
            Label3.Name = "Label3";
            Label3.Size = new Size(273, 59);
            Label3.TabIndex = 34;
            Label3.Text = "VIEW PROFILE";
            // 
            // dgbViewProfile
            // 
            dgbViewProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbViewProfile.Location = new Point(50, 224);
            dgbViewProfile.Margin = new Padding(3, 4, 3, 4);
            dgbViewProfile.Name = "dgbViewProfile";
            dgbViewProfile.RowHeadersWidth = 51;
            dgbViewProfile.Size = new Size(614, 335);
            dgbViewProfile.TabIndex = 33;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(236, 56);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 20);
            Label1.TabIndex = 32;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(489, 606);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 48);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;

            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 1049);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(Label3);
            Controls.Add(dgbViewProfile);
            Controls.Add(Label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewProfile";
            Text = "ViewProfile";
            Load += ViewProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgbViewProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dgbViewProfile;
        internal System.Windows.Forms.Label Label1;
        internal Button btnRefresh;
    }
}