using ShopEasy.Models.DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class EditCustomerForm : Form
    {
        ShopEasyContext context = new ShopEasyContext();

        private int custID;
        public EditCustomerForm(int custID)
        {
            InitializeComponent();

            this.custID = custID;

            //changes accept button to edit for ease of accces
            this.AcceptButton = btn_editCustForm;
            //changes cancel button to cancel for ease of accces
            this.CancelButton = btn_cancelCustForm;
            //populates fields with customer related information
            fetchCust();
        }
        
        //when edit button is clicked
        private void btn_editCustForm_Click(object sender, EventArgs e)
        {
            String accountType;

            //checks for which radio button is checked. Assigns value to accountType accordingly
            if (radio_accountReg.Checked)
            {
                accountType = "default";
            }
            else if (radio_accountTeach.Checked)
            {
                accountType = "teacher";
            }
            else if (radio_accountSenior.Checked)
            {
                accountType = "senior";
            }
            else
                accountType = "veteran";

            var customer = context.Customers.Find(custID);

            //changes customer data to match new data in textbox fields and radio button
            customer.Fname = txtBox_fName.Text;
            customer.Lname = txtBox_lName.Text;
            customer.Email = txtBox_email.Text;
            customer.Type = accountType;

            //validates phone number length
            if (txtBox_phone.Text.Length != 10)
            {
                MessageBox.Show("Please enter a 10 digit phone number.");
            }
            //if phone number passes validation, changes customer phone number and saves all data to database
            else
            {
                customer.Phone = txtBox_phone.Text;
                context.Customers.Update(customer);
                context.SaveChanges();
                MessageBox.Show("Customer edited successfully", "Success");
                //closes form to go back to edit customers page
                Close();
            }
        }

        //closes form when cancel button is clicked
        private void btn_cancelCustForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        //populates form with existing customer data
        private void fetchCust()
        {
            Customers customer = context.Customers.Find(custID);

            if (customer == null)
            {
                MessageBox.Show($"No customer with ID {custID}", "Error");
            }
            else
            {
                txtBox_ID.Text = customer.Id.ToString();
                txtBox_Username.Text = customer.Username;
                txtBox_fName.Text = customer.Fname;
                txtBox_lName.Text = customer.Lname;
                txtBox_email.Text = customer.Email;
                txtBox_phone.Text = customer.Phone;

                //checks correct radio button according to accountType
                if (customer.Type == "default")
                {
                    radio_accountReg.Checked = true;
                }
                else if (customer.Type == "teacher")
                {
                    radio_accountTeach.Checked = true;
                }
                else if (customer.Type == "senior")
                {
                    radio_accountSenior.Checked = true;
                }
                else
                {
                    radio_accountVet.Checked = true;
                }
            }
        }
    }
}
