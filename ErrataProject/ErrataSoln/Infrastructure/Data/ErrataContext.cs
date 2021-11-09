using Core.Models.Errata;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ErrataContext : DbContext
    {
        public ErrataContext() : base("ErrataContext") { }
        public DbSet<ErrorInfo> ErrorInfos { get; set; }

    }
}
