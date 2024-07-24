using System.Net.Mail;

namespace TrainingSolidPrinciples.SRP.Solution;
public class Invoice
{
    public long InvoiceAmount { get; set; }
    public DateTime InvoiceDate { get; set; }

    private readonly ILogger _logger;
    private readonly IEmailSender _emailSender;

    public Invoice(
        ILogger logger,
        IEmailSender emailSender)
    {
        _logger = logger;
        _emailSender = emailSender;
    }

    public void Add(Invoice invoice)
    {
        try
        {
            // Here we need to write the Code for adding invoice

            // Once the Invoice has been added, then send the  mail
            MailMessage mailMessage = new MailMessage(
                "test@iamarpit.net",
                "hello@iamarpit.net",
                "Test Subject",
                "Test Email Body");
            _emailSender.SendEmail(mailMessage);
        }
        catch (Exception ex)
        {
            _logger.Error(ex.ToString());
        }
    }

    public void DeleteInvoice()
    {
        try
        {
            //Here we need to write the Code for Deleting the already generated invoice
        }
        catch (Exception ex)
        {
            _logger.Error(ex.ToString());
        }
    }
}
