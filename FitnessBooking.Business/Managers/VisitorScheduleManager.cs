using AutoMapper;
using FitnessBooking.Core.Enums;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Models.Dto.VisitorSchedule;
using FitnessBooking.Core.Models.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessBooking.Business.Managers
{
    public class VisitorScheduleManager : IVisitorScheduleManager
    {
        private readonly IVisitorScheduleRepository _visitorScheduleRepository;
        private readonly IMapper _mapper;

        public VisitorScheduleManager(IVisitorScheduleRepository visitorScheduleRepository, IMapper mapper)
        {
            _visitorScheduleRepository = visitorScheduleRepository;
            _mapper = mapper;
        }

        public async Task<VisitorScheduleDto> Subscribe(NewVisitorScheduleDto visitorScheduleDto)
        {
            var visitorSchedule = _mapper.Map<VisitorSchedule>(visitorScheduleDto);

            visitorSchedule.StatusId = (int)ScheduleStatus.Ordered;

            var result = await _visitorScheduleRepository.AddAsync(visitorSchedule);

            return _mapper.Map<VisitorScheduleDto>(result);
        }

        public IEnumerable<VisitorScheduleDto> Get(GetVisitorScheduleRequest request)
        {
            var result =
                _visitorScheduleRepository.Find(schedule => schedule.IsAppreciateToRequest(request));

            return result.AsEnumerable().Select(_mapper.Map<VisitorScheduleDto>);
        }

        public async Task<VisitorScheduleDto> UpdateSubscribe(UpdateVisitorScheduleDto visitorScheduleDto)
        {
            var visitorSchedule = _mapper.Map<VisitorSchedule>(visitorScheduleDto);

            var result = await _visitorScheduleRepository.UpdateAsync(visitorSchedule);

            return _mapper.Map<VisitorScheduleDto>(result);
        }

        public async Task<VisitorScheduleDto> UnSubscribe(RemoveVisitorScheduleDto visitorScheduleDto)
        {
            var visitorSchedule = _mapper.Map<VisitorSchedule>(visitorScheduleDto);

            visitorSchedule.StatusId = 3;

            var result = await _visitorScheduleRepository.UpdateAsync(visitorSchedule);

            return _mapper.Map<VisitorScheduleDto>(result);
        }
    }
}