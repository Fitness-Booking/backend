﻿namespace FitnessBooking.Core.Models.Requests
{
    public class GetSectionRequest
    {
        public GetSectionRequest(string name, int? id, int? typeId, int? gymId, int? coachId)
        {
            Id = id;
            Name = name;
            TypeId = typeId;
            GymId = gymId;
            CoachId = coachId;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public int? GymId { get; set; }
        public int? CoachId { get; set; }
    }
}