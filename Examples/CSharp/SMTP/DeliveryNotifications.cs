﻿using System;
using System.Diagnostics;
using Aspose.Email.Mail;

namespace Aspose.Email.Examples.CSharp.Email.IMAP
{
    class DeliveryNotifications
    {
        public static void Run()
        {
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_SMTP();
            string dstEmail = dataDir + "test.eml";

            // Create an instance MailMessage class
            MailMessage msg = new MailMessage();

            // Setting Delivery Notification 
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;


            // Use MailMessage properties like specify sender, recipient and message
            msg.To = "asposetest123@gmail.com";
            msg.From = "newcustomeronnet@gmail.com";
            msg.Subject = "Test Email";
            msg.Body = "Hello World!";


            // Create an instance of SmtpClient class
            SmtpClient client = GetSmtpClient();

            try
            {
                // Client.Send will send this message
                client.Send(msg);
                // Message sent successfully
                Console.WriteLine("Message sent");
            }

            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            Console.WriteLine(Environment.NewLine + "Email sent with delivery notification.");
        }

        private static SmtpClient GetSmtpClient()
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587, "your.email@gmail.com", "your.password");
            client.SecurityOptions = SecurityOptions.Auto;

            return client;
        }
    }
}