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
    public partial class UserControlMojeDane : UserControl
    {
        public UserControlMojeDane()
        {
            InitializeComponent();
        }

        public int my_id;

        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            FormZmienHaslo fZmienHas = new FormZmienHaslo();
            fZmienHas.my_id = my_id;
            fZmienHas.Show();
            fZmienHas.BringToFront();
        }

        private void btnZmienEmail_Click(object sender, EventArgs e)
        {
            FormZmienEmail fZmienEmail = new FormZmienEmail();
            fZmienEmail.my_id = my_id;
            fZmienEmail.Show();
            fZmienEmail.BringToFront();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            string query = "SELECT first_name FROM users WHERE user_id LIKE '" + my_id.ToString() + "'";
            string imie = Form1.sendQueryRetString(query);
            lblPokazImie.Text = imie;

            query = "SELECT last_name FROM users WHERE user_id LIKE '" + my_id.ToString() + "'";
            string nazwisko = Form1.sendQueryRetString(query);
            lblPokazNazwisko.Text = nazwisko;

            query = "SELECT email FROM users WHERE user_id LIKE '" + my_id.ToString() + "'";
            string email = Form1.sendQueryRetString(query);
            lblPokazEmail.Text = email;

            query = "SELECT phone_number FROM users WHERE user_id LIKE '" + my_id.ToString() + "'";
            string tel = Form1.sendQueryRetString(query);
            lblTelefonPokaz.Text = tel;
        }
    }
}
