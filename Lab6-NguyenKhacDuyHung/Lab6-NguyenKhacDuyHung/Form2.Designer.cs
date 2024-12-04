namespace Lab6_NguyenKhacDuyHung
{
	partial class Form2
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
			this.soa = new System.Windows.Forms.Label();
			this.sob = new System.Windows.Forms.Label();
			this.soc = new System.Windows.Forms.Label();
			this.kq = new System.Windows.Forms.Label();
			this.gb = new System.Windows.Forms.GroupBox();
			this.radio2 = new System.Windows.Forms.RadioButton();
			this.radio1 = new System.Windows.Forms.RadioButton();
			this.btngiai = new System.Windows.Forms.Button();
			this.btnclose = new System.Windows.Forms.Button();
			this.txta = new System.Windows.Forms.TextBox();
			this.txtb = new System.Windows.Forms.TextBox();
			this.txtc = new System.Windows.Forms.TextBox();
			this.txtkq = new System.Windows.Forms.TextBox();
			this.gb.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(287, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
			// 
			// soa
			// 
			this.soa.AutoSize = true;
			this.soa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soa.ForeColor = System.Drawing.Color.Blue;
			this.soa.Location = new System.Drawing.Point(494, 117);
			this.soa.Name = "soa";
			this.soa.Size = new System.Drawing.Size(95, 29);
			this.soa.TabIndex = 1;
			this.soa.Text = "Hệ số a";
			// 
			// sob
			// 
			this.sob.AutoSize = true;
			this.sob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sob.ForeColor = System.Drawing.Color.Blue;
			this.sob.Location = new System.Drawing.Point(493, 188);
			this.sob.Name = "sob";
			this.sob.Size = new System.Drawing.Size(96, 29);
			this.sob.TabIndex = 2;
			this.sob.Text = "Hệ số b";
			// 
			// soc
			// 
			this.soc.AutoSize = true;
			this.soc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soc.ForeColor = System.Drawing.Color.Blue;
			this.soc.Location = new System.Drawing.Point(495, 256);
			this.soc.Name = "soc";
			this.soc.Size = new System.Drawing.Size(94, 29);
			this.soc.TabIndex = 3;
			this.soc.Text = "Hệ số c";
			// 
			// kq
			// 
			this.kq.AutoSize = true;
			this.kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kq.ForeColor = System.Drawing.Color.Blue;
			this.kq.Location = new System.Drawing.Point(83, 321);
			this.kq.Name = "kq";
			this.kq.Size = new System.Drawing.Size(95, 29);
			this.kq.TabIndex = 4;
			this.kq.Text = "Kết quả";
			// 
			// gb
			// 
			this.gb.BackColor = System.Drawing.Color.Transparent;
			this.gb.Controls.Add(this.radio2);
			this.gb.Controls.Add(this.radio1);
			this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb.Location = new System.Drawing.Point(63, 114);
			this.gb.Name = "gb";
			this.gb.Size = new System.Drawing.Size(375, 171);
			this.gb.TabIndex = 5;
			this.gb.TabStop = false;
			this.gb.Text = "Chọn phương trình";
			// 
			// radio2
			// 
			this.radio2.AutoSize = true;
			this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radio2.Location = new System.Drawing.Point(25, 100);
			this.radio2.Name = "radio2";
			this.radio2.Size = new System.Drawing.Size(227, 33);
			this.radio2.TabIndex = 1;
			this.radio2.TabStop = true;
			this.radio2.Text = "ax^2 + bx + c = 0";
			this.radio2.UseVisualStyleBackColor = true;
			this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
			// 
			// radio1
			// 
			this.radio1.AutoSize = true;
			this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radio1.Location = new System.Drawing.Point(25, 50);
			this.radio1.Name = "radio1";
			this.radio1.Size = new System.Drawing.Size(147, 33);
			this.radio1.TabIndex = 0;
			this.radio1.TabStop = true;
			this.radio1.Text = "ax + b = 0";
			this.radio1.UseVisualStyleBackColor = true;
			// 
			// btngiai
			// 
			this.btngiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btngiai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btngiai.Location = new System.Drawing.Point(273, 378);
			this.btngiai.Name = "btngiai";
			this.btngiai.Size = new System.Drawing.Size(203, 60);
			this.btngiai.TabIndex = 6;
			this.btngiai.Text = "Thực hiện";
			this.btngiai.UseVisualStyleBackColor = true;
			this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
			// 
			// btnclose
			// 
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnclose.Location = new System.Drawing.Point(534, 378);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(163, 60);
			this.btnclose.TabIndex = 7;
			this.btnclose.Text = "Close";
			this.btnclose.UseVisualStyleBackColor = true;
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			// 
			// txta
			// 
			this.txta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txta.Location = new System.Drawing.Point(630, 112);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(226, 34);
			this.txta.TabIndex = 8;
			// 
			// txtb
			// 
			this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtb.Location = new System.Drawing.Point(630, 183);
			this.txtb.Name = "txtb";
			this.txtb.Size = new System.Drawing.Size(226, 34);
			this.txtb.TabIndex = 9;
			// 
			// txtc
			// 
			this.txtc.Enabled = false;
			this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtc.Location = new System.Drawing.Point(630, 251);
			this.txtc.Name = "txtc";
			this.txtc.Size = new System.Drawing.Size(226, 34);
			this.txtc.TabIndex = 10;
			// 
			// txtkq
			// 
			this.txtkq.Enabled = false;
			this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtkq.Location = new System.Drawing.Point(202, 318);
			this.txtkq.Name = "txtkq";
			this.txtkq.Size = new System.Drawing.Size(654, 34);
			this.txtkq.TabIndex = 11;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 450);
			this.Controls.Add(this.txtkq);
			this.Controls.Add(this.txtc);
			this.Controls.Add(this.txtb);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.btngiai);
			this.Controls.Add(this.gb);
			this.Controls.Add(this.kq);
			this.Controls.Add(this.soc);
			this.Controls.Add(this.sob);
			this.Controls.Add(this.soa);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "FormLab6_2";
			this.gb.ResumeLayout(false);
			this.gb.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label soa;
		private System.Windows.Forms.Label sob;
		private System.Windows.Forms.Label soc;
		private System.Windows.Forms.Label kq;
		private System.Windows.Forms.GroupBox gb;
		private System.Windows.Forms.RadioButton radio2;
		private System.Windows.Forms.RadioButton radio1;
		private System.Windows.Forms.Button btngiai;
		private System.Windows.Forms.Button btnclose;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.TextBox txtb;
		private System.Windows.Forms.TextBox txtc;
		private System.Windows.Forms.TextBox txtkq;
	}
}