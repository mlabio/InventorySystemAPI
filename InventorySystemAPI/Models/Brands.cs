using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Brands
    {
        [Key]
        public int brand_id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string brand_name { get; set; }

        public int brand_status { get; set; }
    }
}
