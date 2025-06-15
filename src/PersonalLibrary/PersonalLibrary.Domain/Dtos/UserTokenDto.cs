namespace PersonalLibrary.Domain.Dtos
{
    public class UserTokenDto
    {
        public Guid Id { get; set; }  // Alterado de string para Guid
        public string Email { get; set; }
        public string Name { get; set; }
        public string? ProfilePic { get; set; }
    }
}
