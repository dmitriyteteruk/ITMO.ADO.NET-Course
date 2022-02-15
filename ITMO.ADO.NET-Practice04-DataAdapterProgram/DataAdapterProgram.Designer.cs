
namespace ITMO.ADO.NET_Practice04_DataAdapterProgram
{
	partial class DataAdapterProgram
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAddRow = new System.Windows.Forms.Button();
			this.buttonDeleteRow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 13);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(775, 216);
			this.dataGridView.TabIndex = 0;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(13, 247);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(183, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Обновить";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonAddRow
			// 
			this.buttonAddRow.Location = new System.Drawing.Point(217, 247);
			this.buttonAddRow.Name = "buttonAddRow";
			this.buttonAddRow.Size = new System.Drawing.Size(181, 23);
			this.buttonAddRow.TabIndex = 2;
			this.buttonAddRow.Text = "Добавить строку";
			this.buttonAddRow.UseVisualStyleBackColor = true;
			this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
			// 
			// buttonDeleteRow
			// 
			this.buttonDeleteRow.Location = new System.Drawing.Point(421, 247);
			this.buttonDeleteRow.Name = "buttonDeleteRow";
			this.buttonDeleteRow.Size = new System.Drawing.Size(166, 23);
			this.buttonDeleteRow.TabIndex = 3;
			this.buttonDeleteRow.Text = "Удалить строку";
			this.buttonDeleteRow.UseVisualStyleBackColor = true;
			this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
			// 
			// DataAdapterProgram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonDeleteRow);
			this.Controls.Add(this.buttonAddRow);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.dataGridView);
			this.Name = "DataAdapterProgram";
			this.Text = "Упражнение 3. Программное создание объекта DataAdapter";
			this.Load += new System.EventHandler(this.DataAdapterProgram_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAddRow;
		private System.Windows.Forms.Button buttonDeleteRow;
	}
}

