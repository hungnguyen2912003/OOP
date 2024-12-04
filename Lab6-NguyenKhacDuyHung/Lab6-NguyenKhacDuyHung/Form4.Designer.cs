namespace Lab6_NguyenKhacDuyHung
{
	partial class Form4
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
			this.username = new System.Windows.Forms.Label();
			this.pwd = new System.Windows.Forms.Label();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.txtpwd = new System.Windows.Forms.TextBox();
			this.btnlogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(235, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "LOG IN";
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.ForeColor = System.Drawing.Color.Fuchsia;
			this.username.Location = new System.Drawing.Point(190, 151);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(124, 29);
			this.username.TabIndex = 1;
			this.username.Text = "Username";
			// 
			// pwd
			// 
			this.pwd.AutoSize = true;
			this.pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pwd.ForeColor = System.Drawing.Color.Fuchsia;
			this.pwd.Location = new System.Drawing.Point(190, 231);
			this.pwd.Name = "pwd";
			this.pwd.Size = new System.Drawing.Size(120, 29);
			this.pwd.TabIndex = 2;
			this.pwd.Text = "Password";
			// 
			// txtusername
			// 
			this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusername.Location = new System.Drawing.Point(379, 148);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(215, 34);
			this.txtusername.TabIndex = 3;
			// 
			// txtpwd
			// 
			this.txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpwd.Location = new System.Drawing.Point(379, 231);
			this.txtpwd.Name = "txtpwd";
			this.txtpwd.Size = new System.Drawing.Size(215, 34);
			this.txtpwd.TabIndex = 4;
			// 
			// btnlogin
			// 
			this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogin.ForeColor = System.Drawing.Color.Red;
			this.btnlogin.Location = new System.Drawing.Point(320, 343);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(159, 43);
			this.btnlogin.TabIndex = 5;
			this.btnlogin.Text = "Log in";
			this.btnlogin.UseVisualStyleBackColor = true;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnlogin);
			this.Controls.Add(this.txtpwd);
			this.Controls.Add(this.txtusername);
			this.Controls.Add(this.pwd);
			this.Controls.Add(this.username);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.Text = "Log in";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.Label pwd;
		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.TextBox txtpwd;
		private System.Windows.Forms.Button btnlogin;
	}
}