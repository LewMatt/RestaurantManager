
namespace RestaurantManager
{
    partial class FormZlozZamowienie
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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.lblZamowienie = new System.Windows.Forms.Label();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxKodPocztowy = new System.Windows.Forms.TextBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.labelUlica = new System.Windows.Forms.Label();
            this.labelKodPocztowy = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.btnZamow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 13;
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
            // lblZamowienie
            // 
            this.lblZamowienie.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZamowienie.Font = new System.Drawing.Font("Segoe Print", 20.25F);
            this.lblZamowienie.Location = new System.Drawing.Point(0, 0);
            this.lblZamowienie.Name = "lblZamowienie";
            this.lblZamowienie.Size = new System.Drawing.Size(1100, 150);
            this.lblZamowienie.TabIndex = 14;
            this.lblZamowienie.Text = "Podaj adres zamówienia";
            this.lblZamowienie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUlica.ForeColor = System.Drawing.Color.Black;
            this.textBoxUlica.Location = new System.Drawing.Point(350, 240);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(450, 36);
            this.textBoxUlica.TabIndex = 15;
            // 
            // textBoxKodPocztowy
            // 
            this.textBoxKodPocztowy.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKodPocztowy.ForeColor = System.Drawing.Color.Black;
            this.textBoxKodPocztowy.Location = new System.Drawing.Point(350, 321);
            this.textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            this.textBoxKodPocztowy.Size = new System.Drawing.Size(450, 36);
            this.textBoxKodPocztowy.TabIndex = 16;
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMiasto.ForeColor = System.Drawing.Color.Black;
            this.textBoxMiasto.Location = new System.Drawing.Point(350, 403);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(450, 36);
            this.textBoxMiasto.TabIndex = 17;
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelUlica.Location = new System.Drawing.Point(270, 240);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(74, 37);
            this.labelUlica.TabIndex = 18;
            this.labelUlica.Text = "Ulica:";
            // 
            // labelKodPocztowy
            // 
            this.labelKodPocztowy.AutoSize = true;
            this.labelKodPocztowy.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelKodPocztowy.Location = new System.Drawing.Point(171, 321);
            this.labelKodPocztowy.Name = "labelKodPocztowy";
            this.labelKodPocztowy.Size = new System.Drawing.Size(173, 37);
            this.labelKodPocztowy.TabIndex = 19;
            this.labelKodPocztowy.Text = "Kod pocztowy:";
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelMiasto.Location = new System.Drawing.Point(252, 403);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(92, 37);
            this.labelMiasto.TabIndex = 20;
            this.labelMiasto.Text = "Miasto:";
            // 
            // btnZamow
            // 
            this.btnZamow.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnZamow.Location = new System.Drawing.Point(425, 500);
            this.btnZamow.Name = "btnZamow";
            this.btnZamow.Size = new System.Drawing.Size(250, 60);
            this.btnZamow.TabIndex = 21;
            this.btnZamow.Text = "Zamów";
            this.btnZamow.UseVisualStyleBackColor = true;
            this.btnZamow.Click += new System.EventHandler(this.btnZamow_Click);
            // 
            // FormZlozZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnZamow);
            this.Controls.Add(this.labelMiasto);
            this.Controls.Add(this.labelKodPocztowy);
            this.Controls.Add(this.labelUlica);
            this.Controls.Add(this.textBoxMiasto);
            this.Controls.Add(this.textBoxKodPocztowy);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.lblZamowienie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZlozZamowienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZlozZamowienie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label lblZamowienie;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.TextBox textBoxKodPocztowy;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.Label labelKodPocztowy;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.Button btnZamow;
    }
}