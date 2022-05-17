namespace ShopEasy
{
    partial class ShopEasyMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Manage Customers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manage Products");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Run Report");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Manage Invoices", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Admin Operations", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Products");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Invoices");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Manage Account");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_exit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.adminCustGrpBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_searchCust = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_addCust = new System.Windows.Forms.Button();
            this.dgvcust = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodGrpBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_prodSearch = new System.Windows.Forms.TextBox();
            this.btn_custProdRefresh = new System.Windows.Forms.Button();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.dgvCustProd = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminProdGrpBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_searchProd = new System.Windows.Forms.TextBox();
            this.btn_prodRefresh = new System.Windows.Forms.Button();
            this.btn_addProd = new System.Windows.Forms.Button();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accGrpBox = new System.Windows.Forms.GroupBox();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.lbl_newPhoneError = new System.Windows.Forms.Label();
            this.lbl_newPassError = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_accLName = new System.Windows.Forms.TextBox();
            this.txtBox_accFName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBox_accPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_accNewPass2 = new System.Windows.Forms.TextBox();
            this.txtBox_accEmail = new System.Windows.Forms.TextBox();
            this.txtBox_accNewPass1 = new System.Windows.Forms.TextBox();
            this.txtBox_accUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_accClear = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.cartGrpBox = new System.Windows.Forms.GroupBox();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clearCart = new System.Windows.Forms.Button();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_cartList = new System.Windows.Forms.Label();
            this.btn_cartBack = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.invoiceGrpBox = new System.Windows.Forms.GroupBox();
            this.comboBox_Dates = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvinvoices = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accLoginGrpBox = new System.Windows.Forms.GroupBox();
            this.lbl_passError = new System.Windows.Forms.Label();
            this.txtBox_confPass = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_accLogin = new System.Windows.Forms.Button();
            this.adminInvoiceGrpBox = new System.Windows.Forms.GroupBox();
            this.dgvAdminInvoice = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_nameError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.adminCustGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.prodGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.adminProdGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.accGrpBox.SuspendLayout();
            this.cartGrpBox.SuspendLayout();
            this.invoiceGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.accLoginGrpBox.SuspendLayout();
            this.adminInvoiceGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.accGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.adminCustGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.prodGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.adminProdGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.cartGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.invoiceGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.accLoginGrpBox);
            this.splitContainer1.Panel2.Controls.Add(this.adminInvoiceGrpBox);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 450);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(47, 394);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(164, 44);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "editCust";
            treeNode1.Text = "Manage Customers";
            treeNode2.Name = "editProd";
            treeNode2.Text = "Manage Products";
            treeNode3.Name = "invoiceReport";
            treeNode3.Text = "Run Report";
            treeNode4.Name = "editInvoices";
            treeNode4.Text = "Manage Invoices";
            treeNode5.Name = "adminNode";
            treeNode5.Text = "Admin Operations";
            treeNode6.Name = "products";
            treeNode6.Text = "Products";
            treeNode7.Name = "invoices";
            treeNode7.Text = "Invoices";
            treeNode8.Name = "editAccount";
            treeNode8.Text = "Manage Account";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(260, 447);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // adminCustGrpBox
            // 
            this.adminCustGrpBox.Controls.Add(this.label4);
            this.adminCustGrpBox.Controls.Add(this.txtBox_searchCust);
            this.adminCustGrpBox.Controls.Add(this.btn_refresh);
            this.adminCustGrpBox.Controls.Add(this.btn_addCust);
            this.adminCustGrpBox.Controls.Add(this.dgvcust);
            this.adminCustGrpBox.Location = new System.Drawing.Point(0, 0);
            this.adminCustGrpBox.Margin = new System.Windows.Forms.Padding(0);
            this.adminCustGrpBox.Name = "adminCustGrpBox";
            this.adminCustGrpBox.Padding = new System.Windows.Forms.Padding(0);
            this.adminCustGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.adminCustGrpBox.TabIndex = 0;
            this.adminCustGrpBox.TabStop = false;
            this.adminCustGrpBox.Text = "Admin Operations";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Search Customer:";
            // 
            // txtBox_searchCust
            // 
            this.txtBox_searchCust.Location = new System.Drawing.Point(155, 309);
            this.txtBox_searchCust.Name = "txtBox_searchCust";
            this.txtBox_searchCust.Size = new System.Drawing.Size(196, 23);
            this.txtBox_searchCust.TabIndex = 12;
            this.txtBox_searchCust.TextChanged += new System.EventHandler(this.txtBox_searchCust_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.Location = new System.Drawing.Point(231, 398);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(106, 40);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_addCust
            // 
            this.btn_addCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addCust.Location = new System.Drawing.Point(6, 398);
            this.btn_addCust.Name = "btn_addCust";
            this.btn_addCust.Size = new System.Drawing.Size(196, 40);
            this.btn_addCust.TabIndex = 1;
            this.btn_addCust.Text = "Add New Customer";
            this.btn_addCust.UseVisualStyleBackColor = true;
            this.btn_addCust.Click += new System.EventHandler(this.btn_addCust_Click);
            // 
            // dgvcust
            // 
            this.dgvcust.AllowUserToAddRows = false;
            this.dgvcust.AllowUserToDeleteRows = false;
            this.dgvcust.AutoGenerateColumns = false;
            this.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.responsibleDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvcust.DataSource = this.customersBindingSource;
            this.dgvcust.Location = new System.Drawing.Point(6, 22);
            this.dgvcust.Name = "dgvcust";
            this.dgvcust.ReadOnly = true;
            this.dgvcust.RowTemplate.Height = 25;
            this.dgvcust.Size = new System.Drawing.Size(1005, 269);
            this.dgvcust.TabIndex = 0;
            this.dgvcust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcust_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsibleDataGridViewTextBoxColumn
            // 
            this.responsibleDataGridViewTextBoxColumn.DataPropertyName = "Responsible";
            this.responsibleDataGridViewTextBoxColumn.HeaderText = "Responsible";
            this.responsibleDataGridViewTextBoxColumn.Name = "responsibleDataGridViewTextBoxColumn";
            this.responsibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(ShopEasy.Models.DataLayer.Customers);
            // 
            // prodGrpBox
            // 
            this.prodGrpBox.Controls.Add(this.label1);
            this.prodGrpBox.Controls.Add(this.txtBox_prodSearch);
            this.prodGrpBox.Controls.Add(this.btn_custProdRefresh);
            this.prodGrpBox.Controls.Add(this.btn_checkOut);
            this.prodGrpBox.Controls.Add(this.dgvCustProd);
            this.prodGrpBox.Location = new System.Drawing.Point(3, 0);
            this.prodGrpBox.Name = "prodGrpBox";
            this.prodGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.prodGrpBox.TabIndex = 4;
            this.prodGrpBox.TabStop = false;
            this.prodGrpBox.Text = "Products";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search product:  ";
            // 
            // txtBox_prodSearch
            // 
            this.txtBox_prodSearch.Location = new System.Drawing.Point(138, 311);
            this.txtBox_prodSearch.Name = "txtBox_prodSearch";
            this.txtBox_prodSearch.Size = new System.Drawing.Size(196, 23);
            this.txtBox_prodSearch.TabIndex = 4;
            this.txtBox_prodSearch.TextChanged += new System.EventHandler(this.txtBox_prodSearch_TextChanged);
            // 
            // btn_custProdRefresh
            // 
            this.btn_custProdRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_custProdRefresh.Location = new System.Drawing.Point(231, 398);
            this.btn_custProdRefresh.Name = "btn_custProdRefresh";
            this.btn_custProdRefresh.Size = new System.Drawing.Size(106, 40);
            this.btn_custProdRefresh.TabIndex = 3;
            this.btn_custProdRefresh.Text = "Refresh";
            this.btn_custProdRefresh.UseVisualStyleBackColor = true;
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_checkOut.Location = new System.Drawing.Point(12, 398);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(196, 40);
            this.btn_checkOut.TabIndex = 2;
            this.btn_checkOut.Text = "Check out";
            this.btn_checkOut.UseVisualStyleBackColor = true;
            this.btn_checkOut.Click += new System.EventHandler(this.btn_checkOut_Click);
            // 
            // dgvCustProd
            // 
            this.dgvCustProd.AllowUserToAddRows = false;
            this.dgvCustProd.AllowUserToDeleteRows = false;
            this.dgvCustProd.AutoGenerateColumns = false;
            this.dgvCustProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn2});
            this.dgvCustProd.DataSource = this.productsBindingSource;
            this.dgvCustProd.Location = new System.Drawing.Point(12, 22);
            this.dgvCustProd.Name = "dgvCustProd";
            this.dgvCustProd.ReadOnly = true;
            this.dgvCustProd.RowTemplate.Height = 25;
            this.dgvCustProd.Size = new System.Drawing.Size(993, 269);
            this.dgvCustProd.TabIndex = 0;
            this.dgvCustProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustProd_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn2
            // 
            this.typeDataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn2.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn2.Name = "typeDataGridViewTextBoxColumn2";
            this.typeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(ShopEasy.Models.DataLayer.Products);
            // 
            // adminProdGrpBox
            // 
            this.adminProdGrpBox.Controls.Add(this.label3);
            this.adminProdGrpBox.Controls.Add(this.txtBox_searchProd);
            this.adminProdGrpBox.Controls.Add(this.btn_prodRefresh);
            this.adminProdGrpBox.Controls.Add(this.btn_addProd);
            this.adminProdGrpBox.Controls.Add(this.dgvprod);
            this.adminProdGrpBox.Location = new System.Drawing.Point(0, 0);
            this.adminProdGrpBox.Name = "adminProdGrpBox";
            this.adminProdGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.adminProdGrpBox.TabIndex = 3;
            this.adminProdGrpBox.TabStop = false;
            this.adminProdGrpBox.Text = "Manage Products";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Product:";
            // 
            // txtBox_searchProd
            // 
            this.txtBox_searchProd.Location = new System.Drawing.Point(141, 308);
            this.txtBox_searchProd.Name = "txtBox_searchProd";
            this.txtBox_searchProd.Size = new System.Drawing.Size(196, 23);
            this.txtBox_searchProd.TabIndex = 8;
            this.txtBox_searchProd.TextChanged += new System.EventHandler(this.txtBox_searchProd_TextChanged);
            // 
            // btn_prodRefresh
            // 
            this.btn_prodRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_prodRefresh.Location = new System.Drawing.Point(231, 398);
            this.btn_prodRefresh.Name = "btn_prodRefresh";
            this.btn_prodRefresh.Size = new System.Drawing.Size(106, 40);
            this.btn_prodRefresh.TabIndex = 3;
            this.btn_prodRefresh.Text = "Refresh";
            this.btn_prodRefresh.UseVisualStyleBackColor = true;
            this.btn_prodRefresh.Click += new System.EventHandler(this.btn_prodRefresh_Click);
            // 
            // btn_addProd
            // 
            this.btn_addProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addProd.Location = new System.Drawing.Point(12, 398);
            this.btn_addProd.Name = "btn_addProd";
            this.btn_addProd.Size = new System.Drawing.Size(196, 40);
            this.btn_addProd.TabIndex = 2;
            this.btn_addProd.Text = "Add New Product";
            this.btn_addProd.UseVisualStyleBackColor = true;
            this.btn_addProd.Click += new System.EventHandler(this.btn_addProd_Click);
            // 
            // dgvprod
            // 
            this.dgvprod.AllowUserToAddRows = false;
            this.dgvprod.AllowUserToDeleteRows = false;
            this.dgvprod.AutoGenerateColumns = false;
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn1});
            this.dgvprod.DataSource = this.productsBindingSource;
            this.dgvprod.Location = new System.Drawing.Point(12, 22);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.ReadOnly = true;
            this.dgvprod.RowTemplate.Height = 25;
            this.dgvprod.Size = new System.Drawing.Size(993, 269);
            this.dgvprod.TabIndex = 0;
            this.dgvprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprod_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // accGrpBox
            // 
            this.accGrpBox.Controls.Add(this.lbl_nameError);
            this.accGrpBox.Controls.Add(this.lbl_usernameError);
            this.accGrpBox.Controls.Add(this.lbl_newPhoneError);
            this.accGrpBox.Controls.Add(this.lbl_newPassError);
            this.accGrpBox.Controls.Add(this.label14);
            this.accGrpBox.Controls.Add(this.label11);
            this.accGrpBox.Controls.Add(this.label12);
            this.accGrpBox.Controls.Add(this.txtBox_accLName);
            this.accGrpBox.Controls.Add(this.txtBox_accFName);
            this.accGrpBox.Controls.Add(this.label13);
            this.accGrpBox.Controls.Add(this.txtBox_accPhone);
            this.accGrpBox.Controls.Add(this.label10);
            this.accGrpBox.Controls.Add(this.label9);
            this.accGrpBox.Controls.Add(this.label8);
            this.accGrpBox.Controls.Add(this.label5);
            this.accGrpBox.Controls.Add(this.txtBox_accNewPass2);
            this.accGrpBox.Controls.Add(this.txtBox_accEmail);
            this.accGrpBox.Controls.Add(this.txtBox_accNewPass1);
            this.accGrpBox.Controls.Add(this.txtBox_accUsername);
            this.accGrpBox.Controls.Add(this.label2);
            this.accGrpBox.Controls.Add(this.btn_accClear);
            this.accGrpBox.Controls.Add(this.btn_apply);
            this.accGrpBox.Location = new System.Drawing.Point(0, 0);
            this.accGrpBox.Margin = new System.Windows.Forms.Padding(0);
            this.accGrpBox.Name = "accGrpBox";
            this.accGrpBox.Padding = new System.Windows.Forms.Padding(0);
            this.accGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.accGrpBox.TabIndex = 14;
            this.accGrpBox.TabStop = false;
            this.accGrpBox.Text = "Manage Account";
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameError.Location = new System.Drawing.Point(691, 120);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(220, 21);
            this.lbl_usernameError.TabIndex = 36;
            this.lbl_usernameError.Text = "Error: Username already taken";
            // 
            // lbl_newPhoneError
            // 
            this.lbl_newPhoneError.AutoSize = true;
            this.lbl_newPhoneError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_newPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lbl_newPhoneError.Location = new System.Drawing.Point(130, 270);
            this.lbl_newPhoneError.Name = "lbl_newPhoneError";
            this.lbl_newPhoneError.Size = new System.Drawing.Size(279, 21);
            this.lbl_newPhoneError.TabIndex = 35;
            this.lbl_newPhoneError.Text = "Error: Phone number must be 10 digits";
            // 
            // lbl_newPassError
            // 
            this.lbl_newPassError.AutoSize = true;
            this.lbl_newPassError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_newPassError.ForeColor = System.Drawing.Color.Red;
            this.lbl_newPassError.Location = new System.Drawing.Point(690, 227);
            this.lbl_newPassError.Name = "lbl_newPassError";
            this.lbl_newPassError.Size = new System.Drawing.Size(221, 21);
            this.lbl_newPassError.TabIndex = 34;
            this.lbl_newPassError.Text = "Error: Passwords do not match";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(608, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 30);
            this.label14.TabIndex = 33;
            this.label14.Text = "Account Credentials";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(79, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "Personal Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(15, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Last Name:";
            // 
            // txtBox_accLName
            // 
            this.txtBox_accLName.Location = new System.Drawing.Point(174, 134);
            this.txtBox_accLName.Name = "txtBox_accLName";
            this.txtBox_accLName.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accLName.TabIndex = 29;
            // 
            // txtBox_accFName
            // 
            this.txtBox_accFName.Location = new System.Drawing.Point(174, 98);
            this.txtBox_accFName.Name = "txtBox_accFName";
            this.txtBox_accFName.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accFName.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(15, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "First Name:";
            // 
            // txtBox_accPhone
            // 
            this.txtBox_accPhone.Location = new System.Drawing.Point(174, 239);
            this.txtBox_accPhone.Name = "txtBox_accPhone";
            this.txtBox_accPhone.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accPhone.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(15, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(528, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Re-enter Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(528, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "New Password:";
            // 
            // txtBox_accNewPass2
            // 
            this.txtBox_accNewPass2.Location = new System.Drawing.Point(690, 191);
            this.txtBox_accNewPass2.Name = "txtBox_accNewPass2";
            this.txtBox_accNewPass2.PasswordChar = '*';
            this.txtBox_accNewPass2.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accNewPass2.TabIndex = 34;
            // 
            // txtBox_accEmail
            // 
            this.txtBox_accEmail.Location = new System.Drawing.Point(174, 195);
            this.txtBox_accEmail.Name = "txtBox_accEmail";
            this.txtBox_accEmail.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accEmail.TabIndex = 30;
            // 
            // txtBox_accNewPass1
            // 
            this.txtBox_accNewPass1.Location = new System.Drawing.Point(690, 149);
            this.txtBox_accNewPass1.Name = "txtBox_accNewPass1";
            this.txtBox_accNewPass1.PasswordChar = '*';
            this.txtBox_accNewPass1.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accNewPass1.TabIndex = 33;
            // 
            // txtBox_accUsername
            // 
            this.txtBox_accUsername.Location = new System.Drawing.Point(690, 94);
            this.txtBox_accUsername.Name = "txtBox_accUsername";
            this.txtBox_accUsername.Size = new System.Drawing.Size(199, 23);
            this.txtBox_accUsername.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(528, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username:";
            // 
            // btn_accClear
            // 
            this.btn_accClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_accClear.Location = new System.Drawing.Point(231, 398);
            this.btn_accClear.Name = "btn_accClear";
            this.btn_accClear.Size = new System.Drawing.Size(106, 40);
            this.btn_accClear.TabIndex = 2;
            this.btn_accClear.Text = "Reset Info";
            this.btn_accClear.UseVisualStyleBackColor = true;
            this.btn_accClear.Click += new System.EventHandler(this.btn_accClear_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_apply.Location = new System.Drawing.Point(6, 398);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(196, 40);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "Apply Changes";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // cartGrpBox
            // 
            this.cartGrpBox.Controls.Add(this.lbl_totalCost);
            this.cartGrpBox.Controls.Add(this.label7);
            this.cartGrpBox.Controls.Add(this.btn_clearCart);
            this.cartGrpBox.Controls.Add(this.lbl_customer);
            this.cartGrpBox.Controls.Add(this.lbl_cartList);
            this.cartGrpBox.Controls.Add(this.btn_cartBack);
            this.cartGrpBox.Controls.Add(this.btn_confirm);
            this.cartGrpBox.Location = new System.Drawing.Point(0, 0);
            this.cartGrpBox.Name = "cartGrpBox";
            this.cartGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.cartGrpBox.TabIndex = 5;
            this.cartGrpBox.TabStop = false;
            this.cartGrpBox.Text = "Shopping Cart";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalCost.Location = new System.Drawing.Point(400, 80);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(258, 37);
            this.lbl_totalCost.TabIndex = 8;
            this.lbl_totalCost.Text = "Placeholder for total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(400, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Balance Due:";
            // 
            // btn_clearCart
            // 
            this.btn_clearCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearCart.Location = new System.Drawing.Point(343, 398);
            this.btn_clearCart.Name = "btn_clearCart";
            this.btn_clearCart.Size = new System.Drawing.Size(163, 40);
            this.btn_clearCart.TabIndex = 6;
            this.btn_clearCart.Text = "Clear Cart";
            this.btn_clearCart.UseVisualStyleBackColor = true;
            this.btn_clearCart.Click += new System.EventHandler(this.btn_clearCart_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Location = new System.Drawing.Point(36, 28);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(176, 15);
            this.lbl_customer.TabIndex = 5;
            this.lbl_customer.Text = "place holder for customer name";
            // 
            // lbl_cartList
            // 
            this.lbl_cartList.Location = new System.Drawing.Point(54, 43);
            this.lbl_cartList.Name = "lbl_cartList";
            this.lbl_cartList.Size = new System.Drawing.Size(267, 330);
            this.lbl_cartList.TabIndex = 4;
            this.lbl_cartList.Text = "place holder for shopping cart";
            // 
            // btn_cartBack
            // 
            this.btn_cartBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cartBack.Location = new System.Drawing.Point(174, 398);
            this.btn_cartBack.Name = "btn_cartBack";
            this.btn_cartBack.Size = new System.Drawing.Size(163, 40);
            this.btn_cartBack.TabIndex = 3;
            this.btn_cartBack.Text = "Continue Shopping";
            this.btn_cartBack.UseVisualStyleBackColor = true;
            this.btn_cartBack.Click += new System.EventHandler(this.btn_cartBack_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.Location = new System.Drawing.Point(12, 398);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(156, 40);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm Check Out";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // invoiceGrpBox
            // 
            this.invoiceGrpBox.Controls.Add(this.comboBox_Dates);
            this.invoiceGrpBox.Controls.Add(this.label6);
            this.invoiceGrpBox.Controls.Add(this.dgvinvoices);
            this.invoiceGrpBox.Location = new System.Drawing.Point(0, 0);
            this.invoiceGrpBox.Name = "invoiceGrpBox";
            this.invoiceGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.invoiceGrpBox.TabIndex = 6;
            this.invoiceGrpBox.TabStop = false;
            this.invoiceGrpBox.Text = "Invoices";
            // 
            // comboBox_Dates
            // 
            this.comboBox_Dates.FormattingEnabled = true;
            this.comboBox_Dates.Items.AddRange(new object[] {
            "All invoices",
            "Past month",
            "Past 3 months",
            "Past 6 months",
            "Past academic year"});
            this.comboBox_Dates.Location = new System.Drawing.Point(141, 314);
            this.comboBox_Dates.Name = "comboBox_Dates";
            this.comboBox_Dates.Size = new System.Drawing.Size(196, 23);
            this.comboBox_Dates.TabIndex = 6;
            this.comboBox_Dates.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dates_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sort by time:";
            // 
            // dgvinvoices
            // 
            this.dgvinvoices.AllowUserToAddRows = false;
            this.dgvinvoices.AllowUserToDeleteRows = false;
            this.dgvinvoices.AutoGenerateColumns = false;
            this.dgvinvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.CustomerId,
            this.Date,
            this.Products,
            this.Cost});
            this.dgvinvoices.DataSource = this.invoicesBindingSource;
            this.dgvinvoices.Location = new System.Drawing.Point(12, 22);
            this.dgvinvoices.Name = "dgvinvoices";
            this.dgvinvoices.ReadOnly = true;
            this.dgvinvoices.RowTemplate.Height = 25;
            this.dgvinvoices.Size = new System.Drawing.Size(993, 269);
            this.dgvinvoices.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Products
            // 
            this.Products.DataPropertyName = "Products";
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataSource = typeof(ShopEasy.Models.DataLayer.Invoices);
            // 
            // accLoginGrpBox
            // 
            this.accLoginGrpBox.Controls.Add(this.lbl_passError);
            this.accLoginGrpBox.Controls.Add(this.txtBox_confPass);
            this.accLoginGrpBox.Controls.Add(this.lbl_login);
            this.accLoginGrpBox.Controls.Add(this.btn_accLogin);
            this.accLoginGrpBox.Location = new System.Drawing.Point(0, 0);
            this.accLoginGrpBox.Margin = new System.Windows.Forms.Padding(0);
            this.accLoginGrpBox.Name = "accLoginGrpBox";
            this.accLoginGrpBox.Padding = new System.Windows.Forms.Padding(0);
            this.accLoginGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.accLoginGrpBox.TabIndex = 34;
            this.accLoginGrpBox.TabStop = false;
            this.accLoginGrpBox.Text = "Manage Account";
            // 
            // lbl_passError
            // 
            this.lbl_passError.AutoSize = true;
            this.lbl_passError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_passError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passError.Location = new System.Drawing.Point(12, 160);
            this.lbl_passError.Name = "lbl_passError";
            this.lbl_passError.Size = new System.Drawing.Size(247, 21);
            this.lbl_passError.TabIndex = 5;
            this.lbl_passError.Text = "Access Denied: Incorrect Password";
            // 
            // txtBox_confPass
            // 
            this.txtBox_confPass.Location = new System.Drawing.Point(15, 127);
            this.txtBox_confPass.Name = "txtBox_confPass";
            this.txtBox_confPass.PasswordChar = '*';
            this.txtBox_confPass.Size = new System.Drawing.Size(236, 23);
            this.txtBox_confPass.TabIndex = 4;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.Location = new System.Drawing.Point(12, 53);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(332, 25);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Please re-enter the password for user ";
            // 
            // btn_accLogin
            // 
            this.btn_accLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_accLogin.Location = new System.Drawing.Point(6, 398);
            this.btn_accLogin.Name = "btn_accLogin";
            this.btn_accLogin.Size = new System.Drawing.Size(196, 40);
            this.btn_accLogin.TabIndex = 1;
            this.btn_accLogin.Text = "Login";
            this.btn_accLogin.UseVisualStyleBackColor = true;
            this.btn_accLogin.Click += new System.EventHandler(this.btn_accLogin_Click);
            // 
            // adminInvoiceGrpBox
            // 
            this.adminInvoiceGrpBox.Controls.Add(this.dgvAdminInvoice);
            this.adminInvoiceGrpBox.Location = new System.Drawing.Point(0, 0);
            this.adminInvoiceGrpBox.Name = "adminInvoiceGrpBox";
            this.adminInvoiceGrpBox.Size = new System.Drawing.Size(1011, 450);
            this.adminInvoiceGrpBox.TabIndex = 7;
            this.adminInvoiceGrpBox.TabStop = false;
            this.adminInvoiceGrpBox.Text = "Invoices";
            // 
            // dgvAdminInvoice
            // 
            this.dgvAdminInvoice.AllowUserToAddRows = false;
            this.dgvAdminInvoice.AllowUserToDeleteRows = false;
            this.dgvAdminInvoice.AutoGenerateColumns = false;
            this.dgvAdminInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvAdminInvoice.DataSource = this.invoicesBindingSource;
            this.dgvAdminInvoice.Location = new System.Drawing.Point(12, 22);
            this.dgvAdminInvoice.Name = "dgvAdminInvoice";
            this.dgvAdminInvoice.ReadOnly = true;
            this.dgvAdminInvoice.RowTemplate.Height = 25;
            this.dgvAdminInvoice.Size = new System.Drawing.Size(993, 269);
            this.dgvAdminInvoice.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Products";
            this.dataGridViewTextBoxColumn4.HeaderText = "Products";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // lbl_nameError
            // 
            this.lbl_nameError.AutoSize = true;
            this.lbl_nameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_nameError.Location = new System.Drawing.Point(174, 160);
            this.lbl_nameError.Name = "lbl_nameError";
            this.lbl_nameError.Size = new System.Drawing.Size(191, 21);
            this.lbl_nameError.TabIndex = 37;
            this.lbl_nameError.Text = "Error: Please enter a name";
            // 
            // ShopEasyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ShopEasyMain";
            this.Text = "ShopEasy";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.adminCustGrpBox.ResumeLayout(false);
            this.adminCustGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.prodGrpBox.ResumeLayout(false);
            this.prodGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.adminProdGrpBox.ResumeLayout(false);
            this.adminProdGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.accGrpBox.ResumeLayout(false);
            this.accGrpBox.PerformLayout();
            this.cartGrpBox.ResumeLayout(false);
            this.cartGrpBox.PerformLayout();
            this.invoiceGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.accLoginGrpBox.ResumeLayout(false);
            this.accLoginGrpBox.PerformLayout();
            this.adminInvoiceGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox adminCustGrpBox;
        private System.Windows.Forms.Button btn_prodRefresh;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView dgvcust;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Button btn_addCust;
        private System.Windows.Forms.GroupBox adminProdGrpBox;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.Button btn_addProd;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox prodGrpBox;
        private System.Windows.Forms.Button btn_custProdRefresh;
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.DataGridView dgvCustProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_searchCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_searchProd;
        private System.Windows.Forms.GroupBox cartGrpBox;
        private System.Windows.Forms.Button btn_cartBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_prodSearch;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label lbl_cartList;
        private System.Windows.Forms.Button btn_clearCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox invoiceGrpBox;
        private System.Windows.Forms.ComboBox comboBox_Dates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvinvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox adminInvoiceGrpBox;
        private System.Windows.Forms.DataGridView dgvAdminInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox accGrpBox;
        private System.Windows.Forms.Button btn_accClear;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_accNewPass2;
        private System.Windows.Forms.TextBox txtBox_accEmail;
        private System.Windows.Forms.TextBox txtBox_accNewPass1;
        private System.Windows.Forms.TextBox txtBox_accUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_accPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_accLName;
        private System.Windows.Forms.TextBox txtBox_accFName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox accLoginGrpBox;
        private System.Windows.Forms.TextBox txtBox_confPass;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_accLogin;
        private System.Windows.Forms.Label lbl_passError;
        private System.Windows.Forms.Label lbl_newPassError;
        private System.Windows.Forms.Label lbl_newPhoneError;
        private System.Windows.Forms.Label lbl_usernameError;
        private System.Windows.Forms.Label lbl_nameError;
    }
}