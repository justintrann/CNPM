using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDoChoiLEGO.BLL
{
    class ProductsBLL
    {
        public int id { get; set; }

        public string id_type { get; set; }

        public int gender { get; set; }

        public int id_age_range { get; set; }

        public string product_name { get; set; }

        public decimal price { get; set; }

        public decimal quantity { get; set; }

        public string img_path { get; set; }

        public string product_desc { get; set; }
    }
}
