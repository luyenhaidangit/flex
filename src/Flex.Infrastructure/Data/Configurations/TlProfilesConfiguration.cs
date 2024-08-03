using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Flex.Domain.SystemManagement.User.Entities;

namespace Flex.Infrastructure.Data.Configurations
{
    public class TlProfilesConfiguration : IEntityTypeConfiguration<TlProfiles>
    {
        public void Configure(EntityTypeBuilder<TlProfiles> builder)
        {
            builder.ToTable("TLPROFILES");

            #region Constraints
            builder.HasKey(p => p.TlId);
            #endregion

            #region Properties
            builder.Property(p => p.TlId)
                .HasColumnName("TLID")
                .IsRequired();

            builder.Property(p => p.TlName)
                .HasColumnName("TLNAME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Pin)
                .HasColumnName("PIN")
                .HasMaxLength(6)
                .IsRequired();
            #endregion
        }
    }
}