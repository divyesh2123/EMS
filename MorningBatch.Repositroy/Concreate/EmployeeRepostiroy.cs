using MorningBatch.DataEntity;
using MorningBatch.Repositroy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningBatch.Repositroy.Concreate
{
    public class EmployeeRepostiroy : IEmployeeRepostiroy
    {
        private readonly WeltecMorningNewBatchContext _context;

        public EmployeeRepostiroy()
        {
            this._context = new WeltecMorningNewBatchContext();
        }

        public bool AddEditEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
          return  _context.SaveChanges() > 0 ? true: false;
        }

        public bool DeleteEmployee(int employeeId)
        {
            var e = _context.Employees.Find(employeeId);

            _context.Employees.Remove(e);

            return _context.SaveChanges() > 0 ? true : false;

        }

        public List<Employee> GetAllEmployees()
        {
          return _context.Employees.OrderByDescending(y=>y.Id).ToList();
        }

        public Employee GetEmployee(int employeeId)
        {
            return _context.Employees.Find(employeeId);
        }
    }
}
