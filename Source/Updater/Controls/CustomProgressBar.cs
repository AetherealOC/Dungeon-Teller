﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Dungeon_Teller.Updater.Controls
{
	public partial class CustomProgressBar : UserControl
	{
		public CustomProgressBar()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
            this.ForeColor = SystemColors.Highlight; // Set the default color of the Pbar 
        }
        protected float percent = 0.0f; // Protected because we don't want this to be accessed from the outside
        // Create a Value property for the Pbar
        public float Value
        {
            get
            {
                return percent;
            }
            set
            {
                // Maintain the Value between 0 and 100
                if (value < 0) value = 0;
                else if (value > 100) value = 100;
                percent = value;
                label1.Text = value.ToString() + "%"; 
                // Redraw the Pbar every time the Value changes
                this.Invalidate(); 
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Brush b = new SolidBrush(this.ForeColor); // Create a brush that will draw the background of the Pbar
            // Create a linear gradient that will be drawn over the background. FromArgb means you can use the Alpha value wich is the transparency
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color.FromArgb(255, Color.White), Color.FromArgb(50, Color.White), LinearGradientMode.ForwardDiagonal);     
            // Calculate how much has the Pbar to be filled for "x" %
            int width = (int)((percent / 100) * this.Width);
            e.Graphics.FillRectangle(b, 0, 0, width, this.Height);
            e.Graphics.FillRectangle(lb, 0, 0, width, this.Height);
            b.Dispose(); lb.Dispose(); 
        }

        private void Pbar_SizeChanged(object sender, EventArgs e)
        {
            // Maintain the label in the center of the Pbar
            label1.Location = new Point(this.Width / 2 - 21 / 2 - 4, this.Height / 2 - 15 / 2);
        }
	}
}
