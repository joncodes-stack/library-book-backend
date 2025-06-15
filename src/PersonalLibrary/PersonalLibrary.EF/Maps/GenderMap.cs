using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalLibrary.Domain.Entities;


namespace PersonalLibrary.EF.Maps
{
    public class GenderMap : BaseMap<Gender>
    {
        public GenderMap() : base("tb_gender") {}

        public override void Configure(EntityTypeBuilder<Gender> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
        }
    }
}
