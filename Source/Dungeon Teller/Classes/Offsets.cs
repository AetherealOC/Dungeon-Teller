using Dungeon_Teller.XML;
using System.Xml.Serialization;

namespace Dungeon_Teller.Classes
{
	class Offsets : OffsetXML
	{

		static Offsets()
		{
			initialize();
		}

		private static void initialize()
		{
			OffsetXML off = OffsetXML.getLocal<OffsetXML>(Properties.Settings.Default.OffSetXML);

			Offsets.playerName = off.playerName;
			Offsets.playerRealm = off.playerRealm;
			Offsets.lfgQueueStats = off.lfgQueueStats;
			Offsets.lfgProposal = off.lfgProposal;
			Offsets.bgQueueStats = off.bgQueueStats;
			Offsets.dbc = off.dbc;
		}

		public static void reinitialize()
		{
			initialize();
		}

		new public static BaseAddress playerName;
		new public static BaseAddress playerRealm;
		new public static BaseAddress lfgQueueStats;
		new public static BaseAddress lfgProposal;
		new public static BGQueueStats bgQueueStats;
		new public static DBC dbc;
	}
}
