using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Vzeeta.Model
{
    public class Appointment:BaseEntity
    {
        public Enums.Days Days { get; set; }
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public UserIdentity Doctor { get; set; }
        public int TimeId { get; set; }
        [ForeignKey("TimeId")]
        public Times Times { get; set; }
    }
}