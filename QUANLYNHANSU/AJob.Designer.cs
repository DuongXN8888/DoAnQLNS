namespace QUANLYNHANSU
{
	partial class AJob
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.cboStatus = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nmToHours = new System.Windows.Forms.NumericUpDown();
			this.nmToMin = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.nmFormHours = new System.Windows.Forms.NumericUpDown();
			this.nmFormMin = new System.Windows.Forms.NumericUpDown();
			this.txtJob = new System.Windows.Forms.TextBox();
			this.chkDone = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmToMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmFormHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmFormMin)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.txtJob);
			this.panel1.Controls.Add(this.chkDone);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(918, 51);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.cboStatus);
			this.panel3.Location = new System.Drawing.Point(694, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(221, 48);
			this.panel3.TabIndex = 5;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Turquoise;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(169, 9);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(49, 28);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Turquoise;
			this.btnSua.Location = new System.Drawing.Point(102, 9);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(49, 28);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// cboStatus
			// 
			this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboStatus.FormattingEnabled = true;
			this.cboStatus.Location = new System.Drawing.Point(3, 11);
			this.cboStatus.Name = "cboStatus";
			this.cboStatus.Size = new System.Drawing.Size(93, 24);
			this.cboStatus.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.nmToHours);
			this.panel2.Controls.Add(this.nmToMin);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.nmFormHours);
			this.panel2.Controls.Add(this.nmFormMin);
			this.panel2.Location = new System.Drawing.Point(427, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(260, 47);
			this.panel2.TabIndex = 4;
			// 
			// nmToHours
			// 
			this.nmToHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmToHours.Location = new System.Drawing.Point(155, 11);
			this.nmToHours.Name = "nmToHours";
			this.nmToHours.Size = new System.Drawing.Size(45, 24);
			this.nmToHours.TabIndex = 5;
			// 
			// nmToMin
			// 
			this.nmToMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmToMin.Location = new System.Drawing.Point(209, 11);
			this.nmToMin.Name = "nmToMin";
			this.nmToMin.Size = new System.Drawing.Size(42, 24);
			this.nmToMin.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(118, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Đến";
			// 
			// nmFormHours
			// 
			this.nmFormHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmFormHours.Location = new System.Drawing.Point(13, 11);
			this.nmFormHours.Name = "nmFormHours";
			this.nmFormHours.Size = new System.Drawing.Size(48, 24);
			this.nmFormHours.TabIndex = 2;
			// 
			// nmFormMin
			// 
			this.nmFormMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmFormMin.Location = new System.Drawing.Point(67, 11);
			this.nmFormMin.Name = "nmFormMin";
			this.nmFormMin.Size = new System.Drawing.Size(45, 24);
			this.nmFormMin.TabIndex = 3;
			// 
			// txtJob
			// 
			this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJob.Location = new System.Drawing.Point(55, 8);
			this.txtJob.Name = "txtJob";
			this.txtJob.Size = new System.Drawing.Size(366, 26);
			this.txtJob.TabIndex = 1;
			// 
			// chkDone
			// 
			this.chkDone.AutoSize = true;
			this.chkDone.BackColor = System.Drawing.SystemColors.ControlLight;
			this.chkDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkDone.Location = new System.Drawing.Point(3, 14);
			this.chkDone.Name = "chkDone";
			this.chkDone.Size = new System.Drawing.Size(18, 17);
			this.chkDone.TabIndex = 0;
			this.chkDone.UseVisualStyleBackColor = false;
			this.chkDone.CheckedChanged += new System.EventHandler(this.chkDone_CheckedChanged);
			// 
			// AJob
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "AJob";
			this.Size = new System.Drawing.Size(924, 57);
			this.Load += new System.EventHandler(this.AJob_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmToMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmFormHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmFormMin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown nmFormMin;
		private System.Windows.Forms.NumericUpDown nmFormHours;
		private System.Windows.Forms.TextBox txtJob;
		private System.Windows.Forms.CheckBox chkDone;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.ComboBox cboStatus;
		private System.Windows.Forms.NumericUpDown nmToHours;
		private System.Windows.Forms.NumericUpDown nmToMin;
		private System.Windows.Forms.Label label1;
	}
}
