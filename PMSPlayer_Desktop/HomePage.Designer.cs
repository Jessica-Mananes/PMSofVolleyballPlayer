namespace PMSPlayer_Desktop
{
    partial class HomePage
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
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnView = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(201, 621);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(303, 69);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search Profile";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.CornflowerBlue;
            btnDelete.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(201, 491);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(303, 74);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Profile";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(201, 200);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(303, 76);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit Profile";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.CornflowerBlue;
            btnView.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.Black;
            btnView.Location = new Point(201, 343);
            btnView.Margin = new Padding(4, 5, 4, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(303, 75);
            btnView.TabIndex = 6;
            btnView.Text = "View Profile";
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.CornflowerBlue;
            btnCreate.Font = new Font("Microsoft Himalaya", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(201, 66);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(303, 72);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create Profile";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PMSPlayer_Desktop.Properties.Resources.bgLogin;
            ClientSize = new Size(696, 1049);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(btnCreate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.Button btnCreate;
    }
}