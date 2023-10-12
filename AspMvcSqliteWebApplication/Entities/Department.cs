using System.ComponentModel.DataAnnotations;

namespace AspMvcSqliteWebApplication.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
    }
}
