using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSolidPrinciples.SRP.Solution;
public class Invoice
{
    public long InvoiceAmount { get; set; }
    public DateTime InvoiceDate { get; set; }

    private readonly ILogger _logger;

    public Invoice(ILogger logger)
    {
        _logger = logger;
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
            SendInvoiceEmail(mailMessage);
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

    public string SendInvoiceEmail(MailMessage mailMessage)
    {
        try
        {
            return "Email has been sent.";
        }
        catch (Exception ex)
        {
            _logger.Error(ex.ToString());
            return string.Empty;
        }
    }
}
