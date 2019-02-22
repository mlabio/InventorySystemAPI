using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Models
{
    public class Company
    {
        [Key]
        public int company_id { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string company_name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string service_charge_valie { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string vat_charge_value { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string address { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string phone { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string country { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string message { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string currency { get; set; }
    }
}
