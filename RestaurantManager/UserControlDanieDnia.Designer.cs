
namespace RestaurantManager
{
    partial class UserControlDanieDnia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDanieDnia));
            this.lblDanieDnia = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanieDnia
            // 
            this.lblDanieDnia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanieDnia.Font = new System.Drawing.Font("Segoe Print", 20.25F);
            this.lblDanieDnia.Location = new System.Drawing.Point(0, 0);
            this.lblDanieDnia.Name = "lblDanieDnia";
            this.lblDanieDnia.Size = new System.Drawing.Size(900, 100);
            this.lblDanieDnia.TabIndex = 1;
            this.lblDanieDnia.Text = "Danie dnia";
            this.lblDanieDnia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Segoe Print", 20.25F);
            this.lblNazwa.Location = new System.Drawing.Point(252, 400);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(397, 47);
            this.lblNazwa.TabIndex = 3;
            this.lblNazwa.Text = "Kotlet drobiowy z frytkami";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(392, 447);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(115, 65);
            this.lblCena.TabIndex = 4;
            this.lblCena.Text = "15zł";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 277);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlDanieDnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDanieDnia);
            this.Name = "UserControlDanieDnia";
            this.Size = new System.Drawing.Size(900, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanieDnia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblCena;
    }
}
