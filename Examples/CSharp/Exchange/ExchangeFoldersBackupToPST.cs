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
    class ExchangeFoldersBackupToPST
    {
        public static void Run()
        {
            // ExStart:ExchangeFoldersBackupToPST
            string dataDir = RunExamples.GetDataDir_Exchange();
            // Create instance of IEWSClient class by providing credentials
            const string mailboxUri = "https://ews.domain.com/ews/Exchange.asmx";
            const string domain = @"";
            const string username = @"username";
            const string password = @"password";
            NetworkCredential credential = new NetworkCredential(username, password, domain);
            IEWSClient client = EWSClient.GetEWSClient(mailboxUri, credential);

            // Get Exchange mailbox info of other email account
            ExchangeMailboxInfo mailboxInfo = client.GetMailboxInfo();
            ExchangeFolderInfo info = client.GetFolderInfo(mailboxInfo.InboxUri);
            ExchangeFolderInfoCollection fc = new ExchangeFolderInfoCollection();
            fc.Add(info);
            client.Backup(fc, dataDir + "Backup_out.pst", Aspose.Email.Outlook.Pst.BackupOptions.None);
            // ExEnd:ExchangeFoldersBackupToPST
        }
    }
}