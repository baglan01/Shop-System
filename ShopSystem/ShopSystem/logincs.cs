using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Integrated Security=SSPI; Persist Security Info=False; Initial Catalog=Shop_System ; Data Source=TENEBRIS\SQLEXPRESS ";

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "Select * from shop_log Where Nickname = '" + nick.Text.Trim() + "' and PSWD = '"+ pswd.Text.Trim() +"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form1 work = new Form1();
                this.Hide();
                work.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }

                SqlCommand command = connection.CreateCommand();

           


        }

        private void regis_Click(object sender, EventArgs e)
        {
            this.Hide();
            register regis = new register();
            regis.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
