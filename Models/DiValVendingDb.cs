using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DiValVending.Models
{
    public class DiValVendingDb : DbContext
    {
        public DiValVendingDb() : base("name=DefaultConnection")
        { }

        public DbSet<RegUser> RegUsers { get; set; }
    }
}