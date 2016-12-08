﻿using Aspose.Email.Outlook;
using Aspose.Email.Outlook.Pst;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class CheckPasswordProtection
    {
        public static void Run()
        {
            // ExStart:CheckPasswordProtection
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();

            MapiMessage mapiMessage = MapiMessage.FromFile(dataDir + "message1.msg");
            FollowUpManager.MarkAsCompleted(mapiMessage);
            mapiMessage.Save(dataDir + "MarkedCompleted_out.msg");
        }

        /// <summary>
        /// Determines whether the specified PST is password protected.
        /// </summary>
        private static bool IsPasswordProtected(PersonalStorage pst)
        {
            // ExStart:CheckPasswordProtection-IsPasswordProtected
            // If the property exists and is nonzero, then the PST file is password protected.
            if (pst.Store.Properties.Contains(MapiPropertyTag.PR_PST_PASSWORD))
            {
                long passwordHash = pst.Store.Properties[MapiPropertyTag.PR_PST_PASSWORD].GetLong();
                return passwordHash != 0;
            }
            return false;
            // ExEnd:CheckPasswordProtection-IsPasswordProtected
        }     
    }
}