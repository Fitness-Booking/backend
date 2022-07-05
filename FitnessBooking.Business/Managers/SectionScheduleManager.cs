using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Models.Dto.SectionSchedule;
using FitnessBooking.Core.Models.Requests;

namespace FitnessBooking.Business.Managers
{
    public class SectionScheduleManager : ISectionScheduleManager
    {
        private readonly ISectionScheduleRepository _sectionScheduleRepository;
        private readonly IMapper _mapper;

        public SectionScheduleManager(ISectionScheduleRepository sectionScheduleRepository, IMapper mapper)
        {
            _sectionScheduleRepository = sectionScheduleRepository;
            _mapper = mapper;
        }

        public async Task<SectionScheduleDto> AddNewSectionSchedule(NewSectionScheduleDto newSectionSchedule)
        {
            var sectionSchedule = _mapper.Map<SectionSchedule>(newSectionSchedule);

            var result = await _sectionScheduleRepository.AddAsync(sectionSchedule);

            return _mapper.Map<SectionScheduleDto>(result);
        }

        public IEnumerable<SectionScheduleDto> GetSectionSchedules(GetSectionScheduleRequest request)
        {
            return _sectionScheduleRepository
                .Find(section => section.IsAppreciateToRequest(request))
                .AsEnumerable()
                .Select(_mapper.Map<SectionScheduleDto>);
        }

        public async Task<SectionScheduleDto> UpdateSectionSchedule(UpdateSectionScheduleDto updateSectionSchedule)
        {
            var sectionSchedule = _sectionScheduleRepository.GetEntityById(updateSectionSchedule.Id);

            if (sectionSchedule == null)
            {
                return null;
            }

            sectionSchedule.StartHour = TimeSpan.FromSeconds(updateSectionSchedule.StartHour);
            sectionSchedule.EndHour = TimeSpan.FromSeconds(updateSectionSchedule.EndHour);
            sectionSchedule.SectionId = updateSectionSchedule.SectionId;

            var result = await _sectionScheduleRepository.UpdateAsync(sectionSchedule);

            return _mapper.Map<SectionScheduleDto>(result);
        }
    }
}