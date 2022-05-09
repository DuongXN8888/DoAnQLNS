namespace QUANLYNHANSU
{
	partial class FrmChuyenMon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyenMon));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtTenChuyenMon = new System.Windows.Forms.TextBox();
			this.lblTenChuyenMon = new System.Windows.Forms.Label();
			this.txtMaChuyenMon = new System.Windows.Forms.TextBox();
			this.lblMaChuyenMon = new System.Windows.Forms.Label();
			this.dgvChuyenMon = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnLuu);
			this.panel2.Location = new System.Drawing.Point(939, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 288);
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
			this.panel3.Controls.Add(this.txtTenChuyenMon);
			this.panel3.Controls.Add(this.lblTenChuyenMon);
			this.panel3.Controls.Add(this.txtMaChuyenMon);
			this.panel3.Controls.Add(this.lblMaChuyenMon);
			this.panel3.Location = new System.Drawing.Point(1, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(932, 288);
			this.panel3.TabIndex = 4;
			// 
			// txtTenChuyenMon
			// 
			this.txtTenChuyenMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenChuyenMon.Location = new System.Drawing.Point(363, 148);
			this.txtTenChuyenMon.Name = "txtTenChuyenMon";
			this.txtTenChuyenMon.Size = new System.Drawing.Size(311, 30);
			this.txtTenChuyenMon.TabIndex = 8;
			// 
			// lblTenChuyenMon
			// 
			this.lblTenChuyenMon.AutoSize = true;
			this.lblTenChuyenMon.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenChuyenMon.Location = new System.Drawing.Point(153, 149);
			this.lblTenChuyenMon.Name = "lblTenChuyenMon";
			this.lblTenChuyenMon.Size = new System.Drawing.Size(185, 26);
			this.lblTenChuyenMon.TabIndex = 7;
			this.lblTenChuyenMon.Text = "Tên Chuyên Môn";
			// 
			// txtMaChuyenMon
			// 
			this.txtMaChuyenMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaChuyenMon.Location = new System.Drawing.Point(363, 94);
			this.txtMaChuyenMon.Name = "txtMaChuyenMon";
			this.txtMaChuyenMon.Size = new System.Drawing.Size(311, 30);
			this.txtMaChuyenMon.TabIndex = 6;
			// 
			// lblMaChuyenMon
			// 
			this.lblMaChuyenMon.AutoSize = true;
			this.lblMaChuyenMon.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblMaChuyenMon.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaChuyenMon.Location = new System.Drawing.Point(153, 92);
			this.lblMaChuyenMon.Name = "lblMaChuyenMon";
			this.lblMaChuyenMon.Size = new System.Drawing.Size(174, 26);
			this.lblMaChuyenMon.TabIndex = 5;
			this.lblMaChuyenMon.Text = "Mã Chuyên Môn";
			// 
			// dgvChuyenMon
			// 
			this.dgvChuyenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChuyenMon.Location = new System.Drawing.Point(1, 292);
			this.dgvChuyenMon.Name = "dgvChuyenMon";
			this.dgvChuyenMon.RowTemplate.Height = 24;
			this.dgvChuyenMon.Size = new System.Drawing.Size(1102, 212);
			this.dgvChuyenMon.TabIndex = 5;
			this.dgvChuyenMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenMon_CellContentClick);
			// 
			// FrmChuyenMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvChuyenMon);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmChuyenMon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Chuyên Môn";
			this.Load += new System.EventHandler(this.FrmChuyenMon_Load);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTenChuyenMon;
		private System.Windows.Forms.Label lblTenChuyenMon;
		private System.Windows.Forms.TextBox txtMaChuyenMon;
		private System.Windows.Forms.Label lblMaChuyenMon;
		private System.Windows.Forms.DataGridView dgvChuyenMon;
	}
}