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
    public partial class FormMenu : Form
    {
        
        public int logged_user_id;

        public FormMenu()
        {
            InitializeComponent();

            userControlDanieDnia1.BringToFront();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnMojeDane_Click(object sender, EventArgs e)
        {
            string query = "SELECT first_name FROM users WHERE user_id LIKE '" + logged_user_id.ToString() + "'";
            string imie = Form1.sendQueryRetString(query);
            userControlMojeDane1.lblPokazImie.Text = imie;

            query = "SELECT last_name FROM users WHERE user_id LIKE '" + logged_user_id.ToString() + "'";
            string nazwisko = Form1.sendQueryRetString(query);
            userControlMojeDane1.lblPokazNazwisko.Text = nazwisko;

            query = "SELECT email FROM users WHERE user_id LIKE '" + logged_user_id.ToString() + "'";
            string email = Form1.sendQueryRetString(query);
            userControlMojeDane1.lblPokazEmail.Text = email;

            query = "SELECT phone_number FROM users WHERE user_id LIKE '" + logged_user_id.ToString() + "'";
            string tel = Form1.sendQueryRetString(query);
            userControlMojeDane1.lblTelefonPokaz.Text = tel;


            userControlMojeDane1.my_id = logged_user_id;
            userControlMojeDane1.BringToFront();
        }

        private void btnDanieDnia_Click(object sender, EventArgs e)
        {
            userControlDanieDnia1.BringToFront();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            List<ListViewItem> pizzaLista = new List<ListViewItem>();
            string query = "SELECT * FROM pizza";
            pizzaLista = Form1.sendQueryRetPizzaList(query);

            userControlPizza1.listViewPizza.Items.Clear();
            
            foreach(ListViewItem item in pizzaLista)
            {
                userControlPizza1.listViewPizza.Items.Add(item);
            }

            userControlPizza1.BringToFront();
        }

        private void btnDaniaGlowne_Click(object sender, EventArgs e)
        {
            List<ListViewItem> daniaGlowneLista = new List<ListViewItem>();
            string query = "SELECT * FROM main_dishes";
            daniaGlowneLista = Form1.sendQueryRetDishesList(query);

            userControlDaniaGlowne1.listViewDaniaGlowne.Items.Clear();

            foreach (ListViewItem item in daniaGlowneLista)
            {
                userControlDaniaGlowne1.listViewDaniaGlowne.Items.Add(item);
            }

            userControlDaniaGlowne1.BringToFront();
        }

        private void btnZupy_Click(object sender, EventArgs e)
        {
            List<ListViewItem> lista = new List<ListViewItem>();
            string query = "SELECT * FROM soups";
            lista = Form1.sendQueryRetDishesList(query);

            userControlZupy1.listViewZupy.Items.Clear();

            foreach (ListViewItem item in lista)
            {
                userControlZupy1.listViewZupy.Items.Add(item);
            }

            userControlZupy1.BringToFront();
        }

        private void btnPrzekaski_Click(object sender, EventArgs e)
        {
            List<ListViewItem> lista = new List<ListViewItem>();
            string query = "SELECT * FROM snacks";
            lista = Form1.sendQueryRetDishesList(query);

            userControlPrzekaski1.listViewPrzekaski.Items.Clear();

            foreach (ListViewItem item in lista)
            {
                userControlPrzekaski1.listViewPrzekaski.Items.Add(item);
            }

            userControlPrzekaski1.BringToFront();
        }

        private void btnNapoje_Click(object sender, EventArgs e)
        {
            List<ListViewItem> lista = new List<ListViewItem>();
            string query = "SELECT * FROM drinks";
            lista = Form1.sendQueryRetDishesList(query);

            userControlNapoje1.listViewNapoje.Items.Clear();

            foreach (ListViewItem item in lista)
            {
                userControlNapoje1.listViewNapoje.Items.Add(item);
            }

            userControlNapoje1.BringToFront();
        }

        private void btnKoszyk_Click(object sender, EventArgs e)
        {
            //dodawanie produktów do koszyka

            foreach (ListViewItem x in userControlPizza1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlPizza1.wybraneProdukty.Clear();

            foreach (ListViewItem x in userControlDaniaGlowne1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlDaniaGlowne1.wybraneProdukty.Clear();

            foreach (ListViewItem x in userControlZupy1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlZupy1.wybraneProdukty.Clear();

            foreach (ListViewItem x in userControlPrzekaski1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlPrzekaski1.wybraneProdukty.Clear();

            foreach (ListViewItem x in userControlNapoje1.wybraneProdukty)
            {
                userControlKoszyk1.produktyKoszyk.Add(x);
            }
            userControlNapoje1.wybraneProdukty.Clear();


            //wyswietlanie koszyka
            userControlKoszyk1.listViewKoszyk.Items.Clear();

            foreach (ListViewItem x in userControlKoszyk1.produktyKoszyk)
            {
                userControlKoszyk1.listViewKoszyk.Items.Add(x);
            }


            //sumowanie ceny łącznej w koszyku

            userControlKoszyk1.suma_koszyk += userControlPizza1.suma;
            userControlPizza1.suma = 0;

            userControlKoszyk1.suma_koszyk += userControlDaniaGlowne1.suma;
            userControlDaniaGlowne1.suma = 0;

            userControlKoszyk1.suma_koszyk += userControlZupy1.suma;
            userControlZupy1.suma = 0;

            userControlKoszyk1.suma_koszyk += userControlPrzekaski1.suma;
            userControlPrzekaski1.suma = 0;

            userControlKoszyk1.suma_koszyk += userControlNapoje1.suma;
            userControlNapoje1.suma = 0;


            //wyswietlanie ceny łącznej w koszyku

            userControlKoszyk1.lblCena.Text = userControlKoszyk1.suma_koszyk.ToString() + " zł";

            userControlKoszyk1.BringToFront();
        }
    }
}
