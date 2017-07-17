using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BSS_Parse
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader (ISettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseLink}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId (int Id)
        {
            var curentUrl = url.Replace("{CurrentId}", Id.ToString());
            var response = await client.GetAsync(curentUrl);
            string source = null;

            if(response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
