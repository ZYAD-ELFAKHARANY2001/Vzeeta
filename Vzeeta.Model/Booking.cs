using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vzeeta.Model.Enums;

namespace Vzeeta.Model
{
    public class Booking:BaseEntity
    {

        public double Price { get; set; }
        public int? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public UserIdentity? Patient { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public UserIdentity? Doctor { get; set; }
        public int CoupounId { get; set; }
        [ForeignKey("CoupounId")]
        public Coupon? Coupon { get; set; }
        public int AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment? Appointment { get; set; }
        public BookingStatus Status { get; set; }
        public bool ConfirmCheckUp { get; set; }

    }
}
