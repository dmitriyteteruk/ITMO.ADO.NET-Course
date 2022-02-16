
namespace ITMO.ADO.NET_Practice04_DataViewExample
{
	partial class DataViewExample
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
			this.GridViewCustomers = new System.Windows.Forms.DataGridView();
			this.textBoxSort = new System.Windows.Forms.TextBox();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.buttonSetDataViewProperties = new System.Windows.Forms.Button();
			this.buttonAddRow = new System.Windows.Forms.Button();
			this.customersTableAdapter1 = new ITMO.ADO.NET_Practice04_DataViewExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
			this.ordersTableAdapter1 = new ITMO.ADO.NET_Practice04_DataViewExample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
			this.northwindDataSet1 = new ITMO.ADO.NET_Practice04_DataViewExample.NorthwindDataSet();
			this.buttonGetOrders = new System.Windows.Forms.Button();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.GridViewCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// GridViewCustomers
			// 
			this.GridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridViewCustomers.Location = new System.Drawing.Point(13, 13);
			this.GridViewCustomers.Name = "GridViewCustomers";
			this.GridViewCustomers.Size = new System.Drawing.Size(584, 323);
			this.GridViewCustomers.TabIndex = 0;
			// 
			// textBoxSort
			// 
			this.textBoxSort.Location = new System.Drawing.Point(13, 358);
			this.textBoxSort.Name = "textBoxSort";
			this.textBoxSort.Size = new System.Drawing.Size(98, 20);
			this.textBoxSort.TabIndex = 1;
			this.textBoxSort.Text = "CustomerID";
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Location = new System.Drawing.Point(139, 359);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
			this.textBoxFilter.TabIndex = 2;
			this.textBoxFilter.Text = "City = \'London\'";
			// 
			// buttonSetDataViewProperties
			// 
			this.buttonSetDataViewProperties.Location = new System.Drawing.Point(277, 359);
			this.buttonSetDataViewProperties.Name = "buttonSetDataViewProperties";
			this.buttonSetDataViewProperties.Size = new System.Drawing.Size(142, 23);
			this.buttonSetDataViewProperties.TabIndex = 3;
			this.buttonSetDataViewProperties.Text = "Set DataView Properties";
			this.buttonSetDataViewProperties.UseVisualStyleBackColor = true;
			this.buttonSetDataViewProperties.Click += new System.EventHandler(this.buttonSetDataViewProperties_Click);
			// 
			// buttonAddRow
			// 
			this.buttonAddRow.Location = new System.Drawing.Point(456, 359);
			this.buttonAddRow.Name = "buttonAddRow";
			this.buttonAddRow.Size = new System.Drawing.Size(141, 23);
			this.buttonAddRow.TabIndex = 4;
			this.buttonAddRow.Text = "Add Row";
			this.buttonAddRow.UseVisualStyleBackColor = true;
			this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
			// 
			// customersTableAdapter1
			// 
			this.customersTableAdapter1.ClearBeforeFill = true;
			// 
			// ordersTableAdapter1
			// 
			this.ordersTableAdapter1.ClearBeforeFill = true;
			// 
			// northwindDataSet1
			// 
			this.northwindDataSet1.DataSetName = "NorthwindDataSet";
			this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// buttonGetOrders
			// 
			this.buttonGetOrders.Location = new System.Drawing.Point(626, 359);
			this.buttonGetOrders.Name = "buttonGetOrders";
			this.buttonGetOrders.Size = new System.Drawing.Size(141, 23);
			this.buttonGetOrders.TabIndex = 5;
			this.buttonGetOrders.Text = "Get Orders";
			this.buttonGetOrders.UseVisualStyleBackColor = true;
			this.buttonGetOrders.Click += new System.EventHandler(this.buttonGetOrders_Click);
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Location = new System.Drawing.Point(626, 13);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.Size = new System.Drawing.Size(564, 323);
			this.dataGridViewOrders.TabIndex = 6;
			// 
			// DataViewExample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 450);
			this.Controls.Add(this.dataGridViewOrders);
			this.Controls.Add(this.buttonGetOrders);
			this.Controls.Add(this.buttonAddRow);
			this.Controls.Add(this.buttonSetDataViewProperties);
			this.Controls.Add(this.textBoxFilter);
			this.Controls.Add(this.textBoxSort);
			this.Controls.Add(this.GridViewCustomers);
			this.Name = "DataViewExample";
			this.Text = "Упражнение 6. Создание и использование объектов DataView";
			this.Load += new System.EventHandler(this.DataViewExample_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridViewCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridViewCustomers;
		private System.Windows.Forms.TextBox textBoxSort;
		private System.Windows.Forms.TextBox textBoxFilter;
		private System.Windows.Forms.Button buttonSetDataViewProperties;
		private System.Windows.Forms.Button buttonAddRow;
		private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
		private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
		private NorthwindDataSet northwindDataSet1;
		private System.Windows.Forms.Button buttonGetOrders;
		private System.Windows.Forms.DataGridView dataGridViewOrders;
	}
}

