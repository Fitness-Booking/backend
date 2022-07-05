using System;
using System.ComponentModel.DataAnnotations;
using FitnessBooking.Core.Models.Dto.VisitorSchedule;
using FitnessBooking.Core.Models.Requests;

namespace FitnessBooking.Core.Models
{
    public class VisitorSchedule
    {
        [Key] public int Id { get; set; }

        public int SectionScheduleId { get; set; }
        public DateTime Day { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public virtual SectionSchedule SectionSchedule { get; set; }
        public virtual User User { get; set; }

        public bool IsAppreciateToRequest(GetVisitorScheduleRequest request)
        {
            return Id == request.Id &&
                   request.UserId == UserId &&
                   request.SectionScheduleId == SectionScheduleId;
        }
    }
}