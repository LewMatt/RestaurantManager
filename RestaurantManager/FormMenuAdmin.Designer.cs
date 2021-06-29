
namespace RestaurantManager
{
    partial class FormMenuAdmin
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
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.lblPanelAdmin = new System.Windows.Forms.Label();
            this.listViewZamowienia = new System.Windows.Forms.ListView();
            this.hIDZamowienia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIDUzytk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProdukty = new System.Windows.Forms.ListView();
            this.hNazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazw = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblUl = new System.Windows.Forms.Label();
            this.lblKodp = new System.Windows.Forms.Label();
            this.lblMiasto = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.labelKodPocztowy = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.btnZrealizuj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnWyloguj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.BackColor = System.Drawing.Color.White;
            this.btnWyloguj.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyloguj.Location = new System.Drawing.Point(1000, 0);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(100, 50);
            this.btnWyloguj.TabIndex = 0;
            this.btnWyloguj.Text = "Wyloguj";
            this.btnWyloguj.UseVisualStyleBackColor = false;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // lblPanelAdmin
            // 
            this.lblPanelAdmin.BackColor = System.Drawing.Color.Orange;
            this.lblPanelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanelAdmin.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPanelAdmin.ForeColor = System.Drawing.Color.White;
            this.lblPanelAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblPanelAdmin.Name = "lblPanelAdmin";
            this.lblPanelAdmin.Size = new System.Drawing.Size(1100, 100);
            this.lblPanelAdmin.TabIndex = 1;
            this.lblPanelAdmin.Text = "Panel restauracji";
            this.lblPanelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewZamowienia
            // 
            this.listViewZamowienia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIDZamowienia,
            this.hIDUzytk,
            this.hPrice});
            this.listViewZamowienia.FullRowSelect = true;
            this.listViewZamowienia.HideSelection = false;
            this.listViewZamowienia.Location = new System.Drawing.Point(108, 185);
            this.listViewZamowienia.Name = "listViewZamowienia";
            this.listViewZamowienia.Size = new System.Drawing.Size(248, 274);
            this.listViewZamowienia.TabIndex = 2;
            this.listViewZamowienia.UseCompatibleStateImageBehavior = false;
            this.listViewZamowienia.View = System.Windows.Forms.View.Details;
            // 
            // hIDZamowienia
            // 
            this.hIDZamowienia.Text = "ID Zamówienia";
            this.hIDZamowienia.Width = 87;
            // 
            // hIDUzytk
            // 
            this.hIDUzytk.Text = "ID Klienta";
            this.hIDUzytk.Width = 92;
            // 
            // hPrice
            // 
            this.hPrice.Text = "Cena ";
            // 
            // listViewProdukty
            // 
            this.listViewProdukty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hNazwa,
            this.hIlosc});
            this.listViewProdukty.FullRowSelect = true;
            this.listViewProdukty.HideSelection = false;
            this.listViewProdukty.Location = new System.Drawing.Point(425, 185);
            this.listViewProdukty.Name = "listViewProdukty";
            this.listViewProdukty.Size = new System.Drawing.Size(248, 274);
            this.listViewProdukty.TabIndex = 3;
            this.listViewProdukty.UseCompatibleStateImageBehavior = false;
            this.listViewProdukty.View = System.Windows.Forms.View.Details;
            // 
            // hNazwa
            // 
            this.hNazwa.Text = "Nazwa";
            this.hNazwa.Width = 168;
            // 
            // hIlosc
            // 
            this.hIlosc.Text = "Ilość";
            this.hIlosc.Width = 75;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(784, 185);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(63, 33);
            this.lblImie.TabIndex = 4;
            this.lblImie.Text = "Imię:";
            // 
            // lblNazw
            // 
            this.lblNazw.AutoSize = true;
            this.lblNazw.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazw.Location = new System.Drawing.Point(737, 237);
            this.lblNazw.Name = "lblNazw";
            this.lblNazw.Size = new System.Drawing.Size(110, 33);
            this.lblNazw.TabIndex = 5;
            this.lblNazw.Text = "Nazwisko:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTel.Location = new System.Drawing.Point(757, 286);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(90, 33);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Telefon:";
            // 
            // lblUl
            // 
            this.lblUl.AutoSize = true;
            this.lblUl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUl.Location = new System.Drawing.Point(779, 333);
            this.lblUl.Name = "lblUl";
            this.lblUl.Size = new System.Drawing.Size(68, 33);
            this.lblUl.TabIndex = 7;
            this.lblUl.Text = "Ulica:";
            // 
            // lblKodp
            // 
            this.lblKodp.AutoSize = true;
            this.lblKodp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodp.Location = new System.Drawing.Point(689, 379);
            this.lblKodp.Name = "lblKodp";
            this.lblKodp.Size = new System.Drawing.Size(158, 33);
            this.lblKodp.TabIndex = 8;
            this.lblKodp.Text = "Kod pocztowy:";
            // 
            // lblMiasto
            // 
            this.lblMiasto.AutoSize = true;
            this.lblMiasto.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiasto.Location = new System.Drawing.Point(763, 426);
            this.lblMiasto.Name = "lblMiasto";
            this.lblMiasto.Size = new System.Drawing.Size(84, 33);
            this.lblMiasto.TabIndex = 9;
            this.lblMiasto.Text = "Miasto:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(853, 185);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(58, 33);
            this.labelImie.TabIndex = 10;
            this.labelImie.Text = "brak";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwisko.Location = new System.Drawing.Point(853, 237);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(58, 33);
            this.labelNazwisko.TabIndex = 11;
            this.labelNazwisko.Text = "brak";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTelefon.Location = new System.Drawing.Point(853, 286);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(58, 33);
            this.labelTelefon.TabIndex = 12;
            this.labelTelefon.Text = "brak";
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUlica.Location = new System.Drawing.Point(853, 333);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(58, 33);
            this.labelUlica.TabIndex = 13;
            this.labelUlica.Text = "brak";
            // 
            // labelKodPocztowy
            // 
            this.labelKodPocztowy.AutoSize = true;
            this.labelKodPocztowy.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKodPocztowy.Location = new System.Drawing.Point(853, 379);
            this.labelKodPocztowy.Name = "labelKodPocztowy";
            this.labelKodPocztowy.Size = new System.Drawing.Size(58, 33);
            this.labelKodPocztowy.TabIndex = 14;
            this.labelKodPocztowy.Text = "brak";
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.Location = new System.Drawing.Point(853, 426);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(58, 33);
            this.labelMiasto.TabIndex = 15;
            this.labelMiasto.Text = "brak";
            // 
            // btnPokaz
            // 
            this.btnPokaz.BackColor = System.Drawing.Color.White;
            this.btnPokaz.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokaz.Location = new System.Drawing.Point(279, 541);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(200, 50);
            this.btnPokaz.TabIndex = 16;
            this.btnPokaz.Text = "Pokaż zamówienie";
            this.btnPokaz.UseVisualStyleBackColor = false;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // btnZrealizuj
            // 
            this.btnZrealizuj.BackColor = System.Drawing.Color.White;
            this.btnZrealizuj.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZrealizuj.Location = new System.Drawing.Point(590, 541);
            this.btnZrealizuj.Name = "btnZrealizuj";
            this.btnZrealizuj.Size = new System.Drawing.Size(200, 50);
            this.btnZrealizuj.TabIndex = 17;
            this.btnZrealizuj.Text = "Zrealizuj zamówienie";
            this.btnZrealizuj.UseVisualStyleBackColor = false;
            this.btnZrealizuj.Click += new System.EventHandler(this.btnZrealizuj_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnZrealizuj);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.labelMiasto);
            this.Controls.Add(this.labelKodPocztowy);
            this.Controls.Add(this.labelUlica);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.lblMiasto);
            this.Controls.Add(this.lblKodp);
            this.Controls.Add(this.lblUl);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNazw);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.listViewProdukty);
            this.Controls.Add(this.listViewZamowienia);
            this.Controls.Add(this.lblPanelAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Label lblPanelAdmin;
        private System.Windows.Forms.ColumnHeader hIDZamowienia;
        private System.Windows.Forms.ColumnHeader hIDUzytk;
        private System.Windows.Forms.ColumnHeader hPrice;
        private System.Windows.Forms.ColumnHeader hNazwa;
        private System.Windows.Forms.ColumnHeader hIlosc;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazw;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblUl;
        private System.Windows.Forms.Label lblKodp;
        private System.Windows.Forms.Label lblMiasto;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.Label labelKodPocztowy;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.Button btnZrealizuj;
        public System.Windows.Forms.ListView listViewZamowienia;
        public System.Windows.Forms.ListView listViewProdukty;
    }
}