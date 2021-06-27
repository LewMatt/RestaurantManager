
namespace RestaurantManager
{
    partial class FormZmienEmail
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
            this.lblZmianaEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.btnZmienEmail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZmianaEmail
            // 
            this.lblZmianaEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZmianaEmail.Font = new System.Drawing.Font("Segoe Print", 20.25F);
            this.lblZmianaEmail.Location = new System.Drawing.Point(0, 0);
            this.lblZmianaEmail.Name = "lblZmianaEmail";
            this.lblZmianaEmail.Size = new System.Drawing.Size(1100, 150);
            this.lblZmianaEmail.TabIndex = 2;
            this.lblZmianaEmail.Text = "Zmiana email";
            this.lblZmianaEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(350, 240);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(450, 36);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "Nowy email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHaslo.Location = new System.Drawing.Point(350, 340);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(450, 36);
            this.textBoxHaslo.TabIndex = 5;
            this.textBoxHaslo.Text = "Hasło";
            this.textBoxHaslo.Enter += new System.EventHandler(this.textBoxHaslo_Enter);
            this.textBoxHaslo.Leave += new System.EventHandler(this.textBoxHaslo_Leave);
            // 
            // btnZmienEmail
            // 
            this.btnZmienEmail.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnZmienEmail.Location = new System.Drawing.Point(425, 500);
            this.btnZmienEmail.Name = "btnZmienEmail";
            this.btnZmienEmail.Size = new System.Drawing.Size(250, 60);
            this.btnZmienEmail.TabIndex = 10;
            this.btnZmienEmail.Text = "Zmień email";
            this.btnZmienEmail.UseVisualStyleBackColor = true;
            this.btnZmienEmail.Click += new System.EventHandler(this.btnZmienEmail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 11;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnAnuluj.Location = new System.Drawing.Point(1000, 0);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 0;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // FormZmienEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnZmienEmail);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblZmianaEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmienEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmienEmail";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZmianaEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button btnZmienEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnuluj;
    }
}