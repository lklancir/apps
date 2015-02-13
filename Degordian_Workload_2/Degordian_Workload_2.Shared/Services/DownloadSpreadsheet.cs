using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Degordian_Workload_2.Services
{
    public class DownloadSpreadsheet 
    {
        // 1tJ64Y8hje0ui4ap9U33h3KWwpxT_-JuVMSZzxD2Er8k
        private static readonly string spreadsheetKey = "1Ka-8bTSo4E7sNmsP41prSQqpjawooAvajnFnLi-jtCI";
        private static string jsonUrlTemplate = "http://spreadsheets.google.com/a/google.com/tq?key={0}";
        async public static Task<JObject> GetJson()
        {
            var url = string.Format(jsonUrlTemplate, spreadsheetKey);
            var client = new HttpClient();
            var response = await client.GetAsync(new Uri(url));
            var rawResult = await response.Content.ReadAsStringAsync();
            int start = rawResult.IndexOf("{", rawResult.IndexOf("{") + 1);
            int end = rawResult.LastIndexOf("}");
            String jsonResponse = rawResult.Substring(start, end - start);
            return JObject.Parse(jsonResponse);
        }
    }
}
