using ShopEasy.Models.DataLayer;
using System;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class AddProductForm : Form
    {
        ShopEasyContext context = new ShopEasyContext();
        public AddProductForm()
        {
            InitializeComponent();
            //changes accept button to add product button for ease of accces
            this.AcceptButton = btn_addProd;
            //changes cancel button to cancel for ease of accces
            this.CancelButton = btn_cancelProd;

            //fills in gaps in product ids; aims to add product to next available id
            int x = 1;
            while (context.Products.Find(x) != null)
            {
                x++;
            }
            int numProd = x;
            txtBox_idProd.Text = numProd.ToString();
        }

        //when add product button is clicked: 
        private void btn_addProd_Click(object sender, EventArgs e)
        {
            String prodType;

            //sets prodType to correct value based on radio button
            if (radio_groceries.Checked)
            {
                prodType = "grocery";
            }
            else if (radio_clothes.Checked)
            {
                prodType = "clothing";
            }
            else if (radio_books.Checked)
            {
                prodType = "book";
            }
            else
                prodType = "instrument";

            decimal newPrice = Convert.ToDecimal(txtBox_priceProd.Text);

            //creates new product with entered information
            var product = new Products
            {
                Id = int.Parse(txtBox_idProd.Text),
                Name = txtBox_nameProd.Text,
                Price = newPrice,
                Quantity = (int)num_quantityProd.Value,
                Type = prodType
            };

            //adds product and saves database
            context.Products.Add(product);
            context.SaveChanges();

            //informs user of success and closes form
            MessageBox.Show("Product added successfully");
            Close();
        }

        //when cancel button is clicked, close form
        private void btn_cancelProd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
