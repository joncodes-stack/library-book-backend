namespace PersonalLibrary.CrossCutting.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailForgetAsync(string email, int code);
        Task SendConfirmEmailAsync(string email);
        Task SendValidatemEmailAsync(string email, string name, int code);
    }
}
