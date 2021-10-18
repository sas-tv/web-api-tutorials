using EmployeeManagementSystem.Common.Entities.Dtos;
using EmployeeManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class EmployeeService
    {
        private EmployeeRepository _EmployeeRepo = new EmployeeRepository();
        public Employee GetEmployeeById(int id)
        {
            if (id < 0)
                throw new Exception("Employee Id cannot be less than zero");
            return _EmployeeRepo.GetEmployeeById(id);
        }

        public List<EmployeeListDto> GetEmployees()
        {
            return _EmployeeRepo.GetEmployees();
        }

        public Employee GetEmployeeByName(string name)
        {
            return _EmployeeRepo.GetEmployeeByName(name);
        }

        public bool CreateEmployee(Employee employee)
        {
            //Validate Inputs
            if (string.IsNullOrEmpty(employee.Name))
                throw new Exception("Employee Name is empty!");
            if (string.IsNullOrEmpty(employee.Email))
                throw new Exception("Employee Email is empty!");

            return _EmployeeRepo.CreateEmployee(employee);
        }

        public bool UpdateEmployee(int id, Employee employee)
        {
            if (id < 0)
                throw new Exception("Employee Id cannot be less than zero");
            if (string.IsNullOrEmpty(employee.Name))
                throw new Exception("Employee Name is empty!");
            if (string.IsNullOrEmpty(employee.Email))
                throw new Exception("Employee Email is empty!");

            return _EmployeeRepo.UpdateEmployee(id, employee);
        }

        public bool DeleteEmployee(int id)
        {
            if (id < 0)
                throw new Exception("Employee Id cannot be less than zero.");

            return _EmployeeRepo.DeleteEmployee(id);
        }
    }
}
