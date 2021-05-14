using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Americano")
            {
                txt_price.Text = "500";
            }
            else if (cmb_items.SelectedItem.ToString() == "Capuchino")
            {
                txt_price.Text = "700";
            }
            else if (cmb_items.SelectedItem.ToString() == "latte")
            {
                txt_price.Text = "600";
            }
            else if (cmb_items.SelectedItem.ToString() == "Chocolate")
            {
                txt_price.Text = "500";
            }
            else if (cmb_items.SelectedItem.ToString() == "Cookies")
            {
                txt_price.Text = "600";
            }
            else if (cmb_items.SelectedItem.ToString() == "Biscuit Kartoshka")
            {
                txt_price.Text = "700";
            }
            else {
                txt_price.Text = "0";
            }

            txt_quantity.Text = "";
            txt_total.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Black;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Americano");
            cmb_items.Items.Add("Capuchino");
            cmb_items.Items.Add("latte");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton1.ForeColor = System.Drawing.Color.Black;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Chocolate");
            cmb_items.Items.Add("Cookies");
            cmb_items.Items.Add("Biscuit Kartoshka");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.TextLength > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_quantity.Text)).ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_ballance.Text = (Convert.ToDouble(txt_net.Text) - Convert.ToDouble(txt_paid.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text ;
            arr[2] = txt_quantity.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

             txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        }

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dicount_TextChanged(object sender, EventArgs e)
        {
            if (txt_dicount.Text.Length > 0) { 
                txt_net.Text = (Convert.ToDouble(txt_sub.Text) - ( Convert.ToDouble(txt_sub.Text) * (Convert.ToDouble(txt_dicount.Text)/100))).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                for (int i = 0; i < listView1.Items.Count; i++) {
                    if (listView1.Items[i].Selected) { 
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {

                    string ConnectionString = @"Integrated Security=SSPI; Persist Security Info=False; Initial Catalog=Shop_System ; Data Source=TENEBRIS\SQLEXPRESS ";
                    
                    SqlConnection connection = new SqlConnection(ConnectionString);

                    SqlCommand command = connection.CreateCommand();

                    connection.Open();

                    command.CommandText = "Insert into Invoice_Master(Invoice_Date , Sub_Total , Discount , Net_Amount , Paid_Amount) values " + " ( getdate()  , " + txt_sub.Text + " ," + txt_dicount.Text + " , " + txt_net.Text + " , " + txt_paid.Text + ") select scope_identity() " ;

                    string Invoice_ID = command.ExecuteScalar().ToString();
                    
                    
                    foreach (ListViewItem ListItem in listView1.Items) {

                        command.CommandText = "Insert into Invoice_Detail(Master_id , Item_Name , Item_Price , Item_Quantity , Item_Total) values " + "('" + Invoice_ID + "' , '" + ListItem.SubItems[0].Text + "' , '" + ListItem.SubItems[1].Text + "' , '" + ListItem.SubItems[2].Text + "' , " + ListItem.SubItems[3].Text + ")";
                       
                        command.ExecuteNonQuery();
                    }
                    
                    connection.Close();
                    MessageBox.Show("Sale created successfully , with Invoice # " + Invoice_ID);
                }
                catch(Exception ee ) {
                    // connection.Close();

                    MessageBox.Show("Sale not created , Error!");
                }
            }
            else {
                MessageBox.Show("Must add an Item in the list");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void to_login_Click(object sender, EventArgs e)
        {
            logincs login = new logincs();
            this.Hide();
            login.Show();
        }
    }
}
