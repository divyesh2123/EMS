using MorningBatch.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningBatch.Repositroy.Interface
{
    public interface IEmployeeRepostiroy
    {
        public bool AddEditEmployee(Employee employee);
        public bool DeleteEmployee(int employeeId);

        public Employee GetEmployee(int employeeId);

        public List<Employee> GetAllEmployees();


    }
}
