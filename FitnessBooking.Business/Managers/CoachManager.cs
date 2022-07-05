using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Models.Dto.Coach;
using FitnessBooking.Core.Models.Requests;

namespace FitnessBooking.Business.Managers
{
    public class CoachManager : ICoachManager
    {
        private readonly ICoachRepository _coachRepository;

        private readonly IMapper _mapper;
        public CoachManager(ICoachRepository coachRepository, IMapper mapper)
        {
            _coachRepository = coachRepository;
            _mapper = mapper;
        }

        public async Task<CoachDto> AddNewCoach(NewCoachDto newCoach)
        {
            var coach = _mapper.Map<Coach>(newCoach);

            coach = await _coachRepository.AddAsync(coach);

            return CoachDto.FromEntityToDto(coach);
        }

        public IEnumerable<CoachDto> GetCoaches(GetCoachRequest request)
        {
            return _coachRepository
                .Find(coach => coach.IsAppreciateToRequest(request))
                .AsEnumerable()
                .Select(_mapper.Map<CoachDto>);
        }

        public async Task<CoachDto> UpdateCoach(UpdateCoachDto updateCoach)
        {
            var coach = _coachRepository.GetEntityById(updateCoach.Id);
            if (coach == null)
            {
                return null;
            }

            coach.SectionId = updateCoach.SectionId;
            coach = await _coachRepository.UpdateAsync(coach);

            return _mapper.Map<CoachDto>(coach);
        }
    }
}