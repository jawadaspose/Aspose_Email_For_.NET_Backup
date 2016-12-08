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
    class ReadUserConfiguration
    {
        public static void Run()
        {
            const string mailboxUri = "https://exchnage/ews/exchange.asmx";
            const string domain = @"";
            const string username = @"username@ASE305.onmicrosoft.com";
            const string password = @"password";
            NetworkCredential credentials = new NetworkCredential(username, password, domain);
            IEWSClient client = EWSClient.GetEWSClient(mailboxUri, credentials);
            Console.WriteLine("Connected to Exchange 2010");

            // ExStart:ReadUserConfiguration
            // Get the User Configuration for Inbox folder
            UserConfigurationName userConfigName = new UserConfigurationName("inbox.config", client.MailboxInfo.InboxUri);
            UserConfiguration userConfig = client.GetUserConfiguration(userConfigName);

            Console.WriteLine("Configuration Id: " + userConfig.Id);
            Console.WriteLine("Configuration Name: " + userConfig.UserConfigurationName.Name);
            Console.WriteLine("Key value pairs:");
            foreach (string key in userConfig.Dictionary.Keys)
            {
                Console.WriteLine(key + ": " + userConfig.Dictionary[key].ToString());
            }
            // ExEnd:ReadUserConfiguration
        }
    }
}