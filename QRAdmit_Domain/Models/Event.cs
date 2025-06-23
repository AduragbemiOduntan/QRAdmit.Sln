using QRAdmit_Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRAdmit_Domain.Models
{
   public class Event : BaseEntity
    {
        //public string EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public DateTime RegistrationDeadline { get; set; }
        public string QRCodeConfig { get; set; } //  (e.g., QR size, type) -- not clear
        [ForeignKey(nameof(User))]
        public string OrganizerId { get; set; }

        public User Organizer { get; set; } 
        public ICollection<Registration> Registrations { get; set; }
        //public ICollection<Venue> Venues { get; set; }
        //public ICollection<TicketType> TicketTypes { get; set; }
    }
}
