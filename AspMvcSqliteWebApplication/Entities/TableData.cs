using System.ComponentModel.DataAnnotations;

namespace AspMvcSqliteWebApplication.Entities
{
    public abstract class TableData
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTimeOffset CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTimeOffset? UpdatedAt { get; set; } = DateTime.Now;

        [Required]
        public Boolean IsDeleted { get; set; } = false;

    }
}
