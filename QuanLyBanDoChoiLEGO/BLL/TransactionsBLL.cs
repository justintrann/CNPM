using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanDoChoiLEGO.BLL
{
    class TransactionsBLL
    {
        public int id { get; set; }

        public int id_staff { get; set; }

        public int id_customer { get; set; }

        public DateTime date_of_purchase { get; set; }

        public string purchase_bill_desc { get; set; }

        public double total_cost { get; set; }

        public DataTable transactionDetails { get; set; }
    }
}
