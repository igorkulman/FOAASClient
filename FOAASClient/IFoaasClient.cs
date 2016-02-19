using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOAASClient
{
    public interface IFoaasClient
    {
        Task<Response> Off(string name, string from);
        Task<Response> You(string name, string from);
        Task<Response> That(string from);
        Task<Response> This(string from);
        Task<Response> Everything(string from);
        Task<Response> Everyone(string from);
        Task<Response> Donut(string name, string from);
        Task<Response> Shakespeare(string name, string from);
        Task<Response> Linus(string name, string from);
        Task<Response> King(string name, string from);
        Task<Response> Pink(string from);
        Task<Response> Life(string from);
        Task<Response> Chainsaw(string name, string from);
        Task<Response> Outside(string name, string from);
        Task<Response> Thing(string thing, string from);
        Task<Response> Thanks(string from);
        Task<Response> Flying(string from);
        Task<Response> Fascinating(string from);
        Task<Response> Madison(string name, string from);
    }
}
