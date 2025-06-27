namespace PMSPlayer_Desktop
{
    partial class SearchProfile
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
            btnBack = new Button();
            dgvSearch = new DataGridView();
            txbSearchArea = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.CornflowerBlue;
            btnRefresh.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(522, 320);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(148, 57);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(522, 414);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 54);
            btnBack.TabIndex = 8;
            btnBack.Text = "Previous";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnPrevious_Click;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(64, 208);
            dgvSearch.Margin = new Padding(3, 4, 3, 4);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.RowHeadersWidth = 51;
            dgvSearch.Size = new Size(432, 340);
            dgvSearch.TabIndex = 7;
            // 
            // txbSearchArea
            // 
            txbSearchArea.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSearchArea.Location = new Point(64, 114);
            txbSearchArea.Margin = new Padding(3, 4, 3, 4);
            txbSearchArea.Name = "txbSearchArea";
            txbSearchArea.Size = new Size(418, 47);
            txbSearchArea.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(522, 114);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(139, 47);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // SearchProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(725, 761);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(dgvSearch);
            Controls.Add(txbSearchArea);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchProfile";
            Text = "SearchProfile";
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.DataGridView dgvSearch;
        internal System.Windows.Forms.TextBox txbSearchArea;
        internal System.Windows.Forms.Button btnSearch;
    }
}