using Microsoft.AspNetCore.Mvc;
using MorningBatch.BussinessEntity;
using MorningBatch.Repositroy.Concreate;
using MorningBatch.Repositroy.Interface;
using MorningBatch.Service.Concreate;
using MorningBatch.Service.Interface;

namespace EMSMorningBatch.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeService service;
        public EmployeeController()
        {
            service = new EmployeeService();
        }

        public IActionResult ListEmployee()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EmployeeViewModal employeeViewModal)
        {
           var d= service.AddEditEmployee(employeeViewModal); 

            if(d)
            {
                return RedirectToAction("ListEmployee");
            }

            return View();
        }
    }
}
