using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Categories
    {
        [Key]
        public int category_id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string category_name { get; set; }

        public int category_status { get; set; }
    }
}
