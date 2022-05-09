namespace QUANLYNHANSU
{
	partial class FrmTo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTo));
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cboMaPhong = new System.Windows.Forms.ComboBox();
			this.txtMaTo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTenTo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvTo = new System.Windows.Forms.DataGridView();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnLuu);
			this.panel3.Location = new System.Drawing.Point(940, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(162, 283);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cboMaPhong);
			this.panel1.Controls.Add(this.txtMaTo);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtTenTo);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(931, 283);
			this.panel1.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(297, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 26);
			this.label3.TabIndex = 27;
			this.label3.Text = "Mã Phòng";
			// 
			// cboMaPhong
			// 
			this.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaPhong.FormattingEnabled = true;
			this.cboMaPhong.Location = new System.Drawing.Point(446, 184);
			this.cboMaPhong.Name = "cboMaPhong";
			this.cboMaPhong.Size = new System.Drawing.Size(290, 30);
			this.cboMaPhong.TabIndex = 28;
			// 
			// txtMaTo
			// 
			this.txtMaTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaTo.Location = new System.Drawing.Point(446, 56);
			this.txtMaTo.Name = "txtMaTo";
			this.txtMaTo.Size = new System.Drawing.Size(290, 30);
			this.txtMaTo.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(297, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 26);
			this.label6.TabIndex = 24;
			this.label6.Text = "Mã Tổ";
			// 
			// txtTenTo
			// 
			this.txtTenTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTo.Location = new System.Drawing.Point(446, 118);
			this.txtTenTo.Name = "txtTenTo";
			this.txtTenTo.Size = new System.Drawing.Size(290, 30);
			this.txtTenTo.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(297, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 26);
			this.label5.TabIndex = 25;
			this.label5.Text = "Tên Tổ";
			// 
			// dgvTo
			// 
			this.dgvTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTo.Location = new System.Drawing.Point(3, 292);
			this.dgvTo.Name = "dgvTo";
			this.dgvTo.RowTemplate.Height = 24;
			this.dgvTo.Size = new System.Drawing.Size(1099, 212);
			this.dgvTo.TabIndex = 31;
			this.dgvTo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTo_CellContentClick);
			// 
			// FrmTo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvTo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmTo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Tổ";
			this.Load += new System.EventHandler(this.FrmTo_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMaTo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTenTo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboMaPhong;
		private System.Windows.Forms.DataGridView dgvTo;
	}
}