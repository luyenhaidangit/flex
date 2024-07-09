using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Flex.Domain.Customer.Entities;

namespace Flex.Infrastructure.Data
{
    public class CfmastConfiguration : IEntityTypeConfiguration<Cfmast>
    {
        public void Configure(EntityTypeBuilder<Cfmast> builder)
        {
            builder.ToTable("Cfmast");
        }
    }
}
