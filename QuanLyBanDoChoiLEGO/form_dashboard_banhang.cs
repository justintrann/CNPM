using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanDoChoiLEGO.BLL;
using QuanLyBanDoChoiLEGO.DAL;
using System.Transactions;
using DGVPrinterHelper;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_banhang : Form
    {
        int listViewOffset;
        public static bool is_admin = false;
        public form_dashboard_banhang()
        {
            InitializeComponent();
            listViewOffset = 24;

        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Đơn Thanh Toán")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_customer_information f2 = new form_customer_information();
                f2.Show();
            }
        }
        private int getNewListViewWidth()
        {
            return this.Width / 2 - listViewOffset;
        }



        private int getNewListViewHeight()
        {
            return this.Height - 117;
        }
        DeaCustDAL dcDAL = new DeaCustDAL(); //
        ProductsDAL pDAL = new ProductsDAL(); //
        UserDAL uDAL = new UserDAL(); //
        TransactionsDAL tDAL = new TransactionsDAL(); //
        TransactionDetailDAL tdDAL = new TransactionDetailDAL();

        DataTable transactionDT = new DataTable();
        private void Form_Loading(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PURCHASE_BILL_DETAIL' table. You can move, or remove it, as needed.
            this.pURCHASE_BILL_DETAILTableAdapter.Fill(this.cNPM_NHOM_1DataSet.PURCHASE_BILL_DETAIL);
            //Specify Columns for our TransactionDataTable
            //  transactionDT.Columns.Add("ID");
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Price");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }
        private void txtSearch_textChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                //Clear all the textboxes
                //  txtID.Text = "";
                txtName.Text = "";
                txtDOB.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            //Write the code to get the details and set the value on text boxes
            DeaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

            //Now transfer or set the value from DeCustBLL to textboxes
            txtName.Text = dc.customer_name;
            txtDOB.Text = dc.date_of_birth;
            txtContact.Text = dc.phone_number;
            txtAddress.Text = dc.home_address;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from productsearch textbox
            string keyword = txtSearchProduct.Text;

            //Check if we have value to txtSearchProduct or not
            if (keyword == "")
            {
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                TxtQty.Text = "";
                return;
            }

            //Search the product and display on respective textboxes
            ProductsBLL p = pDAL.GetProductsForTransaction(keyword);

            //Set the values on textboxes based on p object
            txtProductName.Text = p.product_name;
            txtInventory.Text = p.quantity.ToString();
            txtRate.Text = p.price.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Product Name, Rate and Qty customer wants to buy
                string productName = txtProductName.Text;
                float Rate = float.Parse(txtRate.Text);
                int Qty = int.Parse(TxtQty.Text);

                float Total = Rate * Qty; //Total=RatexQty

                //Display the Subtotal in textbox
                //Get the subtotal value from textbox
                float subTotal = float.Parse(txtSubTotal.Text);
                subTotal = subTotal + Total;

                //Check whether the product is selected or not
                if (productName == "")
                {
                    //Display error MEssage
                    MessageBox.Show("Select the product first. Try Again.");
                }
                else
                {
                    //Add product to the dAta Grid View
                    transactionDT.Rows.Add(productName, Rate, Qty, Total);

                    //Show in DAta Grid View
                    dgvAddedProducts.DataSource = transactionDT;
                    //Display the Subtotal in textbox
                    txtSubTotal.Text = subTotal.ToString();

                    //Clear the Textboxes
                    txtSearchProduct.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0.00";
                    txtRate.Text = "0.00";
                    TxtQty.Text = "";
                }
            }
            catch
            {
                string title = "Thông báo";
                string message = "Không thể thực hiện. Lỗi nhập.";
                MessageBox.Show(message, title);
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                TxtQty.Text = "";
            }
        }


        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            /*  //Check if the grandTotal has value or not if it has not value then calculate the discount first
              string check = txtGrandTotal.Text;
              if (check == "")
              {
                  //Deisplay the error message to calcuate discount
                  MessageBox.Show("Calculate the discount and set the Grand Total First.");
              }
              else
              {
                  //Calculate VAT
                  //Getting the VAT Percent first
                  decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                  decimal vat = decimal.Parse(txtVat.Text);
                  decimal grandTotalWithVAT = ((100 + vat) / 100) * previousGT;

                  //Displaying new grand total with vat
                  txtGrandTotal.Text = grandTotalWithVAT.ToString();
              }*/
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text == "")
                {
                    int x = 0;
                    txtPaidAmount.Text = x.ToString();
                }
                else
                {
                    //Get the paid amount and grand total
                    float subTotal = float.Parse(txtSubTotal.Text);
                    float paidAmount = float.Parse(txtPaidAmount.Text);

                    float returnAmount = paidAmount - subTotal;

                    //Display the return amount as well
                    txtReturnAmount.Text = returnAmount.ToString();
                }
            }
            catch
            {
                string title = "Thông báo";
                string message = "Không thể thực hiện. Lỗi nhập.";
                MessageBox.Show(message, title);
                txtPaidAmount.Text = "0";
                txtReturnAmount.Text = "0";

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionsBLL transaction = new TransactionsBLL();
                transaction.purchase_bill_desc = "LEGO";

                //Get the ID of Dealer or Customer Here
                //Lets get name of the dealer or customer first
                string deaCustName = txtName.Text;
                DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

                transaction.id_customer = dc.id;
                transaction.total_cost = Math.Round(float.Parse(txtSubTotal.Text), 2);
                transaction.date_of_purchase = DateTime.Now;

                /*  //Get the Username of Logged in user
                  string username = frmLogin.loggedIn;
                  userBLL u = uDAL.GetIDFromUsername(username);*/

                int userName = form_login.loggedIn;
                transaction.id_staff = userName;
                transaction.transactionDetails = transactionDT;

                //Lets Create a Boolean Variable and set its value to false
                bool success = false;

                //Actual Code to Insert Transaction And Transaction Details
                using (TransactionScope scope = new TransactionScope())
                {
                    int transactionID = -1;
                    //Create aboolean value and insert transaction 
                    bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                    //Use for loop to insert Transaction Details
                    for (int i = 0; i < transactionDT.Rows.Count; i++)
                    {
                        //Get all the details of the product
                        TransactionDetailBLL transactionDetail = new TransactionDetailBLL();
                        //Get the Product name and convert it to id
                        string ProductName = transactionDT.Rows[i][0].ToString();
                        ProductsBLL p = pDAL.GetProductIDFromName(ProductName);

                        transactionDetail.id_product = p.id;
                        transactionDetail.cost = double.Parse(transactionDT.Rows[i][1].ToString());
                        transactionDetail.quantity = int.Parse(transactionDT.Rows[i][2].ToString());
                        transactionDetail.tt_cost = Math.Round(double.Parse(transactionDT.Rows[i][3].ToString()), 2);

                        bool x = false;
                        //Decrease the Product Quntiyt
                        x = pDAL.DecreaseProduct(transactionDetail.id_product, transactionDetail.quantity);

                        //Insert Transaction Details inside the database
                        bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                        success = w && y && x;
                    }
                    //Transaction Complete
                    scope.Complete();

                    //Code to Print Bill


                    MessageBox.Show("Transaction Completed Sucessfully");
                    //Celar the Data Grid View and Clear all the TExtboxes
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtSearchProduct.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    TxtQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";

                    for (int i = 0; i < transactionDT.Rows.Count; i++)
                    {
                        DataRow dr = transactionDT.Rows[i];
                        transactionDT.Rows.Remove(dr);
                    }
                    transactionDT.RejectChanges();

                    this.Controls.Clear();
                    this.InitializeComponent();

                }
            }
            catch
            {
                //Transaction Failed
                MessageBox.Show("Transaction Failed");
                dgvAddedProducts.DataSource = null;
                dgvAddedProducts.Rows.Clear();

                txtSearch.Text = "";
                txtName.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0";
                txtRate.Text = "0";
                TxtQty.Text = "0";
                txtSubTotal.Text = "0";
                txtPaidAmount.Text = "0";
                txtReturnAmount.Text = "0";

                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    DataRow dr = transactionDT.Rows[i];
                    transactionDT.Rows.Remove(dr);
                }
                transactionDT.RejectChanges();

                this.Controls.Clear();
                this.InitializeComponent();
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscount_enter(object sender, EventArgs e)
        {
            //Get the value fro discount textbox
            // string value = txtDiscount.Text;

            /*if (value == "")
            {
                //Display Error Message
                MessageBox.Show("Please Add Discount First");
            }
            else
            {
                //Get the discount in decimal value
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);

                //Calculate the grandtotal based on discount
                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                //Display the GrandTotla in TextBox
                txtGrandTotal.Text = grandTotal.ToString();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPaidAmount.Text = txtSubTotal.Text;
            return;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (TxtQty.Text == "")
            {
                int x = 0;
                TxtQty.Text = x.ToString();
            }
            return;
        }
    }
}
/*
            TransactionsBLL transaction = new TransactionsBLL();
            string deaCustName = txtName.Text;
            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

            transaction.id_customer = dc.id.ToString();
            transaction.total_cost = Math.Round(decimal.Parse(txtSubTotal.Text), 2);
            transaction.date_of_purchase = DateTime.Now;

           // string username = form_login.loggedIn;
           // UserBLL u = uDAL.GetIDFromUsername(username);

            transaction.id_staff = 3;
            transaction.purchase_bill_desc = "LEGO";
            //transaction.transactionDetails = transactionDT;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //Create aboolean value and insert transaction 
                tDAL.Insert_Transaction(transaction, out transactionID);

                //Use for loop to insert Transaction Details
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Get all the details of the product
                    TransactionDetailBLL transactionDetail = new TransactionDetailBLL();
                    //Get the Product name and convert it to id
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    ProductsBLL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.id_product = p.id;
                  //  transactionDetail.qu = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.quantity = int.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.cost = Math.Round(decimal.Parse(transactionDT.Rows[i][2].ToString()), 2);

                    tdDAL.InsertTransactionDetail(transactionDetail);

                }
            }*/