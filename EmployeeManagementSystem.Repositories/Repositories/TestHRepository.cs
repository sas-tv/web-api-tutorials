using EmployeeManagementSystem.Common.Entities.Dtos;
using EmployeeManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Repositories
{
    public class TestHRepository : ITestHRepository 
    {
        #region Public Methods
        public string GetName()
        {
            return "Sayan Saha";
        }
        #endregion
    }
}
