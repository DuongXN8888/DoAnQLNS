namespace QUANLYNHANSU
{
	partial class FrmBangTiLeLuong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBangTiLeLuong));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.txtTiLeLuong = new System.Windows.Forms.TextBox();
			this.lblTenDanToc = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblMaDanToc = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtSoNgayCong = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboMaTo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboMaPhong = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboNam = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboThang = new System.Windows.Forms.ComboBox();
			this.dgvBangTiLeLuong = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBangTiLeLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnLuu);
			this.panel1.Location = new System.Drawing.Point(938, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(162, 280);
			this.panel1.TabIndex = 3;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnXoa.Image = global::QUANLYNHANSU.Properties.Resources.delete;
			this.btnXoa.Location = new System.Drawing.Point(18, 207);
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
			this.btnThem.Location = new System.Drawing.Point(18, 3);
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
			this.btnSua.Location = new System.Drawing.Point(18, 139);
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
			this.btnLuu.Location = new System.Drawing.Point(18, 71);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(130, 62);
			this.btnLuu.TabIndex = 34;
			this.btnLuu.Text = "Lưu ";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// txtTiLeLuong
			// 
			this.txtTiLeLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTiLeLuong.Location = new System.Drawing.Point(755, 115);
			this.txtTiLeLuong.Name = "txtTiLeLuong";
			this.txtTiLeLuong.Size = new System.Drawing.Size(154, 30);
			this.txtTiLeLuong.TabIndex = 12;
			// 
			// lblTenDanToc
			// 
			this.lblTenDanToc.AutoSize = true;
			this.lblTenDanToc.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenDanToc.Location = new System.Drawing.Point(18, 115);
			this.lblTenDanToc.Name = "lblTenDanToc";
			this.lblTenDanToc.Size = new System.Drawing.Size(78, 26);
			this.lblTenDanToc.TabIndex = 11;
			this.lblTenDanToc.Text = "Tháng";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(106, 32);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(164, 30);
			this.txtID.TabIndex = 10;
			// 
			// lblMaDanToc
			// 
			this.lblMaDanToc.AutoSize = true;
			this.lblMaDanToc.BackColor = System.Drawing.SystemColors.Control;
			this.lblMaDanToc.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaDanToc.Location = new System.Drawing.Point(20, 36);
			this.lblMaDanToc.Name = "lblMaDanToc";
			this.lblMaDanToc.Size = new System.Drawing.Size(33, 26);
			this.lblMaDanToc.TabIndex = 9;
			this.lblMaDanToc.Text = "ID";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.txtSoNgayCong);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.cboMaTo);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.cboMaPhong);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.cboNam);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.cboThang);
			this.panel3.Controls.Add(this.lblMaDanToc);
			this.panel3.Controls.Add(this.txtTiLeLuong);
			this.panel3.Controls.Add(this.txtID);
			this.panel3.Controls.Add(this.lblTenDanToc);
			this.panel3.Location = new System.Drawing.Point(2, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(930, 276);
			this.panel3.TabIndex = 13;
			// 
			// txtSoNgayCong
			// 
			this.txtSoNgayCong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoNgayCong.Location = new System.Drawing.Point(755, 173);
			this.txtSoNgayCong.Name = "txtSoNgayCong";
			this.txtSoNgayCong.Size = new System.Drawing.Size(154, 30);
			this.txtSoNgayCong.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(590, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 26);
			this.label5.TabIndex = 21;
			this.label5.Text = "Số Ngày Công ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(588, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 26);
			this.label6.TabIndex = 20;
			this.label6.Text = "Tỉ Lệ Lương";
			// 
			// cboMaTo
			// 
			this.cboMaTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaTo.FormattingEnabled = true;
			this.cboMaTo.Location = new System.Drawing.Point(423, 169);
			this.cboMaTo.Name = "cboMaTo";
			this.cboMaTo.Size = new System.Drawing.Size(143, 30);
			this.cboMaTo.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(305, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 26);
			this.label3.TabIndex = 18;
			this.label3.Text = "Mã Tổ";
			// 
			// cboMaPhong
			// 
			this.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaPhong.FormattingEnabled = true;
			this.cboMaPhong.Location = new System.Drawing.Point(423, 115);
			this.cboMaPhong.Name = "cboMaPhong";
			this.cboMaPhong.Size = new System.Drawing.Size(143, 30);
			this.cboMaPhong.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(303, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 26);
			this.label4.TabIndex = 16;
			this.label4.Text = "Mã Phòng";
			// 
			// cboNam
			// 
			this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboNam.FormattingEnabled = true;
			this.cboNam.Location = new System.Drawing.Point(106, 169);
			this.cboNam.Name = "cboNam";
			this.cboNam.Size = new System.Drawing.Size(164, 30);
			this.cboNam.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 26);
			this.label2.TabIndex = 14;
			this.label2.Text = "Năm";
			// 
			// cboThang
			// 
			this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboThang.FormattingEnabled = true;
			this.cboThang.Location = new System.Drawing.Point(106, 115);
			this.cboThang.Name = "cboThang";
			this.cboThang.Size = new System.Drawing.Size(164, 30);
			this.cboThang.TabIndex = 13;
			// 
			// dgvBangTiLeLuong
			// 
			this.dgvBangTiLeLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangTiLeLuong.Location = new System.Drawing.Point(2, 288);
			this.dgvBangTiLeLuong.Name = "dgvBangTiLeLuong";
			this.dgvBangTiLeLuong.RowTemplate.Height = 24;
			this.dgvBangTiLeLuong.Size = new System.Drawing.Size(1098, 215);
			this.dgvBangTiLeLuong.TabIndex = 14;
			this.dgvBangTiLeLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangTiLeLuong_CellContentClick);
			// 
			// FrmBangTiLeLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvBangTiLeLuong);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmBangTiLeLuong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bảng Tỉ Lệ Lương Theo Phòng";
			this.Load += new System.EventHandler(this.FrmBangTiLeLuong_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBangTiLeLuong)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.TextBox txtTiLeLuong;
		private System.Windows.Forms.Label lblTenDanToc;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblMaDanToc;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtSoNgayCong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboMaTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboMaPhong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboNam;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboThang;
		private System.Windows.Forms.DataGridView dgvBangTiLeLuong;
	}
}