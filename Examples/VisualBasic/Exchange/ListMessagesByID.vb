﻿Imports Aspose.Email.Exchange

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class ListMessagesByID
		Public Shared Sub Run()
			' ExStart:ListMessagesByID
			' Create instance of ExchangeClient class by giving credentials
			Dim client As New ExchangeClient("https://MachineName/exchange/Username", "username", "password", "domain")

			' Call ListMessages method to list messages info from Inbox
			Dim msgCollection As ExchangeMessageInfoCollection = client.ListMessagesById(client.MailboxInfo.InboxUri, "23A747F0C7A5DB4BAB299C2BE2383FD556E630DD@machinename.local")

			' Loop through the collection to display the basic information
			For Each msgInfo As ExchangeMessageInfo In msgCollection
				Console.WriteLine("Subject: " + msgInfo.Subject)
				Console.WriteLine("From: " + msgInfo.From.ToString())
				Console.WriteLine("To: " + msgInfo.[To].ToString())
				Console.WriteLine("Message ID: " + msgInfo.MessageId)
				Console.WriteLine("Unique URI: " + msgInfo.UniqueUri)
				Console.WriteLine("==================================")
			Next
			' ExEnd:ListMessagesByID
		End Sub
	End Class
End Namespace