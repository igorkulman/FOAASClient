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
        Task<Response> Cool(string from);
        Task<Response> Field(string name, string from, string reference);
        Task<Response> Nugget(string name, string from);
        Task<Response> Yoda(string name, string from);
        Task<Response> Ballmer(string name, string company, string from);
        Task<Response> What(string from);
        Task<Response> Because(string from);
        Task<Response> Caniuse(string tool, string from);
        Task<Response> Bye(string from);
        Task<Response> Diabetes(string from);
        Task<Response> Bus(string name, string from);
        Task<Response> Xmas(string name, string from);
        Task<Response> Bday(string name, string from);
        Task<Response> Awesome(string from);
        Task<Response> Tucker(string from);
        Task<Response> Bucket(string from);
        Task<Response> Family(string from);
        Task<Response> Shutup(string name, string from);
        Task<Response> Zayn(string from);
        Task<Response> KeepCalm(string reaction, string from);
        Task<Response> DoSomething(string todo, string something, string from);
        Task<Response> Thumbs(string who, string from);
        Task<Response> Retard(string from);
    }
}
