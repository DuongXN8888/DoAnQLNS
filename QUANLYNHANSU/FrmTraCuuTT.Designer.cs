namespace QUANLYNHANSU
{
	partial class FrmTraCuuTT
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraCuuTT));
			this.tab = new System.Windows.Forms.TabControl();
			this.tabTKTinhDo = new System.Windows.Forms.TabPage();
			this.btnTC = new System.Windows.Forms.Button();
			this.dgvChuyenMon = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboMaTrinhDo = new System.Windows.Forms.ComboBox();
			this.cboMaChuyenMon = new System.Windows.Forms.ComboBox();
			this.cboMaNV = new System.Windows.Forms.ComboBox();
			this.radMaTrinhDo = new System.Windows.Forms.RadioButton();
			this.radMaChuyenMon = new System.Windows.Forms.RadioButton();
			this.radMaNV = new System.Windows.Forms.RadioButton();
			this.FrmTKNgoaiNgu = new System.Windows.Forms.TabPage();
			this.btnTraCuu = new System.Windows.Forms.Button();
			this.dgvChiTietNgoaiNgu = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cboMaNgoaiNgu = new System.Windows.Forms.ComboBox();
			this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
			this.radNgoaiNgu = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.tab.SuspendLayout();
			this.tabTKTinhDo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).BeginInit();
			this.panel1.SuspendLayout();
			this.FrmTKNgoaiNgu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNgoaiNgu)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab
			// 
			this.tab.Controls.Add(this.tabTKTinhDo);
			this.tab.Controls.Add(this.FrmTKNgoaiNgu);
			this.tab.Location = new System.Drawing.Point(3, 3);
			this.tab.Name = "tab";
			this.tab.SelectedIndex = 0;
			this.tab.Size = new System.Drawing.Size(1099, 500);
			this.tab.TabIndex = 6;
			// 
			// tabTKTinhDo
			// 
			this.tabTKTinhDo.Controls.Add(this.btnTC);
			this.tabTKTinhDo.Controls.Add(this.dgvChuyenMon);
			this.tabTKTinhDo.Controls.Add(this.panel1);
			this.tabTKTinhDo.Location = new System.Drawing.Point(4, 27);
			this.tabTKTinhDo.Name = "tabTKTinhDo";
			this.tabTKTinhDo.Padding = new System.Windows.Forms.Padding(3);
			this.tabTKTinhDo.Size = new System.Drawing.Size(1091, 469);
			this.tabTKTinhDo.TabIndex = 0;
			this.tabTKTinhDo.Text = "Tra Cứu Trình Độ";
			this.tabTKTinhDo.UseVisualStyleBackColor = true;
			// 
			// btnTC
			// 
			this.btnTC.BackColor = System.Drawing.Color.SteelBlue;
			this.btnTC.FlatAppearance.BorderSize = 0;
			this.btnTC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnTC.Image = global::QUANLYNHANSU.Properties.Resources.button7_Image;
			this.btnTC.Location = new System.Drawing.Point(943, 6);
			this.btnTC.Name = "btnTC";
			this.btnTC.Size = new System.Drawing.Size(145, 167);
			this.btnTC.TabIndex = 39;
			this.btnTC.Text = "Tra Cứu";
			this.btnTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTC.UseVisualStyleBackColor = false;
			this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
			// 
			// dgvChuyenMon
			// 
			this.dgvChuyenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChuyenMon.Location = new System.Drawing.Point(0, 179);
			this.dgvChuyenMon.Name = "dgvChuyenMon";
			this.dgvChuyenMon.RowTemplate.Height = 24;
			this.dgvChuyenMon.Size = new System.Drawing.Size(1088, 287);
			this.dgvChuyenMon.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.cboMaTrinhDo);
			this.panel1.Controls.Add(this.cboMaChuyenMon);
			this.panel1.Controls.Add(this.cboMaNV);
			this.panel1.Controls.Add(this.radMaTrinhDo);
			this.panel1.Controls.Add(this.radMaChuyenMon);
			this.panel1.Controls.Add(this.radMaNV);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(937, 167);
			this.panel1.TabIndex = 0;
			// 
			// cboMaTrinhDo
			// 
			this.cboMaTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaTrinhDo.FormattingEnabled = true;
			this.cboMaTrinhDo.Location = new System.Drawing.Point(454, 132);
			this.cboMaTrinhDo.Name = "cboMaTrinhDo";
			this.cboMaTrinhDo.Size = new System.Drawing.Size(261, 26);
			this.cboMaTrinhDo.TabIndex = 5;
			// 
			// cboMaChuyenMon
			// 
			this.cboMaChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaChuyenMon.FormattingEnabled = true;
			this.cboMaChuyenMon.Location = new System.Drawing.Point(454, 79);
			this.cboMaChuyenMon.Name = "cboMaChuyenMon";
			this.cboMaChuyenMon.Size = new System.Drawing.Size(261, 26);
			this.cboMaChuyenMon.TabIndex = 4;
			// 
			// cboMaNV
			// 
			this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaNV.FormattingEnabled = true;
			this.cboMaNV.Location = new System.Drawing.Point(454, 24);
			this.cboMaNV.Name = "cboMaNV";
			this.cboMaNV.Size = new System.Drawing.Size(261, 26);
			this.cboMaNV.TabIndex = 3;
			// 
			// radMaTrinhDo
			// 
			this.radMaTrinhDo.AutoSize = true;
			this.radMaTrinhDo.BackColor = System.Drawing.SystemColors.Control;
			this.radMaTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radMaTrinhDo.Location = new System.Drawing.Point(124, 134);
			this.radMaTrinhDo.Name = "radMaTrinhDo";
			this.radMaTrinhDo.Size = new System.Drawing.Size(122, 24);
			this.radMaTrinhDo.TabIndex = 2;
			this.radMaTrinhDo.TabStop = true;
			this.radMaTrinhDo.Text = "Mã Trình Độ";
			this.radMaTrinhDo.UseVisualStyleBackColor = false;
			this.radMaTrinhDo.CheckedChanged += new System.EventHandler(this.radMaTrinhDo_CheckedChanged);
			// 
			// radMaChuyenMon
			// 
			this.radMaChuyenMon.AutoSize = true;
			this.radMaChuyenMon.BackColor = System.Drawing.SystemColors.Control;
			this.radMaChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radMaChuyenMon.Location = new System.Drawing.Point(124, 81);
			this.radMaChuyenMon.Name = "radMaChuyenMon";
			this.radMaChuyenMon.Size = new System.Drawing.Size(151, 24);
			this.radMaChuyenMon.TabIndex = 1;
			this.radMaChuyenMon.TabStop = true;
			this.radMaChuyenMon.Text = "Mã Chuyên Môn";
			this.radMaChuyenMon.UseVisualStyleBackColor = false;
			this.radMaChuyenMon.CheckedChanged += new System.EventHandler(this.radMaChuyenMon_CheckedChanged);
			// 
			// radMaNV
			// 
			this.radMaNV.AutoSize = true;
			this.radMaNV.BackColor = System.Drawing.SystemColors.Control;
			this.radMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radMaNV.Location = new System.Drawing.Point(124, 26);
			this.radMaNV.Name = "radMaNV";
			this.radMaNV.Size = new System.Drawing.Size(135, 24);
			this.radMaNV.TabIndex = 0;
			this.radMaNV.TabStop = true;
			this.radMaNV.Text = "Mã Nhân Viên";
			this.radMaNV.UseVisualStyleBackColor = false;
			this.radMaNV.CheckedChanged += new System.EventHandler(this.radMaNV_CheckedChanged);
			// 
			// FrmTKNgoaiNgu
			// 
			this.FrmTKNgoaiNgu.Controls.Add(this.btnTraCuu);
			this.FrmTKNgoaiNgu.Controls.Add(this.dgvChiTietNgoaiNgu);
			this.FrmTKNgoaiNgu.Controls.Add(this.panel3);
			this.FrmTKNgoaiNgu.Location = new System.Drawing.Point(4, 27);
			this.FrmTKNgoaiNgu.Name = "FrmTKNgoaiNgu";
			this.FrmTKNgoaiNgu.Padding = new System.Windows.Forms.Padding(3);
			this.FrmTKNgoaiNgu.Size = new System.Drawing.Size(1091, 469);
			this.FrmTKNgoaiNgu.TabIndex = 1;
			this.FrmTKNgoaiNgu.Text = "Tra Cứu Ngoại Ngữ";
			this.FrmTKNgoaiNgu.UseVisualStyleBackColor = true;
			// 
			// btnTraCuu
			// 
			this.btnTraCuu.BackColor = System.Drawing.Color.SteelBlue;
			this.btnTraCuu.FlatAppearance.BorderSize = 0;
			this.btnTraCuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTraCuu.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnTraCuu.Image = global::QUANLYNHANSU.Properties.Resources.button7_Image;
			this.btnTraCuu.Location = new System.Drawing.Point(925, 6);
			this.btnTraCuu.Name = "btnTraCuu";
			this.btnTraCuu.Size = new System.Drawing.Size(163, 167);
			this.btnTraCuu.TabIndex = 41;
			this.btnTraCuu.Text = "Tra Cứu";
			this.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTraCuu.UseVisualStyleBackColor = false;
			this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
			// 
			// dgvChiTietNgoaiNgu
			// 
			this.dgvChiTietNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTietNgoaiNgu.Location = new System.Drawing.Point(6, 179);
			this.dgvChiTietNgoaiNgu.Name = "dgvChiTietNgoaiNgu";
			this.dgvChiTietNgoaiNgu.RowTemplate.Height = 24;
			this.dgvChiTietNgoaiNgu.Size = new System.Drawing.Size(1082, 284);
			this.dgvChiTietNgoaiNgu.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Controls.Add(this.cboMaNgoaiNgu);
			this.panel3.Controls.Add(this.cboMaNhanVien);
			this.panel3.Controls.Add(this.radNgoaiNgu);
			this.panel3.Controls.Add(this.radioButton3);
			this.panel3.Location = new System.Drawing.Point(6, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(913, 167);
			this.panel3.TabIndex = 1;
			// 
			// cboMaNgoaiNgu
			// 
			this.cboMaNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaNgoaiNgu.FormattingEnabled = true;
			this.cboMaNgoaiNgu.Location = new System.Drawing.Point(441, 107);
			this.cboMaNgoaiNgu.Name = "cboMaNgoaiNgu";
			this.cboMaNgoaiNgu.Size = new System.Drawing.Size(261, 26);
			this.cboMaNgoaiNgu.TabIndex = 4;
			// 
			// cboMaNhanVien
			// 
			this.cboMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaNhanVien.FormattingEnabled = true;
			this.cboMaNhanVien.Location = new System.Drawing.Point(441, 26);
			this.cboMaNhanVien.Name = "cboMaNhanVien";
			this.cboMaNhanVien.Size = new System.Drawing.Size(261, 26);
			this.cboMaNhanVien.TabIndex = 3;
			// 
			// radNgoaiNgu
			// 
			this.radNgoaiNgu.AutoSize = true;
			this.radNgoaiNgu.BackColor = System.Drawing.SystemColors.Control;
			this.radNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radNgoaiNgu.Location = new System.Drawing.Point(140, 109);
			this.radNgoaiNgu.Name = "radNgoaiNgu";
			this.radNgoaiNgu.Size = new System.Drawing.Size(136, 24);
			this.radNgoaiNgu.TabIndex = 1;
			this.radNgoaiNgu.TabStop = true;
			this.radNgoaiNgu.Text = "Mã Ngoại Ngữ";
			this.radNgoaiNgu.UseVisualStyleBackColor = false;
			this.radNgoaiNgu.CheckedChanged += new System.EventHandler(this.radNgoaiNgu_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.BackColor = System.Drawing.SystemColors.Control;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(140, 28);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(135, 24);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Mã Nhân Viên";
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// FrmTraCuuTT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.tab);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmTraCuuTT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tra Cứu Thông Tin";
			this.Load += new System.EventHandler(this.FrmTraCuuTT_Load);
			this.tab.ResumeLayout(false);
			this.tabTKTinhDo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.FrmTKNgoaiNgu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNgoaiNgu)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tab;
		private System.Windows.Forms.TabPage tabTKTinhDo;
		private System.Windows.Forms.TabPage FrmTKNgoaiNgu;
		private System.Windows.Forms.DataGridView dgvChuyenMon;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTC;
		private System.Windows.Forms.ComboBox cboMaTrinhDo;
		private System.Windows.Forms.ComboBox cboMaChuyenMon;
		private System.Windows.Forms.ComboBox cboMaNV;
		private System.Windows.Forms.RadioButton radMaTrinhDo;
		private System.Windows.Forms.RadioButton radMaChuyenMon;
		private System.Windows.Forms.RadioButton radMaNV;
		private System.Windows.Forms.Button btnTraCuu;
		private System.Windows.Forms.DataGridView dgvChiTietNgoaiNgu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cboMaNgoaiNgu;
		private System.Windows.Forms.ComboBox cboMaNhanVien;
		private System.Windows.Forms.RadioButton radNgoaiNgu;
		private System.Windows.Forms.RadioButton radioButton3;
	}
}