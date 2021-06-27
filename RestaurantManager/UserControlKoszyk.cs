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
    public partial class UserControlKoszyk : UserControl
    {
        public int suma_koszyk { get; set; }

        public int my_id;

        public UserControlKoszyk()
        {
            InitializeComponent();
            suma_koszyk = 0;
        }

        public List<ListViewItem> produktyKoszyk = new List<ListViewItem>();

        private void btnWyczyscKoszyk_Click(object sender, EventArgs e)
        {
            produktyKoszyk.Clear();
            listViewKoszyk.Items.Clear();
            suma_koszyk = 0;
            lblCena.Text = "0 zł";
            MessageBox.Show("Wyczyszczono koszyk.");
        }

        private void btnZlozZamowienie_Click(object sender, EventArgs e)
        {
            if(produktyKoszyk.Count>0)
            {
                FormZlozZamowienie FZamow = new FormZlozZamowienie();
                FZamow.produktyKoszyk = produktyKoszyk;
                FZamow.my_id = my_id;
                FZamow.cena_zamowienia = suma_koszyk;

                FZamow.Show();
                FZamow.BringToFront();
            }
            else
            {
                MessageBox.Show("Brak produktów w koszyku.");
            }
            
        }
    }
}
