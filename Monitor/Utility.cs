using System;
using System.IO;
using MailKit.Net.Smtp;
using MimeKit;

namespace Monitor
{
    internal class Utility
    {
        /// <summary>
        /// Sends an email from <paramref name="senderEmail"/> to <paramref name="recipientEmail"/>
        /// with an attached file that exists in <paramref name="filePath"/>.
        /// </summary>
        /// <param name="senderEmail"></param>
        /// <param name="recipientEmail"></param>
        /// <param name="filePath"></param>
        public void SendEmail(string senderEmail, string recipientEmail, string filePath)
        {
            string currentTime = DateTime.Now.ToString("F");
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name: "Workload Monitor", address: senderEmail));
            message.To.Add(new MailboxAddress(name: "Recipient", address: recipientEmail));
            message.Subject = "Your PC Workload";
            var builder = new BodyBuilder();
            builder.TextBody = currentTime + "\nYour workload over the past HOUR";
            builder.Attachments.Add(filePath);
            message.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(host: "smtp.gmail.com", port: 587, MailKit.Security.SecureSocketOptions.Auto);
                    client.Authenticate(userName: senderEmail, password: "insert password here");
                    client.Send(message);
                    client.Disconnect(true);

                }
                catch (Exception ex)
                {

                    LogData(ex.Message);
                    Environment.Exit(1);

                }
            }

        }
        /// <summary>
        /// Writes data into a file <paramref name="message"/>. Creates it if it does not exist!
        /// </summary>
        /// <param name="message"></param>
        public void LogData(string message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.ToShortDateString().Replace('/', '_') + ".txt";
            if (File.Exists(filepath))
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(message);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(message);
                }
            }

        }
    }
}
