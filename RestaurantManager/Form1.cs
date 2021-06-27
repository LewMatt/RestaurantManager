using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RestaurantManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnUtworzKonto_Click(object sender, EventArgs e)
        {
            FormCreateAccount fCreAcc = new FormCreateAccount();

            fCreAcc.Show();
            fCreAcc.BringToFront();

        }
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Login")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Login";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Hasło")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Hasło";
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM users WHERE login like '" + textBoxLogin.Text + "' AND password like '" + textBoxPassword.Text + "'";
            string result = "";

            result = sendQueryRetString(query);
            int res = int.Parse(result);

            if (res == 1)
            {
                query = "SELECT user_id FROM users WHERE login LIKE '" + textBoxLogin.Text + "'";
                int id = int.Parse(sendQueryRetString(query));
                MessageBox.Show("Zalogowano");
                FormMenu fMenu = new FormMenu();
                fMenu.logged_user = textBoxLogin.Text;
                fMenu.logged_user_id = id;
                this.textBoxLogin.Text = "";
                this.textBoxPassword.Text = "";
                fMenu.Show();
                fMenu.BringToFront();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło");
            }
        }

        public class DBConnection
        {
            private DBConnection()
            {
            }

            private string databaseName = string.Empty;
            public string DatabaseName
            {
                get { return databaseName; }
                set { databaseName = value; }
            }

            public string Password { get; set; }
            private MySqlConnection connection = null;
            public MySqlConnection Connection
            {
                get { return connection; }
            }

            private static DBConnection _instance = null;
            public static DBConnection Instance()
            {
                if (_instance == null)
                    _instance = new DBConnection();
                return _instance;
            }

            public bool IsConnect()
            {
                if (Connection == null)
                {
                    if (String.IsNullOrEmpty(databaseName))
                        return false;
                    string connstring = string.Format("Server=localhost; database={0}; UID=root; password=", databaseName);
                    connection = new MySqlConnection(connstring);
                    connection.Open();
                }

                return true;
            }

            public void Close()
            {
                connection.Close();
                connection = null;
            }
        }

        public string sendQueryRetString(string query)
        {
            string someStringFromColumnZero = "";
            string result = "";
            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "db_restaurant_manager";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    someStringFromColumnZero = reader.GetString(0);
                    result = someStringFromColumnZero;
                }
                dbCon.Close();
            }
            return result;
        }

        public static List<ListViewItem> sendQueryRetPizzaList(string query)
        {
            List<ListViewItem> lista = new List<ListViewItem>();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "db_restaurant_manager";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ile = reader.FieldCount;

                    for (int i = 1; i < ile; i += 6)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = reader.GetString(i);
                        item.SubItems.Add(reader.GetString(i + 1));
                        item.SubItems.Add(reader.GetString(i + 2));
                        item.SubItems.Add(reader.GetString(i + 3));
                        item.SubItems.Add(reader.GetString(i + 4));
                        lista.Add(item);
                    }
                }
                dbCon.Close();
            }
            return lista;
        }

        public static List<ListViewItem> sendQueryRetDishesList(string query)
        {
            List<ListViewItem> lista = new List<ListViewItem>();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "db_restaurant_manager";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ile = reader.FieldCount;

                    for (int i = 1; i < ile; i += 3)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = reader.GetString(i);
                        item.SubItems.Add(reader.GetString(i + 1));
                        lista.Add(item);
                    }
                }
                dbCon.Close();
            }
            return lista;
        }
    }
}
