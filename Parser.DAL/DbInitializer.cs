using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Parser.DAL
{
    public class DbInitializer : DropCreateDatabaseAlways<ParserContext>
    {
        protected override void Seed(ParserContext context)
        {
            base.Seed(context);
        }
    }
}
