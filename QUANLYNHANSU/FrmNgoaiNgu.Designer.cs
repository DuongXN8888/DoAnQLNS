namespace QUANLYNHANSU
{
	partial class FrmNgoaiNgu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNgoaiNgu));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtTenNgoaiNgu = new System.Windows.Forms.TextBox();
			this.lblTenNgoaiNgu = new System.Windows.Forms.Label();
			this.txtMaNgoaiNgu = new System.Windows.Forms.TextBox();
			this.lblMaNgoaiNgu = new System.Windows.Forms.Label();
			this.dgvNgoaiNgu = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnLuu);
			this.panel2.Location = new System.Drawing.Point(938, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(162, 280);
			this.panel2.TabIndex = 7;
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
			this.panel3.Controls.Add(this.txtTenNgoaiNgu);
			this.panel3.Controls.Add(this.lblTenNgoaiNgu);
			this.panel3.Controls.Add(this.txtMaNgoaiNgu);
			this.panel3.Controls.Add(this.lblMaNgoaiNgu);
			this.panel3.Location = new System.Drawing.Point(-2, 1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(934, 280);
			this.panel3.TabIndex = 8;
			// 
			// txtTenNgoaiNgu
			// 
			this.txtTenNgoaiNgu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNgoaiNgu.Location = new System.Drawing.Point(429, 139);
			this.txtTenNgoaiNgu.Name = "txtTenNgoaiNgu";
			this.txtTenNgoaiNgu.Size = new System.Drawing.Size(250, 30);
			this.txtTenNgoaiNgu.TabIndex = 8;
			// 
			// lblTenNgoaiNgu
			// 
			this.lblTenNgoaiNgu.AutoSize = true;
			this.lblTenNgoaiNgu.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenNgoaiNgu.Location = new System.Drawing.Point(219, 140);
			this.lblTenNgoaiNgu.Name = "lblTenNgoaiNgu";
			this.lblTenNgoaiNgu.Size = new System.Drawing.Size(168, 26);
			this.lblTenNgoaiNgu.TabIndex = 7;
			this.lblTenNgoaiNgu.Text = "Tên Ngoại Ngữ";
			// 
			// txtMaNgoaiNgu
			// 
			this.txtMaNgoaiNgu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNgoaiNgu.Location = new System.Drawing.Point(429, 85);
			this.txtMaNgoaiNgu.Name = "txtMaNgoaiNgu";
			this.txtMaNgoaiNgu.Size = new System.Drawing.Size(250, 30);
			this.txtMaNgoaiNgu.TabIndex = 6;
			// 
			// lblMaNgoaiNgu
			// 
			this.lblMaNgoaiNgu.AutoSize = true;
			this.lblMaNgoaiNgu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblMaNgoaiNgu.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaNgoaiNgu.Location = new System.Drawing.Point(219, 83);
			this.lblMaNgoaiNgu.Name = "lblMaNgoaiNgu";
			this.lblMaNgoaiNgu.Size = new System.Drawing.Size(157, 26);
			this.lblMaNgoaiNgu.TabIndex = 5;
			this.lblMaNgoaiNgu.Text = "Mã Ngoại Ngữ";
			// 
			// dgvNgoaiNgu
			// 
			this.dgvNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNgoaiNgu.Location = new System.Drawing.Point(-2, 287);
			this.dgvNgoaiNgu.Name = "dgvNgoaiNgu";
			this.dgvNgoaiNgu.RowTemplate.Height = 24;
			this.dgvNgoaiNgu.Size = new System.Drawing.Size(1102, 216);
			this.dgvNgoaiNgu.TabIndex = 9;
			this.dgvNgoaiNgu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgoaiNgu_CellContentClick);
			// 
			// FrmNgoaiNgu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvNgoaiNgu);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmNgoaiNgu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Ngoại Ngữ";
			this.Load += new System.EventHandler(this.FrmNgoaiNgu_Load);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNgoaiNgu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTenNgoaiNgu;
		private System.Windows.Forms.Label lblTenNgoaiNgu;
		private System.Windows.Forms.TextBox txtMaNgoaiNgu;
		private System.Windows.Forms.Label lblMaNgoaiNgu;
		private System.Windows.Forms.DataGridView dgvNgoaiNgu;
	}
}