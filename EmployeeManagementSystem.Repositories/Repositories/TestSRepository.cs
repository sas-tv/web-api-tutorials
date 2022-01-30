﻿using EmployeeManagementSystem.Common.Entities.Dtos;
using EmployeeManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Repositories
{
    public class TestSRepository : ITestSRepository
    {
        #region Public Methods
        public string GetName()
        {
            return "Sayan Saha";
        }
        #endregion
    }
}