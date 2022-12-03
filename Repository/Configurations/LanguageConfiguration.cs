using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Model.Book;

namespace Repository.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("Language", "book");
        builder.Property(x => x.Code).HasMaxLength(3);
        builder.Property(x => x.Name).HasMaxLength(50);
    }
}