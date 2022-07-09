using AutoMoq;
using FitnessBooking.Data.Models;
using FitnessBooking.Data.Repository.Repositories;
using Moq;
using System;
using Xunit;

namespace FitnessBooking.Api.Tests.Repository.Repositories
{
    public class UserRepositoryTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var userRepository = mocker.Create<UserRepository>();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
