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
    public partial class FormZmienEmail : Form
    {
        public FormZmienEmail()
        {
            InitializeComponent();
            Color transparentOrange = Color.FromArgb(200, Color.Orange);
            panel1.BackColor = transparentOrange;
            lblZmianaEmail.BackColor = transparentOrange;
            this.Select();
        }

        public int my_id;

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxHaslo.Text = "";
            this.Hide();
        }

        private void btnZmienEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Podaj nowy email.");
            }
            else
            {
                string nowy_email = textBoxEmail.Text;

                if (textBoxHaslo.Text == "")
                {
                    MessageBox.Show("Podaj hasło");
                }
                else
                {
                    string query = "SELECT COUNT(*) FROM users WHERE user_id LIKE " + my_id.ToString() + " AND password LIKE '" + textBoxHaslo.Text + "'";

                    int result = int.Parse(Form1.sendQueryRetString(query));

                    if (result == 0)
                    {
                        MessageBox.Show("Niepoprawne hasło");
                    }
                    else
                    {
                        query = "UPDATE users SET email = '" + nowy_email + "' WHERE user_id LIKE " + my_id.ToString();

                        string trash_res = Form1.sendQueryRetString(query);

                        textBoxEmail.Text = "";
                        textBoxHaslo.Text = "";

                        MessageBox.Show("Zmieniono email.");

                        this.Hide();
                    }
                }
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Nowy email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Nowy email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "Hasło")
            {
                textBoxHaslo.Text = "";
                textBoxHaslo.ForeColor = Color.Black;
                textBoxHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "")
            {
                textBoxHaslo.Text = "Hasło";
                textBoxHaslo.ForeColor = Color.Gray;
                textBoxHaslo.PasswordChar = '\0';
            }
        }
    }
}
