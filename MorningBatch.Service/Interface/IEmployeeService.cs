using MorningBatch.BussinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningBatch.Service.Interface
{
    public interface IEmployeeService
    {
        public bool AddEditEmployee(EmployeeViewModal employee);
        public bool DeleteEmployee(int employeeId);

        public EmployeeViewModal GetEmployee(int employeeId);

        public List<EmployeeViewModal> GetAllEmployees();
    }
}
