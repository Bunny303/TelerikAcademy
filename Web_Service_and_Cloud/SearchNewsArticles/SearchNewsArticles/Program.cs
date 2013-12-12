using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using SearchNewsArticles.Model;

namespace SearchNewsArticles
{
    class Program
    {
        static void Main()
        {
            var baseUrl = "http://api.feedzilla.com/v1/articles/";
            var requester = new HttpRequester(baseUrl);

            Console.Write("Searching for:");
            string query = (Console.ReadLine()).Replace(' ', '+');
            Console.Write("Number of articles:");
            string count = Console.ReadLine();
            string url = "search.json?q=" + query + "&count=" + count;

            var result = requester.Get<Articles>(url);
            Console.WriteLine(string.Join(Environment.NewLine, result.articles.Select(
                    article => String.Format("{0}{1}{2}{3}", article.title, Environment.NewLine, article.url,
                            Environment.NewLine))));
        }
    }

    class HttpRequester
    {
        private string baseUrl;
        private HttpClient client;

        public HttpRequester(string baseUrl)
        {
            this.baseUrl = baseUrl;
            this.client = new HttpClient();
        }

        public T Get<T>(string serviceUrl, string mediaType = "application/json")
        {
            var request = new HttpRequestMessage();

            request.RequestUri = new Uri(this.baseUrl + serviceUrl);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
            request.Method = HttpMethod.Get;

            var response = client.SendAsync(request).Result;

            var returnObj = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(returnObj);
        }
    }
}
