namespace Lab6_NguyenKhacDuyHung
{
	partial class Form3
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
			this.label1 = new System.Windows.Forms.Label();
			this.maso = new System.Windows.Forms.Label();
			this.nhanhieu = new System.Windows.Forms.Label();
			this.gianhap = new System.Windows.Forms.Label();
			this.giaban = new System.Windows.Forms.Label();
			this.txtmaso = new System.Windows.Forms.TextBox();
			this.txtgianhap = new System.Windows.Forms.TextBox();
			this.txtgiaban = new System.Windows.Forms.TextBox();
			this.cmbhieu = new System.Windows.Forms.ComboBox();
			this.btnadd = new System.Windows.Forms.Button();
			this.btndel = new System.Windows.Forms.Button();
			this.btnprice = new System.Windows.Forms.Button();
			this.btnsort = new System.Windows.Forms.Button();
			this.btnclose = new System.Windows.Forms.Button();
			this.picPhone = new System.Windows.Forms.PictureBox();
			this.pictitle = new System.Windows.Forms.Label();
			this.dgvDSDT = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(310, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(374, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "THÔNG TIN ĐIỆN THOẠI";
			// 
			// maso
			// 
			this.maso.AutoSize = true;
			this.maso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maso.ForeColor = System.Drawing.Color.Blue;
			this.maso.Location = new System.Drawing.Point(106, 114);
			this.maso.Name = "maso";
			this.maso.Size = new System.Drawing.Size(78, 29);
			this.maso.TabIndex = 1;
			this.maso.Text = "Mã số";
			// 
			// nhanhieu
			// 
			this.nhanhieu.AutoSize = true;
			this.nhanhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhanhieu.ForeColor = System.Drawing.Color.Blue;
			this.nhanhieu.Location = new System.Drawing.Point(106, 181);
			this.nhanhieu.Name = "nhanhieu";
			this.nhanhieu.Size = new System.Drawing.Size(122, 29);
			this.nhanhieu.TabIndex = 2;
			this.nhanhieu.Text = "Nhãn hiệu";
			// 
			// gianhap
			// 
			this.gianhap.AutoSize = true;
			this.gianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gianhap.ForeColor = System.Drawing.Color.Blue;
			this.gianhap.Location = new System.Drawing.Point(106, 247);
			this.gianhap.Name = "gianhap";
			this.gianhap.Size = new System.Drawing.Size(109, 29);
			this.gianhap.TabIndex = 3;
			this.gianhap.Text = "Giá nhập";
			// 
			// giaban
			// 
			this.giaban.AutoSize = true;
			this.giaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.giaban.ForeColor = System.Drawing.Color.Fuchsia;
			this.giaban.Location = new System.Drawing.Point(106, 317);
			this.giaban.Name = "giaban";
			this.giaban.Size = new System.Drawing.Size(96, 29);
			this.giaban.TabIndex = 4;
			this.giaban.Text = "Giá bán";
			// 
			// txtmaso
			// 
			this.txtmaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmaso.Location = new System.Drawing.Point(261, 109);
			this.txtmaso.Name = "txtmaso";
			this.txtmaso.Size = new System.Drawing.Size(292, 34);
			this.txtmaso.TabIndex = 5;
			// 
			// txtgianhap
			// 
			this.txtgianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtgianhap.Location = new System.Drawing.Point(261, 242);
			this.txtgianhap.Name = "txtgianhap";
			this.txtgianhap.Size = new System.Drawing.Size(292, 34);
			this.txtgianhap.TabIndex = 7;
			// 
			// txtgiaban
			// 
			this.txtgiaban.Enabled = false;
			this.txtgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtgiaban.Location = new System.Drawing.Point(261, 312);
			this.txtgiaban.Name = "txtgiaban";
			this.txtgiaban.Size = new System.Drawing.Size(292, 34);
			this.txtgiaban.TabIndex = 8;
			// 
			// cmbhieu
			// 
			this.cmbhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbhieu.FormattingEnabled = true;
			this.cmbhieu.Items.AddRange(new object[] {
            "Iphone",
            "Samsung",
            "Vivo",
            "Xiaomi",
            "Realme"});
			this.cmbhieu.Location = new System.Drawing.Point(261, 173);
			this.cmbhieu.Name = "cmbhieu";
			this.cmbhieu.Size = new System.Drawing.Size(292, 37);
			this.cmbhieu.TabIndex = 9;
			// 
			// btnadd
			// 
			this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnadd.Location = new System.Drawing.Point(52, 387);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(110, 45);
			this.btnadd.TabIndex = 10;
			this.btnadd.Text = "Thêm";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btndel
			// 
			this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btndel.Location = new System.Drawing.Point(204, 387);
			this.btndel.Name = "btndel";
			this.btndel.Size = new System.Drawing.Size(110, 45);
			this.btndel.TabIndex = 11;
			this.btndel.Text = "Xoá";
			this.btndel.UseVisualStyleBackColor = true;
			this.btndel.Click += new System.EventHandler(this.btndel_Click);
			// 
			// btnprice
			// 
			this.btnprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnprice.Location = new System.Drawing.Point(362, 387);
			this.btnprice.Name = "btnprice";
			this.btnprice.Size = new System.Drawing.Size(196, 45);
			this.btnprice.TabIndex = 12;
			this.btnprice.Text = "Tính giá bán";
			this.btnprice.UseVisualStyleBackColor = true;
			this.btnprice.Click += new System.EventHandler(this.btnprice_Click);
			// 
			// btnsort
			// 
			this.btnsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnsort.Location = new System.Drawing.Point(592, 387);
			this.btnsort.Name = "btnsort";
			this.btnsort.Size = new System.Drawing.Size(157, 45);
			this.btnsort.TabIndex = 13;
			this.btnsort.Text = "Sắp xếp";
			this.btnsort.UseVisualStyleBackColor = true;
			this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
			// 
			// btnclose
			// 
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnclose.Location = new System.Drawing.Point(780, 387);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(110, 45);
			this.btnclose.TabIndex = 14;
			this.btnclose.Text = "Đóng";
			this.btnclose.UseVisualStyleBackColor = true;
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			// 
			// picPhone
			// 
			this.picPhone.Location = new System.Drawing.Point(661, 114);
			this.picPhone.Name = "picPhone";
			this.picPhone.Size = new System.Drawing.Size(198, 244);
			this.picPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPhone.TabIndex = 15;
			this.picPhone.TabStop = false;
			this.picPhone.Click += new System.EventHandler(this.picPhone_Click);
			// 
			// pictitle
			// 
			this.pictitle.AutoSize = true;
			this.pictitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pictitle.ForeColor = System.Drawing.Color.Blue;
			this.pictitle.Location = new System.Drawing.Point(710, 71);
			this.pictitle.Name = "pictitle";
			this.pictitle.Size = new System.Drawing.Size(107, 29);
			this.pictitle.TabIndex = 16;
			this.pictitle.Text = "Hình ảnh";
			// 
			// dgvDSDT
			// 
			this.dgvDSDT.AllowUserToOrderColumns = true;
			this.dgvDSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSDT.Location = new System.Drawing.Point(194, 448);
			this.dgvDSDT.Name = "dgvDSDT";
			this.dgvDSDT.RowHeadersWidth = 51;
			this.dgvDSDT.RowTemplate.Height = 24;
			this.dgvDSDT.Size = new System.Drawing.Size(550, 150);
			this.dgvDSDT.TabIndex = 17;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(951, 623);
			this.Controls.Add(this.dgvDSDT);
			this.Controls.Add(this.pictitle);
			this.Controls.Add(this.picPhone);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.btnsort);
			this.Controls.Add(this.btnprice);
			this.Controls.Add(this.btndel);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.cmbhieu);
			this.Controls.Add(this.txtgiaban);
			this.Controls.Add(this.txtgianhap);
			this.Controls.Add(this.txtmaso);
			this.Controls.Add(this.giaban);
			this.Controls.Add(this.gianhap);
			this.Controls.Add(this.nhanhieu);
			this.Controls.Add(this.maso);
			this.Controls.Add(this.label1);
			this.Name = "Form3";
			this.Text = "FrmPhone";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label maso;
		private System.Windows.Forms.Label nhanhieu;
		private System.Windows.Forms.Label gianhap;
		private System.Windows.Forms.Label giaban;
		private System.Windows.Forms.TextBox txtmaso;
		private System.Windows.Forms.TextBox txtgianhap;
		private System.Windows.Forms.TextBox txtgiaban;
		private System.Windows.Forms.ComboBox cmbhieu;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btndel;
		private System.Windows.Forms.Button btnprice;
		private System.Windows.Forms.Button btnsort;
		private System.Windows.Forms.Button btnclose;
		private System.Windows.Forms.PictureBox picPhone;
		private System.Windows.Forms.Label pictitle;
		private System.Windows.Forms.DataGridView dgvDSDT;
	}
}