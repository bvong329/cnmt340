using ShopEasy.Models.DataLayer;
using System;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class EditProductForm : Form
    {
        ShopEasyContext context = new ShopEasyContext();

        private int productID;
        public EditProductForm(int productID)
        {
            InitializeComponent();

            this.productID = productID;

            //changes accept button to edit for ease of accces
            this.AcceptButton = btn_editProd;
            //changes delete button to cancel for ease of accces
            this.CancelButton = btn_cancelEditProd;

            //populates fields with product related information
            fetchProduct();
        }

        //when edit button is clicked
        private void btn_editProd_Click(object sender, EventArgs e)
        {
            String prodType;
            decimal newPrice = 0.00M;

            //checks for which radio button is checked. Assigns value to prodType accordingly
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
            else if (radio_tech.Checked)
            {
                prodType = "electronic";
            }
            else
                prodType = "instrument";

            if (txtBox_priceProd.Text != "")
            {
                newPrice = Convert.ToDecimal(txtBox_priceProd.Text);
            }

            //changes customer data to match new data in textbox fields and radio button
            var updateProduct = context.Products.Find(productID);
            updateProduct.Name = txtBox_nameProd.Text;
            updateProduct.Price = newPrice;
            updateProduct.Quantity = (int)num_quantityProd.Value;
            updateProduct.Type = prodType;

            //saves changes to database
            context.Products.Update(updateProduct);
            context.SaveChanges();

            //informs action was successful and closes form
            MessageBox.Show("Product edited successfully");
            Close();
        }

        //when cancel button is clicked, cancel form
        private void btn_cancelProd_Click(object sender, EventArgs e)
        {
            Close();
        }

        //populates form with existing customer data
        private void fetchProduct()
        {
            Products product = context.Products.Find(productID);

            if (product == null)
            {
                MessageBox.Show($"No product with ID {productID}", "Error");
            }
            else
            {
                txtBox_idProd.Text = productID.ToString();
                txtBox_nameProd.Text = product.Name;
                txtBox_priceProd.Text = product.Price.ToString();
                num_quantityProd.Value = (int)product.Quantity;

                //checks correct radio button according to prodType
                if (product.Type == "grocery")
                {
                    radio_groceries.Checked = true;
                }
                else if (product.Type == "book")
                {
                    radio_books.Checked = true;
                }
                else if (product.Type == "electronic")
                {
                    radio_tech.Checked = true;
                }
                else if (product.Type == "clothing")
                {
                    radio_clothes.Checked = true;
                }
                else
                {
                    radio_instrument.Checked = true;
                }

            }
        }
    }
}
