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
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMojeDane_Click(object sender, EventArgs e)
        {

        }
    }
}
