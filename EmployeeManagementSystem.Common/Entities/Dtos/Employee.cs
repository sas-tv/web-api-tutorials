using System;

namespace EmployeeManagementSystem.Common.Entities.Dtos
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Department { get; set; }
        public string Competency { get; set; }
    }

}