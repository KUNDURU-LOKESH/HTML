using Consumewebapiin.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Consumewebapiin.Mvc.Controllers
{
    public class EmpController : Controller
    {
        Uri baseuri = new Uri("https://localhost:7268/api");
        HttpClient client = new HttpClient();
        List<EmployeeModel> employees = new List<EmployeeModel>();
        public IActionResult Index()
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri+"/employees").Result;
            if (response.IsSuccessStatusCode)
            {
                string orginalData=response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<EmployeeModel>>(orginalData);

            }


            return View(employees);
        }
        public IActionResult CreateNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel employeeModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7268/api/employees");
                var postData = client.PostAsJsonAsync<EmployeeModel>("employees", employeeModel);
                postData.Wait();
                var result=postData.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError(string.Empty, "server error");
                return View(result);
            }
        }
        public IActionResult Edit(int id)
        {
            client.BaseAddress=baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/employees").Result;
            string orginalData=response.Content.ReadAsStringAsync().Result;
            employees = JsonConvert.DeserializeObject<List<EmployeeModel>>(orginalData);
            var emp = employees.Where(e => e.id == id).FirstOrDefault();
            return View(emp);

        }

        [HttpPost]
        public IActionResult Save(EmployeeModel employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7268/api/");
                var put = client.PutAsJsonAsync<EmployeeModel>($"employees/{employee.id}", employee);
                put.Wait();
                var result=put.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError(string.Empty, "server error");
            }
            return View(employee);
        }
        public IActionResult Delete(int id)
        {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("https://localhost:7268/api/employees/");
                var delete = client.DeleteAsync($"{id}");
                delete.Wait();
                var result = delete.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");  
                }
            }
            ModelState.AddModelError(string.Empty, "server error");
            return View();
        }
        
    }
}
