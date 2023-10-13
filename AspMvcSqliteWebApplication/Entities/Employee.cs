using System.ComponentModel.DataAnnotations;

namespace AspMvcSqliteWebApplication.Entities
{
    public class Employee : TableData
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Gender { get; set; } = string.Empty;
        [Required]
        public int Salary { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}
