namespace InventoryManagement
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameBox = new InventoryManagement.CustomTextBox1();
            this.FullNameBox = new InventoryManagement.CustomTextBox1();
            this.PasswordBox = new InventoryManagement.CustomTextBox1();
            this.TelephoneBox = new InventoryManagement.CustomTextBox1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(919, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // UserNameBox
            // 
            this.UserNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameBox.BorderColor = System.Drawing.Color.Gray;
            this.UserNameBox.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.UserNameBox.BorderHoverColor = System.Drawing.Color.LightCyan;
            this.UserNameBox.BorderSize = 2;
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.UserNameBox.Location = new System.Drawing.Point(13, 131);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameBox.Multiline = false;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Padding = new System.Windows.Forms.Padding(7);
            this.UserNameBox.PasswordChar = false;
            this.UserNameBox.Size = new System.Drawing.Size(164, 31);
            this.UserNameBox.TabIndex = 1;
            this.UserNameBox.Texts = "UserName";
            this.UserNameBox.UnderlineStyle = true;
            this.UserNameBox._TextChanged += new System.EventHandler(this.UserNameBox__TextChanged);
            // 
            // FullNameBox
            // 
            this.FullNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.FullNameBox.BorderColor = System.Drawing.Color.Gray;
            this.FullNameBox.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.FullNameBox.BorderHoverColor = System.Drawing.Color.LightCyan;
            this.FullNameBox.BorderSize = 2;
            this.FullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.FullNameBox.Location = new System.Drawing.Point(13, 170);
            this.FullNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameBox.Multiline = false;
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Padding = new System.Windows.Forms.Padding(7);
            this.FullNameBox.PasswordChar = false;
            this.FullNameBox.Size = new System.Drawing.Size(164, 31);
            this.FullNameBox.TabIndex = 2;
            this.FullNameBox.Texts = "FullName";
            this.FullNameBox.UnderlineStyle = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordBox.BorderColor = System.Drawing.Color.Gray;
            this.PasswordBox.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.PasswordBox.BorderHoverColor = System.Drawing.Color.LightCyan;
            this.PasswordBox.BorderSize = 2;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordBox.Location = new System.Drawing.Point(13, 209);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Multiline = false;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordBox.PasswordChar = false;
            this.PasswordBox.Size = new System.Drawing.Size(164, 31);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.Texts = "Password";
            this.PasswordBox.UnderlineStyle = true;
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.BackColor = System.Drawing.SystemColors.Window;
            this.TelephoneBox.BorderColor = System.Drawing.Color.Gray;
            this.TelephoneBox.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TelephoneBox.BorderHoverColor = System.Drawing.Color.LightCyan;
            this.TelephoneBox.BorderSize = 2;
            this.TelephoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneBox.ForeColor = System.Drawing.Color.DimGray;
            this.TelephoneBox.Location = new System.Drawing.Point(13, 248);
            this.TelephoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelephoneBox.Multiline = false;
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Padding = new System.Windows.Forms.Padding(7);
            this.TelephoneBox.PasswordChar = false;
            this.TelephoneBox.Size = new System.Drawing.Size(164, 31);
            this.TelephoneBox.TabIndex = 4;
            this.TelephoneBox.Texts = "Telephone";
            this.TelephoneBox.UnderlineStyle = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(94, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(175, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(94, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // UsersGV
            // 
            this.UsersGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.UsersGV.Location = new System.Drawing.Point(305, 170);
            this.UsersGV.MultiSelect = false;
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGV.Size = new System.Drawing.Size(626, 384);
            this.UsersGV.TabIndex = 9;
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 10);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(531, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "USERS LIST";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomTextBox1 UserNameBox;
        private CustomTextBox1 FullNameBox;
        private CustomTextBox1 PasswordBox;
        private CustomTextBox1 TelephoneBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView UsersGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}