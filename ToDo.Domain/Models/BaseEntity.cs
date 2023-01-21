using System.ComponentModel.DataAnnotations;
using ToDo.Domain.Enums;

namespace ToDo.Domain.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime UpdateData { get; set; }
        public DateTime DeleteData { get; set; }
        public StatusEntityEnum StatusEntity { get; set; } 
    }
}