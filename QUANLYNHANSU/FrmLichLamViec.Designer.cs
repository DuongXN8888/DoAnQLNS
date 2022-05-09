namespace QUANLYNHANSU
{
	partial class FrmLichLamViec
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichLamViec));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.nmNotify = new System.Windows.Forms.NumericUpDown();
			this.chkNoTyFi = new System.Windows.Forms.CheckBox();
			this.btnToDay = new System.Windows.Forms.Button();
			this.dateDay = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThoat = new System.Windows.Forms.Button();
			this.panaMatrix = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btn = new System.Windows.Forms.Button();
			this.btnsunday = new System.Windows.Forms.Button();
			this.btnsatday = new System.Windows.Forms.Button();
			this.btnThusday = new System.Windows.Forms.Button();
			this.btnwebday = new System.Windows.Forms.Button();
			this.btnTuday = new System.Windows.Forms.Button();
			this.btnMonDay = new System.Windows.Forms.Button();
			this.TimeNotyfi = new System.Windows.Forms.Timer(this.components);
			this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(940, 472);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.btnToDay);
			this.panel3.Controls.Add(this.dateDay);
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(934, 65);
			this.panel3.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.nmNotify);
			this.panel6.Controls.Add(this.chkNoTyFi);
			this.panel6.Location = new System.Drawing.Point(8, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(277, 62);
			this.panel6.TabIndex = 2;
			// 
			// nmNotify
			// 
			this.nmNotify.Enabled = false;
			this.nmNotify.Location = new System.Drawing.Point(124, 20);
			this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
			this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmNotify.Name = "nmNotify";
			this.nmNotify.Size = new System.Drawing.Size(58, 24);
			this.nmNotify.TabIndex = 1;
			this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmNotify.ValueChanged += new System.EventHandler(this.nmNotify_ValueChanged);
			// 
			// chkNoTyFi
			// 
			this.chkNoTyFi.AutoSize = true;
			this.chkNoTyFi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.chkNoTyFi.Location = new System.Drawing.Point(3, 22);
			this.chkNoTyFi.Name = "chkNoTyFi";
			this.chkNoTyFi.Size = new System.Drawing.Size(103, 22);
			this.chkNoTyFi.TabIndex = 0;
			this.chkNoTyFi.Text = "Thông Báo";
			this.chkNoTyFi.UseVisualStyleBackColor = false;
			this.chkNoTyFi.CheckedChanged += new System.EventHandler(this.chkNoTyFi_CheckedChanged);
			// 
			// btnToDay
			// 
			this.btnToDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnToDay.Location = new System.Drawing.Point(801, 8);
			this.btnToDay.Name = "btnToDay";
			this.btnToDay.Size = new System.Drawing.Size(112, 50);
			this.btnToDay.TabIndex = 1;
			this.btnToDay.Text = "Hôm Nay";
			this.btnToDay.UseVisualStyleBackColor = false;
			this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
			// 
			// dateDay
			// 
			this.dateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateDay.Location = new System.Drawing.Point(405, 20);
			this.dateDay.Name = "dateDay";
			this.dateDay.Size = new System.Drawing.Size(212, 38);
			this.dateDay.TabIndex = 0;
			this.dateDay.Value = new System.DateTime(2022, 2, 16, 0, 0, 0, 0);
			this.dateDay.ValueChanged += new System.EventHandler(this.dateDay_ValueChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnThoat);
			this.panel2.Controls.Add(this.panaMatrix);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Location = new System.Drawing.Point(3, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(934, 401);
			this.panel2.TabIndex = 1;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.SteelBlue;
			this.btnThoat.FlatAppearance.BorderSize = 0;
			this.btnThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnThoat.Image = global::QUANLYNHANSU.Properties.Resources.Close;
			this.btnThoat.Location = new System.Drawing.Point(861, 335);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(73, 61);
			this.btnThoat.TabIndex = 38;
			this.btnThoat.Text = "Exit";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// panaMatrix
			// 
			this.panaMatrix.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panaMatrix.Location = new System.Drawing.Point(64, 68);
			this.panaMatrix.Name = "panaMatrix";
			this.panaMatrix.Size = new System.Drawing.Size(797, 327);
			this.panaMatrix.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Controls.Add(this.btnNext);
			this.panel4.Controls.Add(this.btnPrevious);
			this.panel4.Controls.Add(this.btn);
			this.panel4.Controls.Add(this.btnsunday);
			this.panel4.Controls.Add(this.btnsatday);
			this.panel4.Controls.Add(this.btnThusday);
			this.panel4.Controls.Add(this.btnwebday);
			this.panel4.Controls.Add(this.btnTuday);
			this.panel4.Controls.Add(this.btnMonDay);
			this.panel4.Location = new System.Drawing.Point(0, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(934, 59);
			this.panel4.TabIndex = 1;
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnNext.Location = new System.Drawing.Point(869, 3);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(65, 50);
			this.btnNext.TabIndex = 6;
			this.btnNext.Text = "Tháng Sau";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnPrevious.Location = new System.Drawing.Point(0, 3);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(58, 50);
			this.btnPrevious.TabIndex = 2;
			this.btnPrevious.Text = "Tháng Trước";
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btn
			// 
			this.btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn.Location = new System.Drawing.Point(756, 3);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(106, 50);
			this.btn.TabIndex = 2;
			this.btn.Text = "Chủ Nhật";
			this.btn.UseVisualStyleBackColor = false;
			// 
			// btnsunday
			// 
			this.btnsunday.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnsunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsunday.Location = new System.Drawing.Point(641, 3);
			this.btnsunday.Name = "btnsunday";
			this.btnsunday.Size = new System.Drawing.Size(106, 50);
			this.btnsunday.TabIndex = 2;
			this.btnsunday.Text = "Thứ Bảy";
			this.btnsunday.UseVisualStyleBackColor = false;
			// 
			// btnsatday
			// 
			this.btnsatday.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnsatday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsatday.Location = new System.Drawing.Point(529, 3);
			this.btnsatday.Name = "btnsatday";
			this.btnsatday.Size = new System.Drawing.Size(106, 50);
			this.btnsatday.TabIndex = 2;
			this.btnsatday.Text = "Thứ Sáu";
			this.btnsatday.UseVisualStyleBackColor = false;
			// 
			// btnThusday
			// 
			this.btnThusday.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnThusday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThusday.Location = new System.Drawing.Point(405, 3);
			this.btnThusday.Name = "btnThusday";
			this.btnThusday.Size = new System.Drawing.Size(106, 50);
			this.btnThusday.TabIndex = 5;
			this.btnThusday.Text = "Thứ Năm";
			this.btnThusday.UseVisualStyleBackColor = false;
			// 
			// btnwebday
			// 
			this.btnwebday.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnwebday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnwebday.Location = new System.Drawing.Point(293, 3);
			this.btnwebday.Name = "btnwebday";
			this.btnwebday.Size = new System.Drawing.Size(106, 50);
			this.btnwebday.TabIndex = 4;
			this.btnwebday.Text = "Thứ Tư";
			this.btnwebday.UseVisualStyleBackColor = false;
			// 
			// btnTuday
			// 
			this.btnTuday.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnTuday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTuday.Location = new System.Drawing.Point(179, 3);
			this.btnTuday.Name = "btnTuday";
			this.btnTuday.Size = new System.Drawing.Size(106, 50);
			this.btnTuday.TabIndex = 3;
			this.btnTuday.Text = "Thứ Ba";
			this.btnTuday.UseVisualStyleBackColor = false;
			// 
			// btnMonDay
			// 
			this.btnMonDay.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnMonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMonDay.Location = new System.Drawing.Point(64, 3);
			this.btnMonDay.Name = "btnMonDay";
			this.btnMonDay.Size = new System.Drawing.Size(106, 50);
			this.btnMonDay.TabIndex = 2;
			this.btnMonDay.Text = "Thứ Hai";
			this.btnMonDay.UseVisualStyleBackColor = false;
			// 
			// TimeNotyfi
			// 
			this.TimeNotyfi.Enabled = true;
			this.TimeNotyfi.Interval = 60000;
			this.TimeNotyfi.Tick += new System.EventHandler(this.TimeNotyfi_Tick);
			// 
			// Notify
			// 
			this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
			this.Notify.Text = "Thông Báo";
			this.Notify.Visible = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(197, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Phút";
			// 
			// FrmLichLamViec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 472);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmLichLamViec";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lịch Làm Việc";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLichLamViec_FormClosing);
			this.Load += new System.EventHandler(this.FrmLichLamViec_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panaMatrix;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.NumericUpDown nmNotify;
		private System.Windows.Forms.CheckBox chkNoTyFi;
		private System.Windows.Forms.Button btnToDay;
		private System.Windows.Forms.DateTimePicker dateDay;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Button btnsunday;
		private System.Windows.Forms.Button btnsatday;
		private System.Windows.Forms.Button btnThusday;
		private System.Windows.Forms.Button btnwebday;
		private System.Windows.Forms.Button btnTuday;
		private System.Windows.Forms.Button btnMonDay;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Timer TimeNotyfi;
		private System.Windows.Forms.NotifyIcon Notify;
		private System.Windows.Forms.Label label1;
	}
}