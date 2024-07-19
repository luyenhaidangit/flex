using System.ComponentModel.DataAnnotations;

namespace Flex.Domain.Customer.Entities
{
    public class Cfmast
    {
        [Key]
        public string CustId { get; set; }

        public string FullName { get; set; }

        public string? Email { get; set; }
    }
}