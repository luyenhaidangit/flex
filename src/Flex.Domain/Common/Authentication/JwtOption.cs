using System.ComponentModel.DataAnnotations;

namespace Flex.Domain.Common.Authentication
{
    public class JwtOption
    {
        [Required]
        public string Key { get; set; }

        [Required]
        public string Issuer { get; set; }

        [Required]
        public string Audience { get; set; }

        [Range(1, int.MaxValue)]
        public int ExpiryMinutes { get; set; }
    }
}