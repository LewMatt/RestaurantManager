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
            lblCena.Text = "0zł";
            MessageBox.Show("Wyczyszczono koszyk.");
        }
    }
}
