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
            throw new NotImplementedException();
        }

        public List<EmployeeViewModal> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModal GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
