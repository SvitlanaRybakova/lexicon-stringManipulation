using Xunit;
using stringManipulation;

namespace stringManipulation.Tests
{
    public class UserTests
    {
        [Fact]
        public void Constructor_ShouldAssignChildGroup_WhenAgeIsForChild()
        {
            // Arrange
            var age = 4;

            // Act
            var user = new User(age);

            // Assert
            Assert.Equal(User.UserGroup.Child.ToString(), user.Group);
            Assert.Equal(0, user.TicketPrice); // Assuming free ticket for junior
        }

        [Fact]
        public void Constructor_ShouldAssignJuniorGroup_WhenAgeIsForJunior()
        {
            // Arrange
            var age = 15;

            // Act
            var user = new User(age);

            // Assert
            Assert.Equal(User.UserGroup.Junior.ToString(), user.Group);
            Assert.Equal(80, user.TicketPrice); // Assuming 10 is the junior price
        }

        [Fact]
        public void Constructor_ShouldAssignAdultGroup_WhenAgeIsForAdult()
        {
            // Arrange
            var age = 30;

            // Act
            var user = new User(age);

            // Assert
            Assert.Equal(User.UserGroup.Adult.ToString(), user.Group);
            Assert.Equal(120, user.TicketPrice); // Assuming 120 is the standard price for adults
        }

        [Fact]
        public void Constructor_ShouldAssignSeniorGroup_WhenAgeIsForSenior()
        {
            // Arrange
            var age = 65;

            // Act
            var user = new User(age);

            // Assert
            Assert.Equal(User.UserGroup.Senior.ToString(), user.Group);
            Assert.Equal(90, user.TicketPrice); // Assuming 90 is the senior price
        }

        [Fact]
        public void Constructor_ShouldAssignSuperSeniorGroup_WhenAgeIsForSuperSenior()
        {
            // Arrange
            var age = 81;

            // Act
            var user = new User(age);

            // Assert
            Assert.Equal(User.UserGroup.Senior.ToString(), user.Group);
            Assert.Equal(90, user.TicketPrice); // Assuming free ticket for super seniors
        }

        [Fact]
        public void Constructor_ShouldNotAssignGroup_WhenAgeIsInvalid()
        {
            // Arrange
            var age = -1;

            // Act
            var user = new User(age);

            // Assert
            Assert.Null(user.Group);
            Assert.Equal(0, user.TicketPrice); // Assuming default is 0 when invalid age is entered
        }

        [Fact]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var age = 30;
            var user = new User(age);

            // Act
            var result = user.ToString();

            // Assert
            Assert.Equal($"Age: {age}, Group: {User.UserGroup.Adult.ToString()}, Ticket Price: 120", result);
        }
    }
}
