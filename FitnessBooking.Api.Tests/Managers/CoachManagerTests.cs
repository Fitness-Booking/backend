using AutoMapper;
using AutoMoq;
using FitnessBooking.Business.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Managers
{
    public class CoachManagerTests
    {
        [Fact]
        public async Task AddNewCoach_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<CoachManager>();
            NewCoachDto newCoach = null;

            // Act
            var result = await manager.AddNewCoach(
                newCoach);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetCoaches_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<CoachManager>();
            GetCoachRequest request = null;

            // Act
            var result = manager.GetCoaches(
                request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateCoach_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<CoachManager>();
            UpdateCoachDto updateCoach = null;

            // Act
            var result = await manager.UpdateCoach(
                updateCoach);

            // Assert
            Assert.True(false);
        }
    }
}
