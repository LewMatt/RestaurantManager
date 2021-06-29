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
    public partial class FormZmienTelefon : Form
    {
        public FormZmienTelefon()
        {
            InitializeComponent();
            Color transparentOrange = Color.FromArgb(200, Color.Orange);
            panel1.BackColor = transparentOrange;
            lblZmianaTel.BackColor = transparentOrange;
        }

        public int my_id;

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxTelefon.Text = "";
            textBoxHaslo.Text = "";
            this.Hide();
        }

        private void btnZmienTel_Click(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "")
            {
                MessageBox.Show("Podaj nowy nr telefonu.");
            }
            else
            {
                if (int.TryParse(textBoxTelefon.Text, out int x) == false)
                {
                    MessageBox.Show("Podaj poprawny numer telefonu.");
                    textBoxTelefon.Text = "";
                }
                else
                {
                    int nowy_tel = int.Parse(textBoxTelefon.Text);

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
                            query = "UPDATE users SET phone_number = '" + nowy_tel.ToString() + "' WHERE user_id LIKE " + my_id.ToString();

                            string trash_res = Form1.sendQueryRetString(query);

                            textBoxTelefon.Text = "";
                            textBoxHaslo.Text = "";

                            MessageBox.Show("Zmieniono email.");

                            this.Hide();
                        }
                    }
                }

            }
        }

        private void textBoxTelefon_Enter(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "Nowy numer")
            {
                textBoxTelefon.Text = "";
                textBoxTelefon.ForeColor = Color.Black;
            }
        }

        private void textBoxTelefon_Leave(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "")
            {
                textBoxTelefon.Text = "Nowy numer";
                textBoxTelefon.ForeColor = Color.Gray;
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
