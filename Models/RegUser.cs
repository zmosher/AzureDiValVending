using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiValVending.Models
{
    [Table("RegUser")]
    public class RegUser
    {
        [Key]
        public int User_Index { get; set; }
        
    }
}