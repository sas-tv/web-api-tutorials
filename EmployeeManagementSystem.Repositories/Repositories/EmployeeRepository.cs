using EmployeeManagementSystem.Common.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementSystem.Repositories
{
    public class EmployeeRepository
    {
        private List<Employee> EmployeeList = new List<Employee>
        {
            new Employee { Id = 1, Name = "Sayan Saha", DateOfBirth = Convert.ToDateTime("1996-07-14"), Email = "sayansaha@gmail.com", DateOfJoining = DateTime.Today, Competency = "C2", Department = "IT" },
            new Employee { Id = 2, Name = "Elon Musk", DateOfBirth = Convert.ToDateTime("1957-01-07"), Email = "elonmusk@gmail.com", DateOfJoining = DateTime.Today, Competency = "C7", Department = "Human Resources" },
            new Employee { Id = 3, Name = "Bill Gates", DateOfBirth = Convert.ToDateTime("1923-12-23"), Email = "billgates@gmail.com", DateOfJoining = DateTime.Today, Competency = "C4", Department = "Accounting and Finance" },
            new Employee { Id = 4, Name = "Steve Jobs", DateOfBirth = Convert.ToDateTime("1890-03-12"), Email = "stevejobs@rediff.com", DateOfJoining = DateTime.Today, Competency = "C1", Department = "Testing" },
            new Employee { Id = 5, Name = "Mukesh Ambani", DateOfBirth = Convert.ToDateTime("1965-10-29"), Email = "mukeshambani@gmail.com", DateOfJoining = DateTime.Today, Competency = "C2", Department = "Human Resources" }
        };

        public Employee GetEmployeeById(int id)
        {
            var employee = (from e in EmployeeList
                            where e.Id == id
                            select e).FirstOrDefault();
            return employee;
        }

        public List<EmployeeListDto> GetEmployees()
        {
            var employeeList = (from e in EmployeeList
                                select new EmployeeListDto
                                {
                                    Id = e.Id,
                                    Name = e.Name,
                                    Email = e.Email
                                }).ToList();
            return employeeList;
        }

        public Employee GetEmployeeByName(string name)
        {
            var employee = (from e in EmployeeList
                            where e.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
                            select e).FirstOrDefault();
            return employee;
        }

        public bool CreateEmployee(Employee employee)
        {
            var checkEmployeeExists = (from el in EmployeeList
                                       where el.Name.Equals(employee.Name)
                                       select el).Count();

            if (checkEmployeeExists > 0)
                throw new Exception("Employee already exists!");

            //Getting the latest employee id and incremeting it with 1
            var maxEmployeeId = (from el in EmployeeList
                                 orderby el.Id descending
                                 select el.Id).FirstOrDefault();
            employee.Id = maxEmployeeId + 1;

            //Adding the employee in the list
            EmployeeList.Add(employee);

            return true;
        }

        public bool UpdateEmployee(int id, Employee employee)
        {
            var employeeToBeUpdated = (from el in EmployeeList
                                       where el.Id == id
                                       select el).FirstOrDefault();

            if (employeeToBeUpdated == null)
                throw new Exception($"Employee {id} doesn't exist");

            employeeToBeUpdated.Name = employee.Name;
            employeeToBeUpdated.Competency = employee.Competency;
            employeeToBeUpdated.DateOfBirth = employee.DateOfBirth;
            employeeToBeUpdated.DateOfJoining = employee.DateOfJoining;
            employeeToBeUpdated.Department = employee.Department;
            employeeToBeUpdated.Email = employee.Email;

            return true;
        }

        public bool DeleteEmployee(int id)
        {
            var employeeToBeDeleted = (from el in EmployeeList
                                       where el.Id == id
                                       select el).FirstOrDefault();

            if (employeeToBeDeleted == null)
                throw new Exception($"Employee {id} doesn't exist");

            EmployeeList.Remove(employeeToBeDeleted);

            return true;
        }
    }
}
