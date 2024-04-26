namespace IncomeExpress
{
    partial class RegisterForm
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
            this.reg_show_password = new System.Windows.Forms.CheckBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reg_loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_confirmpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_show_password
            // 
            this.reg_show_password.AutoSize = true;
            this.reg_show_password.Location = new System.Drawing.Point(392, 259);
            this.reg_show_password.Name = "reg_show_password";
            this.reg_show_password.Size = new System.Drawing.Size(102, 17);
            this.reg_show_password.TabIndex = 17;
            this.reg_show_password.Text = "Show Password";
            this.reg_show_password.UseVisualStyleBackColor = true;
            this.reg_show_password.CheckedChanged += new System.EventHandler(this.reg_show_password_CheckedChanged);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.Silver;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Location = new System.Drawing.Point(366, 325);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(139, 23);
            this.reg_btn.TabIndex = 16;
            this.reg_btn.Text = "Create Account";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_password
            // 
            this.reg_password.Location = new System.Drawing.Point(319, 168);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(175, 20);
            this.reg_password.TabIndex = 15;
            // 
            // reg_username
            // 
            this.reg_username.Location = new System.Drawing.Point(319, 112);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(175, 20);
            this.reg_username.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "REGISTER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.reg_loginbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 384);
            this.panel1.TabIndex = 10;
            // 
            // reg_loginbtn
            // 
            this.reg_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.reg_loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_loginbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_loginbtn.Location = new System.Drawing.Point(26, 315);
            this.reg_loginbtn.Name = "reg_loginbtn";
            this.reg_loginbtn.Size = new System.Drawing.Size(222, 33);
            this.reg_loginbtn.TabIndex = 10;
            this.reg_loginbtn.Text = "SIGN IN";
            this.reg_loginbtn.UseVisualStyleBackColor = false;
            this.reg_loginbtn.Click += new System.EventHandler(this.reg_loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "SIGN IN HERE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IncomeExpress.Properties.Resources.iconfinder_3_avatar_2754579_120516__1_;
            this.pictureBox2.Location = new System.Drawing.Point(93, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 84);
            this.label3.TabIndex = 1;
            this.label3.Text = "Income and Expenses Tracker";
            // 
            // reg_confirmpass
            // 
            this.reg_confirmpass.Location = new System.Drawing.Point(319, 233);
            this.reg_confirmpass.Name = "reg_confirmpass";
            this.reg_confirmpass.PasswordChar = '*';
            this.reg_confirmpass.Size = new System.Drawing.Size(175, 20);
            this.reg_confirmpass.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Confirm Password";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(570, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(14, 14);
            this.Close.TabIndex = 20;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 384);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.reg_confirmpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_show_password);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox reg_show_password;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reg_loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_confirmpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close;
    }
}