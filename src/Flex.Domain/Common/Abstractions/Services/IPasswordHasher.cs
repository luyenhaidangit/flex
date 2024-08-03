namespace Flex.Domain.Common.Abstractions.Services
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}