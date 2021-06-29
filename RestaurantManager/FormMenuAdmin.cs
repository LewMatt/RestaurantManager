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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
            Color transparentOrange = Color.FromArgb(200, Color.Orange);
            panel1.BackColor = transparentOrange;
            lblPanelAdmin.BackColor = transparentOrange;
        }

        public List<ListViewItem> listaElementow = new List<ListViewItem>();

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            string order_id = listViewZamowienia.SelectedItems[0].Text;

            string query = "SELECT * FROM order_elements WHERE order_id LIKE " + order_id;
            listaElementow = Form1.sendQueryRetOrderElementsList(query);

            listViewProdukty.Items.Clear();

            foreach(ListViewItem item in listaElementow)
            {
                listViewProdukty.Items.Add(item);
            }

            query = "SELECT order_user_id FROM orders WHERE order_id LIKE " + order_id;
            string user_id = Form1.sendQueryRetString(query);

            query = "SELECT first_name FROM users WHERE user_id LIKE " + user_id;
            string imie = Form1.sendQueryRetString(query);

            query = "SELECT last_name FROM users WHERE user_id LIKE " + user_id;
            string nazwisko = Form1.sendQueryRetString(query);

            query = "SELECT phone_number FROM users WHERE user_id LIKE " + user_id;
            string telefon = Form1.sendQueryRetString(query);

            query = "SELECT street FROM order_addresses WHERE order_id LIKE " + order_id;
            string ulica = Form1.sendQueryRetString(query);

            query = "SELECT postal_code FROM order_addresses WHERE order_id LIKE " + order_id;
            string kod_pocztowy = Form1.sendQueryRetString(query);

            query = "SELECT city FROM order_addresses WHERE order_id LIKE " + order_id;
            string miasto = Form1.sendQueryRetString(query);

            labelImie.Text = imie;
            labelNazwisko.Text = nazwisko;
            labelTelefon.Text = telefon;
            labelUlica.Text = ulica;
            labelKodPocztowy.Text = kod_pocztowy;
            labelMiasto.Text = miasto;

        }

        private void btnZrealizuj_Click(object sender, EventArgs e)
        {
            string order_id = listViewZamowienia.SelectedItems[0].Text;

            string query = "DELETE FROM orders WHERE order_id LIKE " + order_id;
            string trash_result = Form1.sendQueryRetString(query);

            query = "DELETE FROM order_elements WHERE order_id LIKE " + order_id;
            trash_result = Form1.sendQueryRetString(query);

            query = "DELETE FROM order_addresses WHERE order_id LIKE " + order_id;
            trash_result = Form1.sendQueryRetString(query);

            List<ListViewItem> lista = new List<ListViewItem>();
            query = "SELECT * FROM orders";
            lista = Form1.sendQueryRetOrdersList(query);

            listViewZamowienia.Items.Clear();

            foreach (ListViewItem item in lista)
            {
                listViewZamowienia.Items.Add(item);
            }

            listViewProdukty.Items.Clear();

            labelImie.Text = "brak";
            labelNazwisko.Text = "brak";
            labelTelefon.Text = "brak";
            labelUlica.Text = "brak";
            labelKodPocztowy.Text = "brak";
            labelMiasto.Text = "brak";

            MessageBox.Show("Zrealizowano zamówienie.");
        }
    }
}
