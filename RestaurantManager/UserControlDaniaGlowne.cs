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
    public partial class UserControlDaniaGlowne : UserControl
    {
        public UserControlDaniaGlowne()
        {
            InitializeComponent();
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();
        public int suma = 0;

        public void btnDodajDoKoszyka_Click(object sender, EventArgs e)//przycisk
        {

            if (int.TryParse(textBoxIleSztuk.Text, out int x) == false)
            {
                MessageBox.Show("Niepoprawna ilosć.");
            }
            else if (int.Parse(textBoxIleSztuk.Text) <= 0)
            {
                MessageBox.Show("Ilość musi być większa niż 0");
            }
            else
            {
                ListViewItem prod = new ListViewItem(listViewDaniaGlowne.SelectedItems[0].Text);
                prod.SubItems.Add(x.ToString());
                int cena = int.Parse(listViewDaniaGlowne.SelectedItems[0].SubItems[1].Text);
                int cena_razem = cena * x;
                prod.SubItems.Add(cena_razem.ToString());
                wybraneProdukty.Add(prod);
                suma = suma + cena_razem;

                MessageBox.Show("Dodano do koszyka.");

                textBoxIleSztuk.Text = "";

            }
        }
    }
}
