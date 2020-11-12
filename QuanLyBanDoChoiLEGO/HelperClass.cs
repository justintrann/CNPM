using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDoChoiLEGO
{
    public class HelperClass
    {
        public static string defaultSelectString = "--Chọn--";
        public static string getGenderString(byte? gender_value)
        {
            switch (gender_value)
            {
                case 0: return "Nam";
                case 1: return "Nữ";
                default: return "Khác";
            }
        }

        public static byte getGenderValue(string gender_string)
        {
            switch (gender_string)
            {
                case "Nam": return 0;
                case "Nữ": return 1;
                default: return 2;
            }
        }

        public static string getAgeRangeString(byte? id_age_range)
        {
            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            return db.AGE_RANGEs.Where(p => p.id == id_age_range).Select(p => p.age_range_name).SingleOrDefault();
        }

        public static string getProductTypeNameString(byte? id_product_type)
        {
            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            return db.PRODUCT_TYPEs.Where(p => p.id == id_product_type).Select(p => p.product_type_name).SingleOrDefault();
        }
    }
}
