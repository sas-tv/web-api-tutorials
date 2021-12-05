using EmployeeManagementSystem.Common.Entities.Dtos;
using System.Collections.Generic;

namespace EmployeeManagementSystem.ApplicationServices.Interfaces
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(int id);
        List<EmployeeListDto> GetEmployees();
        Employee GetEmployeeByName(string name);
        bool CreateEmployee(Employee employee);
        bool UpdateEmployee(int id, Employee employee);
        bool DeleteEmployee(int id);
    }
}
