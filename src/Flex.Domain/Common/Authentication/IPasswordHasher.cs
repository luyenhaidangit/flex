namespace Flex.Domain.Common.Authentication
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}