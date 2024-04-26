namespace IncomeExpress
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_passowrd = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_show_password = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.login_signup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 385);
            this.panel1.TabIndex = 1;
            // 
            // login_signup
            // 
            this.login_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_signup.Location = new System.Drawing.Point(26, 315);
            this.login_signup.Name = "login_signup";
            this.login_signup.Size = new System.Drawing.Size(222, 33);
            this.login_signup.TabIndex = 10;
            this.login_signup.Text = "SIGN UP";
            this.login_signup.UseVisualStyleBackColor = false;
            this.login_signup.Click += new System.EventHandler(this.login_signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "REGISTER HERE";
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
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(564, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(14, 14);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "SIGN IN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(314, 144);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(175, 20);
            this.login_username.TabIndex = 6;
            // 
            // login_passowrd
            // 
            this.login_passowrd.Location = new System.Drawing.Point(314, 208);
            this.login_passowrd.Name = "login_passowrd";
            this.login_passowrd.PasswordChar = '*';
            this.login_passowrd.Size = new System.Drawing.Size(175, 20);
            this.login_passowrd.TabIndex = 7;
            this.login_passowrd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Silver;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Location = new System.Drawing.Point(314, 276);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_show_password
            // 
            this.login_show_password.AutoSize = true;
            this.login_show_password.Location = new System.Drawing.Point(387, 243);
            this.login_show_password.Name = "login_show_password";
            this.login_show_password.Size = new System.Drawing.Size(102, 17);
            this.login_show_password.TabIndex = 9;
            this.login_show_password.Text = "Show Password";
            this.login_show_password.UseVisualStyleBackColor = true;
            this.login_show_password.CheckedChanged += new System.EventHandler(this.login_show_password_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 385);
            this.Controls.Add(this.login_show_password);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_passowrd);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_passowrd;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_show_password;
        private System.Windows.Forms.Button login_signup;
        private System.Windows.Forms.Label label2;
    }
}

