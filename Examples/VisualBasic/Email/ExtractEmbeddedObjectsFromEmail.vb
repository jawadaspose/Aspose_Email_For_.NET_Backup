﻿Imports Aspose.Email.Mail

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email
	Class ExtractEmbeddedObjectsFromEmail
		Public Shared Sub Run()
			' ExStart:ExtractEmbeddedObjectsFromEmail
			' The path to the File directory.
			Dim dataDir As String = RunExamples.GetDataDir_Email()

			' Create an instance of MailMessage and load an email file
            Dim mailMsg As MailMessage = MailMessage.Load(dataDir & Convert.ToString("Message.msg"), New MsgLoadOptions())

			For Each attachment As Attachment In mailMsg.Attachments
				' To display the the attachment file name
				attachment.Save("filename")
				Console.WriteLine(attachment.Name)
			Next

			mailMsg.From = "sender@sender.com"
			mailMsg.[To].Add("receiver@receiver.com")

            Dim client As New SmtpClient("smtp.server.com") With { _
                .Port = 25, _
                .Username = "UserName", _
                .Password = "password" _
            }

            client.Send(dataDir & Convert.ToString("Message.msg"))
			' ExEnd:ExtractEmbeddedObjectsFromEmail
		End Sub
	End Class
End Namespace