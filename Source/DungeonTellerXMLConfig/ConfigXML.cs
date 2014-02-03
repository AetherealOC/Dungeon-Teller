using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Dungeon_Teller.XML
{
	public class ConfigXML
	{

		static RegistryKey reg = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Dungeon Teller");
		public static string visitorID = (string)reg.GetValue("visitorID");

        public static string base_url = "http://dungeonteller.net78.net/update.php?";

		public static T getRemote<T>(string filename="")
		{
			string url = base_url + filename;
			T remote = default(T);
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			request.CookieContainer = new CookieContainer();

			if (visitorID != null)
			{
                request.CookieContainer.Add(new Cookie("visitorID", visitorID, "/", "dungeonteller.net78.net"));
			}

			string dtVersion = getDtVersion();
			if (dtVersion != null)
				dtVersion = " DungeonTeller/" + dtVersion;

			string userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.152 Safari/537.22" + dtVersion;

			request.UserAgent = userAgent;
			request.Proxy = null;

			try
			{
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					if (response.Cookies.Count != 0)
					{
						visitorID = response.Cookies["visitorID"].Value;
						reg.SetValue("visitorID", visitorID);
					}
					Stream dataStream = response.GetResponseStream();
					StreamReader reader = new StreamReader(dataStream);
					remote = (T)serializer.Deserialize(reader);
					reader.Dispose();
					return remote;
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse response = (HttpWebResponse)ex.Response;
				string msg = String.Format("{0}: {1}", response.StatusDescription, url);
				MessageBox.Show(msg, "Update failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return remote;

		}

		public static T getLocal<T>(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			TextReader reader = new StreamReader(filename);
			T local = (T)serializer.Deserialize(reader);
			reader.Dispose();

			return local;
		}

		public static void writeLocal<T>(T config, string filename)
		{
			TextWriter writer = new StreamWriter(filename);

			XmlSerializer serializer = new XmlSerializer(typeof(T));
			serializer.Serialize(writer, config);
			writer.Dispose();
		}

		public static string getDtVersion()
		{
			string dtVersion = null;
			foreach (FileInfo file in new DirectoryInfo(".").GetFiles("*.exe"))
			{
				if (!file.Name.Contains("Updater"))
					dtVersion = FileVersionInfo.GetVersionInfo(file.Name).ProductVersion;
			}

			return dtVersion;
		}

	}
}
