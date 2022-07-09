using AutoMoq;
using FitnessBooking.Data.Models;
using FitnessBooking.Data.Repository.Repositories;
using Moq;
using System;
using Xunit;

namespace FitnessBooking.Api.Tests.Repository.Repositories
{
    public class RoleRepositoryTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var roleRepository = mocker.Create<RoleRepository>();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
