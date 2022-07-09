using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Dto.SectionSchedule;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class SectionScheduleControllerTests
    {
        [Fact]
        public async Task AddNewSectionScheduleAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionScheduleController = mocker.Create<SectionScheduleController>();
            NewSectionScheduleDto newSection = null;

            // Act
            var result = await sectionScheduleController.AddNewSectionScheduleAsync(
                newSection);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateSectionSchedule_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionScheduleController = mocker.Create<SectionScheduleController>();
            UpdateSectionScheduleDto updateSection = null;

            // Act
            var result = await sectionScheduleController.UpdateSectionSchedule(
                updateSection);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSectionSchedules_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionScheduleController = mocker.Create<SectionScheduleController>();
            int? id = null;
            int? sectionId = null;
            TimeSpan? startHour = null;
            TimeSpan? endHour = null;

            // Act
            var result = sectionScheduleController.GetSectionSchedules(
                id,
                sectionId,
                startHour,
                endHour);

            // Assert
            Assert.True(false);
        }
    }
}
