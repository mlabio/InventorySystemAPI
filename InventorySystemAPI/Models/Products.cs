using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string product_name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string product_sku { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string product_price { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string product_qty { get; set; }

        [Column(TypeName = "text")]
        public string product_image { get; set; }

        [Column(TypeName = "text")]
        public string product_description { get; set; }

        [Column(TypeName = "text")]
        public string attribute_value_id { get; set; }

        [Column(TypeName = "text")]
        public string brand_id { get; set; }

        [Column(TypeName = "text")]
        public string category_id { get; set; }

        public int store_id { get; set; }

        public int availability { get; set; }
    }
}
