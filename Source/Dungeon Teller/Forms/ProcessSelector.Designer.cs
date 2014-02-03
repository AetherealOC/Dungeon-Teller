namespace Dungeon_Teller.Forms
{
	partial class ProcessSelector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessSelector));
            this.lbx_WoWIds = new System.Windows.Forms.ListBox();
            this.lbl_processCount = new System.Windows.Forms.Label();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.lbl_processInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_WoWIds
            // 
            this.lbx_WoWIds.FormattingEnabled = true;
            this.lbx_WoWIds.Location = new System.Drawing.Point(10, 60);
            this.lbx_WoWIds.Name = "lbx_WoWIds";
            this.lbx_WoWIds.Size = new System.Drawing.Size(240, 95);
            this.lbx_WoWIds.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lbx_WoWIds, "Tip: If you doubleclick on an id it will point you to the corrosponding WoW windo" +
        "w.");
            this.lbx_WoWIds.DoubleClick += new System.EventHandler(this.lbx_WoWIds_DoubleClick);
            // 
            // lbl_processCount
            // 
            this.lbl_processCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_processCount.Location = new System.Drawing.Point(12, 9);
            this.lbl_processCount.Name = "lbl_processCount";
            this.lbl_processCount.Size = new System.Drawing.Size(240, 17);
            this.lbl_processCount.TabIndex = 7;
            this.lbl_processCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 750;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // lbl_processInfo
            // 
            this.lbl_processInfo.Location = new System.Drawing.Point(10, 26);
            this.lbl_processInfo.Name = "lbl_processInfo";
            this.lbl_processInfo.Size = new System.Drawing.Size(240, 31);
            this.lbl_processInfo.TabIndex = 6;
            this.lbl_processInfo.Text = "Please select your wow process";
            this.lbl_processInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::Dungeon_Teller.Properties.Resources.Refresh;
            this.btn_Refresh.Location = new System.Drawing.Point(135, 161);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(115, 55);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btn_Refresh, "This button will refresh the list of World of Warcraft processes running on your " +
        "computer.");
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Attach
            // 
            this.btn_Attach.Image = global::Dungeon_Teller.Properties.Resources.Attach;
            this.btn_Attach.Location = new System.Drawing.Point(10, 161);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(115, 55);
            this.btn_Attach.TabIndex = 4;
            this.btn_Attach.Text = "Attach";
            this.btn_Attach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Attach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btn_Attach, "This will attach DT to the World of Warcraft.");
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // ProcessSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 222);
            this.Controls.Add(this.lbl_processCount);
            this.Controls.Add(this.lbl_processInfo);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Attach);
            this.Controls.Add(this.lbx_WoWIds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Teller - Process selector";
            this.Load += new System.EventHandler(this.ProcessSelector_Load);
            this.Shown += new System.EventHandler(this.ProcessSelector_Shown);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbx_WoWIds;
		private System.Windows.Forms.Button btn_Attach;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.Label lbl_processCount;
		private System.Windows.Forms.Timer timerBlink;
		private System.Windows.Forms.Label lbl_processInfo;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}