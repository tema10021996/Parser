using Parser.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(ISettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseLink}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId(int Id)
        {
            var curentUrl = url.Replace("{CurrentId}", Id.ToString());
            var response = await client.GetAsync(curentUrl);
            string source = null;

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
                return source;
        }
    }
}
