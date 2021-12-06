
namespace MilitaryEquipmentManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTroop = new System.Windows.Forms.Button();
            this.txtadminpass = new System.Windows.Forms.TextBox();
            this.txtadminuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLogin = new System.Windows.Forms.Button();
            this.txttrooppass = new System.Windows.Forms.TextBox();
            this.txttroopuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.troopLogin = new System.Windows.Forms.Button();
            this.paneltroop = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.paneltroop.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.Image = global::MilitaryEquipmentManagementSystem.Properties.Resources.admin;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(23, 122);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(224, 128);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTroop
            // 
            this.btnTroop.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTroop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTroop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTroop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTroop.Image = global::MilitaryEquipmentManagementSystem.Properties.Resources.troop;
            this.btnTroop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroop.Location = new System.Drawing.Point(23, 431);
            this.btnTroop.Name = "btnTroop";
            this.btnTroop.Size = new System.Drawing.Size(224, 128);
            this.btnTroop.TabIndex = 1;
            this.btnTroop.Text = "Troop";
            this.btnTroop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroop.UseVisualStyleBackColor = false;
            this.btnTroop.Click += new System.EventHandler(this.btnTroop_Click);
            // 
            // txtadminpass
            // 
            this.txtadminpass.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminpass.Location = new System.Drawing.Point(190, 139);
            this.txtadminpass.Name = "txtadminpass";
            this.txtadminpass.Size = new System.Drawing.Size(175, 25);
            this.txtadminpass.TabIndex = 4;
            // 
            // txtadminuser
            // 
            this.txtadminuser.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminuser.Location = new System.Drawing.Point(190, 88);
            this.txtadminuser.Name = "txtadminuser";
            this.txtadminuser.Size = new System.Drawing.Size(175, 25);
            this.txtadminuser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(99, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(99, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // adminLogin
            // 
            this.adminLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.adminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminLogin.Location = new System.Drawing.Point(172, 205);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(95, 32);
            this.adminLogin.TabIndex = 0;
            this.adminLogin.Text = "Login";
            this.adminLogin.UseVisualStyleBackColor = false;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // txttrooppass
            // 
            this.txttrooppass.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrooppass.Location = new System.Drawing.Point(190, 138);
            this.txttrooppass.Name = "txttrooppass";
            this.txttrooppass.Size = new System.Drawing.Size(175, 25);
            this.txttrooppass.TabIndex = 4;
            // 
            // txttroopuser
            // 
            this.txttroopuser.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroopuser.Location = new System.Drawing.Point(190, 81);
            this.txttroopuser.Name = "txttroopuser";
            this.txttroopuser.Size = new System.Drawing.Size(175, 25);
            this.txttroopuser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(101, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(101, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Troop ID";
            // 
            // troopLogin
            // 
            this.troopLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.troopLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.troopLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.troopLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troopLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.troopLogin.Location = new System.Drawing.Point(171, 213);
            this.troopLogin.Name = "troopLogin";
            this.troopLogin.Size = new System.Drawing.Size(95, 32);
            this.troopLogin.TabIndex = 0;
            this.troopLogin.Text = "Login";
            this.troopLogin.UseVisualStyleBackColor = false;
            this.troopLogin.Click += new System.EventHandler(this.troopLogin_Click);
            // 
            // paneltroop
            // 
            this.paneltroop.BackColor = System.Drawing.Color.Wheat;
            this.paneltroop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltroop.Controls.Add(this.txttrooppass);
            this.paneltroop.Controls.Add(this.txttroopuser);
            this.paneltroop.Controls.Add(this.troopLogin);
            this.paneltroop.Controls.Add(this.label3);
            this.paneltroop.Controls.Add(this.label4);
            this.paneltroop.Location = new System.Drawing.Point(301, 350);
            this.paneltroop.Name = "paneltroop";
            this.paneltroop.Size = new System.Drawing.Size(462, 301);
            this.paneltroop.TabIndex = 5;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Wheat;
            this.panelAdmin.Controls.Add(this.txtadminpass);
            this.panelAdmin.Controls.Add(this.txtadminuser);
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Controls.Add(this.label2);
            this.panelAdmin.Controls.Add(this.adminLogin);
            this.panelAdmin.Location = new System.Drawing.Point(301, 34);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(462, 301);
            this.panelAdmin.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilitaryEquipmentManagementSystem.Properties.Resources.cover1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 672);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.paneltroop);
            this.Controls.Add(this.btnTroop);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Military Equipment Management System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.paneltroop.ResumeLayout(false);
            this.paneltroop.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTroop;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.TextBox txtadminpass;
        private System.Windows.Forms.TextBox txtadminuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttrooppass;
        private System.Windows.Forms.TextBox txttroopuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button troopLogin;
        private System.Windows.Forms.Panel paneltroop;
        private System.Windows.Forms.Panel panelAdmin;
    }
}

