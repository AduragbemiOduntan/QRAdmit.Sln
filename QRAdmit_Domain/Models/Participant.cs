using System.ComponentModel.DataAnnotations.Schema;

namespace QRAdmit_Domain.Models
{
    public class Participant : BaseEntity
    {
        //public string ParticipantId { get; set; }
        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public User User { get; set; }
        public ICollection<Registration> Registrations { get; set; }
    }
}
