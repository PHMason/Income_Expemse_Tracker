namespace IncomeExpress
{
    partial class CatergoryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Category_DeleteBtn = new System.Windows.Forms.Button();
            this.Category_ClearBtn = new System.Windows.Forms.Button();
            this.Category_UpdateBtn = new System.Windows.Forms.Button();
            this.Category_addBtn = new System.Windows.Forms.Button();
            this.catergory_status = new System.Windows.Forms.ComboBox();
            this.Category_Status = new System.Windows.Forms.Label();
            this.Category_Type = new System.Windows.Forms.ComboBox();
            this.Category_Catergory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Catergory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Category_DeleteBtn);
            this.panel1.Controls.Add(this.Category_ClearBtn);
            this.panel1.Controls.Add(this.Category_UpdateBtn);
            this.panel1.Controls.Add(this.Category_addBtn);
            this.panel1.Controls.Add(this.catergory_status);
            this.panel1.Controls.Add(this.Category_Status);
            this.panel1.Controls.Add(this.Category_Type);
            this.panel1.Controls.Add(this.Category_Catergory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Catergory);
            this.panel1.Location = new System.Drawing.Point(32, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 562);
            this.panel1.TabIndex = 0;
            // 
            // Category_DeleteBtn
            // 
            this.Category_DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Category_DeleteBtn.FlatAppearance.BorderSize = 0;
            this.Category_DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_DeleteBtn.Location = new System.Drawing.Point(160, 382);
            this.Category_DeleteBtn.Name = "Category_DeleteBtn";
            this.Category_DeleteBtn.Size = new System.Drawing.Size(81, 41);
            this.Category_DeleteBtn.TabIndex = 8;
            this.Category_DeleteBtn.Text = "Delete";
            this.Category_DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // Category_ClearBtn
            // 
            this.Category_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Category_ClearBtn.FlatAppearance.BorderSize = 0;
            this.Category_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_ClearBtn.Location = new System.Drawing.Point(25, 382);
            this.Category_ClearBtn.Name = "Category_ClearBtn";
            this.Category_ClearBtn.Size = new System.Drawing.Size(81, 41);
            this.Category_ClearBtn.TabIndex = 7;
            this.Category_ClearBtn.Text = "Clear";
            this.Category_ClearBtn.UseVisualStyleBackColor = false;
            // 
            // Category_UpdateBtn
            // 
            this.Category_UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Category_UpdateBtn.FlatAppearance.BorderSize = 0;
            this.Category_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_UpdateBtn.Location = new System.Drawing.Point(160, 302);
            this.Category_UpdateBtn.Name = "Category_UpdateBtn";
            this.Category_UpdateBtn.Size = new System.Drawing.Size(81, 41);
            this.Category_UpdateBtn.TabIndex = 6;
            this.Category_UpdateBtn.Text = "Update";
            this.Category_UpdateBtn.UseVisualStyleBackColor = false;
            this.Category_UpdateBtn.Click += new System.EventHandler(this.Category_UpdateBtn_Click);
            // 
            // Category_addBtn
            // 
            this.Category_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.Category_addBtn.FlatAppearance.BorderSize = 0;
            this.Category_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_addBtn.Location = new System.Drawing.Point(25, 302);
            this.Category_addBtn.Name = "Category_addBtn";
            this.Category_addBtn.Size = new System.Drawing.Size(81, 41);
            this.Category_addBtn.TabIndex = 5;
            this.Category_addBtn.Text = "Add";
            this.Category_addBtn.UseVisualStyleBackColor = false;
            this.Category_addBtn.Click += new System.EventHandler(this.Category_addBtn_Click);
            // 
            // catergory_status
            // 
            this.catergory_status.FormattingEnabled = true;
            this.catergory_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.catergory_status.Location = new System.Drawing.Point(25, 235);
            this.catergory_status.Name = "catergory_status";
            this.catergory_status.Size = new System.Drawing.Size(216, 21);
            this.catergory_status.TabIndex = 4;
            // 
            // Category_Status
            // 
            this.Category_Status.AutoSize = true;
            this.Category_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Status.ForeColor = System.Drawing.Color.Black;
            this.Category_Status.Location = new System.Drawing.Point(22, 205);
            this.Category_Status.Name = "Category_Status";
            this.Category_Status.Size = new System.Drawing.Size(50, 16);
            this.Category_Status.TabIndex = 3;
            this.Category_Status.Text = "Status";
            // 
            // Category_Type
            // 
            this.Category_Type.FormattingEnabled = true;
            this.Category_Type.Items.AddRange(new object[] {
            " Income ",
            "Expenses"});
            this.Category_Type.Location = new System.Drawing.Point(25, 140);
            this.Category_Type.Name = "Category_Type";
            this.Category_Type.Size = new System.Drawing.Size(216, 21);
            this.Category_Type.TabIndex = 2;
            // 
            // Category_Catergory
            // 
            this.Category_Catergory.FormattingEnabled = true;
            this.Category_Catergory.Location = new System.Drawing.Point(25, 60);
            this.Category_Catergory.Name = "Category_Catergory";
            this.Category_Catergory.Size = new System.Drawing.Size(216, 21);
            this.Category_Catergory.TabIndex = 1;
            this.Category_Catergory.SelectedIndexChanged += new System.EventHandler(this.Category_Catergory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // Catergory
            // 
            this.Catergory.AutoSize = true;
            this.Catergory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catergory.ForeColor = System.Drawing.Color.Black;
            this.Catergory.Location = new System.Drawing.Point(22, 30);
            this.Catergory.Name = "Catergory";
            this.Catergory.Size = new System.Drawing.Size(75, 16);
            this.Catergory.TabIndex = 0;
            this.Catergory.Text = "Catergory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(313, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 562);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Catergories List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(472, 473);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CatergoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CatergoryForm";
            this.Size = new System.Drawing.Size(872, 625);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Catergory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catergory_status;
        private System.Windows.Forms.Label Category_Status;
        private System.Windows.Forms.ComboBox Category_Type;
        private System.Windows.Forms.ComboBox Category_Catergory;
        private System.Windows.Forms.Button Category_addBtn;
        private System.Windows.Forms.Button Category_DeleteBtn;
        private System.Windows.Forms.Button Category_ClearBtn;
        private System.Windows.Forms.Button Category_UpdateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
