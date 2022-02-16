
namespace ITMO.ADO.NET_Practice04_WorkingDataTable
{
	partial class FormWorkingDataTable
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkingDataTable));
			this.dataGridViewCustomersData = new System.Windows.Forms.DataGridView();
			this.buttonFillTable = new System.Windows.Forms.Button();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSetNorthwind = new ITMO.ADO.NET_Practice04_WorkingDataTable.DataSet1();
			this.buttonAddRow = new System.Windows.Forms.Button();
			this.buttonDeleteRow = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAcceptChanges = new System.Windows.Forms.Button();
			this.buttonRejectChanges = new System.Windows.Forms.Button();
			this.textBoxCellValue = new System.Windows.Forms.TextBox();
			this.textBoxCurrentDRV = new System.Windows.Forms.TextBox();
			this.textBoxOriginalDRV = new System.Windows.Forms.TextBox();
			this.textBoxRowState = new System.Windows.Forms.TextBox();
			this.labelCellCurrentValue = new System.Windows.Forms.Label();
			this.labelCellOriginalValue = new System.Windows.Forms.Label();
			this.labelCurrentValue = new System.Windows.Forms.Label();
			this.labelCellStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetNorthwind)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewCustomersData
			// 
			this.dataGridViewCustomersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomersData.Location = new System.Drawing.Point(13, 13);
			this.dataGridViewCustomersData.Name = "dataGridViewCustomersData";
			this.dataGridViewCustomersData.Size = new System.Drawing.Size(775, 345);
			this.dataGridViewCustomersData.TabIndex = 0;
			this.dataGridViewCustomersData.Click += new System.EventHandler(this.dataGridViewCustomersData_Click);
			// 
			// buttonFillTable
			// 
			this.buttonFillTable.Location = new System.Drawing.Point(13, 376);
			this.buttonFillTable.Name = "buttonFillTable";
			this.buttonFillTable.Size = new System.Drawing.Size(161, 31);
			this.buttonFillTable.TabIndex = 1;
			this.buttonFillTable.Text = "Заполнить таблицу";
			this.buttonFillTable.UseVisualStyleBackColor = true;
			this.buttonFillTable.Click += new System.EventHandler(this.buttonFillTable_Click);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT * FROM Customers";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
			this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NChar, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 0, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 0, "ContactName"),
            new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 0, "ContactTitle"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 0, "Region"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 0, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 0, "Country"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 0, "Phone"),
            new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 0, "Fax")});
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NChar, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 0, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 0, "ContactName"),
            new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 0, "ContactTitle"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 0, "Region"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 0, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 0, "Country"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 0, "Phone"),
            new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 0, "Fax"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ContactName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ContactTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Region", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PostalCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Country", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Phone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null)});
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ContactName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ContactTitle", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Region", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PostalCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Country", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Country", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Phone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fax", System.Data.DataRowVersion.Original, null)});
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSetNorthwind
			// 
			this.dataSetNorthwind.DataSetName = "DataSetNorthwind";
			this.dataSetNorthwind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// buttonAddRow
			// 
			this.buttonAddRow.Location = new System.Drawing.Point(14, 413);
			this.buttonAddRow.Name = "buttonAddRow";
			this.buttonAddRow.Size = new System.Drawing.Size(160, 31);
			this.buttonAddRow.TabIndex = 2;
			this.buttonAddRow.Text = "Добавить строку";
			this.buttonAddRow.UseVisualStyleBackColor = true;
			this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
			// 
			// buttonDeleteRow
			// 
			this.buttonDeleteRow.Location = new System.Drawing.Point(14, 450);
			this.buttonDeleteRow.Name = "buttonDeleteRow";
			this.buttonDeleteRow.Size = new System.Drawing.Size(160, 31);
			this.buttonDeleteRow.TabIndex = 3;
			this.buttonDeleteRow.Text = "Удалить строку";
			this.buttonDeleteRow.UseVisualStyleBackColor = true;
			this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(191, 376);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(160, 31);
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Text = "Обновить данные";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonAcceptChanges
			// 
			this.buttonAcceptChanges.Location = new System.Drawing.Point(191, 413);
			this.buttonAcceptChanges.Name = "buttonAcceptChanges";
			this.buttonAcceptChanges.Size = new System.Drawing.Size(160, 31);
			this.buttonAcceptChanges.TabIndex = 5;
			this.buttonAcceptChanges.Text = "Принять изменения";
			this.buttonAcceptChanges.UseVisualStyleBackColor = true;
			this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
			// 
			// buttonRejectChanges
			// 
			this.buttonRejectChanges.Location = new System.Drawing.Point(191, 450);
			this.buttonRejectChanges.Name = "buttonRejectChanges";
			this.buttonRejectChanges.Size = new System.Drawing.Size(160, 31);
			this.buttonRejectChanges.TabIndex = 6;
			this.buttonRejectChanges.Text = "Отменить изменения";
			this.buttonRejectChanges.UseVisualStyleBackColor = true;
			this.buttonRejectChanges.Click += new System.EventHandler(this.buttonRejectChanges_Click);
			// 
			// textBoxCellValue
			// 
			this.textBoxCellValue.Location = new System.Drawing.Point(556, 376);
			this.textBoxCellValue.Name = "textBoxCellValue";
			this.textBoxCellValue.Size = new System.Drawing.Size(189, 20);
			this.textBoxCellValue.TabIndex = 7;
			// 
			// textBoxCurrentDRV
			// 
			this.textBoxCurrentDRV.Location = new System.Drawing.Point(556, 431);
			this.textBoxCurrentDRV.Name = "textBoxCurrentDRV";
			this.textBoxCurrentDRV.ReadOnly = true;
			this.textBoxCurrentDRV.Size = new System.Drawing.Size(189, 20);
			this.textBoxCurrentDRV.TabIndex = 8;
			// 
			// textBoxOriginalDRV
			// 
			this.textBoxOriginalDRV.Location = new System.Drawing.Point(556, 402);
			this.textBoxOriginalDRV.Name = "textBoxOriginalDRV";
			this.textBoxOriginalDRV.ReadOnly = true;
			this.textBoxOriginalDRV.Size = new System.Drawing.Size(189, 20);
			this.textBoxOriginalDRV.TabIndex = 9;
			this.textBoxOriginalDRV.Visible = false;
			// 
			// textBoxRowState
			// 
			this.textBoxRowState.Location = new System.Drawing.Point(556, 461);
			this.textBoxRowState.Name = "textBoxRowState";
			this.textBoxRowState.ReadOnly = true;
			this.textBoxRowState.Size = new System.Drawing.Size(189, 20);
			this.textBoxRowState.TabIndex = 10;
			// 
			// labelCellCurrentValue
			// 
			this.labelCellCurrentValue.AutoSize = true;
			this.labelCellCurrentValue.Location = new System.Drawing.Point(435, 380);
			this.labelCellCurrentValue.Name = "labelCellCurrentValue";
			this.labelCellCurrentValue.Size = new System.Drawing.Size(111, 13);
			this.labelCellCurrentValue.TabIndex = 11;
			this.labelCellCurrentValue.Text = "Внесите изменения:";
			// 
			// labelCellOriginalValue
			// 
			this.labelCellOriginalValue.AutoSize = true;
			this.labelCellOriginalValue.Location = new System.Drawing.Point(435, 408);
			this.labelCellOriginalValue.Name = "labelCellOriginalValue";
			this.labelCellOriginalValue.Size = new System.Drawing.Size(109, 13);
			this.labelCellOriginalValue.TabIndex = 12;
			this.labelCellOriginalValue.Text = "Исходное значение:";
			// 
			// labelCurrentValue
			// 
			this.labelCurrentValue.AutoSize = true;
			this.labelCurrentValue.Location = new System.Drawing.Point(435, 436);
			this.labelCurrentValue.Name = "labelCurrentValue";
			this.labelCurrentValue.Size = new System.Drawing.Size(105, 13);
			this.labelCurrentValue.TabIndex = 13;
			this.labelCurrentValue.Text = "Текущее значение:";
			// 
			// labelCellStatus
			// 
			this.labelCellStatus.AutoSize = true;
			this.labelCellStatus.Location = new System.Drawing.Point(435, 464);
			this.labelCellStatus.Name = "labelCellStatus";
			this.labelCellStatus.Size = new System.Drawing.Size(102, 13);
			this.labelCellStatus.TabIndex = 14;
			this.labelCellStatus.Text = "Состояние ячейки:";
			// 
			// FormWorkingDataTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 562);
			this.Controls.Add(this.labelCellStatus);
			this.Controls.Add(this.labelCurrentValue);
			this.Controls.Add(this.labelCellOriginalValue);
			this.Controls.Add(this.labelCellCurrentValue);
			this.Controls.Add(this.textBoxRowState);
			this.Controls.Add(this.textBoxOriginalDRV);
			this.Controls.Add(this.textBoxCurrentDRV);
			this.Controls.Add(this.textBoxCellValue);
			this.Controls.Add(this.buttonRejectChanges);
			this.Controls.Add(this.buttonAcceptChanges);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonDeleteRow);
			this.Controls.Add(this.buttonAddRow);
			this.Controls.Add(this.buttonFillTable);
			this.Controls.Add(this.dataGridViewCustomersData);
			this.Name = "FormWorkingDataTable";
			this.Text = "Упражнение 5. Обработка данных в DataTable";
			this.Load += new System.EventHandler(this.FormWorkingDataTable_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetNorthwind)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewCustomersData;
		private System.Windows.Forms.Button buttonFillTable;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private DataSet1 dataSetNorthwind;
		private System.Windows.Forms.Button buttonAddRow;
		private System.Windows.Forms.Button buttonDeleteRow;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAcceptChanges;
		private System.Windows.Forms.Button buttonRejectChanges;
		private System.Windows.Forms.TextBox textBoxCellValue;
		private System.Windows.Forms.TextBox textBoxCurrentDRV;
		private System.Windows.Forms.TextBox textBoxOriginalDRV;
		private System.Windows.Forms.TextBox textBoxRowState;
		private System.Windows.Forms.Label labelCellCurrentValue;
		private System.Windows.Forms.Label labelCellOriginalValue;
		private System.Windows.Forms.Label labelCurrentValue;
		private System.Windows.Forms.Label labelCellStatus;
	}
}

