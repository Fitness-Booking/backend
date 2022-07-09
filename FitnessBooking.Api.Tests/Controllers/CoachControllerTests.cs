using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Dto.Coach;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;
namespace FitnessBooking.Api.Tests.Controllers
{
    public class CoachControllerTests
    {
        private Mock<ICoachManager> coachManager;
        private CoachController coachController;
        private Fixture _fixture;
        public CoachControllerTests()
        {
            coachManager = new Mock<ICoachManager>();
            
            _fixture = new Fixture();
        }
        [Fact]
        public async Task AddNewCoach_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            coachManager.Setup(manager => manager.AddNewCoach(It.IsAny<NewCoachDto>()))
                .ReturnsAsync(Mock.Of<CoachDto>());

            coachController = new CoachController(coachManager.Object);
            
            // Act
            var result = await coachController.AddNewCoach(Mock.Of<NewCoachDto>());

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateCoach_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var coachController = mocker.Create<CoachController>();
            UpdateCoachDto updateCoach = null;

            // Act
            var result = await coachController.UpdateCoach(
                updateCoach);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetCoaches_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var coachController = mocker.Create<CoachController>();
            int? sectionId = null;

            // Act
            var result = coachController.GetCoaches(
                sectionId);

            // Assert
            Assert.True(false);
        }
    }
}
