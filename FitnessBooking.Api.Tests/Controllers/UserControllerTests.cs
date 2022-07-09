using AutoMoq;
using FitnessBooking.Api.Controllers;
using FitnessBooking.Core.Interfaces.Managers;
using FitnessBooking.Core.Models.Dto.User;
using FitnessBooking.Core.Models.Requests;
using Moq;
using System;
using Xunit;

namespace FitnessBooking.Api.Tests.Controllers
{
    public class UserControllerTests
    {
        [Fact]
        public void Register_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var userController = mocker.Create<UserController>();
            RegisterUserDto registerUser = new()
            {
               Email = "someemail@gmail.com",
               Name = "Yehor",
               Password = "Yehor",
               RepeatPassword = "Yehor",
               RoleId = 0
            };

            // Act
            var result = userController.Register(
                registerUser);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Login_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var userController = mocker.Create<UserController>();
            LoginUserDto loginUser = new()
            {
                Email = "someemail@gmail.com",
                Password = "Yehor"
            };

            // Act
            var result = userController.Login(
                loginUser);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var userController = mocker.Create<UserController>();
            GetUserRequest request = null;

            // Act
            var result = userController.Get(
                request);

            // Assert
            Assert.True(false);
        }
    }
}
