
namespace RestaurantManager
{
    partial class FormZmienHaslo
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
            this.lblZmianaHasla = new System.Windows.Forms.Label();
            this.textBoxAktHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHasloPow = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZmienHaslo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZmianaHasla
            // 
            this.lblZmianaHasla.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZmianaHasla.Font = new System.Drawing.Font("Segoe Print", 20.25F);
            this.lblZmianaHasla.Location = new System.Drawing.Point(0, 0);
            this.lblZmianaHasla.Name = "lblZmianaHasla";
            this.lblZmianaHasla.Size = new System.Drawing.Size(1100, 150);
            this.lblZmianaHasla.TabIndex = 1;
            this.lblZmianaHasla.Text = "Zmiana hasła";
            this.lblZmianaHasla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAktHaslo
            // 
            this.textBoxAktHaslo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAktHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAktHaslo.Location = new System.Drawing.Point(325, 200);
            this.textBoxAktHaslo.Name = "textBoxAktHaslo";
            this.textBoxAktHaslo.Size = new System.Drawing.Size(450, 36);
            this.textBoxAktHaslo.TabIndex = 5;
            this.textBoxAktHaslo.Text = "Aktualne hasło";
            this.textBoxAktHaslo.Enter += new System.EventHandler(this.textBoxAktHaslo_Enter);
            this.textBoxAktHaslo.Leave += new System.EventHandler(this.textBoxAktHaslo_Leave);
            // 
            // textBoxNoweHaslo
            // 
            this.textBoxNoweHaslo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoweHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoweHaslo.Location = new System.Drawing.Point(325, 290);
            this.textBoxNoweHaslo.Name = "textBoxNoweHaslo";
            this.textBoxNoweHaslo.Size = new System.Drawing.Size(450, 36);
            this.textBoxNoweHaslo.TabIndex = 6;
            this.textBoxNoweHaslo.Text = "Nowe hasło";
            this.textBoxNoweHaslo.Enter += new System.EventHandler(this.textBoxNoweHaslo_Enter);
            this.textBoxNoweHaslo.Leave += new System.EventHandler(this.textBoxNoweHaslo_Leave);
            // 
            // textBoxNoweHasloPow
            // 
            this.textBoxNoweHasloPow.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoweHasloPow.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoweHasloPow.Location = new System.Drawing.Point(325, 380);
            this.textBoxNoweHasloPow.Name = "textBoxNoweHasloPow";
            this.textBoxNoweHasloPow.Size = new System.Drawing.Size(450, 36);
            this.textBoxNoweHasloPow.TabIndex = 7;
            this.textBoxNoweHasloPow.Text = "Powtórz nowe hasło";
            this.textBoxNoweHasloPow.Enter += new System.EventHandler(this.textBoxNoweHasloPow_Enter);
            this.textBoxNoweHasloPow.Leave += new System.EventHandler(this.textBoxNoweHasloPow_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 8;
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
            // btnZmienHaslo
            // 
            this.btnZmienHaslo.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnZmienHaslo.Location = new System.Drawing.Point(425, 500);
            this.btnZmienHaslo.Name = "btnZmienHaslo";
            this.btnZmienHaslo.Size = new System.Drawing.Size(250, 60);
            this.btnZmienHaslo.TabIndex = 9;
            this.btnZmienHaslo.Text = "Zmień hasło";
            this.btnZmienHaslo.UseVisualStyleBackColor = true;
            this.btnZmienHaslo.Click += new System.EventHandler(this.btnZmienHaslo_Click);
            // 
            // FormZmienHaslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnZmienHaslo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNoweHasloPow);
            this.Controls.Add(this.textBoxNoweHaslo);
            this.Controls.Add(this.textBoxAktHaslo);
            this.Controls.Add(this.lblZmianaHasla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmienHaslo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmienHaslo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZmianaHasla;
        private System.Windows.Forms.TextBox textBoxAktHaslo;
        private System.Windows.Forms.TextBox textBoxNoweHaslo;
        private System.Windows.Forms.TextBox textBoxNoweHasloPow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZmienHaslo;
    }
}