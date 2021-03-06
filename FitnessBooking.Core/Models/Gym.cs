using FitnessBooking.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FitnessBooking.Core.Models
{
    public class Gym
    {
        public Gym()
        {
            Sections = new HashSet<Section>();
        }

        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Section> Sections { get; set; }

        public bool IsAppreciateToRequest(GetGymRequest other)
        {
            return (other.Name?.Equals(Name) ?? true) &&
                    (other.Location?.Equals(Location) ?? true) &&
                    (other.SectionRequest == null ||
                       Sections.All(section => section.IsAppreciateToRequest(other.SectionRequest)));
        }

        private bool Equals(Gym other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && Location == other.Location
                   && Description == other.Description
                   && Equals(Sections, other.Sections);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((Gym)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Location, Description, Sections);
        }
    }
}