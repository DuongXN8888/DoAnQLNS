namespace QUANLYNHANSU
{
	partial class FrmPhongBan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongBan));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.lblDienThoai = new System.Windows.Forms.Label();
			this.txtTenPhong = new System.Windows.Forms.TextBox();
			this.lblTenPhong = new System.Windows.Forms.Label();
			this.txtMaPhong = new System.Windows.Forms.TextBox();
			this.lblMaPhong = new System.Windows.Forms.Label();
			this.dgvPhongBan = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnLuu);
			this.panel2.Location = new System.Drawing.Point(937, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 290);
			this.panel2.TabIndex = 2;
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
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Controls.Add(this.txtDienThoai);
			this.panel3.Controls.Add(this.lblDienThoai);
			this.panel3.Controls.Add(this.txtTenPhong);
			this.panel3.Controls.Add(this.lblTenPhong);
			this.panel3.Controls.Add(this.txtMaPhong);
			this.panel3.Controls.Add(this.lblMaPhong);
			this.panel3.Location = new System.Drawing.Point(4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(927, 284);
			this.panel3.TabIndex = 4;
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDienThoai.Location = new System.Drawing.Point(403, 162);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(311, 30);
			this.txtDienThoai.TabIndex = 10;
			// 
			// lblDienThoai
			// 
			this.lblDienThoai.AutoSize = true;
			this.lblDienThoai.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDienThoai.Location = new System.Drawing.Point(193, 162);
			this.lblDienThoai.Name = "lblDienThoai";
			this.lblDienThoai.Size = new System.Drawing.Size(122, 26);
			this.lblDienThoai.TabIndex = 9;
			this.lblDienThoai.Text = "Điện Thoại";
			// 
			// txtTenPhong
			// 
			this.txtTenPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenPhong.Location = new System.Drawing.Point(403, 116);
			this.txtTenPhong.Name = "txtTenPhong";
			this.txtTenPhong.Size = new System.Drawing.Size(311, 30);
			this.txtTenPhong.TabIndex = 8;
			// 
			// lblTenPhong
			// 
			this.lblTenPhong.AutoSize = true;
			this.lblTenPhong.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenPhong.Location = new System.Drawing.Point(193, 116);
			this.lblTenPhong.Name = "lblTenPhong";
			this.lblTenPhong.Size = new System.Drawing.Size(125, 26);
			this.lblTenPhong.TabIndex = 7;
			this.lblTenPhong.Text = "Tên Phòng";
			// 
			// txtMaPhong
			// 
			this.txtMaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaPhong.Location = new System.Drawing.Point(403, 66);
			this.txtMaPhong.Name = "txtMaPhong";
			this.txtMaPhong.Size = new System.Drawing.Size(311, 30);
			this.txtMaPhong.TabIndex = 6;
			// 
			// lblMaPhong
			// 
			this.lblMaPhong.AutoSize = true;
			this.lblMaPhong.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblMaPhong.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaPhong.Location = new System.Drawing.Point(193, 70);
			this.lblMaPhong.Name = "lblMaPhong";
			this.lblMaPhong.Size = new System.Drawing.Size(114, 26);
			this.lblMaPhong.TabIndex = 5;
			this.lblMaPhong.Text = "Mã Phòng";
			// 
			// dgvPhongBan
			// 
			this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhongBan.Location = new System.Drawing.Point(4, 295);
			this.dgvPhongBan.Name = "dgvPhongBan";
			this.dgvPhongBan.RowTemplate.Height = 24;
			this.dgvPhongBan.Size = new System.Drawing.Size(1097, 206);
			this.dgvPhongBan.TabIndex = 5;
			this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
			// 
			// FrmPhongBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvPhongBan);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmPhongBan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Phòng Ban";
			this.Load += new System.EventHandler(this.FrmPhongBan_Load);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label lblDienThoai;
		private System.Windows.Forms.TextBox txtTenPhong;
		private System.Windows.Forms.Label lblTenPhong;
		private System.Windows.Forms.TextBox txtMaPhong;
		private System.Windows.Forms.Label lblMaPhong;
		private System.Windows.Forms.DataGridView dgvPhongBan;
	}
}