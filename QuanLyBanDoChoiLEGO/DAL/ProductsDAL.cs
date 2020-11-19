using QuanLyBanDoChoiLEGO.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO.DAL
{
    class ProductsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public ProductsBLL GetProductsForTransaction(string keyword)
        {
            //Create an object of ProductsBLL and return it
            ProductsBLL p = new ProductsBLL();
            //SqlConnection
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Datatable to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write the Query to Get the detaisl
                string sql = "SELECT product_name, price, quantity FROM product WHERE id LIKE '%" + keyword + "%' OR product_name LIKE '%" + keyword + "%'";
                //Create Sql Data Adapter to Execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //Open DAtabase Connection
                conn.Open();

                //Pass the value from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to ProductsBLL
                if (dt.Rows.Count > 0)
                {
                    p.product_name = dt.Rows[0]["product_name"].ToString();
                    p.price = float.Parse(dt.Rows[0]["price"].ToString());
                    p.quantity = int.Parse(dt.Rows[0]["quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return p;
        }

        public ProductsBLL GetProductIDFromName(string ProductName)
        {
            //First Create an Object of DeaCust BLL and REturn it
            ProductsBLL p = new ProductsBLL();

            //SQL Conection here
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Data TAble to Holdthe data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "SELECT id FROM product WHERE product_name='" + ProductName + "'";
                //Create the SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                //Passing the CAlue from Adapter to DAtatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return p;
        }

        #region METHOD TO GET CURRENT QUantity from the Database based on Product ID
        public int GetProductQty(int ProductID)
        {
            //SQl Connection First
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Create a Decimal Variable and set its default value to 0
            int quantity = 0;

            //Create Data Table to save the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write WQL Query to Get Quantity from Database
                string sql = "SELECT quantity FROM product WHERE id = " + ProductID;

                //Cerate A SqlCommand
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create a SQL Data Adapter to Execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open DAtabase Connection
                conn.Open();

                //PAss the calue from Data Adapter to DataTable
                adapter.Fill(dt);

                //Lets check if the datatable has value or not
                if (dt.Rows.Count > 0)
                {
                    quantity = int.Parse(dt.Rows[0]["quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return quantity;
        }
        #endregion
        #region METHOD TO UPDATE QUANTITY
        public bool UpdateQuantity(int ProductID, int Qty)
        {
            //Create a Boolean Variable and Set its value to false
            bool success = false;

            //SQl Connection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write the SQL Query to Update Qty
                string sql = "UPDATE product SET quantity=@quantity WHERE id=@id";

                //Create SQL Command to Pass the calue into Queyr
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the VAlue trhough parameters
                cmd.Parameters.AddWithValue("@quantity", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);

                //Open Database Connection
                conn.Open();

                //Create Int Variable and Check whether the query is executed Successfully or not
                int rows = cmd.ExecuteNonQuery();
                //Lets check if the query is executed Successfully or not
                if (rows > 0)
                {
                    //Query Executed Successfully
                    success = true;
                }
                else
                {
                    //Failed to Execute Query
                    success = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion
        #region METHOD TO DECREASE PRODUCT
        public bool DecreaseProduct(int ProductID, int Qty)
        {
            //Create Boolean Variable and SEt its Value to false
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Get the Current product Quantity
                int currentQty = GetProductQty(ProductID);

                //Decrease the Product Quantity based on product sales
                int NewQty = currentQty - Qty;

                //Update Product in Database
                success = UpdateQuantity(ProductID, NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion
    }
}
