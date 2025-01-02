using Employee.Models;
using Microsoft.AspNetCore.Mvc;


namespace Employee.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeesController(EmployeeDbContext context)
        {
            this._context = context;
        }

        
        public IActionResult List()
        {
            var employees = _context.Employees
                .Select(e => new EmployeeViewModel
                {
                    Name = e.Name,
                    Gender = e.Gender,
                    DateOfBirth = e.DateOfBirth,
                    Email = e.Email,
                    Phone = e.Phone,
                    Country = e.Country,
                    State = e.State,
                    City = e.City
                })
                .ToList();

            return View(employees);
        }

        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Add(EmployeeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var employee = new Employer
            {
                Name = model.Name,
                Gender = model.Gender,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                Phone = model.Phone,
                Country = model.Country,
                State = model.State,
                City = model.City
            };

             _context.Employees.Add(employee);
             _context.SaveChanges();

            return RedirectToAction("List");
        }
    }
}
