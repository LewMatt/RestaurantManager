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
        public string logged_user = "";
        public int logged_user_id;

        public FormMenu()
        {
            InitializeComponent();

            userControlDanieDnia1.BringToFront();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMojeDane_Click(object sender, EventArgs e)
        {
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
            userControlKoszyk1.BringToFront();
        }
    }
}
