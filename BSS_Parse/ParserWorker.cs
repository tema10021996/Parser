using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSS_Parse
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        ISettings settings;

        HtmlLoader loader;
        bool isActive;

        public IParser<T>Parser
        {
            get { return parser; }
            set { parser = value; }
        }

        public ISettings Settings
        {
            get { return settings; }
            set { settings = value; loader = new HtmlLoader(value); }
        }

        public bool IsActive
        {
            get { return isActive; }
        }

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, ISettings settings) : this(parser)
        {
            this.settings = settings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = settings.StartPiont; i < settings.EndPiont; i++)
            {
                if(!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseAsync(source);

                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }

            OnCompleted?.Invoke(this);
            isActive = false;        
        }
    }
}
