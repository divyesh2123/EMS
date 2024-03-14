using MorningBatch.BussinessEntity;
using MorningBatch.DataEntity;
using MorningBatch.Repositroy.Concreate;
using MorningBatch.Repositroy.Interface;
using MorningBatch.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningBatch.Service.Concreate
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepostiroy _employeeRepostiroy;

        public EmployeeService()
        {
            _employeeRepostiroy = new EmployeeRepostiroy();
        }

        public bool AddEditEmployee(EmployeeViewModal employee)
        {
            Employee emp = new Employee();
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Id = employee.Id;


            var d = _employeeRepostiroy.AddEditEmployee(emp);
          //email send
            return d;
        }

        public bool DeleteEmployee(int employeeId)
        {
            if(employeeId <0)
            {
                return false;
            }
            
            return _employeeRepostiroy.DeleteEmployee(employeeId);  
        }

        public List<EmployeeViewModal> GetAllEmployees()
        {
            var t = _employeeRepostiroy.GetAllEmployees().Select(y=> new EmployeeViewModal
            {
                FirstName = y.FirstName,    
                Id = y.Id,
                LastName = y.LastName,  

            }).ToList();
            return t;
        }

        public EmployeeViewModal GetEmployee(int employeeId)
        {
            var p = _employeeRepostiroy.GetEmployee(employeeId);

            var d = new EmployeeViewModal
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Id = p.Id
            };

            return d;
        }
    }
}
