﻿using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopParse.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
