﻿using System;
using System.Net;
using Aspose.Email.Exchange;
using Aspose.Email.Mail;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.Exchange
{
    class DeleteMessagesFromExchangeServer
    {
        public static void Run()
        {
            // ExStart:DeleteMessagesFromExchangeServer
            // Create instance of IEWSClient class by giving credentials
            string mailboxURI = "https://Ex2003/exchange/administrator"; // WebDAV

            string username = "administrator";
            string password = "pwd";
            string domain = "domain.local";

            Console.WriteLine("Connecting to Exchange Server....");
            NetworkCredential credential = new NetworkCredential(username, password, domain);
            ExchangeClient client = new ExchangeClient(mailboxURI, credential);

            ExchangeMailboxInfo mailboxInfo = client.GetMailboxInfo();

            // List all messages from Inbox folder
            Console.WriteLine("Listing all messages from Inbox....");
            ExchangeMessageInfoCollection msgInfoColl = client.ListMessages(mailboxInfo.InboxUri);
            foreach (ExchangeMessageInfo msgInfo in msgInfoColl)
            {
                // Delete message based on some criteria
                if (msgInfo.Subject != null &&
                    msgInfo.Subject.ToLower().Contains("delete") == true)
                {
                    client.DeleteMessage(msgInfo.UniqueUri);
                    Console.WriteLine("Message deleted...." + msgInfo.Subject);
                }
                else
                {
                    // Do something else
                }
            }
            // ExEnd:DeleteMessagesFromExchangeServer
        }
    }
}