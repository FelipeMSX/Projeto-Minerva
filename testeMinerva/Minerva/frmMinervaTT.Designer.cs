namespace Minerva
{
	partial class frmMinervaTT
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
			this.lbFirstNome = new System.Windows.Forms.Label();
			this.btSend = new System.Windows.Forms.Button();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lbLastName = new System.Windows.Forms.Label();
			this.gbName = new System.Windows.Forms.GroupBox();
			this.lbEmail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbSubject = new System.Windows.Forms.Label();
			this.gbName.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbFirstNome
			// 
			this.lbFirstNome.AutoSize = true;
			this.lbFirstNome.Location = new System.Drawing.Point(31, 16);
			this.lbFirstNome.Name = "lbFirstNome";
			this.lbFirstNome.Size = new System.Drawing.Size(26, 13);
			this.lbFirstNome.TabIndex = 0;
			this.lbFirstNome.Text = "First";
			// 
			// btSend
			// 
			this.btSend.Location = new System.Drawing.Point(312, 232);
			this.btSend.Name = "btSend";
			this.btSend.Size = new System.Drawing.Size(79, 28);
			this.btSend.TabIndex = 1;
			this.btSend.Text = "Send";
			this.btSend.UseVisualStyleBackColor = true;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(25, 33);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(163, 20);
			this.txtFirstName.TabIndex = 2;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(194, 33);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(163, 20);
			this.txtLastName.TabIndex = 4;
			// 
			// lbLastName
			// 
			this.lbLastName.AutoSize = true;
			this.lbLastName.Location = new System.Drawing.Point(203, 15);
			this.lbLastName.Name = "lbLastName";
			this.lbLastName.Size = new System.Drawing.Size(27, 13);
			this.lbLastName.TabIndex = 3;
			this.lbLastName.Text = "Last";
			// 
			// gbName
			// 
			this.gbName.Controls.Add(this.lbFirstNome);
			this.gbName.Controls.Add(this.txtLastName);
			this.gbName.Controls.Add(this.txtFirstName);
			this.gbName.Controls.Add(this.lbLastName);
			this.gbName.Location = new System.Drawing.Point(34, 29);
			this.gbName.Name = "gbName";
			this.gbName.Size = new System.Drawing.Size(383, 66);
			this.gbName.TabIndex = 5;
			this.gbName.TabStop = false;
			this.gbName.Text = "Name";
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Location = new System.Drawing.Point(21, 121);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(32, 13);
			this.lbEmail.TabIndex = 6;
			this.lbEmail.Text = "Email";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(59, 118);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(332, 20);
			this.txtEmail.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(60, 155);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(331, 55);
			this.textBox1.TabIndex = 8;
			// 
			// lbSubject
			// 
			this.lbSubject.AutoSize = true;
			this.lbSubject.Location = new System.Drawing.Point(11, 158);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(43, 13);
			this.lbSubject.TabIndex = 9;
			this.lbSubject.Text = "Subject";
			this.lbSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmMinervaTT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 278);
			this.Controls.Add(this.lbSubject);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lbEmail);
			this.Controls.Add(this.gbName);
			this.Controls.Add(this.btSend);
			this.Name = "frmMinervaTT";
			this.Text = "Minerva Project";
			this.gbName.ResumeLayout(false);
			this.gbName.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbFirstNome;
		private System.Windows.Forms.Button btSend;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lbLastName;
		private System.Windows.Forms.GroupBox gbName;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbSubject;
	}
}

