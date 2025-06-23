//using QRAdmit_Domain.Enums;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace QRAdmit_Domain.Models
//{
//    class TicketType
//    {
//        public string TicketTypeId { get; set; }
//        [ForeignKey(nameof(Event))]
//        public string EventId { get; set; }
//        public TicketTypeName TicketTypeName { get; set; }
//        //[Column(TypeName = "money")]
//        //[Column(TypeName = "decimal(18,2)")]
//        public decimal Price { get; set; }
//        public int MaxQuantity { get; set; }

//        public Event Event { get; set; }
//    }
//}
