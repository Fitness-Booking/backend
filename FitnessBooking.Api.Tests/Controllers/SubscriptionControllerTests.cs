using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Dto.VisitorSchedule;
using FitnessBooking.Core.Models.Requests;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class SubscriptionControllerTests
    {
        [Fact]
        public async Task SubscribeAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var subscriptionController = mocker.Create<SubscriptionController>();
            NewVisitorScheduleDto visitorScheduleDto = null;

            // Act
            var result = await subscriptionController.SubscribeAsync(
                visitorScheduleDto);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UnSubscribeAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var subscriptionController = mocker.Create<SubscriptionController>();
            RemoveVisitorScheduleDto visitorScheduleDto = null;

            // Act
            var result = await subscriptionController.UnSubscribeAsync(
                visitorScheduleDto);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateSubscribeAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var subscriptionController = mocker.Create<SubscriptionController>();
            UpdateVisitorScheduleDto updateVisitorSchedule = null;

            // Act
            var result = await subscriptionController.UpdateSubscribeAsync(
                updateVisitorSchedule);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetUserSubscriptions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var subscriptionController = mocker.Create<SubscriptionController>();
            GetVisitorScheduleRequest request = null;

            // Act
            var result = subscriptionController.GetUserSubscriptions(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
