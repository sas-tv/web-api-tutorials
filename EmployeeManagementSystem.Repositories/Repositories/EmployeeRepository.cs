using EmployeeManagementSystem.Common.Entities.Dtos;
using EmployeeManagementSystem.Repositories.DatabaseContexts;
using EmployeeManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeDL = EmployeeManagementSystem.Repositories.Entities.Employees;

namespace EmployeeManagementSystem.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Private Variables
        private readonly EmsContext context;
        #endregion

        #region Constructors
        public EmployeeRepository(EmsContext emsContext)
        {
            context = emsContext;
        }
        #endregion

        #region Public Methods
        public Employee GetEmployeeById(int id)
        {
            var employee = (from e in context.Employees
                            where e.Id == id
                            select new Employee
                            {
                                Id = e.Id,
                                Name = e.Name,
                                DateOfBirth = e.DateOfBirth,
                                DateOfJoining = e.DateOfJoining,
                                Email = e.Email,
                                Competency = e.Competency.Name,
                                Department = e.Department.Name
                            }).FirstOrDefault();
            return employee;
        }

        public List<EmployeeListDto> GetEmployees()
        {
            var employeeList = (from e in context.Employees
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
            var employee = (from e in context.Employees
                            where e.Name.ToLower().Equals(name.ToLower())
                            select new Employee
                            {
                                Id = e.Id,
                                Name = e.Name,
                                DateOfBirth = e.DateOfBirth,
                                DateOfJoining = e.DateOfJoining,
                                Email = e.Email,
                                Competency = e.Competency.Name,
                                Department = e.Department.Name,
                                CompetencyId = e.Competency.Id,
                                DepartmentId = e.Department.Id
                            }).FirstOrDefault();
            return employee;
        }

        public bool CreateEmployee(Employee e)
        {
            var checkEmployeeExists = (from el in context.Employees
                                       where el.Name.Equals(e.Name)
                                       select el).Count();

            if (checkEmployeeExists > 0)
                throw new Exception("Employee already exists!");

            var newEmployee = new EmployeeDL
            {
                Id = e.Id,
                Name = e.Name,
                DateOfBirth = e.DateOfBirth,
                DateOfJoining = e.DateOfJoining,
                Email = e.Email,
                CompetencyId = e.CompetencyId,
                DepartmentId = e.DepartmentId
            };

            //Adding the employee in the list
            context.Employees.Add(newEmployee);
            context.SaveChanges();

            return true;
        }

        public bool UpdateEmployee(int id, Employee employee)
        {
            var employeeToBeUpdated = (from el in context.Employees
                                       where el.Id == id
                                       select el).FirstOrDefault();

            if (employeeToBeUpdated == null)
                throw new Exception($"Employee {id} doesn't exist");

            employeeToBeUpdated.Name = employee.Name;
            employeeToBeUpdated.CompetencyId = employee.CompetencyId;
            employeeToBeUpdated.DateOfBirth = employee.DateOfBirth;
            employeeToBeUpdated.DateOfJoining = employee.DateOfJoining;
            employeeToBeUpdated.DepartmentId = employee.DepartmentId;
            employeeToBeUpdated.Email = employee.Email;

            context.SaveChanges();

            return true;
        }

        public bool DeleteEmployee(int id)
        {
            var employeeToBeDeleted = (from el in context.Employees
                                       where el.Id == id
                                       select el).FirstOrDefault();

            if (employeeToBeDeleted == null)
                throw new Exception($"Employee {id} doesn't exist");

            context.Employees.Remove(employeeToBeDeleted);
            context.SaveChanges();

            return true;
        }
        #endregion
    }
}
