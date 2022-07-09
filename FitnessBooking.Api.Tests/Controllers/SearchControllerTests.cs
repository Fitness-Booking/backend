using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Requests;
using Moq;
using System;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class SearchControllerTests
    {
        [Fact]
        public void GetGymsAndSection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var searchController = mocker.Create<SearchController>();
            GetGymRequest request = null;

            // Act
            var result = searchController.GetGymsAndSection(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
