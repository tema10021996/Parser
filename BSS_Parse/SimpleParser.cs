using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace BSS_Parse
{
    class SimpleParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var imgs = document.QuerySelectorAll("img");
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("g-i-tile-i-image fix-height"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
