using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Text;

namespace Minami.CloudTranslation
{
    public class CloudTranslationClient
    {
        private static WebClient webClient;
        private static string UrlBase = "https://translation.googleapis.com/language/translate/v2/?key=";
        private static string Format = "text";
        private static string Url;

        public CloudTranslationClient(string apiKey)
        {
            webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            webClient.Headers[HttpRequestHeader.Accept] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            Url = UrlBase + apiKey;
        }

        public string[] Translate(SourceTexts texts, string target, string source)
        {
            var request = new Request(texts.Texts, target, Format, source);
            var json = JsonConvert.SerializeObject(request, Formatting.Indented);
            var response = JObject.Parse(webClient.UploadString(new Uri(Url), json));
            return response["data"]["translations"].Select(t => t["translatedText"].ToString()).ToArray();
        }

        public string[] Translate(SourceTexts texts, string target)
        {
            var request = new Request(texts.Texts, target, Format);
            var json = JsonConvert.SerializeObject(request, Formatting.Indented);
            var response = JObject.Parse(webClient.UploadString(new Uri(Url), json));
            return response["data"]["translations"].Select(t => t["translatedText"].ToString()).ToArray();
        }
    }
}
