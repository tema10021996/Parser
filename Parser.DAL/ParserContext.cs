using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Parser.DAL
{
    public class ParserContext : DbContext
    {
        public ParserContext() : base("ParserDb")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Parser.DAL.Entities.Products> Product { get; set; }
    }
}
