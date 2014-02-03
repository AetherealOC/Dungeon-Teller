namespace Dungeon_Teller.Forms.Dialogs
{
	partial class UpdaterDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterDialog));
			this.btn_no = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_desc = new System.Windows.Forms.Label();
			this.lbl_title = new System.Windows.Forms.Label();
			this.pic_image = new System.Windows.Forms.PictureBox();
			this.btn_yes = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_no
			// 
			this.btn_no.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btn_no.Location = new System.Drawing.Point(295, 91);
			this.btn_no.Name = "btn_no";
			this.btn_no.Size = new System.Drawing.Size(75, 23);
			this.btn_no.TabIndex = 1;
			this.btn_no.Text = "No";
			this.btn_no.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lbl_desc);
			this.panel1.Controls.Add(this.lbl_title);
			this.panel1.Controls.Add(this.pic_image);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(385, 85);
			this.panel1.TabIndex = 4;
			// 
			// lbl_desc
			// 
			this.lbl_desc.AutoSize = true;
			this.lbl_desc.Location = new System.Drawing.Point(84, 35);
			this.lbl_desc.MaximumSize = new System.Drawing.Size(250, 40);
			this.lbl_desc.Name = "lbl_desc";
			this.lbl_desc.Size = new System.Drawing.Size(158, 39);
			this.lbl_desc.TabIndex = 2;
			this.lbl_desc.Text = "Your offsets version: 5.2.52343\r\nLatest offsets version:: 5.2.3424\r\nDo you want t" +
    "o update them?";
			this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title
			// 
			this.lbl_title.AutoSize = true;
			this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.lbl_title.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbl_title.Location = new System.Drawing.Point(82, 9);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(174, 26);
			this.lbl_title.TabIndex = 1;
			this.lbl_title.Text = "Update available";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_image
			// 
			this.pic_image.Image = global::Dungeon_Teller.Properties.Resources.download;
			this.pic_image.Location = new System.Drawing.Point(12, 10);
			this.pic_image.Name = "pic_image";
			this.pic_image.Size = new System.Drawing.Size(64, 64);
			this.pic_image.TabIndex = 0;
			this.pic_image.TabStop = false;
			// 
			// btn_yes
			// 
			this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.btn_yes.Location = new System.Drawing.Point(214, 91);
			this.btn_yes.Name = "btn_yes";
			this.btn_yes.Size = new System.Drawing.Size(75, 23);
			this.btn_yes.TabIndex = 5;
			this.btn_yes.Text = "Yes";
			this.btn_yes.UseVisualStyleBackColor = true;
			// 
			// UpdaterDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 123);
			this.Controls.Add(this.btn_yes);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_no);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdaterDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dungeon Teller - Updater";
			this.TopMost = true;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_no;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_desc;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.PictureBox pic_image;
		private System.Windows.Forms.Button btn_yes;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}