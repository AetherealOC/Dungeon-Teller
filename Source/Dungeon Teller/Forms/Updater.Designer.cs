namespace Dungeon_Teller.Forms
{
	partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.workerLoadUpdateXml = new System.ComponentModel.BackgroundWorker();
            this.lbl_status = new System.Windows.Forms.Label();
            this.workerLoadOffsets = new System.ComponentModel.BackgroundWorker();
            this.workerLoadUpdater = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // workerLoadUpdateXml
            // 
            this.workerLoadUpdateXml.WorkerReportsProgress = true;
            this.workerLoadUpdateXml.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoadUpdateXml_DoWork);
            this.workerLoadUpdateXml.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoadUpdateXml_RunWorkerCompleted);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_status.Location = new System.Drawing.Point(12, 9);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(221, 24);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Checking for updates ...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // workerLoadOffsets
            // 
            this.workerLoadOffsets.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoadOffsets_DoWork);
            this.workerLoadOffsets.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoadOffsets_RunWorkerCompleted);
            // 
            // workerLoadUpdater
            // 
            this.workerLoadUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoadUpdater_DoWork);
            this.workerLoadUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoadUpdater_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dungeon_Teller.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(58, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 15);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 83);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Teller - Updater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Updater_Load);
            this.Shown += new System.EventHandler(this.Updater_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker workerLoadUpdateXml;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker workerLoadOffsets;
		private System.ComponentModel.BackgroundWorker workerLoadUpdater;
	}
}