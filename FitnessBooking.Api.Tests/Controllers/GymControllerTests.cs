using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Dto.Gym;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class GymControllerTests
    {
        [Fact]
        public async Task AddNewGym_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var gymController = mocker.Create<GymController>();
            NewGymDto newGym = null;

            // Act
            var result = await gymController.AddNewGym(
                newGym);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateGym_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var gymController = mocker.Create<GymController>();
            UpdateGymDto updateGym = null;

            // Act
            var result = await gymController.UpdateGym(
                updateGym);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetGyms_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var gymController = mocker.Create<GymController>();
            string name = null;
            string location = null;

            // Act
            var result = await gymController.GetGyms(
                name,
                location);

            // Assert
            Assert.True(false);
        }
    }
}
