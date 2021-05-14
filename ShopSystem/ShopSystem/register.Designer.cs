
namespace ShopSystem
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nick = new System.Windows.Forms.TextBox();
            this.pswd = new System.Windows.Forms.TextBox();
            this.regis = new System.Windows.Forms.Button();
            this.pswd_2 = new System.Windows.Forms.TextBox();
            this.opisanie = new System.Windows.Forms.Label();
            this.login_op = new System.Windows.Forms.Label();
            this.to_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(57, 207);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(242, 22);
            this.nick.TabIndex = 5;
            this.nick.Text = "login";
            this.nick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(57, 268);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(242, 22);
            this.pswd.TabIndex = 6;
            this.pswd.Text = "pswd";
            this.pswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regis
            // 
            this.regis.Location = new System.Drawing.Point(57, 364);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(100, 39);
            this.regis.TabIndex = 7;
            this.regis.Text = "registration";
            this.regis.UseVisualStyleBackColor = true;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // pswd_2
            // 
            this.pswd_2.Location = new System.Drawing.Point(57, 315);
            this.pswd_2.Name = "pswd_2";
            this.pswd_2.Size = new System.Drawing.Size(242, 22);
            this.pswd_2.TabIndex = 8;
            this.pswd_2.Text = "pswd ";
            this.pswd_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // opisanie
            // 
            this.opisanie.AutoSize = true;
            this.opisanie.Location = new System.Drawing.Point(16, 248);
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(342, 17);
            this.opisanie.TabIndex = 9;
            this.opisanie.Text = "PSWD must be more than 6 simvols and less than 10";
            // 
            // login_op
            // 
            this.login_op.AutoSize = true;
            this.login_op.Location = new System.Drawing.Point(16, 165);
            this.login_op.Name = "login_op";
            this.login_op.Size = new System.Drawing.Size(336, 17);
            this.login_op.TabIndex = 10;
            this.login_op.Text = "Login must be more than 3 and less than 10 simvols";
            this.login_op.Click += new System.EventHandler(this.label1_Click);
            // 
            // to_login
            // 
            this.to_login.Location = new System.Drawing.Point(197, 364);
            this.to_login.Name = "to_login";
            this.to_login.Size = new System.Drawing.Size(102, 39);
            this.to_login.TabIndex = 11;
            this.to_login.Text = "Back";
            this.to_login.UseVisualStyleBackColor = true;
            this.to_login.Click += new System.EventHandler(this.to_login_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.to_login);
            this.Controls.Add(this.login_op);
            this.Controls.Add(this.opisanie);
            this.Controls.Add(this.pswd_2);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.pictureBox1);
            this.Name = "register";
            this.Text = "register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.TextBox pswd_2;
        private System.Windows.Forms.Label opisanie;
        private System.Windows.Forms.Label login_op;
        private System.Windows.Forms.Button to_login;
    }
}