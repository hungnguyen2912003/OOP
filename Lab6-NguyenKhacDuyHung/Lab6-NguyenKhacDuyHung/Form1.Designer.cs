namespace Lab6_NguyenKhacDuyHung
{
	partial class Form1
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
			this.title = new System.Windows.Forms.Label();
			this.soa = new System.Windows.Forms.Label();
			this.sob = new System.Windows.Forms.Label();
			this.kq = new System.Windows.Forms.Label();
			this.txta = new System.Windows.Forms.TextBox();
			this.txtb = new System.Windows.Forms.TextBox();
			this.txtkq = new System.Windows.Forms.TextBox();
			this.btncong = new System.Windows.Forms.Button();
			this.btntru = new System.Windows.Forms.Button();
			this.btnnhan = new System.Windows.Forms.Button();
			this.btnchia = new System.Windows.Forms.Button();
			this.btncalc = new System.Windows.Forms.Button();
			this.btnclose = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.Red;
			this.title.Location = new System.Drawing.Point(182, 35);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(460, 39);
			this.title.TabIndex = 0;
			this.title.Text = "CÁC PHÉP TOÁN SỐ HỌC";
			// 
			// soa
			// 
			this.soa.AutoSize = true;
			this.soa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soa.ForeColor = System.Drawing.Color.Blue;
			this.soa.Location = new System.Drawing.Point(155, 136);
			this.soa.Name = "soa";
			this.soa.Size = new System.Drawing.Size(166, 29);
			this.soa.TabIndex = 1;
			this.soa.Text = "Nhập vào số a";
			// 
			// sob
			// 
			this.sob.AutoSize = true;
			this.sob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sob.ForeColor = System.Drawing.Color.Blue;
			this.sob.Location = new System.Drawing.Point(154, 213);
			this.sob.Name = "sob";
			this.sob.Size = new System.Drawing.Size(167, 29);
			this.sob.TabIndex = 2;
			this.sob.Text = "Nhập vào số b";
			// 
			// kq
			// 
			this.kq.AutoSize = true;
			this.kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kq.ForeColor = System.Drawing.Color.Blue;
			this.kq.Location = new System.Drawing.Point(155, 295);
			this.kq.Name = "kq";
			this.kq.Size = new System.Drawing.Size(95, 29);
			this.kq.TabIndex = 3;
			this.kq.Text = "Kết quả";
			// 
			// txta
			// 
			this.txta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txta.Location = new System.Drawing.Point(350, 131);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(315, 34);
			this.txta.TabIndex = 4;
			// 
			// txtb
			// 
			this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtb.Location = new System.Drawing.Point(350, 208);
			this.txtb.Name = "txtb";
			this.txtb.Size = new System.Drawing.Size(315, 34);
			this.txtb.TabIndex = 5;
			// 
			// txtkq
			// 
			this.txtkq.Enabled = false;
			this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtkq.Location = new System.Drawing.Point(350, 290);
			this.txtkq.Name = "txtkq";
			this.txtkq.Size = new System.Drawing.Size(315, 34);
			this.txtkq.TabIndex = 6;
			// 
			// btncong
			// 
			this.btncong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btncong.Location = new System.Drawing.Point(30, 384);
			this.btncong.Name = "btncong";
			this.btncong.Size = new System.Drawing.Size(101, 53);
			this.btncong.TabIndex = 7;
			this.btncong.Text = "+";
			this.btncong.UseVisualStyleBackColor = true;
			this.btncong.Click += new System.EventHandler(this.btncong_Click);
			// 
			// btntru
			// 
			this.btntru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btntru.Location = new System.Drawing.Point(160, 384);
			this.btntru.Name = "btntru";
			this.btntru.Size = new System.Drawing.Size(101, 53);
			this.btntru.TabIndex = 8;
			this.btntru.Text = "-";
			this.btntru.UseVisualStyleBackColor = true;
			this.btntru.Click += new System.EventHandler(this.btntru_Click);
			// 
			// btnnhan
			// 
			this.btnnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnnhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnnhan.Location = new System.Drawing.Point(294, 384);
			this.btnnhan.Name = "btnnhan";
			this.btnnhan.Size = new System.Drawing.Size(101, 53);
			this.btnnhan.TabIndex = 9;
			this.btnnhan.Text = "*";
			this.btnnhan.UseVisualStyleBackColor = true;
			this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
			// 
			// btnchia
			// 
			this.btnchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnchia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnchia.Location = new System.Drawing.Point(429, 384);
			this.btnchia.Name = "btnchia";
			this.btnchia.Size = new System.Drawing.Size(101, 53);
			this.btnchia.TabIndex = 10;
			this.btnchia.Text = "/";
			this.btnchia.UseVisualStyleBackColor = true;
			this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
			// 
			// btncalc
			// 
			this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btncalc.Location = new System.Drawing.Point(564, 384);
			this.btncalc.Name = "btncalc";
			this.btncalc.Size = new System.Drawing.Size(101, 53);
			this.btncalc.TabIndex = 11;
			this.btncalc.Text = "C";
			this.btncalc.UseVisualStyleBackColor = true;
			this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
			// 
			// btnclose
			// 
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnclose.Location = new System.Drawing.Point(696, 384);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(101, 53);
			this.btnclose.TabIndex = 12;
			this.btnclose.Text = "Close";
			this.btnclose.UseVisualStyleBackColor = true;
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 469);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.btncalc);
			this.Controls.Add(this.btnchia);
			this.Controls.Add(this.btnnhan);
			this.Controls.Add(this.btntru);
			this.Controls.Add(this.btncong);
			this.Controls.Add(this.txtkq);
			this.Controls.Add(this.txtb);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.kq);
			this.Controls.Add(this.sob);
			this.Controls.Add(this.soa);
			this.Controls.Add(this.title);
			this.Name = "Form1";
			this.Text = "Tính toán";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label soa;
		private System.Windows.Forms.Label sob;
		private System.Windows.Forms.Label kq;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.TextBox txtb;
		private System.Windows.Forms.TextBox txtkq;
		private System.Windows.Forms.Button btncong;
		private System.Windows.Forms.Button btntru;
		private System.Windows.Forms.Button btnnhan;
		private System.Windows.Forms.Button btnchia;
		private System.Windows.Forms.Button btncalc;
		private System.Windows.Forms.Button btnclose;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}