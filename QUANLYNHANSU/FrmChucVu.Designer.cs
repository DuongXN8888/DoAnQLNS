namespace QUANLYNHANSU
{
	partial class FrmChucVu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChucVu));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtPhuCap = new System.Windows.Forms.TextBox();
			this.lblPhuCap = new System.Windows.Forms.Label();
			this.txtTenChucVu = new System.Windows.Forms.TextBox();
			this.lblTenChucVu = new System.Windows.Forms.Label();
			this.txtMaChucVu = new System.Windows.Forms.TextBox();
			this.lblMaChucVu = new System.Windows.Forms.Label();
			this.dgvChucVu = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnLuu);
			this.panel2.Location = new System.Drawing.Point(939, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 281);
			this.panel2.TabIndex = 1;
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
			this.panel3.Controls.Add(this.txtPhuCap);
			this.panel3.Controls.Add(this.lblPhuCap);
			this.panel3.Controls.Add(this.txtTenChucVu);
			this.panel3.Controls.Add(this.lblTenChucVu);
			this.panel3.Controls.Add(this.txtMaChucVu);
			this.panel3.Controls.Add(this.lblMaChucVu);
			this.panel3.Location = new System.Drawing.Point(4, 1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(929, 281);
			this.panel3.TabIndex = 3;
			// 
			// txtPhuCap
			// 
			this.txtPhuCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhuCap.Location = new System.Drawing.Point(408, 167);
			this.txtPhuCap.Name = "txtPhuCap";
			this.txtPhuCap.Size = new System.Drawing.Size(311, 30);
			this.txtPhuCap.TabIndex = 10;
			// 
			// lblPhuCap
			// 
			this.lblPhuCap.AutoSize = true;
			this.lblPhuCap.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhuCap.Location = new System.Drawing.Point(198, 167);
			this.lblPhuCap.Name = "lblPhuCap";
			this.lblPhuCap.Size = new System.Drawing.Size(100, 26);
			this.lblPhuCap.TabIndex = 9;
			this.lblPhuCap.Text = "Phụ Cấp";
			// 
			// txtTenChucVu
			// 
			this.txtTenChucVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenChucVu.Location = new System.Drawing.Point(408, 121);
			this.txtTenChucVu.Name = "txtTenChucVu";
			this.txtTenChucVu.Size = new System.Drawing.Size(311, 30);
			this.txtTenChucVu.TabIndex = 8;
			// 
			// lblTenChucVu
			// 
			this.lblTenChucVu.AutoSize = true;
			this.lblTenChucVu.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenChucVu.Location = new System.Drawing.Point(198, 121);
			this.lblTenChucVu.Name = "lblTenChucVu";
			this.lblTenChucVu.Size = new System.Drawing.Size(149, 26);
			this.lblTenChucVu.TabIndex = 7;
			this.lblTenChucVu.Text = "Tên Chức Vụ";
			// 
			// txtMaChucVu
			// 
			this.txtMaChucVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaChucVu.Location = new System.Drawing.Point(408, 71);
			this.txtMaChucVu.Name = "txtMaChucVu";
			this.txtMaChucVu.Size = new System.Drawing.Size(311, 30);
			this.txtMaChucVu.TabIndex = 6;
			// 
			// lblMaChucVu
			// 
			this.lblMaChucVu.AutoSize = true;
			this.lblMaChucVu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblMaChucVu.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaChucVu.Location = new System.Drawing.Point(198, 75);
			this.lblMaChucVu.Name = "lblMaChucVu";
			this.lblMaChucVu.Size = new System.Drawing.Size(138, 26);
			this.lblMaChucVu.TabIndex = 5;
			this.lblMaChucVu.Text = "Mã Chức Vụ";
			// 
			// dgvChucVu
			// 
			this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChucVu.Location = new System.Drawing.Point(4, 288);
			this.dgvChucVu.Name = "dgvChucVu";
			this.dgvChucVu.RowTemplate.Height = 24;
			this.dgvChucVu.Size = new System.Drawing.Size(1099, 217);
			this.dgvChucVu.TabIndex = 4;
			this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick);
			// 
			// FrmChucVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvChucVu);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmChucVu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Chức Vụ";
			this.Load += new System.EventHandler(this.FrmChucVu_Load);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtPhuCap;
		private System.Windows.Forms.Label lblPhuCap;
		private System.Windows.Forms.TextBox txtTenChucVu;
		private System.Windows.Forms.Label lblTenChucVu;
		private System.Windows.Forms.TextBox txtMaChucVu;
		private System.Windows.Forms.Label lblMaChucVu;
		private System.Windows.Forms.DataGridView dgvChucVu;
	}
}