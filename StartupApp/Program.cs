using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StartupApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //get recent updates from wikipedia
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://en.wikipedia.org/w/api.php");

            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("?action=query&format=json&list=recentchanges&rcprop=title%7Cids%7Csizes%7Cflags%7Cuser&rclimit=3").Result;
            if (response.IsSuccessStatusCode)
            {
                using (Stream input = GetContentStream(response.Content), fileStream = File.Create("recentUpdates.json"))
                {
                    input.CopyTo(fileStream);
                }
            }
        }
        static Stream GetContentStream(HttpContent content)
        {
            Task<Stream> results = content.ReadAsStreamAsync();
            return results.Result;
        }
    }
}
