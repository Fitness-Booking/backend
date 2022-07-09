using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Dto.Section;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class SectionControllerTests
    {
        [Fact]
        public async Task AddNewSection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionController = mocker.Create<SectionController>();
            NewSectionDto newSection = null;

            // Act
            var result = await sectionController.AddNewSection(
                newSection);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateSection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionController = mocker.Create<SectionController>();
            UpdateSectionDto updateSection = null;

            // Act
            var result = await sectionController.UpdateSection(
                updateSection);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSections_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionController = mocker.Create<SectionController>();
            string name = null;
            int? id = null;
            int? typeId = null;
            int? gymId = null;
            int? coachId = null;

            // Act
            var result = await sectionController.GetSections(
                name,
                id,
                typeId,
                gymId,
                coachId);

            // Assert
            Assert.True(false);
        }
    }
}
