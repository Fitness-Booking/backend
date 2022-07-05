namespace FitnessBooking.Core.Models.Requests
{
    public class GetUserRequest
    {
        public GetUserRequest(int? id, int? roleId, string email, string name)
        {
            Id = id;
            RoleId = roleId;
            Email = email;
            Name = name;
        }
        public int? Id { get; set; }
        public int? RoleId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

    }
}
