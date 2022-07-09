using AutoMoq;
using FitnessBooking.Api.Controllers;
using Moq;
using System;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class TestControllerTests
    {
        [Fact]
        public void VisitorTest_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var testController = mocker.Create<TestController>();

            // Act
            var result = testController.VisitorTest();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void AdminTest_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var testController = mocker.Create<TestController>();

            // Act
            var result = testController.AdminTest();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void CoachTest_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var testController = mocker.Create<TestController>();

            // Act
            var result = testController.CoachTest();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void RegisterTest_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var testController = mocker.Create<TestController>();

            // Act
            var result = testController.RegisterTest();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void AllUsersTest_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var testController = mocker.Create<TestController>();

            // Act
            var result = testController.AllUsersTest();

            // Assert
            Assert.True(false);
        }
    }
}
