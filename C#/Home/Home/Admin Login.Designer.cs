namespace Home
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblUserNameL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPasswordL = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblPasswordL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancell = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtUserNameL = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkShowPassword);
            this.panel1.Controls.Add(this.lblUserNameL);
            this.panel1.Controls.Add(this.txtPasswordL);
            this.panel1.Controls.Add(this.lblPasswordL);
            this.panel1.Controls.Add(this.btnCancell);
            this.panel1.Controls.Add(this.txtUserNameL);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(67, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 610);
            this.panel1.TabIndex = 35;
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowPassword.Location = new System.Drawing.Point(959, 247);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(88, 29);
            this.checkShowPassword.TabIndex = 33;
            this.checkShowPassword.Text = "Show";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // lblUserNameL
            // 
            this.lblUserNameL.AutoSize = true;
            this.lblUserNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameL.Location = new System.Drawing.Point(259, 130);
            this.lblUserNameL.Name = "lblUserNameL";
            this.lblUserNameL.Size = new System.Drawing.Size(182, 38);
            this.lblUserNameL.TabIndex = 28;
            this.lblUserNameL.Text = "UserName";
            // 
            // txtPasswordL
            // 
            this.txtPasswordL.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPasswordL.Location = new System.Drawing.Point(547, 238);
            this.txtPasswordL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordL.Multiline = true;
            this.txtPasswordL.Name = "txtPasswordL";
            this.txtPasswordL.PasswordChar = '*';
            this.txtPasswordL.Size = new System.Drawing.Size(293, 50);
            this.txtPasswordL.TabIndex = 31;
            // 
            // lblPasswordL
            // 
            this.lblPasswordL.AutoSize = true;
            this.lblPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordL.Location = new System.Drawing.Point(259, 238);
            this.lblPasswordL.Name = "lblPasswordL";
            this.lblPasswordL.Size = new System.Drawing.Size(170, 38);
            this.lblPasswordL.TabIndex = 29;
            this.lblPasswordL.Text = "Password";
            // 
            // btnCancell
            // 
            this.btnCancell.ActiveBorderThickness = 1;
            this.btnCancell.ActiveCornerRadius = 20;
            this.btnCancell.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancell.ActiveForecolor = System.Drawing.Color.Black;
            this.btnCancell.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancell.BackgroundImage")));
            this.btnCancell.ButtonText = "Cancel";
            this.btnCancell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCancell.IdleBorderThickness = 1;
            this.btnCancell.IdleCornerRadius = 20;
            this.btnCancell.IdleFillColor = System.Drawing.Color.Black;
            this.btnCancell.IdleForecolor = System.Drawing.Color.White;
            this.btnCancell.IdleLineColor = System.Drawing.Color.White;
            this.btnCancell.Location = new System.Drawing.Point(901, 513);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(181, 41);
            this.btnCancell.TabIndex = 19;
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // txtUserNameL
            // 
            this.txtUserNameL.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUserNameL.Location = new System.Drawing.Point(547, 130);
            this.txtUserNameL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNameL.Multiline = true;
            this.txtUserNameL.Name = "txtUserNameL";
            this.txtUserNameL.Size = new System.Drawing.Size(293, 50);
            this.txtUserNameL.TabIndex = 30;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.White;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Black;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(673, 513);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 41);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(491, 103);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(371, 69);
            this.lblLogin.TabIndex = 34;
            this.lblLogin.Text = "Admin Login";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1245, 90);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 52);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 33;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1367, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserNameL;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPasswordL;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordL;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancell;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUserNameL;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.CheckBox checkShowPassword;
    }
}