using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessBooking.Data.Models;
using Xunit;
using FitnessBooking.Data.Repository.Repositories;
using FitnessBooking.Core.Models;

namespace FitnessBooking.Api.Tests.Tests.Repositories
{
    public class UserRepositoryTests
    {
        private readonly FitnessBookingContext context;

        public UserRepositoryTests()
        {
            DbContextOptionsBuilder dbOptions = new DbContextOptionsBuilder()
                .UseInMemoryDatabase(
                    Guid.NewGuid().ToString()
                );

            context = new FitnessBookingContext(dbOptions.Options);
        }
        [Fact]
        public async Task AddUser()
        {
            var sut = new UserRepository(context);
            var role = new Role()
            {
                Id = 0,
                Name = "Some Role"
            };
            var user = new User()
            {
                Id = 0,
                Email = "someemail@gmail.com",
                Name = "Yehor",
                Password = "Yehor",
                RoleId = 0,
            };

            var result = await sut.AddAsync(user);

            List<User> users = context.User.ToList();

            Assert.NotNull(result);

            Assert.Single(users);
        }
    }
}
