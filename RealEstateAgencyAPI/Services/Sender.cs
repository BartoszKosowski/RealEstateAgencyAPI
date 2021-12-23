using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using RealEstateAgencyAPI.Models;

namespace RealEstateAgencyAPI.Services
{
    public class Sender
    {
        private readonly Request _request;
        private readonly MailboxAddress _from;
        private MimeMessage _message;

        public Sender(Request request)
        {
            this._request = request;
            this._from = new MailboxAddress("Some Estates", "noreply@someestates.com");
            this._message = new MimeMessage();
        }

        public void Send()
        {
            CreateMessage();
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtpClient.Authenticate("","");
                smtpClient.Send(_message);
                smtpClient.Disconnect(true);
            }
        }

        private void CreateMessage()
        {
            _message.From.Add(_from);
            _message.To.Add(new MailboxAddress($"{_request.Name} {_request.LastName}", _request.Email));
            _message.Subject = "Potwierdzenie przyjęcia zgłoszenia";

            var builder = new BodyBuilder();

            builder.HtmlBody = @"<p>Test message body</p>";

            _message.Body = builder.ToMessageBody();
        }
    }
}
