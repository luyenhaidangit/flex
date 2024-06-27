using Flex.Domain.Entities.Account;
using Flex.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flex.Persistence.Configurations
{
    internal sealed class CfmastConfiguration
    {
        public void Configure(EntityTypeBuilder<Cfmast> builder)
        {
            builder.ToTable(TableNames.Cfmasts);

            builder.HasKey(x => x.CustId);
        }
    }
}
