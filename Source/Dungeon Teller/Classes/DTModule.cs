using System.Windows.Forms;

namespace Dungeon_Teller.Classes
{
	class DTModule
	{

		public DTModule()
		{

		}

		public DTModule(Label lbl_Status, Label lbl_Wait, Label lbl_QueueTime)
		{
			this.lbl_Status = lbl_Status;
			this.lbl_Wait = lbl_Wait;
			this.lbl_QueueTime = lbl_QueueTime;
		}

		public DTModule(Label lbl_Status, Label lbl_Wait, Label lbl_QueueTime, Label lbl_Tank, Label lbl_Healer, Label lbl_Dps, PictureBox pic_Tank, PictureBox pic_Heal, PictureBox pic_Dps)
		{
			this.lbl_Status = lbl_Status;
			this.lbl_Wait = lbl_Wait;
			this.lbl_QueueTime = lbl_QueueTime;
			this.lbl_Tank = lbl_Tank;
			this.lbl_Healer = lbl_Healer;
			this.lbl_Dps = lbl_Dps;
			this.pic_Tank = pic_Tank;
			this.pic_Heal = pic_Heal;
			this.pic_Dps = pic_Dps;
		}

		public Label lbl_Status = null;
		public Label lbl_Wait = null;
		public Label lbl_QueueTime = null;
		public Label lbl_Tank = null;
		public Label lbl_Healer = null;
		public Label lbl_Dps = null;
		public PictureBox pic_Tank = null;
		public PictureBox pic_Heal = null;
		public PictureBox pic_Dps = null;
	}
}