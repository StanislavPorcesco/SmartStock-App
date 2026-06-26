
namespace SmartStock.Classes.Utils
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using SmartStock.Classes.Settings;

    public static class EmailService
    {
        private static readonly string AuthEmail    = "smartstock.auth@gmail.com";
        // Secrets are read from .env at call time — never hardcoded. See EnvManager.
        private static string AuthPassword => EnvManager.Get(EnvManager.AuthEmailPassword);

        private static readonly string ReportsEmail    = "smartstock.reports@gmail.com";
        private static string ReportsPassword => EnvManager.Get(EnvManager.ReportsEmailPassword);

        public static string SendVerificationCode(string receiverEmail)
        {
            Random random = new Random();
            string verificationCode = random.Next(100000, 999999).ToString();

            string htmlTemplate = @"<!DOCTYPE html>
<html lang='en'>
<head>
<meta charset='UTF-8'>
<meta name='viewport' content='width=device-width, initial-scale=1.0'>
<title>SmartStock Verification</title>
<style>
  * {{ box-sizing: border-box; margin: 0; padding: 0; }}
  body {{ background-color: #121212; font-family: 'Segoe UI', Tahoma, sans-serif; color: #ccc; padding: 20px; }}
  .container {{ max-width: 520px; margin: 40px auto; background: #1e1e1e; border: 1px solid #2d2d2d; border-radius: 10px; overflow: hidden; }}
  .header {{ background: linear-gradient(135deg, #1a1a2e 0%, #16213e 100%); padding: 28px 32px; text-align: center; border-bottom: 2px solid #4CAF50; }}
  .header h1 {{ color: #fff; font-size: 26px; letter-spacing: 4px; font-weight: 800; }}
  .header .subtitle {{ color: #4CAF50; font-size: 12px; margin-top: 6px; letter-spacing: 1.5px; text-transform: uppercase; }}
  .content {{ padding: 36px 32px; text-align: center; }}
  .content p {{ color: #aaa; font-size: 14px; line-height: 1.7; }}
  .code-box {{ background: #252525; border: 1px solid #333; border-left: 3px solid #4CAF50; color: #fff; font-size: 38px; font-weight: 800; letter-spacing: 14px; padding: 20px 28px; margin: 28px auto; display: inline-block; border-radius: 6px; font-family: 'Courier New', monospace; }}
  .note {{ color: #555; font-size: 12px; margin-top: 20px; }}
  .footer {{ padding: 16px 28px; text-align: center; color: #444; font-size: 11px; background: #161616; border-top: 1px solid #2a2a2a; }}
</style>
</head>
<body>
<div class='container'>
  <div class='header'>
    <h1>SMART STOCK</h1>
    <div class='subtitle'>Account Verification</div>
  </div>
  <div class='content'>
    <p>Hello! Use the code below to verify your new SmartStock account.</p>
    <div class='code-box'>{0}</div>
    <p class='note'>This code is valid for a single use.<br>If you didn't request this, please ignore this email.</p>
  </div>
  <div class='footer'>&copy; {1} SmartStock Security Team</div>
</div>
</body>
</html>";

            // Această linie va funcționa acum corect:
            string finalBody = string.Format(htmlTemplate, verificationCode, DateTime.Now.Year);
            try
            {
                var msg = new MailMessage();
                msg.From = new MailAddress(AuthEmail, "SmartStock Security");
                msg.To.Add(receiverEmail);
                msg.Subject = "Your SmartStock Access Code: " + verificationCode;
                msg.Body = finalBody;
                msg.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(AuthEmail, AuthPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(msg);
                return verificationCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Sends an HTML report email with an optional PNG chart attachment.
        /// Fully asynchronous — the SMTP round-trip never runs on the UI thread,
        /// so the app stays responsive even when the connection is slow or times out.
        /// Exceptions propagate to the caller (logged + surfaced by ReportScheduler).
        /// </summary>
        public static async Task SendReportAsync(string recipientEmail, string subject, string htmlBody, string? attachmentPath = null)
        {
            using var msg = new MailMessage();
            msg.From = new MailAddress(ReportsEmail, "SmartStock Reports");
            msg.To.Add(recipientEmail);
            msg.Subject = subject;
            msg.Body = htmlBody;
            msg.IsBodyHtml = true;

            if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                msg.Attachments.Add(new Attachment(attachmentPath, "image/png"));

            using var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(ReportsEmail, ReportsPassword),
                EnableSsl = true,
            };

            await smtpClient.SendMailAsync(msg);
        }
    }
}
