using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.EF.Maps
{
    public class StatusMAp : BaseMap<Status>
    {
        public StatusMAp() : base("tb_status") { }

        public override void Configure(EntityTypeBuilder<Status> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
        }
    }
}
