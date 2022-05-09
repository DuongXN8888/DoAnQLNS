namespace QUANLYNHANSU
{
	partial class FrmDanToc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanToc));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtTenDanToc = new System.Windows.Forms.TextBox();
			this.lblTenDanToc = new System.Windows.Forms.Label();
			this.txtMaDanToc = new System.Windows.Forms.TextBox();
			this.lblMaDanToc = new System.Windows.Forms.Label();
			this.dgvDanToc = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanToc)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnLuu);
			this.panel1.Location = new System.Drawing.Point(940, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(162, 277);
			this.panel1.TabIndex = 0;
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
			this.panel3.Controls.Add(this.txtTenDanToc);
			this.panel3.Controls.Add(this.lblTenDanToc);
			this.panel3.Controls.Add(this.txtMaDanToc);
			this.panel3.Controls.Add(this.lblMaDanToc);
			this.panel3.Location = new System.Drawing.Point(3, 8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(931, 277);
			this.panel3.TabIndex = 2;
			// 
			// txtTenDanToc
			// 
			this.txtTenDanToc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenDanToc.Location = new System.Drawing.Point(416, 125);
			this.txtTenDanToc.Name = "txtTenDanToc";
			this.txtTenDanToc.Size = new System.Drawing.Size(311, 30);
			this.txtTenDanToc.TabIndex = 8;
			// 
			// lblTenDanToc
			// 
			this.lblTenDanToc.AutoSize = true;
			this.lblTenDanToc.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenDanToc.Location = new System.Drawing.Point(206, 126);
			this.lblTenDanToc.Name = "lblTenDanToc";
			this.lblTenDanToc.Size = new System.Drawing.Size(145, 26);
			this.lblTenDanToc.TabIndex = 7;
			this.lblTenDanToc.Text = "Tên Dân Tộc";
			// 
			// txtMaDanToc
			// 
			this.txtMaDanToc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaDanToc.Location = new System.Drawing.Point(416, 71);
			this.txtMaDanToc.Name = "txtMaDanToc";
			this.txtMaDanToc.Size = new System.Drawing.Size(311, 30);
			this.txtMaDanToc.TabIndex = 6;
			// 
			// lblMaDanToc
			// 
			this.lblMaDanToc.AutoSize = true;
			this.lblMaDanToc.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblMaDanToc.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaDanToc.Location = new System.Drawing.Point(206, 69);
			this.lblMaDanToc.Name = "lblMaDanToc";
			this.lblMaDanToc.Size = new System.Drawing.Size(134, 26);
			this.lblMaDanToc.TabIndex = 5;
			this.lblMaDanToc.Text = "Mã Dân Tộc";
			// 
			// dgvDanToc
			// 
			this.dgvDanToc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanToc.Location = new System.Drawing.Point(3, 291);
			this.dgvDanToc.Name = "dgvDanToc";
			this.dgvDanToc.RowTemplate.Height = 24;
			this.dgvDanToc.Size = new System.Drawing.Size(1099, 215);
			this.dgvDanToc.TabIndex = 3;
			this.dgvDanToc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanToc_CellContentClick);
			// 
			// FrmDanToc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvDanToc);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmDanToc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Dân Tộc";
			this.Load += new System.EventHandler(this.FrmDanToc_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanToc)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTenDanToc;
		private System.Windows.Forms.Label lblTenDanToc;
		private System.Windows.Forms.TextBox txtMaDanToc;
		private System.Windows.Forms.Label lblMaDanToc;
		private System.Windows.Forms.DataGridView dgvDanToc;
	}
}