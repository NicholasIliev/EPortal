using NUnit.Framework;
using Moq;
using EPortal.Models;
using EPortal.Services;

namespace EPortal.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void RegisterUser_ValidUser_ShouldSucceed()
        {
            // Arrange
            UserService userService = new UserService();
            User user = new User { Username = "testuser", Password = "password"};            

            // Act 
            bool result = userService.RegisterUser(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void RegisterUser_EmptyUsername_ShouldFail()
        {
            // Arrange
            UserService userService = new UserService();
            User user = new User { Username = "", Password = "password" };

            // Act
            bool result = userService.RegisterUser(user);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void RegisterUser_DuplicateUsername_ShouldFail()
        {
            // Arrange
            Mock<UserService> mockUserService = new Mock<UserService>();
            string existingUsername = "duplicateuser";
            mockUserService.Setup(x => x.UserExists(existingUsername)).Returns(true);
            User user = new User { Username = existingUsername, Password = "password" };

            // Act
            bool result = mockUserService.Object.RegisterUser(user);

            // Assert
            Assert.IsFalse(result);
        }

    }
}