using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalLibrary.Domain.Entities;


namespace PersonalLibrary.EF.Maps
{
    public class BaseMap<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : BaseEntity
    {
        private readonly string _tableName;

        public BaseMap(string tableName = "")
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<TDomain> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();

            builder.Property(x => x.Created_At).HasColumnName("created_at").IsRequired();
        }
    }
}
