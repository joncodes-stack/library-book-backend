using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalLibrary.Domain.Entities;


namespace PersonalLibrary.EF.Maps
{
    public class UserMap : BaseMap<User>
    {
        public UserMap() : base("tb_users") { }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("fullName").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(500).IsRequired();
            builder.Property(x => x.RefreshToken).HasColumnName("refreshToken").HasMaxLength(500);
            builder.Property(x => x.RefreshTokenExpireTime).HasColumnName("refreshTokenExpireTime");
            builder.Property(x => x.ProfilePic).HasColumnName("profilePic");
            builder.Property(x => x.Code).HasColumnName("code");
            builder.Property(x => x.CreatedAt).HasColumnName("createdAt").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updatedAt").IsRequired();
        }
    }
}
