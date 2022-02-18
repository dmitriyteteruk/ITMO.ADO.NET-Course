
namespace ITMO.ADO.NET_Practice_6._2_LoadDataSetXml
{
	partial class LoadDataSetXml
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
			this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.labelDataGridViewCustomers = new System.Windows.Forms.Label();
			this.labelDataGridViewOrders = new System.Windows.Forms.Label();
			this.buttonLoadSchema = new System.Windows.Forms.Button();
			this.buttonLoadData = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(13, 37);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.Size = new System.Drawing.Size(1198, 193);
			this.dataGridViewCustomers.TabIndex = 0;
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Location = new System.Drawing.Point(13, 260);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.Size = new System.Drawing.Size(1198, 189);
			this.dataGridViewOrders.TabIndex = 1;
			// 
			// labelDataGridViewCustomers
			// 
			this.labelDataGridViewCustomers.AutoSize = true;
			this.labelDataGridViewCustomers.Location = new System.Drawing.Point(13, 13);
			this.labelDataGridViewCustomers.Name = "labelDataGridViewCustomers";
			this.labelDataGridViewCustomers.Size = new System.Drawing.Size(130, 13);
			this.labelDataGridViewCustomers.TabIndex = 2;
			this.labelDataGridViewCustomers.Text = "Data Grid View Customers";
			// 
			// labelDataGridViewOrders
			// 
			this.labelDataGridViewOrders.AutoSize = true;
			this.labelDataGridViewOrders.Location = new System.Drawing.Point(13, 241);
			this.labelDataGridViewOrders.Name = "labelDataGridViewOrders";
			this.labelDataGridViewOrders.Size = new System.Drawing.Size(112, 13);
			this.labelDataGridViewOrders.TabIndex = 3;
			this.labelDataGridViewOrders.Text = "Data Grid View Orders";
			// 
			// buttonLoadSchema
			// 
			this.buttonLoadSchema.Location = new System.Drawing.Point(13, 466);
			this.buttonLoadSchema.Name = "buttonLoadSchema";
			this.buttonLoadSchema.Size = new System.Drawing.Size(187, 23);
			this.buttonLoadSchema.TabIndex = 4;
			this.buttonLoadSchema.Text = "Загрузить XML схему";
			this.buttonLoadSchema.UseVisualStyleBackColor = true;
			this.buttonLoadSchema.Click += new System.EventHandler(this.buttonLoadSchema_Click);
			// 
			// buttonLoadData
			// 
			this.buttonLoadData.Location = new System.Drawing.Point(229, 466);
			this.buttonLoadData.Name = "buttonLoadData";
			this.buttonLoadData.Size = new System.Drawing.Size(197, 23);
			this.buttonLoadData.TabIndex = 5;
			this.buttonLoadData.Text = "Загрузить данные из XML файла";
			this.buttonLoadData.UseVisualStyleBackColor = true;
			this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
			// 
			// LoadDataSetXml
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1223, 509);
			this.Controls.Add(this.buttonLoadData);
			this.Controls.Add(this.buttonLoadSchema);
			this.Controls.Add(this.labelDataGridViewOrders);
			this.Controls.Add(this.labelDataGridViewCustomers);
			this.Controls.Add(this.dataGridViewOrders);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Name = "LoadDataSetXml";
			this.Text = "Упражнение 6.2. Загрузка объектов DataSet данными XML";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewCustomers;
		private System.Windows.Forms.DataGridView dataGridViewOrders;
		private System.Windows.Forms.Label labelDataGridViewCustomers;
		private System.Windows.Forms.Label labelDataGridViewOrders;
		private System.Windows.Forms.Button buttonLoadSchema;
		private System.Windows.Forms.Button buttonLoadData;
	}
}

