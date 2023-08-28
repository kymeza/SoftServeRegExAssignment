namespace RegExClassTests
{
    public class RegexValidatorTests
    {
        [Theory]
        // Valid case with uppercase, lowercase, digit, and special character. Length is less than 50.
        [InlineData("ASecurePassword!.2023", 50, true)]

        // Contains '@' which is an allowed special character, but no digit.
        [InlineData("person@email.com", 50, false)]

        // Doesn't meet the minimum length requirement of 16.
        [InlineData("Unsecurepass", 16, false)]

        // Missing a special character.
        [InlineData("UnsecurePassword", 50, false)]

        // Contains spaces, which are not allowed.
        [InlineData("ASecure Password!.2023", 50, false)]

        // Contains spaces at the start, which are not allowed.
        [InlineData(" ASecurePassword!.2023", 50, false)]

        // Contains spaces at the end, which are not allowed.
        [InlineData("ASecurePassword!.2023 ", 50, false)]

        // Contains a tab, which is not allowed.
        [InlineData("ASecurePassword!.\t2023", 50, false)]

        // Contains a newline character, which is not allowed.
        [InlineData("ASecurePassword!.\n2023", 50, false)]

        // Contains only special characters. Missing a digit, uppercase, and lowercase character.
        [InlineData("!@#$%^&*()", 50, false)]

        // Valid case with uppercase, lowercase, digit, and special character. Length is less than 10.
        [InlineData("Aa1!", 10, true)]

        // Contains uppercase, lowercase, and digit but no special character. Length is less than 10.
        [InlineData("Aa11", 10, false)]

        // Contains only lowercase, digit, and special character. Missing an uppercase. Length is less than 10.
        [InlineData("aa1!", 10, false)]

        public void TestIsValid(string input, int maxLength, bool expected)
        {
            bool actual = RegexValidator.IsValid(input, maxLength);
            Assert.Equal(expected, actual);
        }
    }
}