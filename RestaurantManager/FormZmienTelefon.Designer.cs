
namespace RestaurantManager
{
    partial class FormZmienTelefon
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
            this.lblZmianaTel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.btnZmienTel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZmianaTel
            // 
            this.lblZmianaTel.BackColor = System.Drawing.Color.Orange;
            this.lblZmianaTel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZmianaTel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZmianaTel.ForeColor = System.Drawing.Color.White;
            this.lblZmianaTel.Location = new System.Drawing.Point(0, 0);
            this.lblZmianaTel.Name = "lblZmianaTel";
            this.lblZmianaTel.Size = new System.Drawing.Size(1100, 120);
            this.lblZmianaTel.TabIndex = 3;
            this.lblZmianaTel.Text = "Zmiana numeru telefonu";
            this.lblZmianaTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 12;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.White;
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnAnuluj.Location = new System.Drawing.Point(1000, 0);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 0;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTelefon.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTelefon.Location = new System.Drawing.Point(350, 240);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(450, 36);
            this.textBoxTelefon.TabIndex = 13;
            this.textBoxTelefon.Text = "Nowy numer";
            this.textBoxTelefon.Enter += new System.EventHandler(this.textBoxTelefon_Enter);
            this.textBoxTelefon.Leave += new System.EventHandler(this.textBoxTelefon_Leave);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHaslo.Location = new System.Drawing.Point(350, 340);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(450, 36);
            this.textBoxHaslo.TabIndex = 14;
            this.textBoxHaslo.Text = "Hasło";
            this.textBoxHaslo.Enter += new System.EventHandler(this.textBoxHaslo_Enter);
            this.textBoxHaslo.Leave += new System.EventHandler(this.textBoxHaslo_Leave);
            // 
            // btnZmienTel
            // 
            this.btnZmienTel.BackColor = System.Drawing.Color.White;
            this.btnZmienTel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnZmienTel.Location = new System.Drawing.Point(425, 500);
            this.btnZmienTel.Name = "btnZmienTel";
            this.btnZmienTel.Size = new System.Drawing.Size(250, 60);
            this.btnZmienTel.TabIndex = 15;
            this.btnZmienTel.Text = "Zmień numer";
            this.btnZmienTel.UseVisualStyleBackColor = false;
            this.btnZmienTel.Click += new System.EventHandler(this.btnZmienTel_Click);
            // 
            // FormZmienTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnZmienTel);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblZmianaTel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmienTelefon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmienTelefon";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZmianaTel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button btnZmienTel;
    }
}