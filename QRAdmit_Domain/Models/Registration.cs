using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRAdmit_Domain.Models
{
    public class Registration : BaseEntity
    {
        //[Key]
        //public string RegistrationId { get; set; }
        [ForeignKey(nameof(Event))]
        public string EventId { get; set; }
        [ForeignKey(nameof(Participant))]
        public string ParticipantId { get; set; }
        public string QRCode { get; set; } //(Base64 or path to QR image)
        public bool IsCheckedIn { get; set; }
        public DateTime CheckedInTime { get; set; }
        public DateTime CheckInTime { get; set; }

        public Event Event { get; set; } 
        public Participant Participant { get; set; }
        public ICollection<QRCodeScanLog> ScanLogs { get; set; }
    }
}
