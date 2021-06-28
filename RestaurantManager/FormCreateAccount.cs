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
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxHaslo.Text = "";
            textBoxPowHaslo.Text = "";
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefon.Text = "";
            this.Close();
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Login")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Login";
                textBoxLogin.ForeColor = Color.Gray;
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

        private void textBoxPowHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxPowHaslo.Text == "Powtórz hasło")
            {
                textBoxPowHaslo.Text = "";
                textBoxPowHaslo.ForeColor = Color.Black;
                textBoxPowHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxPowHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxPowHaslo.Text == "")
            {
                textBoxPowHaslo.Text = "Powtórz hasło";
                textBoxPowHaslo.ForeColor = Color.Gray;
                textBoxPowHaslo.PasswordChar = '\0';
            }
        }

        private void textBoxImie_Enter(object sender, EventArgs e)
        {
            if (textBoxImie.Text == "Imię")
            {
                textBoxImie.Text = "";
                textBoxImie.ForeColor = Color.Black;
            }
        }

        private void textBoxImie_Leave(object sender, EventArgs e)
        {
            if (textBoxImie.Text == "")
            {
                textBoxImie.Text = "Imię";
                textBoxImie.ForeColor = Color.Gray;
            }
        }

        private void textBoxNazwisko_Enter(object sender, EventArgs e)
        {
            if (textBoxNazwisko.Text == "Nazwisko")
            {
                textBoxNazwisko.Text = "";
                textBoxNazwisko.ForeColor = Color.Black;
            }
        }

        private void textBoxNazwisko_Leave(object sender, EventArgs e)
        {
            if (textBoxNazwisko.Text == "")
            {
                textBoxNazwisko.Text = "Nazwisko";
                textBoxNazwisko.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxTelefon_Enter(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "Numer telefonu")
            {
                textBoxTelefon.Text = "";
                textBoxTelefon.ForeColor = Color.Black;
            }
        }

        private void textBoxTelefon_Leave(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "")
            {
                textBoxTelefon.Text = "Numer telefonu";
                textBoxTelefon.ForeColor = Color.Gray;
            }
        }

        private void btnUtworzKonto_Click(object sender, EventArgs e)
        {
            string new_login = textBoxLogin.Text;
            string new_password = textBoxHaslo.Text;
            string new_pass_again = textBoxPowHaslo.Text;
            string new_fname = textBoxImie.Text;
            string new_lname = textBoxNazwisko.Text;
            string new_email = textBoxEmail.Text;
            string new_phone = textBoxTelefon.Text;
            

            string query = "SELECT COUNT(*) FROM users WHERE login LIKE '" + new_login + "'";

            int result = int.Parse(Form1.sendQueryRetString(query));

            if (new_login == "Login" || new_login == "")
            {
                MessageBox.Show("Wprowadź login.");
            }
            if (result == 1)
            {
                MessageBox.Show("Login zajęty.");
                textBoxLogin.Text = "";
            }
            else
            {
                if (new_password == "" || new_password == "Hasło")
                {
                    MessageBox.Show("Wprowadź hasło.");
                }
                else
                {
                    if (new_password != new_pass_again)
                    {
                        MessageBox.Show("Powtórz poprawnie hasło.");
                        textBoxHaslo.Text = "";
                        textBoxPowHaslo.Text = "";
                    }
                    else
                    {
                        if (int.TryParse(new_phone, out int x) == false)
                        {
                            MessageBox.Show("Wprowadź poprawny numer telefonu.");
                            textBoxTelefon.Text = "";
                        }
                        else
                        {
                            string q = "SELECT COUNT(*) FROM users";
                            string ile_uz = Form1.sendQueryRetString(q);
                            int new_id = int.Parse(ile_uz) + 1;
                            int user_type = 1;
                            q = "INSERT INTO `users` (`user_id`, `login`, `password`, `first_name`, `last_name`, `email`, `phone_number`, `user_type`) VALUES ('" + new_id + "', '" + new_login + "', '" + new_password + "', '" + new_fname + "', '" + new_lname + "', '" + new_email + "', '" + new_phone + "', '"+user_type.ToString()+"')";
                            string trash_res = Form1.sendQueryRetString(q);

                            MessageBox.Show("Konto utworzone.");
                            Application.Restart();
                        }
                    }
                }
            }
        }
    }
}
