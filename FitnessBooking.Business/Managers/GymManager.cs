using AutoMapper;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Models.Dto.Gym;
using FitnessBooking.Core.Models.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessBooking.Business.Managers
{
    public class GymManager : IGymManager
    {
        private readonly IGymRepository _gymRepository;
        private readonly IMapper _mapper;

        public GymManager(IGymRepository gymRepository, IMapper mapper)
        {
            _gymRepository = gymRepository;
            _mapper = mapper;
        }

        public async Task<GymDto> AddNewGym(NewGymDto newGym)
        {
            var gym = _mapper.Map<Gym>(newGym);

            var answer = await _gymRepository.AddAsync(gym);

            return _mapper.Map<GymDto>(answer);
        }

        public IEnumerable<GymDto> GetGyms(GetGymRequest request)
        {
            return _gymRepository
                .Find(gym => gym.IsAppreciateToRequest(request))
                .AsEnumerable()
                .Select(_mapper.Map<GymDto>);
        }

        public async Task<GymDto> UpdateGym(UpdateGymDto updateGym)
        {
            var gym = _gymRepository.GetEntityById(updateGym.Id);

            if (gym == null)
            {
                return null;
            }

            gym.Name = updateGym.Name;
            gym.Location = updateGym.Location;
            gym.Description = updateGym.Description;

            var answer = await _gymRepository.UpdateAsync(gym);

            return _mapper.Map<GymDto>(answer);
        }
    }
}