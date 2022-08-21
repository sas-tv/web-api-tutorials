using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementSystem.Repositories.Entities
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int DepartmentId { get; set; }
        public int CompetencyId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual Competencies Competency { get; set; }
        public virtual Departments Department { get; set; }
    }
}
