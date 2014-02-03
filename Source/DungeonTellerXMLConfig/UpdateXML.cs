using System.Xml.Serialization;

namespace Dungeon_Teller.XML
{
	[XmlRoot("update")]
	public class UpdateXML : ConfigXML
	{
		public string wow_version;
		public string tool_version;
		public string updater_version;
		public int force_offsets;
		public string download_url;
		public string msg;
	}
}
