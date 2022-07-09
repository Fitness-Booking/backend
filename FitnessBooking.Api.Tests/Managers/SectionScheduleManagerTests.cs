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
    public class SectionScheduleManagerTests
    {
        [Fact]
        public async Task AddNewSectionSchedule_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<SectionScheduleManager>();
            NewSectionScheduleDto newSectionSchedule = null;

            // Act
            var result = await manager.AddNewSectionSchedule(
                newSectionSchedule);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSectionSchedules_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<SectionScheduleManager>();
            GetSectionScheduleRequest request = null;

            // Act
            var result = manager.GetSectionSchedules(
                request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateSectionSchedule_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<SectionScheduleManager>();
            UpdateSectionScheduleDto updateSectionSchedule = null;

            // Act
            var result = await manager.UpdateSectionSchedule(
                updateSectionSchedule);

            // Assert
            Assert.True(false);
        }
    }
}
