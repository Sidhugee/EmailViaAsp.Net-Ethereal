using EmailServiceBlock.Model;

namespace EmailServiceBlock.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
