namespace Reduz
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
			this.components = new System.ComponentModel.Container();
			this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblAnalise = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSelection = new System.Windows.Forms.Button();
			this.schemas = new Reduz.Schemas();
			this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schemas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(66, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(463, 20);
			this.textBox1.TabIndex = 0;
			// 
			// lblAnalise
			// 
			this.lblAnalise.AutoSize = true;
			this.lblAnalise.Location = new System.Drawing.Point(12, 9);
			this.lblAnalise.Name = "lblAnalise";
			this.lblAnalise.Size = new System.Drawing.Size(48, 13);
			this.lblAnalise.TabIndex = 1;
			this.lblAnalise.Text = "Caminho";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dataGridView1.DataSource = this.fileBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(66, 77);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(463, 215);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnSelection
			// 
			this.btnSelection.Location = new System.Drawing.Point(535, 4);
			this.btnSelection.Name = "btnSelection";
			this.btnSelection.Size = new System.Drawing.Size(75, 23);
			this.btnSelection.TabIndex = 3;
			this.btnSelection.Text = "Selecionar";
			this.btnSelection.UseVisualStyleBackColor = true;
			// 
			// schemas
			// 
			this.schemas.DataSetName = "File";
			this.schemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// fileBindingSource
			// 
			this.fileBindingSource.DataMember = "File";
			this.fileBindingSource.DataSource = this.schemas;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
			this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Caminho";
			this.dataGridViewTextBoxColumn2.HeaderText = "Caminho";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Criação";
			this.dataGridViewTextBoxColumn3.HeaderText = "Criação";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 446);
			this.Controls.Add(this.btnSelection);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblAnalise);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schemas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblAnalise;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSelection;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn criaçãoDataGridViewTextBoxColumn;
		private Schemas file;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.BindingSource fileBindingSource;
		private Schemas schemas;
	}
}

