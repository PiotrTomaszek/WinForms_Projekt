namespace P4_Projekt
{
    partial class AddingUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingUserForm));
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxPassword2 = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.chckBox = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.BackColor = System.Drawing.Color.Silver;
            this.tBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.tBoxLogin.Location = new System.Drawing.Point(223, 153);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(120, 26);
            this.tBoxLogin.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.BackColor = System.Drawing.Color.Silver;
            this.tBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.tBoxPassword.Location = new System.Drawing.Point(223, 192);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(120, 26);
            this.tBoxPassword.TabIndex = 3;
            this.tBoxPassword.UseSystemPasswordChar = true;
            // 
            // tBoxPassword2
            // 
            this.tBoxPassword2.BackColor = System.Drawing.Color.Silver;
            this.tBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPassword2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxPassword2.ForeColor = System.Drawing.Color.Black;
            this.tBoxPassword2.Location = new System.Drawing.Point(222, 231);
            this.tBoxPassword2.Name = "tBoxPassword2";
            this.tBoxPassword2.Size = new System.Drawing.Size(120, 26);
            this.tBoxPassword2.TabIndex = 4;
            this.tBoxPassword2.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(35, 153);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 23);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login: ";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(35, 192);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password: ";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword2.Location = new System.Drawing.Point(35, 231);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(179, 23);
            this.lblPassword2.TabIndex = 7;
            this.lblPassword2.Text = "Re-type Password: ";
            // 
            // chckBox
            // 
            this.chckBox.AutoSize = true;
            this.chckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chckBox.Location = new System.Drawing.Point(24, 264);
            this.chckBox.Name = "chckBox";
            this.chckBox.Size = new System.Drawing.Size(337, 21);
            this.chckBox.TabIndex = 8;
            this.chckBox.Text = "I accept the Terms Conditions and Privacy Policy.";
            this.chckBox.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Orange;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(115, 296);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(150, 50);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Orange;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(142, 357);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 30);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::P4_Projekt.Properties.Resources.myShop_logo;
            this.pBoxLogo.Location = new System.Drawing.Point(125, 12);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(128, 128);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 11;
            this.pBoxLogo.TabStop = false;
            // 
            // AddingUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.chckBox);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tBoxPassword2);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddingUserForm";
            this.Text = "myShop - Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxPassword2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.CheckBox chckBox;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pBoxLogo;
    }
}