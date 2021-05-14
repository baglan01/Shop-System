
namespace ShopSystem
{
    partial class logincs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logincs));
            this.nick = new System.Windows.Forms.TextBox();
            this.pswd = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regis = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(87, 138);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(242, 22);
            this.nick.TabIndex = 0;
            this.nick.Text = "login";
            this.nick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nick.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(87, 195);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(242, 22);
            this.pswd.TabIndex = 1;
            this.pswd.Text = "pswd";
            this.pswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.login.Location = new System.Drawing.Point(152, 250);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(118, 39);
            this.login.TabIndex = 2;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // regis
            // 
            this.regis.Location = new System.Drawing.Point(152, 312);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(118, 39);
            this.regis.TabIndex = 4;
            this.regis.Text = "registration";
            this.regis.UseVisualStyleBackColor = true;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(152, 376);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(118, 39);
            this.exit.TabIndex = 5;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // logincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.nick);
            this.Name = "logincs";
            this.Text = "logincs";
            this.Load += new System.EventHandler(this.logincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.Button exit;
    }
}