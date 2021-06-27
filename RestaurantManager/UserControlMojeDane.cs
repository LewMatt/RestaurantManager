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
    public partial class UserControlMojeDane : UserControl
    {
        public UserControlMojeDane()
        {
            InitializeComponent();
        }

        public int my_id;

        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            FormZmienHaslo fZmienHas = new FormZmienHaslo();
            fZmienHas.my_id = my_id;
            fZmienHas.Show();
            fZmienHas.BringToFront();
        }


    }
}
