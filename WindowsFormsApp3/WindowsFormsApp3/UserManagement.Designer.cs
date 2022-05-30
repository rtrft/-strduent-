namespace WindowsFormsApp3
{
    partial class UserManagement
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
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.user1View = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserPasswd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumbe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.user1View)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(312, 17);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(95, 25);
            this.txtuserName.TabIndex = 4;
            // 
            // user1View
            // 
            this.user1View.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.user1View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user1View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.user1View.Location = new System.Drawing.Point(3, 259);
            this.user1View.Name = "user1View";
            this.user1View.RowTemplate.Height = 27;
            this.user1View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user1View.Size = new System.Drawing.Size(479, 335);
            this.user1View.TabIndex = 5;
            this.user1View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user1View_CellContentClick_1);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "用户名";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "passwd";
            this.Column2.HeaderText = "密码";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PhoneNumbe";
            this.Column3.HeaderText = "电话号码";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // txtuserPasswd
            // 
            this.txtuserPasswd.Location = new System.Drawing.Point(81, 64);
            this.txtuserPasswd.MaxLength = 6;
            this.txtuserPasswd.Name = "txtuserPasswd";
            this.txtuserPasswd.Size = new System.Drawing.Size(95, 25);
            this.txtuserPasswd.TabIndex = 7;
            this.txtuserPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(302, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 11;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 12;
            this.button5.Text = "重置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 13;
            this.button6.Text = "退出";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "电话号码";
            // 
            // txtPhoneNumbe
            // 
            this.txtPhoneNumbe.Location = new System.Drawing.Point(312, 64);
            this.txtPhoneNumbe.MaxLength = 11;
            this.txtPhoneNumbe.Name = "txtPhoneNumbe";
            this.txtPhoneNumbe.Size = new System.Drawing.Size(95, 25);
            this.txtPhoneNumbe.TabIndex = 15;
            this.txtPhoneNumbe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(81, 14);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(95, 25);
            this.txtID.TabIndex = 17;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 598);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumbe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuserPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user1View);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label1);
            this.Name = "UserManagement";
            this.Text = "账号管理";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.DataGridView user1View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserPasswd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNumbe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}