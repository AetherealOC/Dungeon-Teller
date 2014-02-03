namespace Dungeon_Teller.Updater.Forms
{
	partial class UpdateCompleted
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCompleted));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_desc = new System.Windows.Forms.Label();
			this.lbl_heading = new System.Windows.Forms.Label();
			this.pic_image = new System.Windows.Forms.PictureBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_start = new System.Windows.Forms.Button();
			this.timer_startDungeonTeller = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lbl_desc);
			this.panel1.Controls.Add(this.lbl_heading);
			this.panel1.Controls.Add(this.pic_image);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(406, 94);
			this.panel1.TabIndex = 4;
			// 
			// lbl_desc
			// 
			this.lbl_desc.AutoSize = true;
			this.lbl_desc.Location = new System.Drawing.Point(87, 39);
			this.lbl_desc.MaximumSize = new System.Drawing.Size(310, 45);
			this.lbl_desc.Name = "lbl_desc";
			this.lbl_desc.Size = new System.Drawing.Size(301, 39);
			this.lbl_desc.TabIndex = 2;
			this.lbl_desc.Text = "If you want Dungeon Teller to be continued in the future then please take a momen" +
    "t and give me some motivation and send me some reputation on Ownedcore.";
			// 
			// lbl_heading
			// 
			this.lbl_heading.AutoSize = true;
			this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lbl_heading.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbl_heading.Location = new System.Drawing.Point(83, 11);
			this.lbl_heading.Name = "lbl_heading";
			this.lbl_heading.Size = new System.Drawing.Size(189, 24);
			this.lbl_heading.TabIndex = 1;
			this.lbl_heading.Text = "Download completed";
			// 
			// pic_image
			// 
			this.pic_image.Image = global::Dungeon_Teller.Updater.Properties.Resources.Ok;
			this.pic_image.Location = new System.Drawing.Point(13, 11);
			this.pic_image.Name = "pic_image";
			this.pic_image.Size = new System.Drawing.Size(64, 64);
			this.pic_image.TabIndex = 0;
			this.pic_image.TabStop = false;
			// 
			// btn_cancel
			// 
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(318, 102);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 6;
			this.btn_cancel.Text = "Close";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_start
			// 
			this.btn_start.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_start.Location = new System.Drawing.Point(172, 102);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(140, 23);
			this.btn_start.TabIndex = 5;
			this.btn_start.Text = "Start Dungeon Teller [15]";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// timer_startDungeonTeller
			// 
			this.timer_startDungeonTeller.Interval = 1000;
			this.timer_startDungeonTeller.Tick += new System.EventHandler(this.startDungeonTeller_Tick);
			// 
			// UpdateCompleted
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 137);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UpdateCompleted";
			this.Text = "UpdateCompleted";
			this.Shown += new System.EventHandler(this.UpdateCompleted_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_desc;
		private System.Windows.Forms.Label lbl_heading;
		private System.Windows.Forms.PictureBox pic_image;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Timer timer_startDungeonTeller;
	}
}