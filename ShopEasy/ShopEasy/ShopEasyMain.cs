using ShopEasy.Models.DataLayer;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class ShopEasyMain : Form
    {
        private ShopEasyContext context = new ShopEasyContext();

        //creates new shopping cart to add products into
        private Products[] cart = new Products[100];

        private int userID;
        public ShopEasyMain(int userID)
        {
            InitializeComponent();
            this.AcceptButton = null;
            this.CancelButton = null;

            this.userID = userID;

            //if user is not an admin (via -1), gray out admin operations node
            if (userID != -1)
            {
                treeView1.Nodes[0].Nodes.Clear();
                treeView1.Nodes[0].ForeColor = Color.Gray;
            }

            //Creates delete and modify columns for admins to edit customers
            DataGridViewButtonColumn deleteColumnCust = new DataGridViewButtonColumn();
            deleteColumnCust.HeaderText = "";
            deleteColumnCust.UseColumnTextForButtonValue = true;
            deleteColumnCust.Text = "Delete";

            DataGridViewButtonColumn modifyColumnCust = new DataGridViewButtonColumn();
            modifyColumnCust.HeaderText = "";
            modifyColumnCust.UseColumnTextForButtonValue = true;
            modifyColumnCust.Text = "Modify";

            //adds those columns to the datagrid in edit customer node under admin operations
            dgvcust.Columns.Add(modifyColumnCust);
            dgvcust.Columns.Add(deleteColumnCust);

            //creates delete and modify columns for admins to edit products
            DataGridViewButtonColumn deleteColumnProd = new DataGridViewButtonColumn();
            deleteColumnProd.HeaderText = "";
            deleteColumnProd.UseColumnTextForButtonValue = true;
            deleteColumnProd.Text = "Delete";

            DataGridViewButtonColumn modifyColumnProd = new DataGridViewButtonColumn();
            modifyColumnProd.HeaderText = "";
            modifyColumnProd.UseColumnTextForButtonValue = true;
            modifyColumnProd.Text = "Modify";

            //adds these columns to the datagrid in edit products node under admin operations
            dgvprod.Columns.Add(modifyColumnProd);
            dgvprod.Columns.Add(deleteColumnProd);

            //creates add cart button for customers to add products to their carts
            DataGridViewButtonColumn addCart = new DataGridViewButtonColumn();
            addCart.HeaderText = "";
            addCart.UseColumnTextForButtonValue = true;
            addCart.Text = "Add to Cart";

            //adds this column to the datagrid in products node
            dgvCustProd.Columns.Add(addCart);

            //form utilizes groupboxes to create "forms within forms"
            //this hides them all at startup before anything is selected
            adminCustGrpBox.Hide();
            adminProdGrpBox.Hide();
            prodGrpBox.Hide();
            cartGrpBox.Hide();
            invoiceGrpBox.Hide();
            adminInvoiceGrpBox.Hide();
            accLoginGrpBox.Hide();
            accGrpBox.Hide();
        }

        //checks when anything in the treeview is selected
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //when edit customer node under admin operations is selected, do the following:
            if (treeView1.SelectedNode.Name == "editCust")
            {
                //makes sure to hide every other groupbox other than the one needed
                adminCustGrpBox.Show();
                adminProdGrpBox.Hide();
                prodGrpBox.Hide();
                cartGrpBox.Hide();
                invoiceGrpBox.Hide();
                adminInvoiceGrpBox.Hide();
                accLoginGrpBox.Hide();
                accGrpBox.Hide();

                //changes accept button to add customer for ease of accces
                this.AcceptButton = btn_addCust;

                //links Customers datatable to datagrid
                dgvcust.DataSource = context.Customers.ToList();

                //customizes column width to present data nicely
                dgvcust.Columns[0].Width = 30;
                dgvcust.Columns[1].Width = 100;
                dgvcust.Columns[2].Width = 100;
                dgvcust.Columns[3].Width = 50;
                dgvcust.Columns[4].Width = 80;
                dgvcust.Columns[5].Width = 100;
                dgvcust.Columns[6].Width = 150;
                dgvcust.Columns[7].Width = 100;
                dgvcust.Columns[8].Width = 75;

            }
            //when edit products node under admin operations is selected, do the following:
            if (treeView1.SelectedNode.Name == "editProd")
            {
                //makes sure to hide every other groupbox other than the one needed
                adminCustGrpBox.Hide();
                adminProdGrpBox.Show();
                prodGrpBox.Hide();
                cartGrpBox.Hide();
                invoiceGrpBox.Hide();
                adminInvoiceGrpBox.Hide();
                accLoginGrpBox.Hide();
                accGrpBox.Hide();

                //changes accept button to add product for ease of accces
                this.AcceptButton = btn_addProd;

                //links Products datatable to datagrid
                dgvprod.DataSource = context.Products.ToList();
            }
            //when run report node under admin operations -> manage invoices is selected, do the following:
            if (treeView1.SelectedNode.Name == "invoiceReport")
            {
                //makes sure to hide every other groupbox other than the one needed
                adminCustGrpBox.Hide();
                adminProdGrpBox.Hide();
                prodGrpBox.Hide();
                cartGrpBox.Hide();
                invoiceGrpBox.Hide();
                adminInvoiceGrpBox.Show();
                accLoginGrpBox.Hide();
                accGrpBox.Hide();

                //nothing here to utilize accept button
                this.AcceptButton = null;

                //links Invoices datatable to datagrid
                dgvAdminInvoice.DataSource = context.Invoices.ToList();
            }
            //when products node is selected, do the following:
            if (treeView1.SelectedNode.Name == "products")
            {
                //makes sure to hide every other groupbox other than the one needed
                adminCustGrpBox.Hide();
                adminProdGrpBox.Hide();
                prodGrpBox.Show();
                cartGrpBox.Hide();
                invoiceGrpBox.Hide();
                adminInvoiceGrpBox.Hide();
                accLoginGrpBox.Hide();
                accGrpBox.Hide();

                //changes accept button to checkout for ease of accces
                this.AcceptButton = btn_checkOut;

                //links Products datatable to datagrid
                dgvCustProd.DataSource = context.Products.ToList();
            }
            //when invoices node is selected, do the following:
            if (treeView1.SelectedNode.Name == "invoices")
            {
                //makes sure to hide every other groupbox other than the one needed
                adminCustGrpBox.Hide();
                adminProdGrpBox.Hide();
                prodGrpBox.Hide();
                cartGrpBox.Hide();
                invoiceGrpBox.Show();
                adminInvoiceGrpBox.Hide();
                accLoginGrpBox.Hide();
                accGrpBox.Hide();

                //nothing here to utilize accept button
                this.AcceptButton = null;

                //comboBox is set to All invoices before user changes anything
                comboBox_Dates.SelectedIndex = 0;

                //gets list of customer invoices that pertain to that customer
                var custInvoices = from invoices in context.Invoices
                                   where invoices.CustomerId == userID
                                   select invoices;

                //links custInvoices query to datagrid
                dgvinvoices.DataSource = custInvoices.ToList();
            }
            //when invoices node is selected, do the following:
            if (treeView1.SelectedNode.Name == "editAccount")
            {
                //makes sure to hide every other groupbox other than the one needed
                adminCustGrpBox.Hide();
                adminProdGrpBox.Hide();
                prodGrpBox.Hide();
                cartGrpBox.Hide();
                invoiceGrpBox.Hide();
                adminInvoiceGrpBox.Hide();
                accLoginGrpBox.Show();
                lbl_passError.Hide();

                txtBox_confPass.Text = "";

                //changes accept button to login for ease of accces
                this.AcceptButton = btn_accLogin;

                //if user is not an admin (via -1), they are able to edit their accounts
                if (userID != -1)
                {
                    Customers customer = context.Customers.Find(userID);

                    lbl_login.Text = "Please re-enter the password for user\n" + customer.Username;
                }
                //if user IS an admin, they are NOT able to edit their accounts
                else
                {
                    lbl_login.Text = "You cannot edit this administrative account.";
                    //Cannot login when buttons are hidden
                    btn_accLogin.Hide();
                    txtBox_confPass.Hide();
                }
            }
        }

        //method to fetch user information for the manage account page
        private void fetchUser()
        {
            Customers customer = context.Customers.Find(userID);

            if (customer == null)
            {
                MessageBox.Show($"No customer with ID {userID}. Please contact administration.", "Error");
            }
            else
            {
                //sets textbox fields to current customer data
                txtBox_accUsername.Text = customer.Username;
                txtBox_accFName.Text = customer.Fname;
                txtBox_accLName.Text = customer.Lname;
                txtBox_accEmail.Text = customer.Email;
                txtBox_accPhone.Text = customer.Phone;
                txtBox_accNewPass1.Text = "";
                txtBox_accNewPass2.Text = "";
            }
        }

        //when a datagrid cell from edit customers node in admin operations is clicked, do the following:
        private void dgvcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customers selectedCustomer = null;

            //these are where the modify and delete buttons are located at in the datagrid
            const int ModifyIndex = 9;
            const int DeleteIndex = 10;

            //checks if cell clicked was a modify button
            if (e.ColumnIndex == ModifyIndex)
            {
                //grabs the id of the customer in the row that the modify button was clicked in
                int customerID = (int)dgvcust.Rows[e.RowIndex].Cells[0].Value;

                //opens a new EditCustomerForm where the admin can edit the customer
                EditCustomerForm f = new EditCustomerForm(customerID);
                f.Show();
            }
            //checks if cell clicked was a delete button
            else if (e.ColumnIndex == DeleteIndex)
            {
                //grabs the id of the customer in the row that the delete button was clicked in
                int customerID = (int)dgvcust.Rows[e.RowIndex].Cells[0].Value;
                selectedCustomer = context.Customers.Find(customerID);

                //if that customer exists
                if (selectedCustomer != null)
                {
                    //asks if delete was intentional
                    var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedCustomer.Fname}?\nTheir invoices will be deleted too", "Confirm Delete", MessageBoxButtons.YesNoCancel);

                    //if yes, delete customer and their invoices
                    if (confirmResult == DialogResult.Yes)
                    {
                        context.Customers.Remove(selectedCustomer);
                        var removeInvoice = context.Invoices.Find(selectedCustomer.Id);
                        context.Invoices.Remove(removeInvoice);

                        MessageBox.Show("Customer deleted successfully", "Success");
                    }
                }
            }
            //saves changes to the database
            context.SaveChanges();
            dgvcust.DataSource = context.Customers.ToList();
        }

        //when add customer button located in admin operations -> edit customers node is clicked:
        private void btn_addCust_Click(object sender, EventArgs e)
        {
            //create new form where admin can add new customers
            AddCustomerForm f = new AddCustomerForm();
            f.Show();
        }

        //when a datagrid cell from edit products node in admin operations is clicked, do the following:
        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Products selectedProduct = null;

            //these are where the modify and delete buttons are located at in the datagrid
            const int ModifyIndex = 5;
            const int DeleteIndex = 6;

            //checks if cell clicked was a modify button
            if (e.ColumnIndex == ModifyIndex)
            {
                //grabs the id of the product in the row that the modify button was clicked in
                int productID = (int)dgvprod.Rows[e.RowIndex].Cells[0].Value;

                //opens a new EditProductForm where the admin can edit the product
                EditProductForm f = new EditProductForm(productID);
                f.Show();
            }
            //checks if cell clicked was a delete button
            else if (e.ColumnIndex == DeleteIndex)
            {
                //grabs the id of the product in the row that the delete button was clicked in
                int productID = (int)dgvprod.Rows[e.RowIndex].Cells[0].Value;
                selectedProduct = context.Products.Find(productID);

                //if product exists
                if (selectedProduct != null)
                {
                    //asks if delete was intentional
                    var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedProduct.Name}?", "Confirm Delete", MessageBoxButtons.YesNoCancel);

                    //if yes, delete
                    if (confirmResult == DialogResult.Yes)
                    {
                        context.Products.Remove(selectedProduct);
                        MessageBox.Show("Product deleted successfully", "Success");
                    }
                }
            }
            //saves changes to database
            context.SaveChanges();
            dgvprod.DataSource = context.Products.ToList();
        }

        //when add product button located in admin operations -> edit products node is clicked:
        private void btn_addProd_Click(object sender, EventArgs e)
        {
            //create new form where admin can add new products
            AddProductForm f = new AddProductForm();
            f.Show();
        }

        //when exit button is clicked, exit applicatoin
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //when refresh button is clicked, assign context to a new ShopEasyContext
        //this is to update the context in case any changes have occured in the database
        //links to datagrid so it displays the new changes
        //this is located in admin operations -> edit customers
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            context = new ShopEasyContext();
            dgvcust.DataSource = context.Customers.ToList();
        }

        //also a refresh button with same functionality
        //it is located in admin operations -> edit products
        private void btn_prodRefresh_Click(object sender, EventArgs e)
        {
            context = new ShopEasyContext();
            dgvprod.DataSource = context.Products.ToList();
        }

        //when text is entered into search bar located in Products, do the following:
        private void txtBox_prodSearch_TextChanged(object sender, EventArgs e)
        {
            //query of all products containing any search term entered within the name, type, or id
            var prodSearch = from prod in context.Products
                             where prod.Name.Contains(txtBox_prodSearch.Text)
                             || prod.Type.Contains(txtBox_prodSearch.Text)
                             || prod.Id.ToString().Contains(txtBox_prodSearch.Text)
                             select prod;

            //links the datagrid to the matching query of products
            dgvCustProd.DataSource = prodSearch.ToList();
        }

        //when text is entered into search bar located in admin operations -> edit customers, do the following:
        private void txtBox_searchCust_TextChanged(object sender, EventArgs e)
        {
            int idSearch = 0;

            //try to parse text as int to search for id
            try
            {
                idSearch = int.Parse(txtBox_searchCust.Text);
            }
            catch (Exception ex)
            {
            }

            //query of all customers containing any search term entered within
            //first name, last name, id, email, phone, or type
            var custSearch = from cust in context.Customers
                             where cust.Fname.Contains(txtBox_searchCust.Text)
                             || cust.Lname.Contains(txtBox_searchCust.Text)
                             || cust.Id == idSearch
                             || cust.Email.Contains(txtBox_searchCust.Text)
                             || cust.Phone.Contains(txtBox_searchCust.Text)
                             || cust.Type.Contains(txtBox_searchCust.Text)
                             select cust;

            //links the datagrid to the matching query of customers
            dgvcust.DataSource = custSearch.ToList();
        }

        //same search functionality as previous product search
        //this is located in admin operations -> edit products
        private void txtBox_searchProd_TextChanged(object sender, EventArgs e)
        {
            var prodSearch = from prod in context.Products
                             where prod.Name.Contains(txtBox_searchProd.Text)
                             || prod.Type.Contains(txtBox_searchProd.Text)
                             || prod.Id.ToString().Contains(txtBox_searchProd.Text)
                             select prod;

            dgvprod.DataSource = prodSearch.ToList();
        }

        //when a datagrid cell from products node is clicked, do the following:
        private void dgvCustProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if user is admin (via -1), deny the ability to shop
            if (userID == -1)
            {
                MessageBox.Show("Admins cannot shop on the job.");
            }
            //if user is a customer:
            else
            {
                Products selectedProduct;

                //this is where the add to cart button is located at in the datagrid
                const int AddtoCartIndex = 5;

                //checks if cell clicked was an add to cart button
                if (e.ColumnIndex == AddtoCartIndex)
                {
                    //grabs the id of the product in the row that the modify button was clicked in
                    int productID = (int)dgvCustProd.Rows[e.RowIndex].Cells[0].Value;
                    selectedProduct = context.Products.Find(productID);

                    //fills in the next available slot in cart array
                    for (int i = 0; i < cart.Length; i++)
                    {
                        //if product quantity is 0, user cannot add to cart
                        if (selectedProduct.Quantity == 0)
                        {
                            MessageBox.Show("Out of stock; product was not added to cart", "Error");
                            break;
                        }
                        //if current cart slot is empty, add product to that cart slot
                        if (cart[i] == null)
                        {
                            cart[i] = selectedProduct;

                            //informs user of success
                            MessageBox.Show("Product added to cart.", "Success");

                            //decrements product quantity that was just added to cart, as if it were taking it off the shelf
                            selectedProduct.Quantity = selectedProduct.Quantity - 1;
                            context.Products.Update(selectedProduct);
                            context.SaveChanges();

                            break;
                        }
                        //cart is limited to 100 slots
                        else if (i == cart.Length - 1)
                        {
                            MessageBox.Show("Cart limit reached; product was not added to cart", "Error");
                        }
                    }
                }
                dgvCustProd.DataSource = context.Products.ToList();
            }
        }

        //when checkout button located in products node is clicked: 
        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            //if user is admin (via -1), deny shopping privileges
            if (userID == -1)
            {
                MessageBox.Show("Admins cannot checkout.");
            }
            //if user is customer:
            else
            {
                //hide the products list and open up their cart
                prodGrpBox.Hide();
                cartGrpBox.Show();

                //changes accept button to confirm check out for ease of access
                this.AcceptButton = btn_confirm;
                //changes cancel button to continue shopping button for ease of access
                this.CancelButton = btn_cartBack;

                Customers custUser = context.Customers.Find(userID);

                //Welcome message including user's first and last name
                lbl_customer.Text = "Hello, " + custUser.Fname + " " + custUser.Lname;

                Decimal totalPrice = 0;
                Decimal salesTaxCost = 0;

                lbl_cartList.Text = "";

                //displays every item in cart and their cost
                foreach (var item in cart)
                {
                    //if item does not exist, exit loop
                    if (item == null)
                        break;
                    //adds item name to the text
                    lbl_cartList.Text += "\n" + item.Name;
                    //adds item cost to the text
                    lbl_cartList.Text += "     $" + item.Price;
                    //if a teacher is checking out a book
                    if (item.Type == "book" && custUser.Type == "teacher")
                    {
                        //add a 10% discount to only the book
                        decimal teacherDiscount = Math.Round(item.Price * (Decimal)0.10, 2);
                        lbl_cartList.Text += "\n10% teacher discount: - $" + teacherDiscount;
                        totalPrice += item.Price - teacherDiscount;
                    }
                    //if not a teacher checking out a book, add regular price to total
                    else
                    {
                        totalPrice += item.Price;
                    }
                }
                //if the customer is regular or a teacher, add 5.5% sales tax to total
                if (custUser.Type == "default" || custUser.Type == "teacher")
                {
                    salesTaxCost = totalPrice * (Decimal)0.055;
                    lbl_cartList.Text += "\n\n\n5.5% Sales Tax: + $" + Math.Round(salesTaxCost, 2);
                    totalPrice += salesTaxCost;
                }
                //if customer is senior, add a 5% discount to total
                else if (custUser.Type == "senior")
                {
                    decimal seniorDiscount = totalPrice * (Decimal)0.05;
                    lbl_cartList.Text += "\n\n\n5% Senior Discount: - $" + Math.Round(seniorDiscount, 2);
                    totalPrice -= seniorDiscount;
                }
                //if customer is a veteran, add a 10% discount to total
                else if (custUser.Type == "veteran")
                {
                    decimal vetDiscount = totalPrice * (Decimal)0.10;
                    lbl_cartList.Text += "\n\n\n10% Veteran Discount: - $" + Math.Round(vetDiscount, 2);
                    totalPrice -= vetDiscount;
                }

                //displays total cost in a big font on the right side
                lbl_cartList.Text += "\nTotal Cost: " + Math.Round(totalPrice, 2);
                lbl_totalCost.Text = Math.Round(totalPrice, 2).ToString();
            }
        }

        //when continue shopping button is clicked, hide cart and show the products list
        private void btn_cartBack_Click(object sender, EventArgs e)
        {
            prodGrpBox.Show();
            cartGrpBox.Hide();
            //changes accept button back to checkout
            this.AcceptButton = btn_checkOut;
            this.CancelButton = null;
        }

        //when clear cart is clicked, do the following:
        private void btn_clearCart_Click(object sender, EventArgs e)
        {
            //asks if cart clear is intentional
            var confirmResult = MessageBox.Show("Are you sure you want to clear your cart? This cannot be undone", "Clear Cart?", MessageBoxButtons.YesNoCancel);

            //if yes, clear cart
            if (confirmResult == DialogResult.Yes)
            {
                //cart list becomes empty again
                lbl_cartList.Text = "";
                
                //iterates through the cart array to clear it and increments products that were taken off the shelf
                for (int i = 0; i < cart.Length; i++)
                {
                    if (cart[i] == null)
                        break;
                    cart[i].Quantity += 1;
                    cart[i] = null;
                }
                lbl_totalCost.Text = "";
                //saves to database
                context.SaveChanges();
            }
        }

        //when confirm checkout button is clicked, create new invoice
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //changes accept button back to checkout
            this.AcceptButton = btn_checkOut;
            this.CancelButton = null;

            //fills in gaps in invoice ids; aims to add invoice to next available id
            int x = 1;
            while (context.Invoices.Find(x) != null)
            {
                x++;
            }
            int invoiceID = x;

            //counts number of products in cart
            int numProducts = 0;
            foreach (var item in cart)
            {
                if (item == null)
                    break;
                cart[numProducts] = null;
                numProducts++;
            }

            //creates new invoice with cart info
            var newInvoice = new Invoices
            {
                Id = invoiceID,
                CustomerId = userID,
                Date = DateTime.Now,
                Products = numProducts,
                Cost = decimal.Parse(lbl_totalCost.Text)
            };

            //add new invoice
            context.Invoices.Add(newInvoice);

            //save to database
            context.SaveChanges();

            //informs user of success
            MessageBox.Show("Item(s) successfully purchased! Invoice has been generated. Thank you for your service.", "Success");

            //switches back to product listing
            prodGrpBox.Show();
            cartGrpBox.Hide();
        }

        //when the value of the combobox located in invoices node is changed,
        //run a meaningful query to mirror what was selected
        private void comboBox_Dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when all invoices is selected, display all invoices pertaining to the customer
            DateTime date = DateTime.Today;
            var timeSearch = from time in context.Invoices
                             where time.CustomerId == userID
                             select time;

            //when past month is selected, display all invoices from the past month pertaining to the customer
            if (comboBox_Dates.SelectedIndex == 1)
            {
                timeSearch = from time in context.Invoices
                             where ((date.Year - time.Date.Year) * 12) + date.Month - time.Date.Month <= 1
                             && time.CustomerId == userID
                             select time;
            }
            //when past 3 months is selected, display all invoices from the past 3 months pertaining to the customer
            else if (comboBox_Dates.SelectedIndex == 2)
            {
                timeSearch = from time in context.Invoices
                             where ((date.Year - time.Date.Year) * 12) + date.Month - time.Date.Month <= 3
                             && time.CustomerId == userID
                             select time;
            }
            //when past 6 months is selected, display all invoices from the past 6 months pertaining to the customer
            else if (comboBox_Dates.SelectedIndex == 3)
            {
                timeSearch = from time in context.Invoices
                             where ((date.Year - time.Date.Year) * 12) + date.Month - time.Date.Month <= 6
                             && time.CustomerId == userID
                             select time;
            }
            //when past academic year is selected, display all invoices from the past academic year (9 months) pertaining to the customer
            else if (comboBox_Dates.SelectedIndex == 4)
            {
                timeSearch = from time in context.Invoices
                             where ((date.Year - time.Date.Year) * 12) + date.Month - time.Date.Month <= 9
                             && time.CustomerId == userID
                             select time;
            }
            //links datagrid to query
            dgvinvoices.DataSource = timeSearch.ToList();
        }

        //when reset info button is clicked, reset all the changed information to what is in the database
        private void btn_accClear_Click(object sender, EventArgs e)
        {
            Customers customer = context.Customers.Find(userID);

            txtBox_accUsername.Text = customer.Username;
            txtBox_accFName.Text = customer.Fname;
            txtBox_accLName.Text = customer.Lname;
            txtBox_accEmail.Text = customer.Email;
            txtBox_accPhone.Text = customer.Phone;

            txtBox_accNewPass1.Text = "";
            txtBox_accNewPass2.Text = "";
        }

        //when apply changes button is clicked, update customer to data entered
        private void btn_apply_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btn_accLogin;
            this.CancelButton = null;

            Boolean error = false;

            //query to grab all users with the same username
            var user = from users in context.Customers
                       where users.Username.Equals(txtBox_accUsername.Text)
                       select users;

            //if the query has more than one entry,
            //show error in which username is already taken
            if (user.SingleOrDefault() != null)
            {
                lbl_usernameError.Text = "Error: Username already taken";
                lbl_usernameError.Show();
                error = true;
            }
            //if the username field is empty,
            //show error asking to enter a username
            if (txtBox_accUsername.Text == "")
            {
                lbl_usernameError.Text = "Error: Please enter a username";
                lbl_usernameError.Show();
                error = true;
            }
            //if the password field is empty,
            //show error asking to enter a password
            if (txtBox_accNewPass1.Text == "")
            {
                lbl_newPassError.Text = "Error: Please enter a password";
                lbl_newPassError.Show();
                error = true;
            }
            //if both password fields do not match,
            //show error informing user the passwords do not match
            if (!txtBox_accNewPass1.Text.Equals(txtBox_accNewPass2.Text))
            {
                lbl_newPassError.Text = "Error: Passwords do not match";
                lbl_newPassError.Show();
                error = true;
            }
            //if first name field is empty,
            //show error asking to enter a first name
            if (txtBox_accFName.Text == "")
            {
                lbl_nameError.Text = "Error: Please enter a first name";
                lbl_nameError.Show();
                error = true;
            }
            //if last name field is empty,
            //show error asking to enter a last name
            if (txtBox_accLName.Text == "")
            {
                lbl_nameError.Text = "Error: Please enter a last name";
                lbl_nameError.Show();
                error = true;
            }
            //if the phone length is greater than 10,
            //inform user to enter a phone number of length 10
            if (txtBox_accPhone.Text.Length != 10)
            {
                lbl_newPhoneError.Show();
                error = true;
            }
            //if there were no errors, update customer with new information
            if (!error)
            {
                lbl_newPassError.Hide();
                lbl_newPhoneError.Hide();
                lbl_usernameError.Hide();
                lbl_nameError.Hide();

                Customers customer = context.Customers.Find(userID);

                customer.Username = txtBox_accUsername.Text;
                customer.Password = txtBox_accNewPass1.Text;
                customer.Fname = txtBox_accFName.Text;
                customer.Lname = txtBox_accLName.Text;
                customer.Email = txtBox_accEmail.Text;
                customer.Phone = txtBox_accPhone.Text;

                //update customer and save changes to database
                context.Customers.Update(customer);
                context.SaveChanges();

                //informs customer of success
                MessageBox.Show("Successfully updated information.", "Success");

                lbl_login.Text = "Please re-enter the password for user\n" + customer.Username;
                txtBox_confPass.Text = "";

                //logs out customer from manage account for security reasons
                accGrpBox.Hide();
                accLoginGrpBox.Show();
            }
        }

        private void btn_accLogin_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btn_apply;
            this.CancelButton = null;

            Customers customer = context.Customers.Find(userID);
            if (txtBox_confPass.Text == "")
            {
                lbl_passError.Show();
            }
            else if (customer.Password.Equals(txtBox_confPass.Text))
            {
                accLoginGrpBox.Hide();
                accGrpBox.Show();
                lbl_newPassError.Hide();
                lbl_newPhoneError.Hide();
                lbl_usernameError.Hide();
                lbl_passError.Hide();
                lbl_nameError.Hide();

                fetchUser();
            }
            else
            {
                lbl_passError.Show();
            }
        }
    }
}
