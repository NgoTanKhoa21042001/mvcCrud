using Microsoft.AspNetCore.Mvc;
using mvcCrud.Data;
using mvcCrud.Models;
using mvcCrud.Models.Domain;

namespace mvcCrud.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public EmployeesController(MVCDemoDbContext mVCDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(AddEmployeesViewModel addEmployeesRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeesRequest.Name,
                Email = addEmployeesRequest.Email,
                Salary = addEmployeesRequest.Salary,
                DateOfBirth = addEmployeesRequest.DateOfBirth,

            }
        }


    }
}
