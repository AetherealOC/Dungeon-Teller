using System.Xml.Serialization;

namespace Dungeon_Teller.Classes.Config
{
	[XmlRoot("update")]
	public class UpdateXML : ConfigXML
	{
		[XmlIgnore]
		public static string filename="update.xml";

		public string wow_version;
		public string tool_version;
		public int force_offsets;
		public string download_url;
		public string msg;
	}
}
