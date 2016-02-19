using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FOAASClient
{
    public class FoaasClient : IFoaasClient
    {
        private const string BaseUrl = "http://foaas.com";

        private async Task<Response> Get(string url, params string[] parameters)
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            var client = new HttpClient(handler);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            
            var res = await client.GetStringAsync(BaseUrl + url+"/"+string.Join("/", parameters));
            return JsonConvert.DeserializeObject<Response>(res);
        }

        public Task<Response> Off(string name, string @from)
        {
            return Get("/off", name, @from);
        }

        public Task<Response> You(string name, string @from)
        {
            return Get("/you", name, @from);
        }

        public Task<Response> That(string @from)
        {
            return Get("/that", @from);
        }

        public Task<Response> This(string @from)
        {
            return Get("/this", @from);
        }

        public Task<Response> Everything(string @from)
        {
            return Get("/everything", @from);
        }

        public Task<Response> Everyone(string @from)
        {
            return Get("/everyone", @from);
        }

        public Task<Response> Donut(string name, string @from)
        {
            return Get("/donut", name, @from);
        }

        public Task<Response> Shakespeare(string name, string @from)
        {
            return Get("/shakespeare", name, @from);
        }

        public Task<Response> Linus(string name, string @from)
        {
            return Get("/linus", name, @from);
        }

        public Task<Response> King(string name, string @from)
        {
            return Get("/king", name, @from);
        }

        public Task<Response> Pink(string @from)
        {
            return Get("/pink", @from);
        }

        public Task<Response> Life(string @from)
        {
            return Get("/life", @from);
        }

        public Task<Response> Chainsaw(string name, string @from)
        {
            return Get("/chainsaw",name, @from);
        }

        public Task<Response> Outside(string name, string @from)
        {
            return Get("/outside", name, @from);
        }

        public Task<Response> Thing(string thing, string @from)
        {
            return Get($"/{thing}", @from);
        }

        public Task<Response> Thanks(string @from)
        {
            return Get("/thanks", @from);
        }

        public Task<Response> Flying(string @from)
        {
            return Get("/flying", @from);
        }

        public Task<Response> Fascinating(string @from)
        {
            return Get("/fascinating", @from);
        }

        public Task<Response> Madison(string name, string @from)
        {
            return Get("/madison", name, @from);
        }

        public Task<Response> Cool(string @from)
        {
            return Get("/cool", @from);
        }

        public Task<Response> Field(string name, string @from, string reference)
        {
            return Get("/field", name, @from, reference);
        }

        public Task<Response> Nugget(string name, string @from)
        {
            return Get("/nugget", name, @from);
        }
    }
}
