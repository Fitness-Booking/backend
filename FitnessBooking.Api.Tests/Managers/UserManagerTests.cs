using AutoMapper;
using AutoMoq;
using FitnessBooking.Business.Managers;
using FitnessBooking.Core.Interfaces.Repositories;
using FitnessBooking.Core.Interfaces.Singletons;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FitnessBooking.Api.Tests.Managers
{
    public class UserManagerTests
    {
        [Fact]
        public void Login_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<UserManager>();
            LoginUserDto loginUserDto = null;

            // Act
            var result = manager.Login(
                loginUserDto);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RegisterAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<UserManager>();
            RegisterUserDto registerUser = null;

            // Act
            var result = await manager.RegisterAsync(
                registerUser);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var manager = mocker.Create<UserManager>();
            GetUserRequest request = null;

            // Act
            var result = manager.Get(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
