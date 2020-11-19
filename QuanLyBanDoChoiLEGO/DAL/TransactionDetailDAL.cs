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
    class TransactionDetailDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool InsertTransactionDetail(TransactionDetailBLL td)
        {
            //Create a boolean value and set its default value to false
            bool isSuccess = false;

            //Create a database connection here
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql Query to Insert Transaction detais
                string sql = "INSERT INTO purchase_bill_detail (id_product, cost, quantity,tt_cost) VALUES (@id_product, @cost, @quantity, @tt_cost)";

                //Passing the value to the SQL Query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@id_product", td.id_product);
                cmd.Parameters.AddWithValue("@cost", td.cost);
                cmd.Parameters.AddWithValue("@quantity", td.quantity);
                cmd.Parameters.AddWithValue("@tt_cost", td.tt_cost);

                //Open Database connection
                conn.Open();

                //declare the int variable and execute the query
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Query
                    isSuccess = false;
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
            return isSuccess;
        }


    }
}
