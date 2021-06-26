
namespace RestaurantManager
{
    partial class UserControlPizza
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPizza = new System.Windows.Forms.Label();
            this.listViewPizza = new System.Windows.Forms.ListView();
            this.hNazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPizza
            // 
            this.lblPizza.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPizza.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPizza.Location = new System.Drawing.Point(0, 0);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(900, 100);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizza";
            this.lblPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewPizza
            // 
            this.listViewPizza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hNazwa,
            this.hOpis,
            this.hCena30,
            this.hCena40,
            this.hCena50});
            this.listViewPizza.HideSelection = false;
            this.listViewPizza.Location = new System.Drawing.Point(100, 150);
            this.listViewPizza.Name = "listViewPizza";
            this.listViewPizza.Size = new System.Drawing.Size(500, 300);
            this.listViewPizza.TabIndex = 1;
            this.listViewPizza.UseCompatibleStateImageBehavior = false;
            this.listViewPizza.View = System.Windows.Forms.View.Details;
            // 
            // hNazwa
            // 
            this.hNazwa.Text = "Nazwa";
            // 
            // hOpis
            // 
            this.hOpis.Text = "Opis";
            this.hOpis.Width = 220;
            // 
            // hCena30
            // 
            this.hCena30.Text = "Cena 30cm";
            this.hCena30.Width = 70;
            // 
            // hCena40
            // 
            this.hCena40.Text = "Cena 40cm";
            this.hCena40.Width = 70;
            // 
            // hCena50
            // 
            this.hCena50.Text = "Cena 50cm";
            this.hCena50.Width = 70;
            // 
            // lblIleSztuk
            // 
            this.lblIleSztuk.AutoSize = true;
            this.lblIleSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIleSztuk.Location = new System.Drawing.Point(650, 230);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(62, 25);
            this.lblIleSztuk.TabIndex = 3;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIleSztuk.Location = new System.Drawing.Point(720, 227);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 31);
            this.textBoxIleSztuk.TabIndex = 4;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajDoKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDoKoszyka.ForeColor = System.Drawing.Color.White;
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(650, 320);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(200, 50);
            this.btnDodajDoKoszyka.TabIndex = 5;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = false;
            // 
            // UserControlPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewPizza);
            this.Controls.Add(this.lblPizza);
            this.Name = "UserControlPizza";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.ListView listViewPizza;
        private System.Windows.Forms.ColumnHeader hNazwa;
        private System.Windows.Forms.ColumnHeader hOpis;
        private System.Windows.Forms.ColumnHeader hCena30;
        private System.Windows.Forms.ColumnHeader hCena40;
        private System.Windows.Forms.ColumnHeader hCena50;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
    }
}
