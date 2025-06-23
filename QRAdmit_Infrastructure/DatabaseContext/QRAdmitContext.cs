using Microsoft.EntityFrameworkCore;
using QRAdmit_Domain.Models;

namespace QRAdmit_Infrastructure.DatabaseContext
{
    public class QRAdmitContext : DbContext
    {

        public QRAdmitContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<QRCodeScanLog> QRCodeScanLogs { get; set; }
    }
}
