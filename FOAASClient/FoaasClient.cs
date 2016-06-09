using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace FOAASClient
{
    public class FoaasClient : IFoaasClient
    {
        private const string BaseUrl = "http://foaas.com";

        private readonly HttpClient _client;

        public FoaasClient()
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            _client = new HttpClient(handler);
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
        }

        private async Task<Response> Get(string url, params string[] parameters)
        {
            var res = await _client.GetStringAsync(BaseUrl + url+"/"+string.Join("/", parameters));
            return JsonConvert.DeserializeObject<Response>(res);
        }

        public Task<Response> Off(string name, string from)
        {
            return Get("/off", name, from);
        }

        public Task<Response> You(string name, string from)
        {
            return Get("/you", name, from);
        }

        public Task<Response> That(string from)
        {
            return Get("/that", from);
        }

        public Task<Response> This(string from)
        {
            return Get("/this", from);
        }

        public Task<Response> Everything(string from)
        {
            return Get("/everything", from);
        }

        public Task<Response> Everyone(string from)
        {
            return Get("/everyone", from);
        }

        public Task<Response> Donut(string name, string from)
        {
            return Get("/donut", name, from);
        }

        public Task<Response> Shakespeare(string name, string from)
        {
            return Get("/shakespeare", name, from);
        }

        public Task<Response> Linus(string name, string from)
        {
            return Get("/linus", name, from);
        }

        public Task<Response> King(string name, string from)
        {
            return Get("/king", name, from);
        }

        public Task<Response> Pink(string from)
        {
            return Get("/pink", from);
        }

        public Task<Response> Life(string from)
        {
            return Get("/life", from);
        }

        public Task<Response> Chainsaw(string name, string from)
        {
            return Get("/chainsaw",name, from);
        }

        public Task<Response> Outside(string name, string from)
        {
            return Get("/outside", name, from);
        }

        public Task<Response> Thing(string thing, string from)
        {
            return Get($"/{thing}", from);
        }

        public Task<Response> Thanks(string from)
        {
            return Get("/thanks", from);
        }

        public Task<Response> Flying(string from)
        {
            return Get("/flying", from);
        }

        public Task<Response> Fascinating(string from)
        {
            return Get("/fascinating", from);
        }

        public Task<Response> Madison(string name, string from)
        {
            return Get("/madison", name, from);
        }

        public Task<Response> Cool(string from)
        {
            return Get("/cool", from);
        }

        public Task<Response> Field(string name, string from, string reference)
        {
            return Get("/field", name, from, reference);
        }

        public Task<Response> Nugget(string name, string from)
        {
            return Get("/nugget", name, from);
        }

        public Task<Response> Yoda(string name, string from)
        {
            return Get("/yoda", name, from);
        }

        public Task<Response> Ballmer(string name, string company, string from)
        {
            return Get("/ballmer", name, company, from);
        }

        public Task<Response> What(string from)
        {
            return Get("/what", from);
        }

        public Task<Response> Because(string from)
        {
            return Get("/because", from);
        }

        public Task<Response> Caniuse(string tool, string from)
        {
            return Get("/caniuse", tool, from);
        }

        public Task<Response> Bye(string from)
        {
            return Get("/bye", from);
        }

        public Task<Response> Diabetes(string from)
        {
            return Get("/diabetes", from);
        }

        public Task<Response> Bus(string name, string from)
        {
            return Get("/bus", name, from);
        }

        public Task<Response> Xmas(string name, string from)
        {
            return Get("/xmas", name, from);
        }

        public Task<Response> Bday(string name, string from)
        {
            return Get("/bday", name, from);
        }

        public Task<Response> Awesome(string from)
        {
            return Get("/awesome", from);
        }

        public Task<Response> Tucker(string from)
        {
            return Get("/tucker", from);
        }

        public Task<Response> Bucket(string from)
        {
            return Get("/bucket", from);
        }

        public Task<Response> Family(string from)
        {
            return Get("/family", from);
        }

        public Task<Response> Shutup(string name, string from)
        {
            return Get("/shutup", name, from);
        }

        public Task<Response> Zayn(string from)
        {
            return Get("/zayn", from);
        }

        public Task<Response> KeepCalm(string reaction, string from)
        {
            return Get("/keepcalm", reaction, from);
        }

        public Task<Response> DoSomething(string todo, string something, string from)
        {
            return Get("/dosomething", todo, something, from);
        }

        public Task<Response> Mornin(string from)
        {
            return Get("/mornin", from);
        }

        public Task<Response> Thumbs(string who, string from)
        {
            return Get("/thumbs", who, from);
        }

        public Task<Response> Retard(string from)
        {
            return Get("/retard", from);
        }

        public Task<Response> Greed(string noun, string from)
        {
            return Get("/greed", noun, from);
        }
    }
}
