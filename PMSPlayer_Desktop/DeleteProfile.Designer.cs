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
            DataGridView1 = new DataGridView();
            Label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.AccessibleRole = AccessibleRole.Sound;
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(315, 595);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(143, 56);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleRole = AccessibleRole.Sound;
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(495, 595);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 56);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Delete ";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.AccessibleRole = AccessibleRole.Sound;
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Microsoft Himalaya", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(42, 838);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 56);
            btnBack.TabIndex = 36;
            btnBack.Text = "Previous";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(26, 210);
            DataGridView1.Margin = new Padding(3, 4, 3, 4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(634, 322);
            DataGridView1.TabIndex = 35;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.CornflowerBlue;
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
            //BackgroundImage = PMSPlayer_Desktop.Properties.Resources.bgLogin;
            ClientSize = new Size(696, 1049);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(DataGridView1);
            Controls.Add(Label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteProfile";
            Text = "DeleteProfile";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label3;
    }
}