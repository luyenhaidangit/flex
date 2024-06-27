namespace Flex.Contract.Services.V1.Account.Login
{
    public static class Response
    {
        public class Authenticated
        {
            public string? AccessToken { get; set; }
            public string? RefreshToken { get; set; }
            public DateTime RefreshTokenExpiryTime { get; set; }
        }
    }
}
