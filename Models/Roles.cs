using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiValVending.Models
{
    [Table("Roles")]
    public class Roles 
    {
        [Key]
        public int RoleID { get; set; }

        public DateTime Creation { get; set; }
        public string Name { get; set; }

    }
}