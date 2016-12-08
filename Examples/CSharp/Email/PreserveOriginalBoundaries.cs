﻿using System.IO;
using Aspose.Email.Mail;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email
{
    class PreserveOriginalBoundaries
    {
        public static void Run()
        {
            // ExStart:PreservOriginalBoundaries
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Email();

            MailMessage mailMessage = MailMessage.Load(dataDir + "Attachments.eml");

            // Save as eml with preserved original boundares
            EmlSaveOptions emlSaveOptions = new EmlSaveOptions(MailMessageSaveType.EmlFormat)
            {
                PreserveOriginalBoundaries = true
            };
            mailMessage.Save(dataDir + "PreserveOriginalBoundaries_out.eml", emlSaveOptions);
            // ExEnd:PreservOriginalBoundaries
        }
    }
}
