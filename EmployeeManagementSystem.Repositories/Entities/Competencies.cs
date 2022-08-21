using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementSystem.Repositories.Entities
{
    public partial class Competencies
    {
        public Competencies()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
