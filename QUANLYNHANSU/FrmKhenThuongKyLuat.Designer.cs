using System;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
	partial class FrmKhenThuongKyLuat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhenThuongKyLuat));
			this.label1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTenLoai = new System.Windows.Forms.TextBox();
			this.txtMaLoai = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnXoa1 = new System.Windows.Forms.Button();
			this.btnThem1 = new System.Windows.Forms.Button();
			this.btnSua1 = new System.Windows.Forms.Button();
			this.btnLuu1 = new System.Windows.Forms.Button();
			this.dgvDMKTKL = new System.Windows.Forms.DataGridView();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDMKTKL)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(207, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(537, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "DANH MỤC KHEN THƯỞNG KỸ LUẬT";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.txtTenLoai);
			this.panel5.Controls.Add(this.txtMaLoai);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(0, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(924, 285);
			this.panel5.TabIndex = 33;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(262, 157);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 26);
			this.label9.TabIndex = 18;
			this.label9.Text = "Tên Loại";
			// 
			// txtTenLoai
			// 
			this.txtTenLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenLoai.Location = new System.Drawing.Point(463, 157);
			this.txtTenLoai.Name = "txtTenLoai";
			this.txtTenLoai.Size = new System.Drawing.Size(278, 30);
			this.txtTenLoai.TabIndex = 12;
			// 
			// txtMaLoai
			// 
			this.txtMaLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaLoai.Location = new System.Drawing.Point(463, 85);
			this.txtMaLoai.Name = "txtMaLoai";
			this.txtMaLoai.Size = new System.Drawing.Size(278, 30);
			this.txtMaLoai.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(262, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "Mã Loại";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.Controls.Add(this.btnXoa1);
			this.panel4.Controls.Add(this.btnThem1);
			this.panel4.Controls.Add(this.btnSua1);
			this.panel4.Controls.Add(this.btnLuu1);
			this.panel4.Location = new System.Drawing.Point(930, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(170, 285);
			this.panel4.TabIndex = 34;
			// 
			// btnXoa1
			// 
			this.btnXoa1.BackColor = System.Drawing.Color.SteelBlue;
			this.btnXoa1.FlatAppearance.BorderSize = 0;
			this.btnXoa1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnXoa1.Image = global::QUANLYNHANSU.Properties.Resources.delete;
			this.btnXoa1.Location = new System.Drawing.Point(18, 207);
			this.btnXoa1.Name = "btnXoa1";
			this.btnXoa1.Size = new System.Drawing.Size(130, 62);
			this.btnXoa1.TabIndex = 36;
			this.btnXoa1.Text = "Xóa";
			this.btnXoa1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa1.UseVisualStyleBackColor = false;
			this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
			// 
			// btnThem1
			// 
			this.btnThem1.BackColor = System.Drawing.Color.SteelBlue;
			this.btnThem1.FlatAppearance.BorderSize = 0;
			this.btnThem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnThem1.Image = global::QUANLYNHANSU.Properties.Resources.bn_;
			this.btnThem1.Location = new System.Drawing.Point(18, 3);
			this.btnThem1.Name = "btnThem1";
			this.btnThem1.Size = new System.Drawing.Size(130, 62);
			this.btnThem1.TabIndex = 33;
			this.btnThem1.Text = "Thêm";
			this.btnThem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem1.UseVisualStyleBackColor = false;
			this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
			// 
			// btnSua1
			// 
			this.btnSua1.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSua1.FlatAppearance.BorderSize = 0;
			this.btnSua1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnSua1.Image = global::QUANLYNHANSU.Properties.Resources._1__6_;
			this.btnSua1.Location = new System.Drawing.Point(18, 139);
			this.btnSua1.Name = "btnSua1";
			this.btnSua1.Size = new System.Drawing.Size(130, 62);
			this.btnSua1.TabIndex = 35;
			this.btnSua1.Text = "Sửa";
			this.btnSua1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua1.UseVisualStyleBackColor = false;
			this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
			// 
			// btnLuu1
			// 
			this.btnLuu1.BackColor = System.Drawing.Color.SteelBlue;
			this.btnLuu1.FlatAppearance.BorderSize = 0;
			this.btnLuu1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnLuu1.Image = global::QUANLYNHANSU.Properties.Resources._1__5_1;
			this.btnLuu1.Location = new System.Drawing.Point(18, 71);
			this.btnLuu1.Name = "btnLuu1";
			this.btnLuu1.Size = new System.Drawing.Size(130, 62);
			this.btnLuu1.TabIndex = 34;
			this.btnLuu1.Text = "Lưu ";
			this.btnLuu1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLuu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuu1.UseVisualStyleBackColor = false;
			this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
			// 
			// dgvDMKTKL
			// 
			this.dgvDMKTKL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDMKTKL.Location = new System.Drawing.Point(0, 294);
			this.dgvDMKTKL.Name = "dgvDMKTKL";
			this.dgvDMKTKL.RowTemplate.Height = 24;
			this.dgvDMKTKL.Size = new System.Drawing.Size(1100, 210);
			this.dgvDMKTKL.TabIndex = 35;
			this.dgvDMKTKL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMKTKL_CellContentClick);
			// 
			// FrmKhenThuongKyLuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 506);
			this.Controls.Add(this.dgvDMKTKL);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmKhenThuongKyLuat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khen Thưởng Kỹ Luật";
			this.Load += new System.EventHandler(this.FrmKhenThuongKyLuat_Load);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDMKTKL)).EndInit();
			this.ResumeLayout(false);

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			
		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTenLoai;
		private System.Windows.Forms.TextBox txtMaLoai;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnXoa1;
		private System.Windows.Forms.Button btnThem1;
		private System.Windows.Forms.Button btnSua1;
		private System.Windows.Forms.Button btnLuu1;
		private System.Windows.Forms.DataGridView dgvDMKTKL;
	}
}