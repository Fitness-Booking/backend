using FitnessBooking.Core.Interfaces.Infrastructure;
using FitnessBooking.Core.Models.Dto.SectionSchedule;
using FitnessBooking.Core.Models.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessBooking.Core.Interfaces.Managers
{
    public interface ISectionScheduleManager : ITransientService
    {
        public Task<SectionScheduleDto> AddNewSectionSchedule(NewSectionScheduleDto newSectionSchedule);

        public IEnumerable<SectionScheduleDto> GetSectionSchedules(GetSectionScheduleRequest request);

        public Task<SectionScheduleDto> UpdateSectionSchedule(UpdateSectionScheduleDto updateSectionSchedule);
    }
}