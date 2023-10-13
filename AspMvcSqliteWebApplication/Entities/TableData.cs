using System.ComponentModel.DataAnnotations;

namespace AspMvcSqliteWebApplication.Entities
{
    public abstract class TableData
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public String CreatedBy { get; set; } = String.Empty;

        [Required]
        public DateTimeOffset CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public String UpdatedBy { get; set; } = String.Empty;

        [Required]
        public DateTimeOffset UpdatedAt { get; set; } = DateTime.Now;

        [Required]
        public Boolean IsDeleted { get; set; } = false;

    }
}
