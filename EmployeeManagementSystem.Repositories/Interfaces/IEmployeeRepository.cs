using EmployeeManagementSystem.Common.Entities.Dtos;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        List<EmployeeListDto> GetEmployees();
        Employee GetEmployeeByName(string name);
        bool CreateEmployee(Employee employee);
        bool UpdateEmployee(int id, Employee employee);
        bool DeleteEmployee(int id);
    }
}
