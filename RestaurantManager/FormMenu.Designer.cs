
namespace RestaurantManager
{
    partial class FormMenu
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
            this.btnNapoje = new System.Windows.Forms.Button();
            this.btnPrzekaski = new System.Windows.Forms.Button();
            this.btnZupy = new System.Windows.Forms.Button();
            this.btnDaniaGlowne = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnDanieDnia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKoszyk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMojeDane = new System.Windows.Forms.Button();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.userControlMojeDane1 = new RestaurantManager.UserControlMojeDane();
            this.userControlKoszyk1 = new RestaurantManager.UserControlKoszyk();
            this.userControlNapoje1 = new RestaurantManager.UserControlNapoje();
            this.userControlPrzekaski1 = new RestaurantManager.UserControlPrzekaski();
            this.userControlZupy1 = new RestaurantManager.UserControlZupy();
            this.userControlDaniaGlowne1 = new RestaurantManager.UserControlDaniaGlowne();
            this.userControlPizza1 = new RestaurantManager.UserControlPizza();
            this.userControlDanieDnia1 = new RestaurantManager.UserControlDanieDnia();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnNapoje);
            this.panel1.Controls.Add(this.btnPrzekaski);
            this.panel1.Controls.Add(this.btnZupy);
            this.panel1.Controls.Add(this.btnDaniaGlowne);
            this.panel1.Controls.Add(this.btnPizza);
            this.panel1.Controls.Add(this.btnDanieDnia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            // 
            // btnNapoje
            // 
            this.btnNapoje.BackColor = System.Drawing.Color.White;
            this.btnNapoje.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnNapoje.Location = new System.Drawing.Point(0, 380);
            this.btnNapoje.Name = "btnNapoje";
            this.btnNapoje.Size = new System.Drawing.Size(200, 70);
            this.btnNapoje.TabIndex = 5;
            this.btnNapoje.Text = "Napoje";
            this.btnNapoje.UseVisualStyleBackColor = false;
            this.btnNapoje.Click += new System.EventHandler(this.btnNapoje_Click);
            // 
            // btnPrzekaski
            // 
            this.btnPrzekaski.BackColor = System.Drawing.Color.White;
            this.btnPrzekaski.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnPrzekaski.Location = new System.Drawing.Point(0, 304);
            this.btnPrzekaski.Name = "btnPrzekaski";
            this.btnPrzekaski.Size = new System.Drawing.Size(200, 70);
            this.btnPrzekaski.TabIndex = 4;
            this.btnPrzekaski.Text = "Przekąski";
            this.btnPrzekaski.UseVisualStyleBackColor = false;
            this.btnPrzekaski.Click += new System.EventHandler(this.btnPrzekaski_Click);
            // 
            // btnZupy
            // 
            this.btnZupy.BackColor = System.Drawing.Color.White;
            this.btnZupy.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnZupy.Location = new System.Drawing.Point(0, 228);
            this.btnZupy.Name = "btnZupy";
            this.btnZupy.Size = new System.Drawing.Size(200, 70);
            this.btnZupy.TabIndex = 3;
            this.btnZupy.Text = "Zupy";
            this.btnZupy.UseVisualStyleBackColor = false;
            this.btnZupy.Click += new System.EventHandler(this.btnZupy_Click);
            // 
            // btnDaniaGlowne
            // 
            this.btnDaniaGlowne.BackColor = System.Drawing.Color.White;
            this.btnDaniaGlowne.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnDaniaGlowne.Location = new System.Drawing.Point(0, 152);
            this.btnDaniaGlowne.Name = "btnDaniaGlowne";
            this.btnDaniaGlowne.Size = new System.Drawing.Size(200, 70);
            this.btnDaniaGlowne.TabIndex = 2;
            this.btnDaniaGlowne.Text = "Dania główne";
            this.btnDaniaGlowne.UseVisualStyleBackColor = false;
            this.btnDaniaGlowne.Click += new System.EventHandler(this.btnDaniaGlowne_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.Color.White;
            this.btnPizza.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnPizza.Location = new System.Drawing.Point(0, 76);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(200, 70);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnDanieDnia
            // 
            this.btnDanieDnia.BackColor = System.Drawing.Color.White;
            this.btnDanieDnia.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnDanieDnia.Location = new System.Drawing.Point(0, 0);
            this.btnDanieDnia.Name = "btnDanieDnia";
            this.btnDanieDnia.Size = new System.Drawing.Size(200, 70);
            this.btnDanieDnia.TabIndex = 0;
            this.btnDanieDnia.Text = "Danie dnia";
            this.btnDanieDnia.UseVisualStyleBackColor = false;
            this.btnDanieDnia.Click += new System.EventHandler(this.btnDanieDnia_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnKoszyk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnKoszyk
            // 
            this.btnKoszyk.BackColor = System.Drawing.Color.White;
            this.btnKoszyk.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnKoszyk.Location = new System.Drawing.Point(800, 0);
            this.btnKoszyk.Name = "btnKoszyk";
            this.btnKoszyk.Size = new System.Drawing.Size(100, 100);
            this.btnKoszyk.TabIndex = 0;
            this.btnKoszyk.Text = "Koszyk";
            this.btnKoszyk.UseVisualStyleBackColor = false;
            this.btnKoszyk.Click += new System.EventHandler(this.btnKoszyk_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.btnMojeDane);
            this.panel3.Controls.Add(this.btnWyloguj);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 50);
            this.panel3.TabIndex = 2;
            // 
            // btnMojeDane
            // 
            this.btnMojeDane.BackColor = System.Drawing.Color.White;
            this.btnMojeDane.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnMojeDane.Location = new System.Drawing.Point(0, 0);
            this.btnMojeDane.Name = "btnMojeDane";
            this.btnMojeDane.Size = new System.Drawing.Size(150, 50);
            this.btnMojeDane.TabIndex = 1;
            this.btnMojeDane.Text = "Moje dane";
            this.btnMojeDane.UseVisualStyleBackColor = false;
            this.btnMojeDane.Click += new System.EventHandler(this.btnMojeDane_Click);
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.BackColor = System.Drawing.Color.White;
            this.btnWyloguj.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.btnWyloguj.Location = new System.Drawing.Point(800, 0);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(100, 50);
            this.btnWyloguj.TabIndex = 0;
            this.btnWyloguj.Text = "Wyloguj";
            this.btnWyloguj.UseVisualStyleBackColor = false;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // userControlMojeDane1
            // 
            this.userControlMojeDane1.BackColor = System.Drawing.Color.Beige;
            this.userControlMojeDane1.Location = new System.Drawing.Point(200, 100);
            this.userControlMojeDane1.Name = "userControlMojeDane1";
            this.userControlMojeDane1.Size = new System.Drawing.Size(900, 550);
            this.userControlMojeDane1.TabIndex = 10;
            // 
            // userControlKoszyk1
            // 
            this.userControlKoszyk1.BackColor = System.Drawing.Color.Beige;
            this.userControlKoszyk1.Location = new System.Drawing.Point(200, 100);
            this.userControlKoszyk1.Name = "userControlKoszyk1";
            this.userControlKoszyk1.Size = new System.Drawing.Size(900, 550);
            this.userControlKoszyk1.suma_koszyk = 0;
            this.userControlKoszyk1.TabIndex = 9;
            // 
            // userControlNapoje1
            // 
            this.userControlNapoje1.BackColor = System.Drawing.Color.Beige;
            this.userControlNapoje1.Location = new System.Drawing.Point(200, 100);
            this.userControlNapoje1.Name = "userControlNapoje1";
            this.userControlNapoje1.Size = new System.Drawing.Size(900, 550);
            this.userControlNapoje1.TabIndex = 8;
            // 
            // userControlPrzekaski1
            // 
            this.userControlPrzekaski1.BackColor = System.Drawing.Color.Beige;
            this.userControlPrzekaski1.Location = new System.Drawing.Point(200, 100);
            this.userControlPrzekaski1.Name = "userControlPrzekaski1";
            this.userControlPrzekaski1.Size = new System.Drawing.Size(900, 550);
            this.userControlPrzekaski1.TabIndex = 7;
            // 
            // userControlZupy1
            // 
            this.userControlZupy1.BackColor = System.Drawing.Color.Beige;
            this.userControlZupy1.Location = new System.Drawing.Point(200, 100);
            this.userControlZupy1.Name = "userControlZupy1";
            this.userControlZupy1.Size = new System.Drawing.Size(900, 550);
            this.userControlZupy1.TabIndex = 6;
            // 
            // userControlDaniaGlowne1
            // 
            this.userControlDaniaGlowne1.BackColor = System.Drawing.Color.Beige;
            this.userControlDaniaGlowne1.Location = new System.Drawing.Point(200, 100);
            this.userControlDaniaGlowne1.Name = "userControlDaniaGlowne1";
            this.userControlDaniaGlowne1.Size = new System.Drawing.Size(900, 550);
            this.userControlDaniaGlowne1.TabIndex = 5;
            // 
            // userControlPizza1
            // 
            this.userControlPizza1.BackColor = System.Drawing.Color.Beige;
            this.userControlPizza1.Location = new System.Drawing.Point(200, 100);
            this.userControlPizza1.Name = "userControlPizza1";
            this.userControlPizza1.Size = new System.Drawing.Size(900, 550);
            this.userControlPizza1.TabIndex = 4;
            // 
            // userControlDanieDnia1
            // 
            this.userControlDanieDnia1.BackColor = System.Drawing.Color.Beige;
            this.userControlDanieDnia1.Location = new System.Drawing.Point(200, 100);
            this.userControlDanieDnia1.Name = "userControlDanieDnia1";
            this.userControlDanieDnia1.Size = new System.Drawing.Size(900, 550);
            this.userControlDanieDnia1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lion Bistro";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.userControlMojeDane1);
            this.Controls.Add(this.userControlKoszyk1);
            this.Controls.Add(this.userControlNapoje1);
            this.Controls.Add(this.userControlPrzekaski1);
            this.Controls.Add(this.userControlZupy1);
            this.Controls.Add(this.userControlDaniaGlowne1);
            this.Controls.Add(this.userControlPizza1);
            this.Controls.Add(this.userControlDanieDnia1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnKoszyk;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Button btnNapoje;
        private System.Windows.Forms.Button btnPrzekaski;
        private System.Windows.Forms.Button btnZupy;
        private System.Windows.Forms.Button btnDaniaGlowne;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnDanieDnia;
        private System.Windows.Forms.Button btnMojeDane;
        private UserControlDanieDnia userControlDanieDnia1;
        private UserControlPizza userControlPizza1;
        private UserControlDaniaGlowne userControlDaniaGlowne1;
        private UserControlZupy userControlZupy1;
        private UserControlPrzekaski userControlPrzekaski1;
        private UserControlNapoje userControlNapoje1;
        private UserControlKoszyk userControlKoszyk1;
        private UserControlMojeDane userControlMojeDane1;
        private System.Windows.Forms.Label label1;
    }
}