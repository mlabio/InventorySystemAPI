using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Attribute_value
    {
        [Key]
        public int attribute_value_id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string attribute_value_desc { get; set; }

        [ForeignKey("Attributes")]
        public int atrribute_id { get; set; }
    }
}
