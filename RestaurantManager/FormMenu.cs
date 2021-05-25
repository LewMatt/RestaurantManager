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

        }

        private void btnDanieDnia_Click(object sender, EventArgs e)
        {
            userControlDanieDnia1.BringToFront();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            userControlPizza1.BringToFront();
        }

        private void btnDaniaGlowne_Click(object sender, EventArgs e)
        {
            userControlDaniaGlowne1.BringToFront();
        }

        private void btnZupy_Click(object sender, EventArgs e)
        {
            userControlZupy1.BringToFront();
        }

        private void btnPrzekaski_Click(object sender, EventArgs e)
        {
            userControlPrzekaski1.BringToFront();
        }

        private void btnNapoje_Click(object sender, EventArgs e)
        {
            userControlNapoje1.BringToFront();
        }
    }
}
