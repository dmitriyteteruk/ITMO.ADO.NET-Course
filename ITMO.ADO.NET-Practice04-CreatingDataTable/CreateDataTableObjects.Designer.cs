
namespace ITMO.ADO.NET_Practice04_CreatingDataTable
{
	partial class FormCreateTableObjects
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
			this.buttonFillChildTable = new System.Windows.Forms.Button();
			this.dataGridViewChildTable = new System.Windows.Forms.DataGridView();
			this.dataGridViewParentTable = new System.Windows.Forms.DataGridView();
			this.buttonFillParentTable = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParentTable)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonFillChildTable
			// 
			this.buttonFillChildTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonFillChildTable.Location = new System.Drawing.Point(13, 13);
			this.buttonFillChildTable.Name = "buttonFillChildTable";
			this.buttonFillChildTable.Size = new System.Drawing.Size(489, 44);
			this.buttonFillChildTable.TabIndex = 0;
			this.buttonFillChildTable.Text = "Заполнить дочернюю таблицу";
			this.buttonFillChildTable.UseVisualStyleBackColor = true;
			this.buttonFillChildTable.Click += new System.EventHandler(this.buttonFillChildTable_Click);
			// 
			// dataGridViewChildTable
			// 
			this.dataGridViewChildTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewChildTable.Location = new System.Drawing.Point(13, 63);
			this.dataGridViewChildTable.Name = "dataGridViewChildTable";
			this.dataGridViewChildTable.Size = new System.Drawing.Size(489, 375);
			this.dataGridViewChildTable.TabIndex = 1;
			// 
			// dataGridViewParentTable
			// 
			this.dataGridViewParentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewParentTable.Location = new System.Drawing.Point(508, 63);
			this.dataGridViewParentTable.Name = "dataGridViewParentTable";
			this.dataGridViewParentTable.Size = new System.Drawing.Size(477, 375);
			this.dataGridViewParentTable.TabIndex = 2;
			// 
			// buttonFillParentTable
			// 
			this.buttonFillParentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonFillParentTable.Location = new System.Drawing.Point(508, 12);
			this.buttonFillParentTable.Name = "buttonFillParentTable";
			this.buttonFillParentTable.Size = new System.Drawing.Size(476, 44);
			this.buttonFillParentTable.TabIndex = 3;
			this.buttonFillParentTable.Text = "Заполнить основную таблицу";
			this.buttonFillParentTable.UseVisualStyleBackColor = true;
			this.buttonFillParentTable.Click += new System.EventHandler(this.buttonFillParentTable_Click);
			// 
			// FormCreateTableObjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 450);
			this.Controls.Add(this.buttonFillParentTable);
			this.Controls.Add(this.dataGridViewParentTable);
			this.Controls.Add(this.dataGridViewChildTable);
			this.Controls.Add(this.buttonFillChildTable);
			this.Name = "FormCreateTableObjects";
			this.Text = "Упражнение 2. Создание объектов DataTable";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParentTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonFillChildTable;
		private System.Windows.Forms.DataGridView dataGridViewChildTable;
		private System.Windows.Forms.DataGridView dataGridViewParentTable;
		private System.Windows.Forms.Button buttonFillParentTable;
	}
}

