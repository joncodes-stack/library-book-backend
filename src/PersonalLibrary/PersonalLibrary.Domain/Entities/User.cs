using System.ComponentModel.Design;

namespace PersonalLibrary.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
                
        }

        public User(string name, string email, string password, string profilePic, int? code, bool validEmail, string? refreshToken, DateTime refreshTokenExpireTime)
        {
            Name = name;
            Email = email;
            Password = password;
            ProfilePic = profilePic;
            Code = code;
            RefreshToken = refreshToken;
            RefreshTokenExpireTime = refreshTokenExpireTime;
            CreatedAt = DateTime.Now;
            ValidEmail = validEmail;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }
        public int? Code { get; set; }
        public bool ValidEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpireTime { get; set; }
    }
}
