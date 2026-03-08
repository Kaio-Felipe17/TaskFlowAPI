using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskFlowAPI.Domain.Entities;

namespace TaskFlowAPI.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .ToTable("Users")
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(x => x.PasswordHash)
            .IsRequired()
            .HasMaxLength(100);
    }
}
