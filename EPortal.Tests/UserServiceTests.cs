using NUnit.Framework;
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
            // TODO
        }

        [Test]
        public void RegisterUser_DuplicateUsername_ShouldFail()
        {
            // TODO
        }

    }
}