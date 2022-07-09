using AutoMoq;
using FitnessBooking.Data.Models;
using FitnessBooking.Data.Repository.Repositories;
using Moq;
using System;
using Xunit;

namespace FitnessBooking.Api.Tests.Repository.Repositories
{
    public class SectionScheduleRepositoryTests
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var sectionScheduleRepository = mocker.Create<SectionScheduleRepository>();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
