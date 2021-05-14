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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regis_Click(object sender, EventArgs e)
        {
            if (nick.Text.Length > 3 && nick.Text.Length < 10 && pswd.Text.Length >= 6 && pswd.Text.Length <= 10 && pswd.Text == pswd_2.Text)
            {
                try
                {
                    string ConnectionString = @"Integrated Security=SSPI; Persist Security Info=False; Initial Catalog=Shop_System ; Data Source=TENEBRIS\SQLEXPRESS ";

                    SqlConnection connection = new SqlConnection(ConnectionString);

                    SqlCommand command = connection.CreateCommand();

                    
                    command.CommandText = "Insert into shop_log(Nickname , PSWD ) values " + " (@nickname , @pswd) select scope_identity() ";

                    command.Parameters.Add("@nickname", SqlDbType.VarChar).Value = nick.Text;
                    command.Parameters.Add("@pswd", SqlDbType.VarChar).Value = pswd.Text;
                    
                    connection.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Well done! ");
                    }
                    else {
                        MessageBox.Show("You suck! ");
                    }
                    connection.Close();
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error! , can't add into database");
                }
            }
            else {
                MessageBox.Show("Error! , requirement not met");
            }
        }

        private void to_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            logincs login = new logincs();
            login.Show();
        }
    }
}
