namespace VballPlayer_Desktop
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
            this.Label3 = new System.Windows.Forms.Label();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Label3.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Navy;
            this.Label3.Location = new System.Drawing.Point(230, 62);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(245, 45);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "CREATE PROFILE";
            // 
            // txbAge
            // 
            this.txbAge.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAge.Location = new System.Drawing.Point(263, 240);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(402, 31);
            this.txbAge.TabIndex = 20;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(263, 183);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(400, 31);
            this.txbName.TabIndex = 19;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Libero",
            "Setter",
            "Blocker",
            "Opposite Spiker",
            "Opposite Hitter",
            "Middle Hitter"});
            this.cmbPosition.Location = new System.Drawing.Point(263, 308);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(402, 32);
            this.cmbPosition.TabIndex = 18;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(133, 308);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(114, 35);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "Position:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(106, 240);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(141, 35);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Player Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(79, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 35);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Player Name: ";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(85, 605);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 45);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(373, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 53);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VballPlayer_Desktop.Properties.Resources.bgLogin;
            this.ClientSize = new System.Drawing.Size(696, 839);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "CreateProfile";
            this.Text = "CreateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

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