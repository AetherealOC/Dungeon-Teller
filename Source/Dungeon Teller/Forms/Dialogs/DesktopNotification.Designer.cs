namespace Dungeon_Teller
{
	partial class DesktopNotification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopNotification));
			this.btn_accept = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_desc = new System.Windows.Forms.Label();
			this.lbl_heading = new System.Windows.Forms.Label();
			this.pic_image = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_accept
			// 
			this.btn_accept.AutoSize = true;
			this.btn_accept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_accept.Location = new System.Drawing.Point(233, 93);
			this.btn_accept.Name = "btn_accept";
			this.btn_accept.Size = new System.Drawing.Size(92, 23);
			this.btn_accept.TabIndex = 1;
			this.btn_accept.Text = "Switch to WoW";
			this.btn_accept.UseVisualStyleBackColor = true;
			// 
			// btn_cancel
			// 
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(331, 93);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 2;
			this.btn_cancel.Text = "Close";
			this.btn_cancel.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lbl_desc);
			this.panel1.Controls.Add(this.lbl_heading);
			this.panel1.Controls.Add(this.pic_image);
			this.panel1.Location = new System.Drawing.Point(0, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(420, 85);
			this.panel1.TabIndex = 3;
			// 
			// lbl_desc
			// 
			this.lbl_desc.AutoSize = true;
			this.lbl_desc.Location = new System.Drawing.Point(87, 39);
			this.lbl_desc.MaximumSize = new System.Drawing.Size(319, 35);
			this.lbl_desc.Name = "lbl_desc";
			this.lbl_desc.Size = new System.Drawing.Size(191, 13);
			this.lbl_desc.TabIndex = 2;
			this.lbl_desc.Text = "Your queue for \'dungeon\' is now ready!";
			// 
			// lbl_heading
			// 
			this.lbl_heading.AutoSize = true;
			this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lbl_heading.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbl_heading.Location = new System.Drawing.Point(83, 11);
			this.lbl_heading.Name = "lbl_heading";
			this.lbl_heading.Size = new System.Drawing.Size(85, 24);
			this.lbl_heading.TabIndex = 1;
			this.lbl_heading.Text = "Category";
			// 
			// pic_image
			// 
			this.pic_image.Image = global::Dungeon_Teller.Properties.Resources.dungeon_finder_icon;
			this.pic_image.Location = new System.Drawing.Point(12, 10);
			this.pic_image.Name = "pic_image";
			this.pic_image.Size = new System.Drawing.Size(64, 64);
			this.pic_image.TabIndex = 0;
			this.pic_image.TabStop = false;
			// 
			// DesktopNotification
			// 
			this.AcceptButton = this.btn_accept;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(418, 122);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_accept);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DesktopNotification";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dungeon Teller - Notification";
			this.TopMost = true;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_image;
		private System.Windows.Forms.Button btn_accept;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_heading;
		private System.Windows.Forms.Label lbl_desc;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}