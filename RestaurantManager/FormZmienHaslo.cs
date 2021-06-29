using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class FormZmienHaslo : Form
    {
        public FormZmienHaslo()
        {
            InitializeComponent();
            Color transparentOrange = Color.FromArgb(200, Color.Orange);
            panel1.BackColor = transparentOrange;
            lblZmianaHasla.BackColor = transparentOrange;
            this.Select();
        }

        public int my_id;

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxAktHaslo.Text = "";
            textBoxNoweHaslo.Text = "";
            textBoxNoweHasloPow.Text = "";
            this.Hide();
        }

        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            if (textBoxAktHaslo.Text == "")
            {
                MessageBox.Show("Wpisz hasło.");
            }
            else
            {
                string query = "SELECT COUNT(*) FROM users WHERE user_id LIKE " + my_id.ToString() + " AND password LIKE '" + textBoxAktHaslo.Text + "'";
                int res = int.Parse(Form1.sendQueryRetString(query));

                if (res == 0)
                {
                    MessageBox.Show("Aktualne hasło nieprawidłowe.");
                }
                else
                {
                    if (textBoxNoweHaslo.Text != textBoxNoweHasloPow.Text || textBoxNoweHaslo.Text == "")
                    {
                        MessageBox.Show("Powtórz poprawnie nowe hasło.");
                    }
                    else
                    {
                        
                        query = "UPDATE users SET password = '"+textBoxNoweHaslo.Text+"' WHERE user_id LIKE "+my_id.ToString();
                        string trash_res = Form1.sendQueryRetString(query);
                        MessageBox.Show("Hasło zmienione.");
                        textBoxAktHaslo.Text = "";
                        textBoxNoweHaslo.Text = "";
                        textBoxNoweHasloPow.Text = "";
                        this.Hide();
                    }
                }
            }
        }

        private void textBoxAktHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxAktHaslo.Text == "Aktualne hasło")
            {
                textBoxAktHaslo.Text = "";
                textBoxAktHaslo.ForeColor = Color.Black;
                textBoxAktHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxAktHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxAktHaslo.Text == "")
            {
                textBoxAktHaslo.Text = "Aktualne hasło";
                textBoxAktHaslo.ForeColor = Color.Gray;
                textBoxAktHaslo.PasswordChar = '\0';
            }
        }

        private void textBoxNoweHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxNoweHaslo.Text == "Nowe hasło")
            {
                textBoxNoweHaslo.Text = "";
                textBoxNoweHaslo.ForeColor = Color.Black;
                textBoxNoweHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxNoweHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxNoweHaslo.Text == "")
            {
                textBoxNoweHaslo.Text = "Nowe hasło";
                textBoxNoweHaslo.ForeColor = Color.Gray;
                textBoxNoweHaslo.PasswordChar = '\0';
            }
        }

        private void textBoxNoweHasloPow_Enter(object sender, EventArgs e)
        {
            if (textBoxNoweHasloPow.Text == "Powtórz nowe hasło")
            {
                textBoxNoweHasloPow.Text = "";
                textBoxNoweHasloPow.ForeColor = Color.Black;
                textBoxNoweHasloPow.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxNoweHasloPow_Leave(object sender, EventArgs e)
        {
            if (textBoxNoweHasloPow.Text == "")
            {
                textBoxNoweHasloPow.Text = "Powtórz nowe hasło";
                textBoxNoweHasloPow.ForeColor = Color.Gray;
                textBoxNoweHasloPow.PasswordChar = '\0';
            }
        }

    }
}
