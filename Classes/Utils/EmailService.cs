
namespace SmartStock.Classes.Utils
{
    using System;
    using System.Net;
    using System.Net.Mail;

    public static class EmailService
    {
        // Configurează aceste date în appSettings.json 
        private static readonly string SenderEmail = "smartstock.auth@gmail.com";
        private static readonly string SenderPassword = "atpmqdmhoglkariy";

        public static string SendVerificationCode(string receiverEmail)
        {
            Random random = new Random();
            string verificationCode = random.Next(100000, 999999).ToString();

            // Șablonul HTML (păstrat într-un string sau fișier local)
            // Modifică string-ul HTML astfel (observă acoladele duble la CSS):
            string htmlTemplate = @"
                <!DOCTYPE html>
                <html>
                <head>
                    <style>
                        body {{ background-color: #1a1a1a; margin: 0; padding: 0; font-family: 'Segoe UI', sans-serif; }}
                        .container {{ max-width: 600px; margin: 40px auto; background-color: #252525; border: 1px solid #333; border-radius: 8px; overflow: hidden; }}
                        .header {{ background-color: #333; padding: 20px; text-align: center; border-bottom: 2px solid #ffffff; }}
                        .header h1 {{ color: #ffffff; margin: 0; font-size: 24px; letter-spacing: 2px; }}
                        .content {{ padding: 40px; text-align: center; color: #cccccc; }}
                        .code-box {{ background-color: #111; border: 1px dashed #ffffff; color: #ffffff; font-size: 36px; font-weight: bold; letter-spacing: 10px; padding: 20px; margin: 30px 0; display: inline-block; border-radius: 4px; }}
                        .footer {{ padding: 20px; text-align: center; color: #666; font-size: 12px; background-color: #1f1f1f; }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'><h1>SMART STOCK</h1></div>
                        <div class='content'>
                            <p>Hello! Use the following code to verify your new account:</p>
                            <div class='code-box'>{0}</div>
                            <p>If you didn't request this code, please ignore this email.</p>
                        </div>
                        <div class='footer'>&copy; 2026 SmartStock Security Team</div>
                    </div>
                </body>
                </html>";

            // Această linie va funcționa acum corect:
            string finalBody = string.Format(htmlTemplate, verificationCode);
            try
            {
                var msg = new MailMessage();
                msg.From = new MailAddress(SenderEmail, "SmartStock Security");
                msg.To.Add(receiverEmail);
                msg.Subject = "Your SmartStock Access Code: " + verificationCode;
                msg.Body = finalBody;
                msg.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(SenderEmail, SenderPassword),
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
    }
}
