using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDoChoiLEGO.BLL
{
    class TransactionDetailBLL
    {
        public int id_bill { get; set; }

        public int id_product { get; set; }

        public double cost { get; set; }

        public int quantity { get; set; }

        public double tt_cost { get; set; }
    }
}
