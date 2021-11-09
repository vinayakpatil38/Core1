using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnivBE.Models;

namespace UnivBE.Data
{
    public class UnivContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}