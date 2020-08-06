namespace P4_Projekt
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnProfle = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.shoppingUserControl1 = new P4_Projekt.UserControls.ShoppingUserControl();
            this.infoUserControl1 = new P4_Projekt.UserControls.InfoUserControl();
            this.historyUserControl1 = new P4_Projekt.UserControls.HistoryUserControl();
            this.profileUserControl1 = new P4_Projekt.UserControls.ProfileUserControl();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.pnlMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.Moccasin;
            this.pnlSideMenu.Controls.Add(this.lblHours);
            this.pnlSideMenu.Controls.Add(this.lblTime);
            this.pnlSideMenu.Controls.Add(this.btnLogOut);
            this.pnlSideMenu.Controls.Add(this.btnInfo);
            this.pnlSideMenu.Controls.Add(this.btnProfle);
            this.pnlSideMenu.Controls.Add(this.btnHistory);
            this.pnlSideMenu.Controls.Add(this.btnShopping);
            this.pnlSideMenu.Controls.Add(this.pBoxLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(150, 611);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.Transparent;
            this.lblHours.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHours.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHours.ForeColor = System.Drawing.Color.Black;
            this.lblHours.Location = new System.Drawing.Point(0, 568);
            this.lblHours.Name = "lblHours";
            this.lblHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHours.Size = new System.Drawing.Size(67, 24);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "Hours";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(0, 592);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(44, 19);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Date";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Orange;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 390);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 60);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Orange;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnInfo.FlatAppearance.BorderSize = 2;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(0, 330);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(150, 60);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnProfle
            // 
            this.btnProfle.BackColor = System.Drawing.Color.Orange;
            this.btnProfle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfle.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnProfle.FlatAppearance.BorderSize = 2;
            this.btnProfle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfle.ForeColor = System.Drawing.Color.White;
            this.btnProfle.Location = new System.Drawing.Point(0, 270);
            this.btnProfle.Name = "btnProfle";
            this.btnProfle.Size = new System.Drawing.Size(150, 60);
            this.btnProfle.TabIndex = 3;
            this.btnProfle.Text = "Profile";
            this.btnProfle.UseVisualStyleBackColor = false;
            this.btnProfle.Click += new System.EventHandler(this.btnProfle_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Orange;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnHistory.FlatAppearance.BorderSize = 2;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(0, 210);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(150, 60);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.BackColor = System.Drawing.Color.Orange;
            this.btnShopping.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShopping.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btnShopping.FlatAppearance.BorderSize = 2;
            this.btnShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopping.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShopping.ForeColor = System.Drawing.Color.White;
            this.btnShopping.Location = new System.Drawing.Point(0, 150);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(150, 60);
            this.btnShopping.TabIndex = 1;
            this.btnShopping.Text = "Shopping";
            this.btnShopping.UseVisualStyleBackColor = false;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBoxLogo.Image = global::P4_Projekt.Properties.Resources.myShop_logo;
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            this.pBoxLogo.Click += new System.EventHandler(this.pBoxLogo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.BackColor = System.Drawing.Color.Moccasin;
            this.pnlMainForm.Controls.Add(this.shoppingUserControl1);
            this.pnlMainForm.Controls.Add(this.infoUserControl1);
            this.pnlMainForm.Controls.Add(this.historyUserControl1);
            this.pnlMainForm.Controls.Add(this.profileUserControl1);
            this.pnlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainForm.Location = new System.Drawing.Point(150, 0);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(909, 611);
            this.pnlMainForm.TabIndex = 1;
            // 
            // shoppingUserControl1
            // 
            this.shoppingUserControl1.BackColor = System.Drawing.Color.Moccasin;
            this.shoppingUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingUserControl1.Location = new System.Drawing.Point(0, 0);
            this.shoppingUserControl1.MinimumSize = new System.Drawing.Size(879, 512);
            this.shoppingUserControl1.Name = "shoppingUserControl1";
            this.shoppingUserControl1.Size = new System.Drawing.Size(909, 611);
            this.shoppingUserControl1.TabIndex = 3;
            // 
            // infoUserControl1
            // 
            this.infoUserControl1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.infoUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.infoUserControl1.Name = "infoUserControl1";
            this.infoUserControl1.Size = new System.Drawing.Size(909, 611);
            this.infoUserControl1.TabIndex = 2;
            // 
            // historyUserControl1
            // 
            this.historyUserControl1.AutoScroll = true;
            this.historyUserControl1.AutoSize = true;
            this.historyUserControl1.BackColor = System.Drawing.Color.Orange;
            this.historyUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyUserControl1.Location = new System.Drawing.Point(0, 0);
            this.historyUserControl1.MinimumSize = new System.Drawing.Size(896, 511);
            this.historyUserControl1.Name = "historyUserControl1";
            this.historyUserControl1.Size = new System.Drawing.Size(909, 611);
            this.historyUserControl1.TabIndex = 1;
            // 
            // profileUserControl1
            // 
            this.profileUserControl1.BackColor = System.Drawing.Color.SlateGray;
            this.profileUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileUserControl1.Location = new System.Drawing.Point(0, 0);
            this.profileUserControl1.MinimumSize = new System.Drawing.Size(896, 511);
            this.profileUserControl1.Name = "profileUserControl1";
            this.profileUserControl1.Size = new System.Drawing.Size(909, 611);
            this.profileUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 611);
            this.Controls.Add(this.pnlMainForm);
            this.Controls.Add(this.pnlSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1075, 650);
            this.Name = "MainForm";
            this.Text = "myShop - Main";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.pnlMainForm.ResumeLayout(false);
            this.pnlMainForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnProfle;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMainForm;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblTime;
        private UserControls.ProfileUserControl profileUserControl1;
        private UserControls.HistoryUserControl historyUserControl1;
        private UserControls.InfoUserControl infoUserControl1;
        private UserControls.ShoppingUserControl shoppingUserControl1;
    }
}