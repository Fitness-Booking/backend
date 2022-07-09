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
    public class VisitorScheduleManagerTests
    {
        [Fact]
        public async Task Subscribe_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<VisitorScheduleManager>();
            NewVisitorScheduleDto visitorScheduleDto = null;

            // Act
            var result = await manager.Subscribe(
                visitorScheduleDto);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<VisitorScheduleManager>();
            GetVisitorScheduleRequest request = null;

            // Act
            var result = manager.Get(
                request);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateSubscribe_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<VisitorScheduleManager>();
            UpdateVisitorScheduleDto visitorScheduleDto = null;

            // Act
            var result = await manager.UpdateSubscribe(
                visitorScheduleDto);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UnSubscribe_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<VisitorScheduleManager>();
            RemoveVisitorScheduleDto visitorScheduleDto = null;

            // Act
            var result = await manager.UnSubscribe(
                visitorScheduleDto);

            // Assert
            Assert.True(false);
        }
    }
}
