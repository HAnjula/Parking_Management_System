﻿namespace ParkingManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.foreverClose1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelPassword);
            this.panel1.Controls.Add(this.LabelUsername);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtUname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 505);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::ParkingManagementSystem.Properties.Resources.Rectangle_110;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(75, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // foreverClose1
            // 
            this.foreverClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverClose1.BackColor = System.Drawing.Color.White;
            this.foreverClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverClose1.DefaultLocation = true;
            this.foreverClose1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.foreverClose1.Location = new System.Drawing.Point(310, 16);
            this.foreverClose1.Name = "foreverClose1";
            this.foreverClose1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverClose1.Size = new System.Drawing.Size(18, 18);
            this.foreverClose1.TabIndex = 8;
            this.foreverClose1.Text = "foreverClose1";
            this.foreverClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelPassword.Location = new System.Drawing.Point(48, 235);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(82, 20);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Password:";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelUsername.Location = new System.Drawing.Point(48, 158);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(87, 20);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Username:";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(52, 262);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(235, 29);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.White;
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.Location = new System.Drawing.Point(52, 185);
            this.txtUname.Margin = new System.Windows.Forms.Padding(2);
            this.txtUname.Multiline = true;
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(235, 29);
            this.txtUname.TabIndex = 0;
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPassword;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}