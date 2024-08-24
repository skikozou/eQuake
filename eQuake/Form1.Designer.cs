namespace eQuake
{
	partial class eQuakeMonitor
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eQuakeMonitor));
			TaskbarAlert = new NotifyIcon(components);
			CheckData = new System.Windows.Forms.Timer(components);
			debugOut = new Label();
			Monitor = new PictureBox();
			richTextBox1 = new RichTextBox();
			debugB = new Button();
			((System.ComponentModel.ISupportInitialize)Monitor).BeginInit();
			SuspendLayout();
			// 
			// TaskbarAlert
			// 
			TaskbarAlert.Icon = (Icon)resources.GetObject("TaskbarAlert.Icon");
			TaskbarAlert.Text = "DeskAlert";
			TaskbarAlert.Visible = true;
			TaskbarAlert.Click += TaskbarAlert_Click;
			// 
			// CheckData
			// 
			CheckData.Interval = 1000;
			CheckData.Tick += CheckData_Tick;
			// 
			// debugOut
			// 
			debugOut.AutoSize = true;
			debugOut.Font = new Font("Yu Gothic UI", 20F);
			debugOut.Location = new Point(12, 9);
			debugOut.Name = "debugOut";
			debugOut.Size = new Size(148, 37);
			debugOut.TabIndex = 0;
			debugOut.Text = "Debug text";
			// 
			// Monitor
			// 
			Monitor.Location = new Point(12, 49);
			Monitor.Name = "Monitor";
			Monitor.Size = new Size(352, 400);
			Monitor.TabIndex = 1;
			Monitor.TabStop = false;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(370, 49);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(500, 400);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
			// 
			// debugB
			// 
			debugB.Location = new Point(139, 456);
			debugB.Name = "debugB";
			debugB.Size = new Size(103, 31);
			debugB.TabIndex = 3;
			debugB.Text = "test alert";
			debugB.UseVisualStyleBackColor = true;
			debugB.Click += debugB_Click;
			// 
			// eQuakeMonitor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(900, 500);
			Controls.Add(debugB);
			Controls.Add(richTextBox1);
			Controls.Add(Monitor);
			Controls.Add(debugOut);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "eQuakeMonitor";
			Text = "eQuakeMonitor";
			TopMost = true;
			Shown += Form1_Shown;
			((System.ComponentModel.ISupportInitialize)Monitor).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NotifyIcon TaskbarAlert;
		private System.Windows.Forms.Timer CheckData;
		private Label debugOut;
		private PictureBox Monitor;
		private RichTextBox richTextBox1;
		private Button debugB;
	}
}
