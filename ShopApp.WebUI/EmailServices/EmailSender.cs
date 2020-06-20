using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.EmailServices
{
    public class EmailSender : IEmailSender
    {

        private const string SendGridKey = "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";
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(SendGridKey, subject, htmlMessage, email);
        }

        private Task Execute(string sendGridKey, string subject, string message, string email)
        {
            var client = new SendGridClient(sendGridKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("info@shopapp.com", "Shop App"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(new EmailAddress(email));
            return client.SendEmailAsync(msg);
        }
    }
}
