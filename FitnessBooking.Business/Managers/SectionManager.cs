using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Models.Dto.Section;
using FitnessBooking.Core.Models.Requests;

namespace FitnessBooking.Business.Managers
{
    public class SectionManager : ISectionManager
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;

        public SectionManager(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }

        public async Task<SectionDto> AddNewSection(NewSectionDto newSection)
        {
            var section = _mapper.Map<Section>(newSection);

            var answer = await _sectionRepository.AddAsync(section);

            return _mapper.Map<SectionDto>(answer);
        }

        public async Task<SectionDto> UpdateSection(UpdateSectionDto updateSection)
        {
            var section = _sectionRepository.GetEntityById(updateSection.Id);

            if (section == null)
            {
                return null;
            }

            section.GymId = updateSection.GymId;
            section.Name = updateSection.Name;
            section.TypeId = updateSection.TypeId;

            var answer = await _sectionRepository.UpdateAsync(section);

            return _mapper.Map<SectionDto>(answer);
        }

        public IEnumerable<SectionDto> GetSections(GetSectionRequest request)
        {
            return _sectionRepository
                .Find(section => section.IsAppreciateToRequest(request))
                .AsEnumerable()
                .Select(_mapper.Map<SectionDto>);
        }
    }
}