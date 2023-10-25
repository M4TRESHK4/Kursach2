namespace Kursach2
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.clearFieldsLogLink = new System.Windows.Forms.LinkLabel();
            this.createAccLink = new System.Windows.Forms.LinkLabel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitLabelLog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(94, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.panel1.Location = new System.Drawing.Point(31, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.panel2.Location = new System.Drawing.Point(31, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(25, 379);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(242, 30);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // clearFieldsLogLink
            // 
            this.clearFieldsLogLink.AutoSize = true;
            this.clearFieldsLogLink.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFieldsLogLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.clearFieldsLogLink.Location = new System.Drawing.Point(193, 313);
            this.clearFieldsLogLink.Name = "clearFieldsLogLink";
            this.clearFieldsLogLink.Size = new System.Drawing.Size(74, 16);
            this.clearFieldsLogLink.TabIndex = 8;
            this.clearFieldsLogLink.TabStop = true;
            this.clearFieldsLogLink.Text = "Clear fields";
            this.clearFieldsLogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearFieldsLogLink_LinkClicked);
            // 
            // createAccLink
            // 
            this.createAccLink.AutoSize = true;
            this.createAccLink.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.createAccLink.Location = new System.Drawing.Point(32, 412);
            this.createAccLink.Name = "createAccLink";
            this.createAccLink.Size = new System.Drawing.Size(229, 16);
            this.createAccLink.TabIndex = 10;
            this.createAccLink.TabStop = true;
            this.createAccLink.Text = "If you don\'t have account, create it here";
            this.createAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccLink_LinkClicked);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.txtUserName.Location = new System.Drawing.Point(65, 236);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 19);
            this.txtUserName.TabIndex = 11;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.txtUserPassword.Location = new System.Drawing.Point(65, 276);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(202, 19);
            this.txtUserPassword.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kursach2.Properties.Resources.icons8_пароль_50;
            this.pictureBox3.Location = new System.Drawing.Point(27, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kursach2.Properties.Resources.icons8_пользователь_32;
            this.pictureBox2.Location = new System.Drawing.Point(25, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach2.Properties.Resources.icons8_вход_в_систему__в_кружке__стрелка_вправо_96;
            this.pictureBox1.Location = new System.Drawing.Point(97, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitLabelLog
            // 
            this.exitLabelLog.ActiveLinkColor = System.Drawing.Color.Thistle;
            this.exitLabelLog.AutoSize = true;
            this.exitLabelLog.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabelLog.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(36)))), ((int)(((byte)(216)))));
            this.exitLabelLog.Location = new System.Drawing.Point(259, 3);
            this.exitLabelLog.Name = "exitLabelLog";
            this.exitLabelLog.Size = new System.Drawing.Size(31, 35);
            this.exitLabelLog.TabIndex = 13;
            this.exitLabelLog.TabStop = true;
            this.exitLabelLog.Text = "X";
            this.exitLabelLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.exitLabelLog);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.createAccLink);
            this.Controls.Add(this.clearFieldsLogLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel clearFieldsLogLink;
        private System.Windows.Forms.LinkLabel createAccLink;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.LinkLabel exitLabelLog;
    }
}

