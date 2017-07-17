using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopParse.Core
{
    interface ISettings
    {
        string BaseLink { get; set; }

        string Prefix { get; set; }

        int StartPiont { get; set; }

        int EndPiont { get; set; }
    }
}
