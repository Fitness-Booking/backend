using AutoMapper;
using AutoMoq;
using FitnessBooking.Business.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Models.Dto.Section;
using FitnessBooking.Core.Models.Requests;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Managers
{
    public class SectionManagerTests
    {
        [Fact]
        public async Task AddNewSection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<SectionManager>();
            NewSectionDto newSection = null;

            // Act
            var result = await manager.AddNewSection(
                newSection);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateSection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<SectionManager>();
            UpdateSectionDto updateSection = null;

            // Act
            var result = await manager.UpdateSection(
                updateSection);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSections_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<SectionManager>();
            GetSectionRequest request = null;

            // Act
            var result = manager.GetSections(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
