using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Flex.Domain.CorporateAction.Entities;

namespace Flex.Infrastructure.Data.Configurations
{
    public class CamastConfiguration : IEntityTypeConfiguration<Camast>
    {
        public void Configure(EntityTypeBuilder<Camast> builder)
        {
            builder.ToTable("CAMAST");

            builder.HasKey(c => c.CamastId);

            #region Properties
            builder.Property(c => c.CamastId)
                .HasColumnName("CAMASTID")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Catype)
                .HasColumnName("CATYPE")
                .HasMaxLength(3);

            builder.Property(c => c.CodeId)
                .HasColumnName("CODEID")
                .HasMaxLength(10);

            builder.Property(c => c.ToCodeId)
                .HasColumnName("TOCODEID")
                .HasMaxLength(10);

            builder.Property(c => c.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1);
            #endregion
        }
    }
}