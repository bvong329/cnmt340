namespace ShopEasy
{
    partial class LoginFormAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_loginBack = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(89, 71);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(179, 23);
            this.txtBox_Username.TabIndex = 2;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(89, 115);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(179, 23);
            this.txtBox_Password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(37, 185);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 40);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_loginBack
            // 
            this.btn_loginBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_loginBack.Location = new System.Drawing.Point(165, 185);
            this.btn_loginBack.Name = "btn_loginBack";
            this.btn_loginBack.Size = new System.Drawing.Size(91, 40);
            this.btn_loginBack.TabIndex = 5;
            this.btn_loginBack.Text = "Back";
            this.btn_loginBack.UseVisualStyleBackColor = true;
            this.btn_loginBack.Click += new System.EventHandler(this.btn_loginBack_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(45, 159);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(211, 23);
            this.lbl_error.TabIndex = 6;
            this.lbl_error.Text = "Invalid username or password";
            // 
            // LoginFormAdmin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btn_loginBack;
            this.ClientSize = new System.Drawing.Size(296, 325);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_loginBack);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginFormAdmin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_loginBack;
        private System.Windows.Forms.Label lbl_error;
    }
}