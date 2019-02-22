using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Attributes
    {
        [Key]
        public int attribute_id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string attribute_name { get; set; }

        public int attribute_status { get; set; }
    }
}
