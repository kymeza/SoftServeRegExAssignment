using System.Text.RegularExpressions;

public static class RegexValidator
{
    private const string Pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@\[\]^_`{|}~])\S+$";

    public static bool IsValid(string input, int maxLength)
    {
        if (input.Length > maxLength) 
            return false;

        return Regex.IsMatch(input, Pattern);
    }
}