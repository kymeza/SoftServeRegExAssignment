### Application Description

The application is a .NET 6 Class Library that offers functionality to validate string inputs based on a specific set of requirements. Users can verify if a given string adheres to constraints such as the presence of uppercase, lowercase, digits, special characters, and length, all while ensuring there are no whitespace characters.

### Regex Implementation Description

The implemented regular expression is a comprehensive solution designed for flexibility and reliability. It leverages positive lookaheads to ascertain that at least one uppercase letter, one lowercase letter, one digit, and one special character from a predefined list are present in the input. Additionally, the regex ensures the absence of whitespace characters throughout the entire string. The length of the input string can be dynamically checked against a user-defined maximum, offering added flexibility.

### Running the Application Locally

1. Ensure you have .NET 6 SDK installed on your machine. If not, download it from [here](https://dotnet.microsoft.com/download/dotnet/6.0).
2. Clone the repository: `git clone https://github.com/kymeza/SoftServeRegExAssignment`.
3. Navigate to the repository's directory.
4. To run the tests, execute the following command: `dotnet test`.