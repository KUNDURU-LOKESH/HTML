using Employee_crud_mvc.Data;
using Employee_crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee_crud_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<IActionResult> Index()
        {
            var employee = await _employeeContext.Employees.ToListAsync();
            return View(employee);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["Getemoloyeedetails"] = searchString;
            var searchItem = from m in _employeeContext.Employees
                             select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchItem = searchItem.Where(s => s.FirstName.Contains(searchString));
            }

            return View(await searchItem.AsNoTracking().ToListAsync());
        }

        public IActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Employees.Add(employee);
                await _employeeContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var employee = await _employeeContext.Employees.SingleOrDefaultAsync(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public async Task<IActionResult> Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);

            }
            _employeeContext.Employees.Update(employee);
            await _employeeContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var getempDetails=await _employeeContext.Employees.SingleOrDefaultAsync(e => e.Id == id);
            return View(getempDetails);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var deleteemp= await _employeeContext.Employees.SingleOrDefaultAsync(e => e.Id == id);
            if (deleteemp == null)
            {
                return NotFound();
            }
            _employeeContext.Employees.Remove(deleteemp);
            await _employeeContext.SaveChangesAsync();
            return RedirectToAction("Index");
            
        }

    }
}
