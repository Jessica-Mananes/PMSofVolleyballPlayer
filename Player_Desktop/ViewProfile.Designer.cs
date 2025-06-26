namespace VballPlayer_Desktop
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
            DataGridView1 = new DataGridView();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
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
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.CornflowerBlue;
            Label3.Font = new Font("Impact", 28F);
            Label3.ForeColor = Color.Navy;
            Label3.Location = new Point(226, 76);
            Label3.Name = "Label3";
            Label3.Size = new Size(273, 59);
            Label3.TabIndex = 34;
            Label3.Text = "VIEW PROFILE";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(50, 224);
            DataGridView1.Margin = new Padding(3, 4, 3, 4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(614, 451);
            DataGridView1.TabIndex = 33;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(236, 56);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 20);
            Label1.TabIndex = 32;
            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Player_Desktop.Properties.Resources.bgLogin;
            ClientSize = new Size(696, 1049);
            Controls.Add(btnBack);
            Controls.Add(Label3);
            Controls.Add(DataGridView1);
            Controls.Add(Label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewProfile";
            Text = "ViewProfile";
            Load += ViewProfile_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label1;
    }
}