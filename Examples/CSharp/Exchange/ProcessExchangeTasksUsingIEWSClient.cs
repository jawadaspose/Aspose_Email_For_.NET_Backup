﻿using System;
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
    class ProcessExchangeTasksUsingIEWSClient
    {
        public static void Run()
        {
            // ExStart:ProcessExchangeTasksUsingIEWSClient
            // Create instance of EWSClient class by giving credentials
            IEWSClient client = EWSClient.GetEWSClient("https://outlook.office365.com/ews/exchange.asmx", "testUser", "pwd", "domain");

            // Create Exchange task object
            ExchangeTask task = new ExchangeTask();

            // Set task subject and status to In progress
            task.Subject = "New-Test";
            task.Status = ExchangeTaskStatus.InProgress;
            client.CreateTask(client.MailboxInfo.TasksUri, task);
            // ExEnd:ProcessExchangeTasksUsingIEWSClient
        }
    }
}