namespace VballPlayer_Desktop
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 45);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(21, 513);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(793, 239);
            this.dgvData.TabIndex = 43;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(326, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 52);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save Profile\r\n\r\n";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txbAge
            // 
            this.txbAge.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAge.Location = new System.Drawing.Point(245, 204);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(400, 28);
            this.txbAge.TabIndex = 37;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(245, 110);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(400, 28);
            this.txbName.TabIndex = 36;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Libero",
            "Setter",
            "Blocker",
            "Opposite Spiker",
            "Opposite Hitter"});
            this.cmbPosition.Location = new System.Drawing.Point(245, 284);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(402, 29);
            this.cmbPosition.TabIndex = 35;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(55, 283);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(95, 28);
            this.lblPosition.TabIndex = 33;
            this.lblPosition.Text = "Position:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(55, 192);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(53, 28);
            this.lblAge.TabIndex = 32;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(55, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 28);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Player Name: ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(271, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(165, 37);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "EDIT PROFILE";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 780);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Label3);
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}