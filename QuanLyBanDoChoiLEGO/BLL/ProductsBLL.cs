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

        public int id_type { get; set; }

        public int gender { get; set; }

        public int id_age_range { get; set; }

        public string product_name { get; set; }

        public float price { get; set; }

        public int quantity { get; set; }

        public string img_path { get; set; }

        public string product_desc { get; set; }
    }
}
