using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopParse.Core
{
    class Settings : ISettings
    {
        public Settings(int start, int end)
        {
            StartPiont = start;
            EndPiont = end;
        }

        public string BaseLink { get; set; } = "https://habrahabr.ru/";

        public int EndPiont { get; set; }

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPiont { get; set; }
    }
}
