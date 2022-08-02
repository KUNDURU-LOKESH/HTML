using Consumewebapiin.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Consumewebapiin.Mvc.Controllers
{
    public class ExternalController : Controller
    {
        Uri baseAddress = new Uri("https://dummy.restapiexample.com/api/v1");
        HttpClient client;
        public ExternalController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public IActionResult Index()
        {
            ExternalEmployee externalEmployee = new ExternalEmployee();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/employees").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                externalEmployee = JsonConvert.DeserializeObject<ExternalEmployee>(data);
                return View(externalEmployee);
            }
            else
            {
                return BadRequest("Too many requests on server Please try again.");
            }
        }
    }
}
