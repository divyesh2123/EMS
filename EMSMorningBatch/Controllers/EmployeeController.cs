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
          
            return View(service.GetAllEmployees());
        }

        public IActionResult Index(int? id)
        {
            if(id.HasValue)
            {
                return View(service.GetEmployee(id.Value));
            }

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

        public IActionResult DeleteEmployee(int employeeId)
        {
           var result = service.DeleteEmployee(employeeId);

            return RedirectToAction("ListEmployee");
        }
    }
}
