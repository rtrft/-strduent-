namespace WindowsFormsApp3
{
    partial class UserAdd
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
            this.user1View = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserPasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumbe = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user1View)).BeginInit();
            this.SuspendLayout();
            // 
            // user1View
            // 
            this.user1View.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.user1View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user1View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.user1View.Location = new System.Drawing.Point(12, 165);
            this.user1View.Name = "user1View";
            this.user1View.RowTemplate.Height = 27;
            this.user1View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user1View.Size = new System.Drawing.Size(611, 277);
            this.user1View.TabIndex = 6;
            this.user1View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user1View_CellContentClick_1);
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
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户姓名";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(98, 17);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(106, 25);
            this.txtuserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "密码";
            // 
            // txtuserPasswd
            // 
            this.txtuserPasswd.Location = new System.Drawing.Point(296, 17);
            this.txtuserPasswd.MaxLength = 6;
            this.txtuserPasswd.Name = "txtuserPasswd";
            this.txtuserPasswd.Size = new System.Drawing.Size(103, 25);
            this.txtuserPasswd.TabIndex = 10;
            this.txtuserPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "电话号码";
            // 
            // txtPhoneNumbe
            // 
            this.txtPhoneNumbe.Location = new System.Drawing.Point(503, 17);
            this.txtPhoneNumbe.MaxLength = 11;
            this.txtPhoneNumbe.Name = "txtPhoneNumbe";
            this.txtPhoneNumbe.Size = new System.Drawing.Size(117, 25);
            this.txtPhoneNumbe.TabIndex = 16;
            this.txtPhoneNumbe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 18;
            this.button5.Text = "重置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(477, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 19;
            this.button6.Text = "退出";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 444);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPhoneNumbe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuserPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user1View);
            this.Name = "UserAdd";
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView user1View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserPasswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNumbe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}