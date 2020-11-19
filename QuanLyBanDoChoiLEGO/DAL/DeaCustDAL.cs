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
    class DeaCustDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DataTble to hold the value from database and return it
            DataTable dt = new DataTable();

            try
            {
                //Write SQL Query t Select all the DAta from dAtabase
                string sql = "SELECT * FROM CUSTOMER";
                //Creating SQL Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creting SQL Data Adapter to Store Data From Database Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();
                //Passign the value from SQL Data Adapter to DAta table
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DeaCustBLL SearchDealerCustomerForTransaction(string keyword)
        {
            //Create an object for DeaCustBLL class
            DeaCustBLL dc = new DeaCustBLL();

            //Create a DAtabase Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a DAta Table to hold the value temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write a SQL Query to Search Dealer or Customer Based on Keywords
                string sql = "SELECT customer_name, phone_number, date_of_birth, home_address from CUSTOMER WHERE id LIKE '%" + keyword + "%' OR customer_name LIKE N'%" + keyword + "%'";

                //Create a Sql Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //Open the DAtabase Connection
                conn.Open();

                //Transfer the data from SqlData Adapter to DAta Table
                adapter.Fill(dt);

                //If we have values on dt we need to save it in dealerCustomer BLL
                if (dt.Rows.Count > 0)
                {
                    //dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                    dc.customer_name = dt.Rows[0]["customer_name"].ToString();
                    dc.phone_number = dt.Rows[0]["phone_number"].ToString();
                    dc.date_of_birth = dt.Rows[0]["date_of_birth"].ToString();
                    dc.home_address = dt.Rows[0]["home_address"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }

            return dc;
        }

        public DeaCustBLL GetDeaCustIDFromName(string Name)
        {
            DeaCustBLL dc = new DeaCustBLL();

            //Create a DAtabase Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a DAta Table to hold the value temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "SELECT id FROM customer WHERE customer_name=N'" + Name + "'";
                //Create the SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                //Passing the CAlue from Adapter to DAtatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return dc;
        }
    }

    

}
