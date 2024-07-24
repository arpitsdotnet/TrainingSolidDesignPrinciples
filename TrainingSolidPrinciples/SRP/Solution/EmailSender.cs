using System.Net.Mail;

namespace TrainingSolidPrinciples.SRP.Solution;
public interface IEmailSender
{
    string SendEmail(MailMessage message);
}
internal class EmailSender : IEmailSender
{
    private readonly ILogger _logger;

    public EmailSender(ILogger logger)
    {
        _logger = logger;
    }
    public string SendEmail(MailMessage message)
    {
        try
        {
            return "Email has been sent succesfully.";
        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message);
            return string.Empty;
        }
    }
}
