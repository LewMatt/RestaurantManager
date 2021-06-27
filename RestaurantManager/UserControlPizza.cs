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
    public partial class UserControlPizza : UserControl
    {
        public UserControlPizza()
        {
            InitializeComponent();
        }

        public List<ListViewItem> wybraneProdukty = new List<ListViewItem>();
        public int suma = 0;

        private void btnDodajDoKoszyka_Click(object sender, EventArgs e)
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
                if(radioButton30cm.Checked == false && radioButton40cm.Checked == false && radioButton50cm.Checked == false)
                {
                    MessageBox.Show("Wybierz rozmiar.");
                }
                else
                {
                    int rozmiar_pizzy;
                    string rozmiar_text;
                    if(radioButton30cm.Checked == true)
                    {
                        rozmiar_pizzy = 2;
                        rozmiar_text = "30cm";
                    }
                    else if(radioButton40cm.Checked == true)
                    {
                        rozmiar_pizzy = 3;
                        rozmiar_text = "40cm";
                    }
                    else
                    {
                        rozmiar_pizzy = 4;
                        rozmiar_text = "50cm";
                    }
                    ListViewItem prod = new ListViewItem(listViewPizza.SelectedItems[0].Text + " " + rozmiar_text);
                    prod.SubItems.Add(x.ToString());
                    int cena = int.Parse(listViewPizza.SelectedItems[0].SubItems[rozmiar_pizzy].Text);
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
}
