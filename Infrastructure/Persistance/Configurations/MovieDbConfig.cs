using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class MovieDbConfig : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(x => x.ReleaseDate)
            .IsRequired();
        builder.Property(x => x.PosterUrl)
            .HasMaxLength(500);
        builder.Property(x => x.Overview)
            .HasMaxLength(1000);
        builder.Property(x => x.Genres)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(x => x.Runtime)
            .IsRequired(false);
        builder.Property(x => x.Language)
            .IsRequired()
            .HasMaxLength(50);
    }
}
