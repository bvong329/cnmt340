using ShopEasy.Models.DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class AddCustomerForm : Form
    {
        ShopEasyContext context = new ShopEasyContext();
        public AddCustomerForm()
        {
            InitializeComponent();

            //changes accept button to add customer button for ease of accces
            this.AcceptButton = btn_addCustForm;
            //changes cancel button to cancel for ease of accces
            this.CancelButton = btn_cancelCustForm;

            //fills in gaps in customer ids; aims to add customers to next available id
            int x = 1;
            while (context.Customers.Find(x) != null)
            {
                x++;
            }
            int numCust = x;

            txtBox_ID.Text = numCust.ToString();
        }
        
        //when add customer button is clicked: 
        private void btn_addCustForm_Click(object sender, EventArgs e)
        {
            String accountType;

            //sets accountType to correct value based on radio button
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
            {
                accountType = "veteran";
            }

            //creates new customer with entered information
            //phone is currently a placeholder before it was validated
            var customer = new Customers
            {
                Id = int.Parse(txtBox_ID.Text),
                Username = txtBox_Username.Text,
                Password = txtBox_Username.Text,
                Fname = txtBox_fName.Text,
                Lname = txtBox_lName.Text,
                Phone = "0000000000",
                Email = txtBox_email.Text,
                Responsible = txtBox_fName.Text,
                Type = accountType
            };

            //validates phone number length to be 10
            if (txtBox_phone.Text.Length != 10)
            {
                MessageBox.Show("Please enter a 10 digit phone number.");
            }
            //if phone passes validation
            else
            {
                //adds new customer to customers datatable
                context.Customers.Add(customer);
                context.SaveChanges();
                //changes phone number from placeholder phone to the entered one
                customer.Phone = txtBox_phone.Text;
                //saves changes to database
                context.Customers.Update(customer);
                context.SaveChanges();
                //informs user of success and closes form
                MessageBox.Show("Customer added successfully", "Success");
                Close();
            }
        }

        //next two events are for a system generated default username and password
        //syntax is first letter of first name, last name, then id number
        //example: john doe with id 1 has username/password of jdoe1
        //these events change the username textbox in realtime as user is entering in information
        private void txtBox_fName_TextChanged(object sender, EventArgs e)
        {
            int numCust = int.Parse(txtBox_ID.Text);
            if (txtBox_fName.Text != "")
                txtBox_Username.Text = txtBox_fName.Text[0] + txtBox_lName.Text + numCust;
            else
                txtBox_Username.Text = txtBox_lName.Text + numCust;
        }

        private void txtBox_lName_TextChanged(object sender, EventArgs e)
        {
            int numCust = int.Parse(txtBox_ID.Text);
            if (txtBox_fName.Text != "")
                txtBox_Username.Text = txtBox_fName.Text[0] + txtBox_lName.Text + numCust;
            else
                txtBox_Username.Text = txtBox_lName.Text + numCust;
        }

        //when cancel button is clicked, close form
        private void btn_cancelCustForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
