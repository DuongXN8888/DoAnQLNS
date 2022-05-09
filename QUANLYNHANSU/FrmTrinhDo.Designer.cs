namespace QUANLYNHANSU
{
	partial class FrmTrinhDo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrinhDo));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtTenTrinhDo = new System.Windows.Forms.TextBox();
			this.lblTenTrinhDo = new System.Windows.Forms.Label();
			this.txtMaTrinhDo = new System.Windows.Forms.TextBox();
			this.lblMaTrinhDo = new System.Windows.Forms.Label();
			this.dgvTrinhDo = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnLuu);
			this.panel2.Location = new System.Drawing.Point(932, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(169, 277);
			this.panel2.TabIndex = 5;
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
			this.panel3.Controls.Add(this.txtTenTrinhDo);
			this.panel3.Controls.Add(this.lblTenTrinhDo);
			this.panel3.Controls.Add(this.txtMaTrinhDo);
			this.panel3.Controls.Add(this.lblMaTrinhDo);
			this.panel3.Location = new System.Drawing.Point(-1, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(927, 274);
			this.panel3.TabIndex = 6;
			// 
			// txtTenTrinhDo
			// 
			this.txtTenTrinhDo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTrinhDo.Location = new System.Drawing.Point(424, 136);
			this.txtTenTrinhDo.Name = "txtTenTrinhDo";
			this.txtTenTrinhDo.Size = new System.Drawing.Size(250, 30);
			this.txtTenTrinhDo.TabIndex = 8;
			// 
			// lblTenTrinhDo
			// 
			this.lblTenTrinhDo.AutoSize = true;
			this.lblTenTrinhDo.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenTrinhDo.Location = new System.Drawing.Point(214, 137);
			this.lblTenTrinhDo.Name = "lblTenTrinhDo";
			this.lblTenTrinhDo.Size = new System.Drawing.Size(147, 26);
			this.lblTenTrinhDo.TabIndex = 7;
			this.lblTenTrinhDo.Text = "Tên Trình Độ";
			// 
			// txtMaTrinhDo
			// 
			this.txtMaTrinhDo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaTrinhDo.Location = new System.Drawing.Point(424, 82);
			this.txtMaTrinhDo.Name = "txtMaTrinhDo";
			this.txtMaTrinhDo.Size = new System.Drawing.Size(250, 30);
			this.txtMaTrinhDo.TabIndex = 6;
			// 
			// lblMaTrinhDo
			// 
			this.lblMaTrinhDo.AutoSize = true;
			this.lblMaTrinhDo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblMaTrinhDo.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaTrinhDo.Location = new System.Drawing.Point(214, 80);
			this.lblMaTrinhDo.Name = "lblMaTrinhDo";
			this.lblMaTrinhDo.Size = new System.Drawing.Size(136, 26);
			this.lblMaTrinhDo.TabIndex = 5;
			this.lblMaTrinhDo.Text = "Mã Trình Độ";
			// 
			// dgvTrinhDo
			// 
			this.dgvTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTrinhDo.Location = new System.Drawing.Point(-1, 283);
			this.dgvTrinhDo.Name = "dgvTrinhDo";
			this.dgvTrinhDo.RowTemplate.Height = 24;
			this.dgvTrinhDo.Size = new System.Drawing.Size(1102, 221);
			this.dgvTrinhDo.TabIndex = 7;
			this.dgvTrinhDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhDo_CellContentClick);
			// 
			// FrmTrinhDo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvTrinhDo);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmTrinhDo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh Mục Trình Độ";
			this.Load += new System.EventHandler(this.FrmTrinhDo_Load);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTenTrinhDo;
		private System.Windows.Forms.Label lblTenTrinhDo;
		private System.Windows.Forms.TextBox txtMaTrinhDo;
		private System.Windows.Forms.Label lblMaTrinhDo;
		private System.Windows.Forms.DataGridView dgvTrinhDo;
	}
}