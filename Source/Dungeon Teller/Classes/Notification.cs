using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Dungeon_Teller.Classes
{
	class Notification
	{
		public static void sendPushNotification(int providerIndex, string key, string title, string message)
		{
			WebClient client = new WebClient();
			NameValueCollection data = new NameValueCollection();
			client.Proxy = null;

			Uri api = null;
			NameValueCollection parameters = null;

			if (providerIndex == 1)
			{
				parameters = new NameValueCollection {
					{ "token", "X52StO16VHy9Jho2mac2G0RNNJD6qP" },
					{ "user", key },
					{ "title", title },
					{ "message", message }
				};

				api = new Uri("https://api.pushover.net/1/messages.json");
			}
			else if (providerIndex == 2 || providerIndex == 3)
			{
				parameters = new NameValueCollection {
					{ "apikey", key },
					{ "application", "Dungeon Teller" },
					{ "event", title },
					{ "description", message }
				};

				if (providerIndex == 2)
					api = new Uri("https://www.notifymyandroid.com/publicapi/notify");
				if (providerIndex == 3)
					api = new Uri("https://api.prowlapp.com/publicapi/add");
			}

			client.UploadValuesAsync(api, "POST", parameters);
		}

		public static void sendMail(string toAddress, string subject, string message)
		{
			MailAddress From = new MailAddress("Dungeon Teller <dungeon-teller@localhost>");
			MailAddress To = new MailAddress(toAddress);

			MailMessage msg = new MailMessage(From, To);
			msg.Subject = subject;
			msg.Body = message;

			try
			{
				string address = To.ToString();
				string domain = address.Substring(address.IndexOf('@') + 1);
				string mxRecord = DnsLookUp.GetMXRecords(domain)[0];
				SmtpClient client = new SmtpClient(mxRecord);
				client.SendAsync(msg, "message1");
			}
			catch (Exception ex)
			{
				MessageBox.Show(String.Format("Failed to send email with the following error:\n'{0}'", ex.Message), "Mail-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
