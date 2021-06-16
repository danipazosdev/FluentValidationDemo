using Xunit;

namespace FluentValidationDemo.Test
{
    public class UserModelTests
    {
        [Fact]
        public void UserNameIsNull()
        {
            var user = new UserModel
            {
                Name = null
            };

            var validator = new UserValidator();
            var validationResult = validator.Validate(user);

            Assert.False(validationResult.IsValid);
        }
    }
}
