using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FOAASClient
{
    public class FoaasClient : IFoaasClient
    {
        private const string baseUrl = "http://foaas.com";

        private async Task<Response> Get(string url, params string[] parameters)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");
            var res = await client.GetStringAsync(baseUrl + url+"/"+string.Join("/", parameters));
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
    }
}
