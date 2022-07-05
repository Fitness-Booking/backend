using AutoMapper;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Models.Dto.Coach;
using FitnessBooking.Core.Models.Dto.Gym;
using FitnessBooking.Core.Models.Dto.Section;
using FitnessBooking.Core.Models.Dto.SectionSchedule;
using FitnessBooking.Core.Models.Dto.User;
using FitnessBooking.Core.Models.Dto.VisitorSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBooking.Core.Profiles
{
    public class FitnessBookingProfile : Profile
	{
		public FitnessBookingProfile()
		{
			CreateMap<User, LoginUserDto>();
			CreateMap<User, AuthenticateUserDto>();
			CreateMap<User, LoginUserDto>();

			CreateMap<Coach, CoachDto>();
			CreateMap<Coach, NewCoachDto>();
			CreateMap<Coach, UpdateCoachDto>();

			CreateMap<Gym, GymDto>();
			CreateMap<Gym, NewGymDto>();
			CreateMap<Gym, UpdateGymDto>();

			CreateMap<Section, NewSectionDto>();
			CreateMap<Section, SectionDto>();
			CreateMap<Section, UpdateSectionDto>();

			CreateMap<SectionSchedule, NewSectionScheduleDto>();
			CreateMap<SectionSchedule, SectionScheduleDto>();
			CreateMap<SectionSchedule, UpdateSectionScheduleDto>();

			CreateMap<VisitorSchedule, NewVisitorScheduleDto>();
			CreateMap<VisitorSchedule, RemoveVisitorScheduleDto>();
			CreateMap<VisitorSchedule, UpdateVisitorScheduleDto>();
			CreateMap<VisitorSchedule, VisitorScheduleDto>();


			CreateMap<LoginUserDto, User>();
			CreateMap<AuthenticateUserDto, User>();
			CreateMap<LoginUserDto, User>();

			CreateMap<CoachDto, Coach>();
			CreateMap<NewCoachDto, Coach>();
			CreateMap<UpdateCoachDto, Coach>();

			CreateMap<GymDto, Gym>();
			CreateMap<NewGymDto, Gym>();
			CreateMap<UpdateGymDto, Gym>();

			CreateMap<NewSectionDto, Section>();
			CreateMap<SectionDto, Section>();
			CreateMap<UpdateSectionDto, Section>();

			CreateMap<NewSectionScheduleDto, SectionSchedule>();
			CreateMap<SectionScheduleDto, SectionSchedule>();
			CreateMap<UpdateSectionScheduleDto, SectionSchedule>();

			CreateMap<NewVisitorScheduleDto, VisitorSchedule>();
			CreateMap<RemoveVisitorScheduleDto, VisitorSchedule>();
			CreateMap<UpdateVisitorScheduleDto, VisitorSchedule>();
			CreateMap<VisitorScheduleDto, VisitorSchedule>();
		}
	}
}
