namespace QUANLYNHANSU
{
	partial class FrmSucKhoeNhanVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucKhoeNhanVien));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TagThongTin = new System.Windows.Forms.TabPage();
			this.dgvSucKhoe = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtNgay = new System.Windows.Forms.TextBox();
			this.txtDiTat = new System.Windows.Forms.TextBox();
			this.txtCanNang = new System.Windows.Forms.TextBox();
			this.lbDiTat = new System.Windows.Forms.Label();
			this.lbCanNang = new System.Windows.Forms.Label();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.lbGhiChu = new System.Windows.Forms.Label();
			this.txtSoCon = new System.Windows.Forms.TextBox();
			this.txtChieuCao = new System.Windows.Forms.TextBox();
			this.lbSoCon = new System.Windows.Forms.Label();
			this.lbChieuCao = new System.Windows.Forms.Label();
			this.txtDiUngThuoc = new System.Windows.Forms.TextBox();
			this.lbDiUngThuoc = new System.Windows.Forms.Label();
			this.txtThiLuc = new System.Windows.Forms.TextBox();
			this.lbThiLuc = new System.Windows.Forms.Label();
			this.lbNgayKham = new System.Windows.Forms.Label();
			this.txtDiChuyen = new System.Windows.Forms.TextBox();
			this.txtNhomMau = new System.Windows.Forms.TextBox();
			this.cboMaNV = new System.Windows.Forms.ComboBox();
			this.lbDiChuyen = new System.Windows.Forms.Label();
			this.lbNhomMau = new System.Windows.Forms.Label();
			this.lbMaNV = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.TagTimKiem = new System.Windows.Forms.TabPage();
			this.dgvTK = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnTK = new System.Windows.Forms.Button();
			this.txtTimKiemMaNV = new System.Windows.Forms.TextBox();
			this.lbMaLoaiHD = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.TagThongTin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.TagTimKiem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1102, 72);
			this.panel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(389, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(442, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "THÔNG TIN KHÁM SỨC KHỎE ";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TagThongTin);
			this.tabControl1.Controls.Add(this.TagTimKiem);
			this.tabControl1.Location = new System.Drawing.Point(2, 79);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1102, 426);
			this.tabControl1.TabIndex = 6;
			// 
			// TagThongTin
			// 
			this.TagThongTin.Controls.Add(this.dgvSucKhoe);
			this.TagThongTin.Controls.Add(this.panel2);
			this.TagThongTin.Controls.Add(this.panel3);
			this.TagThongTin.Location = new System.Drawing.Point(4, 27);
			this.TagThongTin.Name = "TagThongTin";
			this.TagThongTin.Padding = new System.Windows.Forms.Padding(3);
			this.TagThongTin.Size = new System.Drawing.Size(1094, 395);
			this.TagThongTin.TabIndex = 0;
			this.TagThongTin.Text = "Thông Tin Sức Khỏe";
			this.TagThongTin.UseVisualStyleBackColor = true;
			// 
			// dgvSucKhoe
			// 
			this.dgvSucKhoe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSucKhoe.Location = new System.Drawing.Point(6, 273);
			this.dgvSucKhoe.Name = "dgvSucKhoe";
			this.dgvSucKhoe.RowTemplate.Height = 24;
			this.dgvSucKhoe.Size = new System.Drawing.Size(910, 125);
			this.dgvSucKhoe.TabIndex = 4;
			this.dgvSucKhoe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucKhoe_CellContentClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.txtNgay);
			this.panel2.Controls.Add(this.txtDiTat);
			this.panel2.Controls.Add(this.txtCanNang);
			this.panel2.Controls.Add(this.lbDiTat);
			this.panel2.Controls.Add(this.lbCanNang);
			this.panel2.Controls.Add(this.txtGhiChu);
			this.panel2.Controls.Add(this.lbGhiChu);
			this.panel2.Controls.Add(this.txtSoCon);
			this.panel2.Controls.Add(this.txtChieuCao);
			this.panel2.Controls.Add(this.lbSoCon);
			this.panel2.Controls.Add(this.lbChieuCao);
			this.panel2.Controls.Add(this.txtDiUngThuoc);
			this.panel2.Controls.Add(this.lbDiUngThuoc);
			this.panel2.Controls.Add(this.txtThiLuc);
			this.panel2.Controls.Add(this.lbThiLuc);
			this.panel2.Controls.Add(this.lbNgayKham);
			this.panel2.Controls.Add(this.txtDiChuyen);
			this.panel2.Controls.Add(this.txtNhomMau);
			this.panel2.Controls.Add(this.cboMaNV);
			this.panel2.Controls.Add(this.lbDiChuyen);
			this.panel2.Controls.Add(this.lbNhomMau);
			this.panel2.Controls.Add(this.lbMaNV);
			this.panel2.Location = new System.Drawing.Point(6, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(910, 261);
			this.panel2.TabIndex = 3;
			// 
			// txtNgay
			// 
			this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNgay.Location = new System.Drawing.Point(190, 166);
			this.txtNgay.Name = "txtNgay";
			this.txtNgay.Size = new System.Drawing.Size(137, 30);
			this.txtNgay.TabIndex = 44;
			// 
			// txtDiTat
			// 
			this.txtDiTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiTat.Location = new System.Drawing.Point(545, 219);
			this.txtDiTat.Name = "txtDiTat";
			this.txtDiTat.Size = new System.Drawing.Size(137, 30);
			this.txtDiTat.TabIndex = 43;
			// 
			// txtCanNang
			// 
			this.txtCanNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCanNang.Location = new System.Drawing.Point(545, 168);
			this.txtCanNang.Name = "txtCanNang";
			this.txtCanNang.Size = new System.Drawing.Size(137, 30);
			this.txtCanNang.TabIndex = 42;
			// 
			// lbDiTat
			// 
			this.lbDiTat.AutoSize = true;
			this.lbDiTat.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbDiTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiTat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbDiTat.Location = new System.Drawing.Point(365, 221);
			this.lbDiTat.Name = "lbDiTat";
			this.lbDiTat.Size = new System.Drawing.Size(75, 26);
			this.lbDiTat.TabIndex = 41;
			this.lbDiTat.Text = "Dị Tật";
			// 
			// lbCanNang
			// 
			this.lbCanNang.AutoSize = true;
			this.lbCanNang.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbCanNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCanNang.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbCanNang.Location = new System.Drawing.Point(365, 166);
			this.lbCanNang.Name = "lbCanNang";
			this.lbCanNang.Size = new System.Drawing.Size(118, 26);
			this.lbCanNang.TabIndex = 40;
			this.lbCanNang.Text = "Cân Nặng";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGhiChu.Location = new System.Drawing.Point(717, 62);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(172, 30);
			this.txtGhiChu.TabIndex = 39;
			// 
			// lbGhiChu
			// 
			this.lbGhiChu.AutoSize = true;
			this.lbGhiChu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGhiChu.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbGhiChu.Location = new System.Drawing.Point(767, 7);
			this.lbGhiChu.Name = "lbGhiChu";
			this.lbGhiChu.Size = new System.Drawing.Size(99, 26);
			this.lbGhiChu.TabIndex = 38;
			this.lbGhiChu.Text = "Ghi Chú";
			// 
			// txtSoCon
			// 
			this.txtSoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoCon.Location = new System.Drawing.Point(545, 111);
			this.txtSoCon.Name = "txtSoCon";
			this.txtSoCon.Size = new System.Drawing.Size(137, 30);
			this.txtSoCon.TabIndex = 37;
			// 
			// txtChieuCao
			// 
			this.txtChieuCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChieuCao.Location = new System.Drawing.Point(545, 62);
			this.txtChieuCao.Name = "txtChieuCao";
			this.txtChieuCao.Size = new System.Drawing.Size(137, 30);
			this.txtChieuCao.TabIndex = 36;
			// 
			// lbSoCon
			// 
			this.lbSoCon.AutoSize = true;
			this.lbSoCon.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbSoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoCon.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbSoCon.Location = new System.Drawing.Point(365, 111);
			this.lbSoCon.Name = "lbSoCon";
			this.lbSoCon.Size = new System.Drawing.Size(91, 26);
			this.lbSoCon.TabIndex = 35;
			this.lbSoCon.Text = "Số Con";
			// 
			// lbChieuCao
			// 
			this.lbChieuCao.AutoSize = true;
			this.lbChieuCao.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbChieuCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbChieuCao.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbChieuCao.Location = new System.Drawing.Point(365, 56);
			this.lbChieuCao.Name = "lbChieuCao";
			this.lbChieuCao.Size = new System.Drawing.Size(124, 26);
			this.lbChieuCao.TabIndex = 34;
			this.lbChieuCao.Text = "Chiều Cao";
			// 
			// txtDiUngThuoc
			// 
			this.txtDiUngThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiUngThuoc.Location = new System.Drawing.Point(545, 5);
			this.txtDiUngThuoc.Name = "txtDiUngThuoc";
			this.txtDiUngThuoc.Size = new System.Drawing.Size(137, 30);
			this.txtDiUngThuoc.TabIndex = 33;
			// 
			// lbDiUngThuoc
			// 
			this.lbDiUngThuoc.AutoSize = true;
			this.lbDiUngThuoc.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbDiUngThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiUngThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbDiUngThuoc.Location = new System.Drawing.Point(365, 7);
			this.lbDiUngThuoc.Name = "lbDiUngThuoc";
			this.lbDiUngThuoc.Size = new System.Drawing.Size(156, 26);
			this.lbDiUngThuoc.TabIndex = 32;
			this.lbDiUngThuoc.Text = "Dị Ứng Thuốc";
			// 
			// txtThiLuc
			// 
			this.txtThiLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThiLuc.Location = new System.Drawing.Point(190, 219);
			this.txtThiLuc.Name = "txtThiLuc";
			this.txtThiLuc.Size = new System.Drawing.Size(137, 30);
			this.txtThiLuc.TabIndex = 31;
			// 
			// lbThiLuc
			// 
			this.lbThiLuc.AutoSize = true;
			this.lbThiLuc.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbThiLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThiLuc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbThiLuc.Location = new System.Drawing.Point(6, 221);
			this.lbThiLuc.Name = "lbThiLuc";
			this.lbThiLuc.Size = new System.Drawing.Size(89, 26);
			this.lbThiLuc.TabIndex = 30;
			this.lbThiLuc.Text = "Thị Lực";
			// 
			// lbNgayKham
			// 
			this.lbNgayKham.AutoSize = true;
			this.lbNgayKham.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNgayKham.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbNgayKham.Location = new System.Drawing.Point(6, 166);
			this.lbNgayKham.Name = "lbNgayKham";
			this.lbNgayKham.Size = new System.Drawing.Size(136, 26);
			this.lbNgayKham.TabIndex = 28;
			this.lbNgayKham.Text = "Ngày Khám";
			// 
			// txtDiChuyen
			// 
			this.txtDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiChuyen.Location = new System.Drawing.Point(190, 109);
			this.txtDiChuyen.Name = "txtDiChuyen";
			this.txtDiChuyen.Size = new System.Drawing.Size(137, 30);
			this.txtDiChuyen.TabIndex = 27;
			// 
			// txtNhomMau
			// 
			this.txtNhomMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNhomMau.Location = new System.Drawing.Point(190, 56);
			this.txtNhomMau.Name = "txtNhomMau";
			this.txtNhomMau.Size = new System.Drawing.Size(137, 30);
			this.txtNhomMau.TabIndex = 26;
			// 
			// cboMaNV
			// 
			this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaNV.FormattingEnabled = true;
			this.cboMaNV.Location = new System.Drawing.Point(190, 3);
			this.cboMaNV.Name = "cboMaNV";
			this.cboMaNV.Size = new System.Drawing.Size(137, 30);
			this.cboMaNV.TabIndex = 25;
			// 
			// lbDiChuyen
			// 
			this.lbDiChuyen.AutoSize = true;
			this.lbDiChuyen.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiChuyen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbDiChuyen.Location = new System.Drawing.Point(6, 109);
			this.lbDiChuyen.Name = "lbDiChuyen";
			this.lbDiChuyen.Size = new System.Drawing.Size(123, 26);
			this.lbDiChuyen.TabIndex = 24;
			this.lbDiChuyen.Text = "Di Chuyền";
			// 
			// lbNhomMau
			// 
			this.lbNhomMau.AutoSize = true;
			this.lbNhomMau.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbNhomMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhomMau.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbNhomMau.Location = new System.Drawing.Point(6, 56);
			this.lbNhomMau.Name = "lbNhomMau";
			this.lbNhomMau.Size = new System.Drawing.Size(127, 26);
			this.lbNhomMau.TabIndex = 23;
			this.lbNhomMau.Text = "Nhóm Máu";
			// 
			// lbMaNV
			// 
			this.lbMaNV.AutoSize = true;
			this.lbMaNV.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaNV.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbMaNV.Location = new System.Drawing.Point(6, 3);
			this.lbMaNV.Name = "lbMaNV";
			this.lbMaNV.Size = new System.Drawing.Size(162, 26);
			this.lbMaNV.TabIndex = 22;
			this.lbMaNV.Text = "Mã Nhân Viên";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnLuu);
			this.panel3.Location = new System.Drawing.Point(922, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(176, 392);
			this.panel3.TabIndex = 2;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnXoa.Image = global::QUANLYNHANSU.Properties.Resources.delete;
			this.btnXoa.Location = new System.Drawing.Point(23, 288);
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
			this.btnThem.Location = new System.Drawing.Point(23, 51);
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
			this.btnSua.Location = new System.Drawing.Point(23, 208);
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
			this.btnLuu.Location = new System.Drawing.Point(23, 130);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(130, 62);
			this.btnLuu.TabIndex = 34;
			this.btnLuu.Text = "Lưu ";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// TagTimKiem
			// 
			this.TagTimKiem.Controls.Add(this.dgvTK);
			this.TagTimKiem.Controls.Add(this.panel4);
			this.TagTimKiem.Location = new System.Drawing.Point(4, 27);
			this.TagTimKiem.Name = "TagTimKiem";
			this.TagTimKiem.Padding = new System.Windows.Forms.Padding(3);
			this.TagTimKiem.Size = new System.Drawing.Size(1121, 437);
			this.TagTimKiem.TabIndex = 1;
			this.TagTimKiem.Text = "Tìm Kiếm Thông Tin";
			this.TagTimKiem.UseVisualStyleBackColor = true;
			// 
			// dgvTK
			// 
			this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTK.Location = new System.Drawing.Point(3, 117);
			this.dgvTK.Name = "dgvTK";
			this.dgvTK.RowTemplate.Height = 24;
			this.dgvTK.Size = new System.Drawing.Size(1115, 314);
			this.dgvTK.TabIndex = 33;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel4.Controls.Add(this.btnTK);
			this.panel4.Controls.Add(this.txtTimKiemMaNV);
			this.panel4.Controls.Add(this.lbMaLoaiHD);
			this.panel4.Location = new System.Drawing.Point(3, 6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1115, 112);
			this.panel4.TabIndex = 32;
			// 
			// btnTK
			// 
			this.btnTK.BackColor = System.Drawing.Color.SteelBlue;
			this.btnTK.FlatAppearance.BorderSize = 0;
			this.btnTK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTK.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnTK.Image = global::QUANLYNHANSU.Properties.Resources.button7_Image;
			this.btnTK.Location = new System.Drawing.Point(792, 25);
			this.btnTK.Name = "btnTK";
			this.btnTK.Size = new System.Drawing.Size(130, 62);
			this.btnTK.TabIndex = 34;
			this.btnTK.Text = "Tìm Kiếm";
			this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTK.UseVisualStyleBackColor = false;
			this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
			// 
			// txtTimKiemMaNV
			// 
			this.txtTimKiemMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiemMaNV.Location = new System.Drawing.Point(379, 39);
			this.txtTimKiemMaNV.Name = "txtTimKiemMaNV";
			this.txtTimKiemMaNV.Size = new System.Drawing.Size(344, 30);
			this.txtTimKiemMaNV.TabIndex = 23;
			// 
			// lbMaLoaiHD
			// 
			this.lbMaLoaiHD.AutoSize = true;
			this.lbMaLoaiHD.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaLoaiHD.Location = new System.Drawing.Point(129, 40);
			this.lbMaLoaiHD.Name = "lbMaLoaiHD";
			this.lbMaLoaiHD.Size = new System.Drawing.Size(152, 26);
			this.lbMaLoaiHD.TabIndex = 24;
			this.lbMaLoaiHD.Text = "Mã Nhân Viên";
			// 
			// FrmSucKhoeNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmSucKhoeNhanVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông Tin Sức Khỏe";
			this.Load += new System.EventHandler(this.FrmSucKhoeNhanVien_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.TagThongTin.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.TagTimKiem.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TagThongTin;
		private System.Windows.Forms.TabPage TagTimKiem;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtDiChuyen;
		private System.Windows.Forms.TextBox txtNhomMau;
		private System.Windows.Forms.ComboBox cboMaNV;
		private System.Windows.Forms.Label lbDiChuyen;
		private System.Windows.Forms.Label lbNhomMau;
		private System.Windows.Forms.Label lbMaNV;
		private System.Windows.Forms.Label lbNgayKham;
		private System.Windows.Forms.TextBox txtThiLuc;
		private System.Windows.Forms.Label lbThiLuc;
		private System.Windows.Forms.TextBox txtDiUngThuoc;
		private System.Windows.Forms.Label lbDiUngThuoc;
		private System.Windows.Forms.TextBox txtSoCon;
		private System.Windows.Forms.TextBox txtChieuCao;
		private System.Windows.Forms.Label lbSoCon;
		private System.Windows.Forms.Label lbChieuCao;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label lbGhiChu;
		private System.Windows.Forms.TextBox txtDiTat;
		private System.Windows.Forms.TextBox txtCanNang;
		private System.Windows.Forms.Label lbDiTat;
		private System.Windows.Forms.Label lbCanNang;
		private System.Windows.Forms.DataGridView dgvSucKhoe;
		private System.Windows.Forms.TextBox txtNgay;
		private System.Windows.Forms.DataGridView dgvTK;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnTK;
		private System.Windows.Forms.TextBox txtTimKiemMaNV;
		private System.Windows.Forms.Label lbMaLoaiHD;
	}
}