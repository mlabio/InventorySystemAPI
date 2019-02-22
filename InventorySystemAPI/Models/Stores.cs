using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Stores
    {
        [Key]
        public int store_id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string store_name { get; set; }

        public int store_status { get; set; }
    }
}
