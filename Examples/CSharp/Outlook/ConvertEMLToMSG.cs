﻿using Aspose.Email.Mail;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class ConvertEMLToMSG
    {
        public static void Run()
        {
            //ExStart:ConvertEMLToMSG
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();

            // Load mail message
            MailMessage message = MailMessage.Load(dataDir + "Message.eml", new EmlLoadOptions());
            // Save as MSG
            message.Save(dataDir + "ConvertEMLToMSG_out.msg", SaveOptions.DefaultMsgUnicode);
            //ExEnd:ConvertEMLToMSG
        }
    }
}