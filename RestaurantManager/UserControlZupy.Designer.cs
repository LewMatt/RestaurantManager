
namespace RestaurantManager
{
    partial class UserControlZupy
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
            this.lblZupy = new System.Windows.Forms.Label();
            this.listViewZupy = new System.Windows.Forms.ListView();
            this.hNazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIleSztuk = new System.Windows.Forms.Label();
            this.textBoxIleSztuk = new System.Windows.Forms.TextBox();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblZupy
            // 
            this.lblZupy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZupy.Font = new System.Drawing.Font("Segoe Print", 20.25F);
            this.lblZupy.Location = new System.Drawing.Point(0, 0);
            this.lblZupy.Name = "lblZupy";
            this.lblZupy.Size = new System.Drawing.Size(900, 100);
            this.lblZupy.TabIndex = 0;
            this.lblZupy.Text = "Zupy";
            this.lblZupy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewZupy
            // 
            this.listViewZupy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hNazwa,
            this.hCena});
            this.listViewZupy.FullRowSelect = true;
            this.listViewZupy.HideSelection = false;
            this.listViewZupy.Location = new System.Drawing.Point(100, 150);
            this.listViewZupy.Name = "listViewZupy";
            this.listViewZupy.Size = new System.Drawing.Size(405, 300);
            this.listViewZupy.TabIndex = 2;
            this.listViewZupy.UseCompatibleStateImageBehavior = false;
            this.listViewZupy.View = System.Windows.Forms.View.Details;
            // 
            // hNazwa
            // 
            this.hNazwa.Text = "Nazwa";
            this.hNazwa.Width = 320;
            // 
            // hCena
            // 
            this.hCena.Text = "Cena (zł)";
            this.hCena.Width = 80;
            // 
            // lblIleSztuk
            // 
            this.lblIleSztuk.AutoSize = true;
            this.lblIleSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIleSztuk.Location = new System.Drawing.Point(600, 230);
            this.lblIleSztuk.Name = "lblIleSztuk";
            this.lblIleSztuk.Size = new System.Drawing.Size(62, 25);
            this.lblIleSztuk.TabIndex = 4;
            this.lblIleSztuk.Text = "Ilość:";
            // 
            // textBoxIleSztuk
            // 
            this.textBoxIleSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIleSztuk.Location = new System.Drawing.Point(700, 227);
            this.textBoxIleSztuk.Name = "textBoxIleSztuk";
            this.textBoxIleSztuk.Size = new System.Drawing.Size(100, 31);
            this.textBoxIleSztuk.TabIndex = 5;
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajDoKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDoKoszyka.ForeColor = System.Drawing.Color.White;
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(600, 320);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(200, 50);
            this.btnDodajDoKoszyka.TabIndex = 6;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = false;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
            // 
            // UserControlZupy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.textBoxIleSztuk);
            this.Controls.Add(this.lblIleSztuk);
            this.Controls.Add(this.listViewZupy);
            this.Controls.Add(this.lblZupy);
            this.Name = "UserControlZupy";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZupy;
        private System.Windows.Forms.ColumnHeader hNazwa;
        private System.Windows.Forms.ColumnHeader hCena;
        private System.Windows.Forms.Label lblIleSztuk;
        private System.Windows.Forms.TextBox textBoxIleSztuk;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
        public System.Windows.Forms.ListView listViewZupy;
    }
}
