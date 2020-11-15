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
                    p.price = decimal.Parse(dt.Rows[0]["price"].ToString());
                    p.quantity = decimal.Parse(dt.Rows[0]["quantity"].ToString());
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


    }
}
