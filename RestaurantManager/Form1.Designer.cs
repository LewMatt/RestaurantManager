﻿
namespace RestaurantManager
{
    partial class Form1
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
            this.lblRestaurantManager = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUtworzKonto = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRestaurantManager
            // 
            this.lblRestaurantManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRestaurantManager.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRestaurantManager.Location = new System.Drawing.Point(0, 0);
            this.lblRestaurantManager.Name = "lblRestaurantManager";
            this.lblRestaurantManager.Size = new System.Drawing.Size(1100, 140);
            this.lblRestaurantManager.TabIndex = 0;
            this.lblRestaurantManager.Text = "Restaurant Manager";
            this.lblRestaurantManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUtworzKonto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnUtworzKonto
            // 
            this.btnUtworzKonto.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzKonto.Location = new System.Drawing.Point(0, 0);
            this.btnUtworzKonto.Name = "btnUtworzKonto";
            this.btnUtworzKonto.Size = new System.Drawing.Size(200, 50);
            this.btnUtworzKonto.TabIndex = 0;
            this.btnUtworzKonto.Text = "Utwórz konto";
            this.btnUtworzKonto.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(1000, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Location = new System.Drawing.Point(371, 239);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(358, 45);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(371, 341);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(358, 45);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Hasło";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(256, 233);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(109, 51);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblHaslo.Location = new System.Drawing.Point(254, 335);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(110, 51);
            this.lblHaslo.TabIndex = 5;
            this.lblHaslo.Text = "Hasło:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.btnLogin.Location = new System.Drawing.Point(425, 480);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRestaurantManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurantManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUtworzKonto;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Button btnLogin;
    }
}

