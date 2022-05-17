namespace ShopEasy
{
    partial class LoginMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_cust = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.Location = new System.Drawing.Point(233, 57);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(108, 53);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.Location = new System.Drawing.Point(80, 134);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(135, 58);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_cust
            // 
            this.btn_cust.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cust.Location = new System.Drawing.Point(348, 134);
            this.btn_cust.Name = "btn_cust";
            this.btn_cust.Size = new System.Drawing.Size(135, 58);
            this.btn_cust.TabIndex = 2;
            this.btn_cust.Text = "Customer";
            this.btn_cust.UseVisualStyleBackColor = true;
            this.btn_cust.Click += new System.EventHandler(this.btn_cust_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(215, 227);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(135, 58);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // LoginMain
            // 
            this.AcceptButton = this.btn_cust;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(577, 430);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cust);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.lbl_login);
            this.Name = "LoginMain";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_cust;
        private System.Windows.Forms.Button btn_exit;
    }
}
