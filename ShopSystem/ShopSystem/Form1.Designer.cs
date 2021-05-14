
namespace ShopSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_dicount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.txt_ballance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.to_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_items
            // 
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(208, 167);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(416, 24);
            this.cmb_items.TabIndex = 0;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(208, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Coffee";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(356, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sweets";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(59, 241);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(118, 22);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(217, 241);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(118, 22);
            this.txt_quantity.TabIndex = 7;
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(378, 241);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(118, 22);
            this.txt_total.TabIndex = 9;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Price,
            this.Quantity,
            this.Total});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 299);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(565, 172);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item Name";
            this.Item.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 75;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 75;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sub Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(112, 490);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(100, 22);
            this.txt_sub.TabIndex = 14;
            this.txt_sub.Text = "0";
            this.txt_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sub.TextChanged += new System.EventHandler(this.txt_sub_TextChanged);
            // 
            // txt_dicount
            // 
            this.txt_dicount.Location = new System.Drawing.Point(316, 490);
            this.txt_dicount.Name = "txt_dicount";
            this.txt_dicount.Size = new System.Drawing.Size(100, 22);
            this.txt_dicount.TabIndex = 16;
            this.txt_dicount.Text = "0";
            this.txt_dicount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dicount.TextChanged += new System.EventHandler(this.txt_dicount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(532, 490);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(100, 22);
            this.txt_net.TabIndex = 18;
            this.txt_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Net Amount";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Paid";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(532, 526);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(100, 22);
            this.txt_paid.TabIndex = 20;
            this.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_paid.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txt_ballance
            // 
            this.txt_ballance.Location = new System.Drawing.Point(532, 564);
            this.txt_ballance.Name = "txt_ballance";
            this.txt_ballance.Size = new System.Drawing.Size(100, 22);
            this.txt_ballance.TabIndex = 22;
            this.txt_ballance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ballance";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "Remove item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(37, 552);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 31);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // to_login
            // 
            this.to_login.Location = new System.Drawing.Point(137, 552);
            this.to_login.Name = "to_login";
            this.to_login.Size = new System.Drawing.Size(75, 31);
            this.to_login.TabIndex = 25;
            this.to_login.Text = "Back";
            this.to_login.UseVisualStyleBackColor = true;
            this.to_login.Click += new System.EventHandler(this.to_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 606);
            this.Controls.Add(this.to_login);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_ballance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dicount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Shop System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_dicount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.TextBox txt_ballance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button to_login;
    }
}

