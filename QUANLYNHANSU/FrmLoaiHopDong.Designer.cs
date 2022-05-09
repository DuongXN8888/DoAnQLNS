namespace QUANLYNHANSU
{
	partial class FrmLoaiHopDong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiHopDong));
			this.tabLoaiHD = new System.Windows.Forms.TabControl();
			this.TagLoaiHopDong = new System.Windows.Forms.TabPage();
			this.dgvLoaiHD = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMaLoaiHD = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTenLoaiHD = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.tabTKLoaiHD = new System.Windows.Forms.TabPage();
			this.dgvTKLoaiHD = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnThoatTK = new System.Windows.Forms.Button();
			this.btnTKHD = new System.Windows.Forms.Button();
			this.txtTimKiemMaHD = new System.Windows.Forms.TextBox();
			this.lbMaLoaiHD = new System.Windows.Forms.Label();
			this.tabLoaiHD.SuspendLayout();
			this.TagLoaiHopDong.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHD)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabTKLoaiHD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTKLoaiHD)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabLoaiHD
			// 
			this.tabLoaiHD.Controls.Add(this.TagLoaiHopDong);
			this.tabLoaiHD.Controls.Add(this.tabTKLoaiHD);
			this.tabLoaiHD.Location = new System.Drawing.Point(3, 12);
			this.tabLoaiHD.Name = "tabLoaiHD";
			this.tabLoaiHD.SelectedIndex = 0;
			this.tabLoaiHD.Size = new System.Drawing.Size(1097, 491);
			this.tabLoaiHD.TabIndex = 6;
			// 
			// TagLoaiHopDong
			// 
			this.TagLoaiHopDong.Controls.Add(this.dgvLoaiHD);
			this.TagLoaiHopDong.Controls.Add(this.panel1);
			this.TagLoaiHopDong.Controls.Add(this.panel3);
			this.TagLoaiHopDong.Location = new System.Drawing.Point(4, 27);
			this.TagLoaiHopDong.Name = "TagLoaiHopDong";
			this.TagLoaiHopDong.Padding = new System.Windows.Forms.Padding(3);
			this.TagLoaiHopDong.Size = new System.Drawing.Size(1089, 460);
			this.TagLoaiHopDong.TabIndex = 0;
			this.TagLoaiHopDong.Text = "Loại Hợp Đồng";
			this.TagLoaiHopDong.UseVisualStyleBackColor = true;
			// 
			// dgvLoaiHD
			// 
			this.dgvLoaiHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLoaiHD.Location = new System.Drawing.Point(6, 287);
			this.dgvLoaiHD.Name = "dgvLoaiHD";
			this.dgvLoaiHD.RowTemplate.Height = 24;
			this.dgvLoaiHD.Size = new System.Drawing.Size(1080, 167);
			this.dgvLoaiHD.TabIndex = 31;
			this.dgvLoaiHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHD_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.txtMaLoaiHD);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtTenLoaiHD);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(912, 275);
			this.panel1.TabIndex = 30;
			// 
			// txtMaLoaiHD
			// 
			this.txtMaLoaiHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaLoaiHD.Location = new System.Drawing.Point(486, 78);
			this.txtMaLoaiHD.Name = "txtMaLoaiHD";
			this.txtMaLoaiHD.Size = new System.Drawing.Size(214, 30);
			this.txtMaLoaiHD.TabIndex = 23;
			this.txtMaLoaiHD.TextChanged += new System.EventHandler(this.txtMaLoaiHD_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(181, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(202, 26);
			this.label6.TabIndex = 24;
			this.label6.Text = "Mã Loại Hợp Đồng";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// txtTenLoaiHD
			// 
			this.txtTenLoaiHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenLoaiHD.Location = new System.Drawing.Point(486, 136);
			this.txtTenLoaiHD.Name = "txtTenLoaiHD";
			this.txtTenLoaiHD.Size = new System.Drawing.Size(214, 30);
			this.txtTenLoaiHD.TabIndex = 26;
			this.txtTenLoaiHD.TextChanged += new System.EventHandler(this.txtTenLoaiHD_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(181, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(213, 26);
			this.label5.TabIndex = 25;
			this.label5.Text = "Tên Loại Hợp Đồng";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnLuu);
			this.panel3.Location = new System.Drawing.Point(924, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(162, 278);
			this.panel3.TabIndex = 29;
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
			// tabTKLoaiHD
			// 
			this.tabTKLoaiHD.Controls.Add(this.dgvTKLoaiHD);
			this.tabTKLoaiHD.Controls.Add(this.panel4);
			this.tabTKLoaiHD.Location = new System.Drawing.Point(4, 27);
			this.tabTKLoaiHD.Name = "tabTKLoaiHD";
			this.tabTKLoaiHD.Padding = new System.Windows.Forms.Padding(3);
			this.tabTKLoaiHD.Size = new System.Drawing.Size(1089, 460);
			this.tabTKLoaiHD.TabIndex = 1;
			this.tabTKLoaiHD.Text = "Tìm Kiếm Loại Hợp Đồng";
			this.tabTKLoaiHD.UseVisualStyleBackColor = true;
			// 
			// dgvTKLoaiHD
			// 
			this.dgvTKLoaiHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTKLoaiHD.Location = new System.Drawing.Point(3, 234);
			this.dgvTKLoaiHD.Name = "dgvTKLoaiHD";
			this.dgvTKLoaiHD.RowTemplate.Height = 24;
			this.dgvTKLoaiHD.Size = new System.Drawing.Size(1083, 220);
			this.dgvTKLoaiHD.TabIndex = 32;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel4.Controls.Add(this.btnThoatTK);
			this.panel4.Controls.Add(this.btnTKHD);
			this.panel4.Controls.Add(this.txtTimKiemMaHD);
			this.panel4.Controls.Add(this.lbMaLoaiHD);
			this.panel4.Location = new System.Drawing.Point(3, 6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1083, 222);
			this.panel4.TabIndex = 31;
			// 
			// btnThoatTK
			// 
			this.btnThoatTK.BackColor = System.Drawing.Color.SteelBlue;
			this.btnThoatTK.FlatAppearance.BorderSize = 0;
			this.btnThoatTK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoatTK.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnThoatTK.Image = global::QUANLYNHANSU.Properties.Resources.Close;
			this.btnThoatTK.Location = new System.Drawing.Point(774, 118);
			this.btnThoatTK.Name = "btnThoatTK";
			this.btnThoatTK.Size = new System.Drawing.Size(130, 62);
			this.btnThoatTK.TabIndex = 38;
			this.btnThoatTK.Text = "Hủy";
			this.btnThoatTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoatTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoatTK.UseVisualStyleBackColor = false;
			this.btnThoatTK.Click += new System.EventHandler(this.btnThoatTK_Click);
			// 
			// btnTKHD
			// 
			this.btnTKHD.BackColor = System.Drawing.Color.SteelBlue;
			this.btnTKHD.FlatAppearance.BorderSize = 0;
			this.btnTKHD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTKHD.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnTKHD.Image = global::QUANLYNHANSU.Properties.Resources.button7_Image;
			this.btnTKHD.Location = new System.Drawing.Point(774, 39);
			this.btnTKHD.Name = "btnTKHD";
			this.btnTKHD.Size = new System.Drawing.Size(130, 62);
			this.btnTKHD.TabIndex = 34;
			this.btnTKHD.Text = "Tìm Kiếm";
			this.btnTKHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTKHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTKHD.UseVisualStyleBackColor = false;
			this.btnTKHD.Click += new System.EventHandler(this.btnTKHD_Click);
			// 
			// txtTimKiemMaHD
			// 
			this.txtTimKiemMaHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiemMaHD.Location = new System.Drawing.Point(439, 89);
			this.txtTimKiemMaHD.Name = "txtTimKiemMaHD";
			this.txtTimKiemMaHD.Size = new System.Drawing.Size(214, 30);
			this.txtTimKiemMaHD.TabIndex = 23;
			// 
			// lbMaLoaiHD
			// 
			this.lbMaLoaiHD.AutoSize = true;
			this.lbMaLoaiHD.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaLoaiHD.Location = new System.Drawing.Point(189, 90);
			this.lbMaLoaiHD.Name = "lbMaLoaiHD";
			this.lbMaLoaiHD.Size = new System.Drawing.Size(202, 26);
			this.lbMaLoaiHD.TabIndex = 24;
			this.lbMaLoaiHD.Text = "Mã Loại Hợp Đồng";
			// 
			// FrmLoaiHopDong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.tabLoaiHD);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmLoaiHopDong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loại Hợp Đồng";
			this.Load += new System.EventHandler(this.FrmLoaiHopDong_Load);
			this.tabLoaiHD.ResumeLayout(false);
			this.TagLoaiHopDong.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHD)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.tabTKLoaiHD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTKLoaiHD)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabLoaiHD;
		private System.Windows.Forms.TabPage TagLoaiHopDong;
		private System.Windows.Forms.TabPage tabTKLoaiHD;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMaLoaiHD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTenLoaiHD;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvLoaiHD;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnTKHD;
		private System.Windows.Forms.TextBox txtTimKiemMaHD;
		private System.Windows.Forms.Label lbMaLoaiHD;
		private System.Windows.Forms.DataGridView dgvTKLoaiHD;
		private System.Windows.Forms.Button btnThoatTK;
	}
}