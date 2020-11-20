using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_thongke : Form
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public form_dashboard_thongke()
        {
            InitializeComponent();
            NamTextBox.ForeColor = Color.LightGray;
            NamTextBox.Text = "Vui lòng nhập năm";
            this.NamTextBox.Leave += new System.EventHandler(this.NamTextBox_Leave);
            this.NamTextBox.Enter += new System.EventHandler(this.NamTextBox_Enter);

        }

        private void NamTextBox_Leave(object sender, EventArgs e)
        {
            if (NamTextBox.Text == "")
            {
                NamTextBox.Text = "Vui lòng nhập năm";
                NamTextBox.ForeColor = Color.Gray;
            }
        }

        private void NamTextBox_Enter(object sender, EventArgs e)
        {
            if (NamTextBox.Text == "Vui lòng nhập năm")
            {
                NamTextBox.Text = "";
                NamTextBox.ForeColor = Color.Black;
            }
        }


        private void NamTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void thgke_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //dataGridView1.AutoResizeColumns = true;
            
            SqlConnection connection = new SqlConnection(myconnstrng);
            //string query = "select * from purchase_bill where year(date_of_purchase) = @nam and month(date_of_purchase) = @thang";
           // string query = "select month(date_of_purchase) as 'Thang', sum(total_cost) as Sum from purchase_bill where year(date_of_purchase) = @nam and month(date_of_purchase) = @thang group by date_of_purchase, total_cost";
            string query = "select month(date_of_purchase) as Thang, sum(total_cost) as Sum from purchase_bill where year(date_of_purchase) = @nam group by month(date_of_purchase)";


            //SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@nam", nam);
            // SqlDataAdapter da = new SqlDataAdapter(command);

            

            connection.Open();
           
            int nam;
            
            bool nam_succeed = Int32.TryParse(NamTextBox.Text, out nam);
            

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nam", nam);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            connection.Close();

            if (nam_succeed == false)
                MessageBox.Show("Có lỗi trong quá trình sử dụng");
            else
            {
                //clear data
                foreach (var series in BieuDo.Series)
                {
                    series.Points.Clear();
                }
                //add data
                dataGridView1.DataSource = GetAllBill().Tables[0];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                BieuDo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                BieuDo.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                BieuDo.ChartAreas["ChartArea1"].AxisY.Title = "Tổng doanh thu tháng";
                BieuDo.Series["Tổng tiền"]["DrawingStyle"] = "Cylinder";
                //if(BieuDo.Series.Contains("Ex"))
                    //BieuDo.Series.Add("Ex");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BieuDo.Series["Tổng tiền"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["Sum"]);
                    BieuDo.Series["Ex"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["Sum"]);
                    BieuDo.Series["Ex"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
            }
        }

        DataSet GetAllBill()
        {
            DataSet data = new DataSet();
            DataTable dt = new DataTable();

            int nam;
            bool nam_succeed = Int32.TryParse(NamTextBox.Text, out nam);
            string query = "select * from purchase_bill where year(date_of_purchase) = @nam";
            //string query2 = "select month(date_of_purchase) from purchase_bill";
            
            using (SqlConnection connection = new SqlConnection(myconnstrng ))
            {
                connection.Open();

                //SqlCommand command3 = new SqlCommand(query2, connection);

               
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nam", nam);
                SqlDataAdapter da = new SqlDataAdapter(command);

                //SqlDataAdapter chart = new SqlDataAdapter(query2, connection);
                da.Fill(data);
                
                connection.Close();
            }

            return data;
        }

        private void form_dashboard_thongke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PURCHASE_BILL' table. You can move, or remove it, as needed.
            this.pURCHASE_BILLTableAdapter.Fill(this.cNPM_NHOM_1DataSet.PURCHASE_BILL);

        }
    }
}
