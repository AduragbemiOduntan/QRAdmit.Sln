using System.ComponentModel.DataAnnotations;

namespace QRAdmit_Domain.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; } 
        public string CreatedBy{ get; set; } 
        public string ModifiedBy { get; set; } 
        public bool IsActive { get; set; }

    }
}
