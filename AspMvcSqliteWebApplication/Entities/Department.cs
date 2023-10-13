using System.ComponentModel.DataAnnotations;

namespace AspMvcSqliteWebApplication.Entities
{
    public class Department : TableData
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
    }
}
