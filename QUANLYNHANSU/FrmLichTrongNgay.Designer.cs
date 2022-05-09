namespace QUANLYNHANSU
{
	partial class FrmLichTrongNgay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichTrongNgay));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MnuThemViec = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuHomNay = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNextDay = new System.Windows.Forms.Button();
			this.dateDay = new System.Windows.Forms.DateTimePicker();
			this.panJob = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuThemViec,
            this.MnuHomNay});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(933, 38);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MnuThemViec
			// 
			this.MnuThemViec.BackgroundImage = global::QUANLYNHANSU.Properties.Resources._1331;
			this.MnuThemViec.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.MnuThemViec.Name = "MnuThemViec";
			this.MnuThemViec.Size = new System.Drawing.Size(127, 34);
			this.MnuThemViec.Text = "Thêm Việc";
			this.MnuThemViec.Click += new System.EventHandler(this.MnuThemViec_Click);
			// 
			// MnuHomNay
			// 
			this.MnuHomNay.BackgroundImage = global::QUANLYNHANSU.Properties.Resources._1331;
			this.MnuHomNay.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.MnuHomNay.Name = "MnuHomNay";
			this.MnuHomNay.Size = new System.Drawing.Size(117, 34);
			this.MnuHomNay.Text = "Hôm Nay";
			this.MnuHomNay.Click += new System.EventHandler(this.MnuHomNay_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.btnPrevious);
			this.panel1.Controls.Add(this.btnNextDay);
			this.panel1.Controls.Add(this.dateDay);
			this.panel1.Location = new System.Drawing.Point(0, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(933, 50);
			this.panel1.TabIndex = 1;
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnPrevious.Location = new System.Drawing.Point(3, 5);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(138, 44);
			this.btnPrevious.TabIndex = 2;
			this.btnPrevious.Text = "Hôm Qua";
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNextDay
			// 
			this.btnNextDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnNextDay.Location = new System.Drawing.Point(795, 3);
			this.btnNextDay.Name = "btnNextDay";
			this.btnNextDay.Size = new System.Drawing.Size(138, 44);
			this.btnNextDay.TabIndex = 1;
			this.btnNextDay.Text = "Ngày Mai";
			this.btnNextDay.UseVisualStyleBackColor = false;
			this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
			// 
			// dateDay
			// 
			this.dateDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateDay.Location = new System.Drawing.Point(390, 13);
			this.dateDay.Name = "dateDay";
			this.dateDay.Size = new System.Drawing.Size(148, 24);
			this.dateDay.TabIndex = 0;
			this.dateDay.ValueChanged += new System.EventHandler(this.dateDay_ValueChanged);
			// 
			// panJob
			// 
			this.panJob.Location = new System.Drawing.Point(0, 97);
			this.panJob.Name = "panJob";
			this.panJob.Size = new System.Drawing.Size(933, 438);
			this.panJob.TabIndex = 2;
			// 
			// FrmLichTrongNgay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 535);
			this.Controls.Add(this.panJob);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "FrmLichTrongNgay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lịch Trong Ngày";
			this.Load += new System.EventHandler(this.FrmLichTrongNgay_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MnuThemViec;
		private System.Windows.Forms.ToolStripMenuItem MnuHomNay;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dateDay;
		private System.Windows.Forms.Panel panJob;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNextDay;
	}
}