namespace ShopEasy
{
    partial class EditProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prodGrpBox = new System.Windows.Forms.GroupBox();
            this.radio_instrument = new System.Windows.Forms.RadioButton();
            this.radio_tech = new System.Windows.Forms.RadioButton();
            this.radio_books = new System.Windows.Forms.RadioButton();
            this.radio_clothes = new System.Windows.Forms.RadioButton();
            this.radio_groceries = new System.Windows.Forms.RadioButton();
            this.txtBox_nameProd = new System.Windows.Forms.TextBox();
            this.txtBox_idProd = new System.Windows.Forms.TextBox();
            this.num_quantityProd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_priceProd = new System.Windows.Forms.TextBox();
            this.btn_editProd = new System.Windows.Forms.Button();
            this.btn_cancelEditProd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prodGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantityProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(95, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(383, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // prodGrpBox
            // 
            this.prodGrpBox.Controls.Add(this.radio_instrument);
            this.prodGrpBox.Controls.Add(this.radio_tech);
            this.prodGrpBox.Controls.Add(this.radio_books);
            this.prodGrpBox.Controls.Add(this.radio_clothes);
            this.prodGrpBox.Controls.Add(this.radio_groceries);
            this.prodGrpBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodGrpBox.Location = new System.Drawing.Point(330, 68);
            this.prodGrpBox.Name = "prodGrpBox";
            this.prodGrpBox.Size = new System.Drawing.Size(200, 223);
            this.prodGrpBox.TabIndex = 4;
            this.prodGrpBox.TabStop = false;
            this.prodGrpBox.Text = "Type";
            // 
            // radio_instrument
            // 
            this.radio_instrument.AutoSize = true;
            this.radio_instrument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_instrument.Location = new System.Drawing.Point(17, 172);
            this.radio_instrument.Name = "radio_instrument";
            this.radio_instrument.Size = new System.Drawing.Size(111, 25);
            this.radio_instrument.TabIndex = 4;
            this.radio_instrument.Text = "Instruments";
            this.radio_instrument.UseVisualStyleBackColor = true;
            // 
            // radio_tech
            // 
            this.radio_tech.AutoSize = true;
            this.radio_tech.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_tech.Location = new System.Drawing.Point(17, 137);
            this.radio_tech.Name = "radio_tech";
            this.radio_tech.Size = new System.Drawing.Size(102, 25);
            this.radio_tech.TabIndex = 3;
            this.radio_tech.Text = "Electronics";
            this.radio_tech.UseVisualStyleBackColor = true;
            // 
            // radio_books
            // 
            this.radio_books.AutoSize = true;
            this.radio_books.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_books.Location = new System.Drawing.Point(17, 102);
            this.radio_books.Name = "radio_books";
            this.radio_books.Size = new System.Drawing.Size(70, 25);
            this.radio_books.TabIndex = 2;
            this.radio_books.Text = "Books";
            this.radio_books.UseVisualStyleBackColor = true;
            // 
            // radio_clothes
            // 
            this.radio_clothes.AutoSize = true;
            this.radio_clothes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_clothes.Location = new System.Drawing.Point(17, 67);
            this.radio_clothes.Name = "radio_clothes";
            this.radio_clothes.Size = new System.Drawing.Size(87, 25);
            this.radio_clothes.TabIndex = 1;
            this.radio_clothes.Text = "Clothing";
            this.radio_clothes.UseVisualStyleBackColor = true;
            // 
            // radio_groceries
            // 
            this.radio_groceries.AutoSize = true;
            this.radio_groceries.Checked = true;
            this.radio_groceries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_groceries.Location = new System.Drawing.Point(17, 31);
            this.radio_groceries.Name = "radio_groceries";
            this.radio_groceries.Size = new System.Drawing.Size(83, 25);
            this.radio_groceries.TabIndex = 0;
            this.radio_groceries.TabStop = true;
            this.radio_groceries.Text = "Grocery";
            this.radio_groceries.UseVisualStyleBackColor = true;
            // 
            // txtBox_nameProd
            // 
            this.txtBox_nameProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_nameProd.Location = new System.Drawing.Point(167, 80);
            this.txtBox_nameProd.Name = "txtBox_nameProd";
            this.txtBox_nameProd.Size = new System.Drawing.Size(100, 23);
            this.txtBox_nameProd.TabIndex = 5;
            // 
            // txtBox_idProd
            // 
            this.txtBox_idProd.Location = new System.Drawing.Point(282, 22);
            this.txtBox_idProd.Name = "txtBox_idProd";
            this.txtBox_idProd.ReadOnly = true;
            this.txtBox_idProd.Size = new System.Drawing.Size(68, 23);
            this.txtBox_idProd.TabIndex = 7;
            // 
            // num_quantityProd
            // 
            this.num_quantityProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_quantityProd.Location = new System.Drawing.Point(167, 137);
            this.num_quantityProd.Name = "num_quantityProd";
            this.num_quantityProd.Size = new System.Drawing.Size(100, 23);
            this.num_quantityProd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // txtBox_priceProd
            // 
            this.txtBox_priceProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_priceProd.Location = new System.Drawing.Point(167, 200);
            this.txtBox_priceProd.Name = "txtBox_priceProd";
            this.txtBox_priceProd.Size = new System.Drawing.Size(100, 23);
            this.txtBox_priceProd.TabIndex = 10;
            // 
            // btn_editProd
            // 
            this.btn_editProd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_editProd.Location = new System.Drawing.Point(160, 332);
            this.btn_editProd.Name = "btn_editProd";
            this.btn_editProd.Size = new System.Drawing.Size(116, 45);
            this.btn_editProd.TabIndex = 11;
            this.btn_editProd.Text = "Edit";
            this.btn_editProd.UseVisualStyleBackColor = true;
            this.btn_editProd.Click += new System.EventHandler(this.btn_editProd_Click);
            // 
            // btn_cancelEditProd
            // 
            this.btn_cancelEditProd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelEditProd.Location = new System.Drawing.Point(347, 331);
            this.btn_cancelEditProd.Name = "btn_cancelEditProd";
            this.btn_cancelEditProd.Size = new System.Drawing.Size(117, 46);
            this.btn_cancelEditProd.TabIndex = 12;
            this.btn_cancelEditProd.Text = "Cancel";
            this.btn_cancelEditProd.UseVisualStyleBackColor = true;
            this.btn_cancelEditProd.Click += new System.EventHandler(this.btn_cancelProd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(171, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Product ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(95, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name:";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelEditProd;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancelEditProd);
            this.Controls.Add(this.btn_editProd);
            this.Controls.Add(this.txtBox_priceProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_quantityProd);
            this.Controls.Add(this.txtBox_idProd);
            this.Controls.Add(this.txtBox_nameProd);
            this.Controls.Add(this.prodGrpBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProductForm";
            this.Text = "Edit Product";
            this.prodGrpBox.ResumeLayout(false);
            this.prodGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantityProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox prodGrpBox;
        private System.Windows.Forms.TextBox txtBox_nameProd;
        private System.Windows.Forms.TextBox txtBox_idProd;
        private System.Windows.Forms.NumericUpDown num_quantityProd;
        private System.Windows.Forms.RadioButton radio_instrument;
        private System.Windows.Forms.RadioButton radio_tech;
        private System.Windows.Forms.RadioButton radio_books;
        private System.Windows.Forms.RadioButton radio_clothes;
        private System.Windows.Forms.RadioButton radio_groceries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_priceProd;
        private System.Windows.Forms.Button btn_editProd;
        private System.Windows.Forms.Button btn_cancelEditProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}