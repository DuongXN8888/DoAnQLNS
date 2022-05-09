namespace QUANLYNHANSU
{
	partial class FrmChiTietNgoaiNgu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietNgoaiNgu));
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtNoiCap = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateNgayCap = new System.Windows.Forms.DateTimePicker();
			this.txtTrinhDo = new System.Windows.Forms.TextBox();
			this.cboMaNgoaiNgu = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cboMaNV = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvChiTietNgoaiNgu = new System.Windows.Forms.DataGridView();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNgoaiNgu)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.Controls.Add(this.btnXoa);
			this.panel4.Controls.Add(this.btnThem);
			this.panel4.Controls.Add(this.btnSua);
			this.panel4.Controls.Add(this.btnLuu);
			this.panel4.Location = new System.Drawing.Point(932, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(170, 290);
			this.panel4.TabIndex = 35;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnXoa.Image = global::QUANLYNHANSU.Properties.Resources.delete;
			this.btnXoa.Location = new System.Drawing.Point(20, 215);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(130, 62);
			this.btnXoa.TabIndex = 36;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnThem.Image = global::QUANLYNHANSU.Properties.Resources.bn_;
			this.btnThem.Location = new System.Drawing.Point(20, 11);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(130, 62);
			this.btnThem.TabIndex = 33;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSua.FlatAppearance.BorderSize = 0;
			this.btnSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnSua.Image = global::QUANLYNHANSU.Properties.Resources._1__6_;
			this.btnSua.Location = new System.Drawing.Point(20, 147);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(130, 62);
			this.btnSua.TabIndex = 35;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
			this.btnLuu.FlatAppearance.BorderSize = 0;
			this.btnLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnLuu.Image = global::QUANLYNHANSU.Properties.Resources._1__5_1;
			this.btnLuu.Location = new System.Drawing.Point(20, 79);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(130, 62);
			this.btnLuu.TabIndex = 34;
			this.btnLuu.Text = "Lưu ";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Control;
			this.panel5.Controls.Add(this.txtNoiCap);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.dateNgayCap);
			this.panel5.Controls.Add(this.txtTrinhDo);
			this.panel5.Controls.Add(this.cboMaNgoaiNgu);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.cboMaNV);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.txtID);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(931, 290);
			this.panel5.TabIndex = 36;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// txtNoiCap
			// 
			this.txtNoiCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoiCap.Location = new System.Drawing.Point(697, 118);
			this.txtNoiCap.Name = "txtNoiCap";
			this.txtNoiCap.Size = new System.Drawing.Size(180, 30);
			this.txtNoiCap.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(489, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 26);
			this.label2.TabIndex = 25;
			this.label2.Text = "Nơi Cấp";
			// 
			// dateNgayCap
			// 
			this.dateNgayCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNgayCap.Location = new System.Drawing.Point(697, 177);
			this.dateNgayCap.Name = "dateNgayCap";
			this.dateNgayCap.Size = new System.Drawing.Size(180, 30);
			this.dateNgayCap.TabIndex = 24;
			// 
			// txtTrinhDo
			// 
			this.txtTrinhDo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTrinhDo.Location = new System.Drawing.Point(697, 65);
			this.txtTrinhDo.Name = "txtTrinhDo";
			this.txtTrinhDo.Size = new System.Drawing.Size(180, 30);
			this.txtTrinhDo.TabIndex = 22;
			// 
			// cboMaNgoaiNgu
			// 
			this.cboMaNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaNgoaiNgu.FormattingEnabled = true;
			this.cboMaNgoaiNgu.Location = new System.Drawing.Point(266, 175);
			this.cboMaNgoaiNgu.Name = "cboMaNgoaiNgu";
			this.cboMaNgoaiNgu.Size = new System.Drawing.Size(160, 33);
			this.cboMaNgoaiNgu.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(53, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 26);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mã Ngoại Ngữ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(489, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 26);
			this.label8.TabIndex = 19;
			this.label8.Text = "Trình Độ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(489, 175);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(111, 26);
			this.label9.TabIndex = 18;
			this.label9.Text = "Ngày Cấp";
			// 
			// cboMaNV
			// 
			this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaNV.FormattingEnabled = true;
			this.cboMaNV.Location = new System.Drawing.Point(266, 117);
			this.cboMaNV.Name = "cboMaNV";
			this.cboMaNV.Size = new System.Drawing.Size(160, 33);
			this.cboMaNV.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(53, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 26);
			this.label5.TabIndex = 14;
			this.label5.Text = "Mã Nhân Viên";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(266, 63);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(160, 30);
			this.txtID.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "ID";
			// 
			// dgvChiTietNgoaiNgu
			// 
			this.dgvChiTietNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTietNgoaiNgu.Location = new System.Drawing.Point(3, 292);
			this.dgvChiTietNgoaiNgu.Name = "dgvChiTietNgoaiNgu";
			this.dgvChiTietNgoaiNgu.RowTemplate.Height = 24;
			this.dgvChiTietNgoaiNgu.Size = new System.Drawing.Size(1099, 214);
			this.dgvChiTietNgoaiNgu.TabIndex = 37;
			this.dgvChiTietNgoaiNgu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietNgoaiNgu_CellContentClick);
			// 
			// FrmChiTietNgoaiNgu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvChiTietNgoaiNgu);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmChiTietNgoaiNgu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi Tiết Trình Độ Ngoại Ngữ";
			this.Load += new System.EventHandler(this.FrmChiTietNgoaiNgu_Load);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNgoaiNgu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DateTimePicker dateNgayCap;
		private System.Windows.Forms.TextBox txtTrinhDo;
		private System.Windows.Forms.ComboBox cboMaNgoaiNgu;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cboMaNV;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNoiCap;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvChiTietNgoaiNgu;
	}
}