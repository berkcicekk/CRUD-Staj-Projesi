using System.Security.Principal;

namespace ASPNETMVCCRUD.Models
{
    public class UpdateEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
