﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDoChoiLEGO.BLL
{
    class TransactionsBLL
    {
        public int id { get; set; }

        public string id_staff { get; set; }

        public string id_customer { get; set; }

        public DateTime date_of_purchase { get; set; }

        public string purchase_bill_desc { get; set; }

        public decimal total_cost { get; set; }

    }
}
