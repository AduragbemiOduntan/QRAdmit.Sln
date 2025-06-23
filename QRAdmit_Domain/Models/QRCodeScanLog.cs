using QRAdmit_Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QRAdmit_Domain.Models
{
    public class QRCodeScanLog : BaseEntity
    {
        //[Key]
        //public string QRCodeScanId { get; set; }
        [ForeignKey(nameof(Registration))]
        public string RegistationId { get; set; }
        [ForeignKey(nameof(User))]
        public string ScannedByUserId { get; set; } // staff or volunteer who scanned the QR
        public DateTime ScannedAt { get; set; }
        public ScanStatus ScanStatus { get; set; }
        //public string ScanLocation { get; set; } // For multi-venue event tracking or security

        public Registration Registration { get; set; }
        public User ScannedByUser { get; set; }


    }
}
