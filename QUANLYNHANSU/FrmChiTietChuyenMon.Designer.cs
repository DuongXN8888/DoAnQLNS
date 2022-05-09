namespace QUANLYNHANSU
{
	partial class FrmChiTietChuyenMon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietChuyenMon));
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cboMaTrinhDo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTruong = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateNgayCap = new System.Windows.Forms.DateTimePicker();
			this.cboMaChuyenMon = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cboMaNV = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvChiTietChuyenMon = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietChuyenMon)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.Controls.Add(this.btnXoa);
			this.panel4.Controls.Add(this.btnThem);
			this.panel4.Controls.Add(this.btnSua);
			this.panel4.Controls.Add(this.btnLuu);
			this.panel4.Location = new System.Drawing.Point(5, 230);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1091, 71);
			this.panel4.TabIndex = 36;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnXoa.Image = global::QUANLYNHANSU.Properties.Resources.delete;
			this.btnXoa.Location = new System.Drawing.Point(892, 3);
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
			this.btnThem.Location = new System.Drawing.Point(117, 3);
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
			this.btnSua.Location = new System.Drawing.Point(638, 3);
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
			this.btnLuu.Location = new System.Drawing.Point(376, 3);
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
			this.panel5.Controls.Add(this.cboMaTrinhDo);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.txtTruong);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.dateNgayCap);
			this.panel5.Controls.Add(this.cboMaChuyenMon);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.cboMaNV);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.txtID);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(3, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1093, 221);
			this.panel5.TabIndex = 37;
			// 
			// cboMaTrinhDo
			// 
			this.cboMaTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaTrinhDo.FormattingEnabled = true;
			this.cboMaTrinhDo.Location = new System.Drawing.Point(824, 25);
			this.cboMaTrinhDo.Name = "cboMaTrinhDo";
			this.cboMaTrinhDo.Size = new System.Drawing.Size(160, 33);
			this.cboMaTrinhDo.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(611, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 26);
			this.label6.TabIndex = 27;
			this.label6.Text = "Mã Trình Độ";
			// 
			// txtTruong
			// 
			this.txtTruong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTruong.Location = new System.Drawing.Point(824, 143);
			this.txtTruong.Name = "txtTruong";
			this.txtTruong.Size = new System.Drawing.Size(160, 30);
			this.txtTruong.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(616, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 26);
			this.label2.TabIndex = 25;
			this.label2.Text = "Trường";
			// 
			// dateNgayCap
			// 
			this.dateNgayCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNgayCap.Location = new System.Drawing.Point(824, 85);
			this.dateNgayCap.Name = "dateNgayCap";
			this.dateNgayCap.Size = new System.Drawing.Size(160, 30);
			this.dateNgayCap.TabIndex = 24;
			// 
			// cboMaChuyenMon
			// 
			this.cboMaChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaChuyenMon.FormattingEnabled = true;
			this.cboMaChuyenMon.Location = new System.Drawing.Point(266, 136);
			this.cboMaChuyenMon.Name = "cboMaChuyenMon";
			this.cboMaChuyenMon.Size = new System.Drawing.Size(160, 33);
			this.cboMaChuyenMon.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(53, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 26);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mã Chuyên Môn";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(616, 83);
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
			this.cboMaNV.Location = new System.Drawing.Point(266, 76);
			this.cboMaNV.Name = "cboMaNV";
			this.cboMaNV.Size = new System.Drawing.Size(160, 33);
			this.cboMaNV.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(53, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 26);
			this.label5.TabIndex = 14;
			this.label5.Text = "Mã Nhân Viên";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(266, 22);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(160, 30);
			this.txtID.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "ID";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// dgvChiTietChuyenMon
			// 
			this.dgvChiTietChuyenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTietChuyenMon.Location = new System.Drawing.Point(0, 0);
			this.dgvChiTietChuyenMon.Name = "dgvChiTietChuyenMon";
			this.dgvChiTietChuyenMon.RowTemplate.Height = 24;
			this.dgvChiTietChuyenMon.Size = new System.Drawing.Size(1095, 196);
			this.dgvChiTietChuyenMon.TabIndex = 38;
			this.dgvChiTietChuyenMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietChuyenMon_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.dgvChiTietChuyenMon);
			this.panel1.Location = new System.Drawing.Point(3, 304);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1090, 196);
			this.panel1.TabIndex = 39;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Location = new System.Drawing.Point(4, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1098, 503);
			this.panel2.TabIndex = 40;
			// 
			// FrmChiTietChuyenMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmChiTietChuyenMon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi Tiết Chuyên Môn";
			this.Load += new System.EventHandler(this.FrmChiTietChuyenMon_Load);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietChuyenMon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtTruong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateNgayCap;
		private System.Windows.Forms.ComboBox cboMaChuyenMon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cboMaNV;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvChiTietChuyenMon;
		private System.Windows.Forms.ComboBox cboMaTrinhDo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}