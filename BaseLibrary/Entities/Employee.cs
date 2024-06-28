using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public DateOnly? Birthdate { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }


        //RelationShip : Many to one
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }

        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        public Branch? Branch { get; set; }
        public int BranchId { get; set; }


    }
}
