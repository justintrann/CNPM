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
    class TransactionsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Insert_Transaction(TransactionsBLL t, out int transactionID)
        {
            //Create a boolean value and set its default value to false
            bool isSuccess = false;
            //Set the out transactionID value to negative 1 i.e. -1
            transactionID = -1;
            //Create a SqlConnection first
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL Query to Insert Transactions
                string sql = "INSERT INTO purchase_bill (id_staff, id_customer, date_of_purchase, purchase_bill_desc, total_cost) VALUES (@id_staff, @id_customer, @date_of_purchase, @purchase_bill_desc, @total_cost); SELECT @@IDENTITY;";

                //Sql Commandto pass the value in sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the value to sql query using cmd
                cmd.Parameters.AddWithValue("@id_staff", t.id_staff);
                cmd.Parameters.AddWithValue("@id_customer", t.id_customer);
                cmd.Parameters.AddWithValue("@date_of_purchase", t.date_of_purchase);
                cmd.Parameters.AddWithValue("@purchase_bill_desc", t.purchase_bill_desc);
                cmd.Parameters.AddWithValue("@total_cost", t.total_cost);

                //Open Database Connection
                conn.Open();

                //Execute the Query
                object o = cmd.ExecuteScalar();

                //If the query is executed successfully then the value will not be null else it will be null
                if (o != null)
                {
                    //Query Executed Successfully
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else
                {
                    //failed to execute query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the connection 
                conn.Close();
            }

            return isSuccess;
        }

        public TransactionsBLL getid()
        {
            //First Create an Object of DeaCust BLL and REturn it
            TransactionsBLL t = new TransactionsBLL();

            //SQL Conection here
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Data TAble to Holdthe data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "select id from purchase_bill where id=@@identity";
                //Create the SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                //Passing the CAlue from Adapter to DAtatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    t.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return t;
        }
    }
}
