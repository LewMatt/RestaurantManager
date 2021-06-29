
namespace RestaurantManager
{
    partial class FormCreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxPowHaslo = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.btnUtworzKonto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnPowrot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnPowrot
            // 
            this.btnPowrot.BackColor = System.Drawing.Color.White;
            this.btnPowrot.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrot.Location = new System.Drawing.Point(1000, 0);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(100, 50);
            this.btnPowrot.TabIndex = 0;
            this.btnPowrot.Text = "Powrót";
            this.btnPowrot.UseVisualStyleBackColor = false;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Location = new System.Drawing.Point(350, 60);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(400, 36);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Login";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHaslo.Location = new System.Drawing.Point(350, 130);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(400, 36);
            this.textBoxHaslo.TabIndex = 2;
            this.textBoxHaslo.Text = "Hasło";
            this.textBoxHaslo.Enter += new System.EventHandler(this.textBoxHaslo_Enter);
            this.textBoxHaslo.Leave += new System.EventHandler(this.textBoxHaslo_Leave);
            // 
            // textBoxPowHaslo
            // 
            this.textBoxPowHaslo.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxPowHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPowHaslo.Location = new System.Drawing.Point(350, 200);
            this.textBoxPowHaslo.Name = "textBoxPowHaslo";
            this.textBoxPowHaslo.Size = new System.Drawing.Size(400, 36);
            this.textBoxPowHaslo.TabIndex = 3;
            this.textBoxPowHaslo.Text = "Powtórz hasło";
            this.textBoxPowHaslo.Enter += new System.EventHandler(this.textBoxPowHaslo_Enter);
            this.textBoxPowHaslo.Leave += new System.EventHandler(this.textBoxPowHaslo_Leave);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxImie.ForeColor = System.Drawing.Color.Gray;
            this.textBoxImie.Location = new System.Drawing.Point(350, 270);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(400, 36);
            this.textBoxImie.TabIndex = 4;
            this.textBoxImie.Text = "Imię";
            this.textBoxImie.Enter += new System.EventHandler(this.textBoxImie_Enter);
            this.textBoxImie.Leave += new System.EventHandler(this.textBoxImie_Leave);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxNazwisko.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNazwisko.Location = new System.Drawing.Point(350, 340);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(400, 36);
            this.textBoxNazwisko.TabIndex = 5;
            this.textBoxNazwisko.Text = "Nazwisko";
            this.textBoxNazwisko.Enter += new System.EventHandler(this.textBoxNazwisko_Enter);
            this.textBoxNazwisko.Leave += new System.EventHandler(this.textBoxNazwisko_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(350, 410);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(400, 36);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.textBoxTelefon.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTelefon.Location = new System.Drawing.Point(350, 480);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(400, 36);
            this.textBoxTelefon.TabIndex = 7;
            this.textBoxTelefon.Text = "Numer telefonu";
            this.textBoxTelefon.Enter += new System.EventHandler(this.textBoxTelefon_Enter);
            this.textBoxTelefon.Leave += new System.EventHandler(this.textBoxTelefon_Leave);
            // 
            // btnUtworzKonto
            // 
            this.btnUtworzKonto.BackColor = System.Drawing.Color.White;
            this.btnUtworzKonto.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzKonto.Location = new System.Drawing.Point(425, 560);
            this.btnUtworzKonto.Name = "btnUtworzKonto";
            this.btnUtworzKonto.Size = new System.Drawing.Size(250, 50);
            this.btnUtworzKonto.TabIndex = 8;
            this.btnUtworzKonto.Text = "Utwórz konto";
            this.btnUtworzKonto.UseVisualStyleBackColor = false;
            this.btnUtworzKonto.Click += new System.EventHandler(this.btnUtworzKonto_Click);
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnUtworzKonto);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxPowHaslo);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateAccount";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxPowHaslo;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Button btnUtworzKonto;
    }
}