using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.EF.Maps
{
    public class ItemMap : BaseMap<Item>
    {
        public ItemMap() : base("tb_item") {}

        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Type).HasColumnName("type").IsRequired();
            builder.Property(x => x.Author_Platform).HasColumnName("auhor_platform").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ImageUrl).HasColumnName("image_url").HasMaxLength(300);
            builder.Property(x => x.CurrentProgress).HasColumnName("current_progress").IsRequired();
            builder.Property(x => x.TotalProgress).HasColumnName("total_progress").IsRequired();
            builder.Property(x => x.Progress).HasColumnName("progress").HasMaxLength(100).IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");

            // Relacionamento com Gender
            builder.HasOne(x => x.Gender)
                .WithMany()
                .HasForeignKey("IdGender")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // Relacionamento com User
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey("IdUser")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            // Relacionamento com Status
            builder.HasOne<Status>()
                .WithMany()
                .HasForeignKey("IdStatus")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
