
namespace BSS_Parse
{
    class Settings : ISettings
    {
        public string BaseLink { get; set; } = "https://rozetka.com.ua/notebooks/c80004/filter/preset=budget/";

        public int EndPiont { get; set; }

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPiont { get; set; }        
    }
}