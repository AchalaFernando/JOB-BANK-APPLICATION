namespace Home
{
    partial class DisplayApplicationDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayApplicationDetails));
            this.dgViewApplicationDisplay = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDisplayApplication = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblSignUp = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewApplicationDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewApplicationDisplay
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgViewApplicationDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgViewApplicationDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgViewApplicationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewApplicationDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewApplicationDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgViewApplicationDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewApplicationDisplay.DoubleBuffered = true;
            this.dgViewApplicationDisplay.EnableHeadersVisualStyles = false;
            this.dgViewApplicationDisplay.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgViewApplicationDisplay.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgViewApplicationDisplay.Location = new System.Drawing.Point(205, 138);
            this.dgViewApplicationDisplay.Name = "dgViewApplicationDisplay";
            this.dgViewApplicationDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewApplicationDisplay.RowTemplate.Height = 24;
            this.dgViewApplicationDisplay.Size = new System.Drawing.Size(934, 547);
            this.dgViewApplicationDisplay.TabIndex = 0;
            // 
            // btnDisplayApplication
            // 
            this.btnDisplayApplication.ActiveBorderThickness = 1;
            this.btnDisplayApplication.ActiveCornerRadius = 20;
            this.btnDisplayApplication.ActiveFillColor = System.Drawing.Color.White;
            this.btnDisplayApplication.ActiveForecolor = System.Drawing.Color.Black;
            this.btnDisplayApplication.ActiveLineColor = System.Drawing.Color.White;
            this.btnDisplayApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDisplayApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayApplication.BackgroundImage")));
            this.btnDisplayApplication.ButtonText = "Application Details";
            this.btnDisplayApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayApplication.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayApplication.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDisplayApplication.IdleBorderThickness = 1;
            this.btnDisplayApplication.IdleCornerRadius = 20;
            this.btnDisplayApplication.IdleFillColor = System.Drawing.Color.Black;
            this.btnDisplayApplication.IdleForecolor = System.Drawing.Color.White;
            this.btnDisplayApplication.IdleLineColor = System.Drawing.Color.White;
            this.btnDisplayApplication.Location = new System.Drawing.Point(910, 750);
            this.btnDisplayApplication.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisplayApplication.Name = "btnDisplayApplication";
            this.btnDisplayApplication.Size = new System.Drawing.Size(248, 41);
            this.btnDisplayApplication.TabIndex = 9;
            this.btnDisplayApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDisplayApplication.Click += new System.EventHandler(this.btnDisplayApplication_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Back";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(62, 750);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(194, 41);
            this.bunifuThinButton21.TabIndex = 10;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(474, 35);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(418, 69);
            this.lblSignUp.TabIndex = 42;
            this.lblSignUp.Text = "All Application";
            // 
            // DisplayApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1376, 843);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnDisplayApplication);
            this.Controls.Add(this.dgViewApplicationDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayApplicationDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewApplicationDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewApplicationDisplay;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDisplayApplication;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSignUp;
    }
}