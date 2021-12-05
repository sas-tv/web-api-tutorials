using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Common.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Private Variables
        private IEmployeeService _EmployeeService;
        #endregion

        #region Constructors
        public EmployeeController(IEmployeeService employeeService)
        {
            _EmployeeService = employeeService;
        }
        #endregion

        #region Public Methods
        [HttpGet, Route("{id:int}")]
        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            try
            {
                employee = _EmployeeService.GetEmployeeById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employee ?? new Employee();
        }

        [HttpGet]
        public List<EmployeeListDto> GetEmployees()
        {
            return _EmployeeService.GetEmployees();
        }

        [HttpGet, Route("{name}")]
        public Employee GetEmployeeByName(string name)
        {
            var employee = _EmployeeService.GetEmployeeByName(name);
            return employee ?? new Employee();
        }

        [HttpPost]
        public bool CreateEmployee(Employee employee)
        {
            try
            {
                return _EmployeeService.CreateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut, Route("{id:int}")]
        public bool UpdateEmployee(int id, Employee employee)
        {
            try
            {
                return _EmployeeService.UpdateEmployee(id, employee);                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete, Route("{id:int}")]
        public bool DeleteEmployee(int id)
        {
            try
            {
                return _EmployeeService.DeleteEmployee(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
