namespace Dungeon_Teller.Updater.Forms
{
	partial class Update
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
			this.lbl_status = new System.Windows.Forms.Label();
			this.bw_extractUpdate = new System.ComponentModel.BackgroundWorker();
			this.progress_status = new Dungeon_Teller.Updater.Controls.CustomProgressBar();
			this.SuspendLayout();
			// 
			// lbl_status
			// 
			this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lbl_status.Location = new System.Drawing.Point(0, 10);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(200, 16);
			this.lbl_status.TabIndex = 1;
			this.lbl_status.Text = "Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bw_extractUpdate
			// 
			this.bw_extractUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_extractUpdate_DoWork);
			this.bw_extractUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_extractUpdate_RunWorkerCompleted);
			// 
			// progress_status
			// 
			this.progress_status.BackColor = System.Drawing.SystemColors.Window;
			this.progress_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.progress_status.ForeColor = System.Drawing.SystemColors.Highlight;
			this.progress_status.Location = new System.Drawing.Point(10, 30);
			this.progress_status.Name = "progress_status";
			this.progress_status.Size = new System.Drawing.Size(180, 25);
			this.progress_status.TabIndex = 2;
			this.progress_status.Value = 0F;
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(204, 71);
			this.Controls.Add(this.progress_status);
			this.Controls.Add(this.lbl_status);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Update";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Updater";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_status;
		private System.ComponentModel.BackgroundWorker bw_extractUpdate;
		private Controls.CustomProgressBar progress_status;
	}
}

