using AutoMapper;
using AutoMoq;
using FitnessBooking.Business.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models.Dto.Gym;
using FitnessBooking.Core.Models.Requests;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Managers
{
    public class GymManagerTests
    {
        [Fact]
        public async Task AddNewGym_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<GymManager>();
            NewGymDto newGym = null;

            // Act
            var result = await manager.AddNewGym(
                newGym);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetGyms_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<GymManager>();
            GetGymRequest request = null;

            // Act
            var result = manager.GetGyms(
                request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateGym_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<GymManager>();
            UpdateGymDto updateGym = null;

            // Act
            var result = await manager.UpdateGym(
                updateGym);

            // Assert
            Assert.True(false);
        }
    }
}
