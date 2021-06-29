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
    public partial class FormZlozZamowienie : Form
    {
        public FormZlozZamowienie()
        {
            InitializeComponent();
            Color transparentOrange = Color.FromArgb(200, Color.Orange);
            panel1.BackColor = transparentOrange;
            lblZamowienie.BackColor = transparentOrange;
        }

        public List<ListViewItem> produktyKoszyk = new List<ListViewItem>();
        public int my_id;
        public int cena_zamowienia;

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnZamow_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) from orders";

            int order_id = int.Parse(Form1.sendQueryRetString(query)) + 1;

            string ulica = textBoxUlica.Text;
            string kod_pocztowy = textBoxKodPocztowy.Text;
            string miasto = textBoxMiasto.Text;

            query = "INSERT INTO `order_addresses` (`order_id`, `street`, `postal_code`, `city`) VALUES ('"+order_id+"', '"+ ulica + "', '"+ kod_pocztowy + "', '"+ miasto + "')";

            string trash_res = Form1.sendQueryRetString(query);

            foreach(ListViewItem item in produktyKoszyk)
            {
                string nazwa = item.Text;
                string ilosc = item.SubItems[1].Text;
                string cena = item.SubItems[2].Text;

                query = "INSERT INTO `order_elements` (`order_id`, `name`, `amount`, `price`) VALUES ('"+order_id+"', '"+nazwa+"', '"+ilosc+"', '"+cena+"')";
                trash_res = Form1.sendQueryRetString(query);
            }

            query = "INSERT INTO `orders` (`order_id`, `order_user_id`, `order_price`) VALUES ('"+order_id+"', '"+my_id+"', '"+cena_zamowienia+"')";
            trash_res = Form1.sendQueryRetString(query);


            MessageBox.Show("Złożono zamówienie");
            textBoxUlica.Text = "";
            textBoxKodPocztowy.Text = "";
            textBoxMiasto.Text = "";
            this.Hide();
        }
    }
}
