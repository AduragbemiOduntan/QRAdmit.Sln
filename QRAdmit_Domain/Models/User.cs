using QRAdmit_Domain.Enums;

namespace QRAdmit_Domain.Models
{
    public class User : BaseEntity
    {
        //public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public AccountType AccountType { get; set; }
        public string LastLogin { get; set; }

        public ICollection<Event> OrganizedEvents { get; set; }
        public ICollection<QRCodeScanLog> QRCodeScanLogs { get; set; }
        public Participant Participant { get; set; }
    }
}
