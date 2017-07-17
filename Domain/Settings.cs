using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Settings : ISettings
    {
        public Settings(int start, int end)
        {
            StartPiont = 1;
            EndPiont = 2;
        }

        public string BaseLink { get; set; } = "https://habrahabr.ru/";

        public int EndPiont { get; set; }

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPiont { get; set; }
    }
}
