
namespace ITMO.ADO.NET_Practice03_DBCommand
{
	partial class DBCommand
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
			this.sqlCommandWorkWithDB = new System.Data.SqlClient.SqlCommand();
			this.sqlConnectionToLocalDB = new System.Data.SqlClient.SqlConnection();
			this.buttonQueryData = new System.Windows.Forms.Button();
			this.textBoxResultFromQuery = new System.Windows.Forms.TextBox();
			this.buttonPacketQuery = new System.Windows.Forms.Button();
			this.textBoxResultPacketQuery = new System.Windows.Forms.TextBox();
			this.buttonInvokeStoredProcedure = new System.Windows.Forms.Button();
			this.sqlCommandInvokeStoredProcedure = new System.Data.SqlClient.SqlCommand();
			this.textBoxResultStoredProcedure = new System.Windows.Forms.TextBox();
			this.buttonCreateTable = new System.Windows.Forms.Button();
			this.sqlCommandCreateTable = new System.Data.SqlClient.SqlCommand();
			this.buttonQueryWithParameters = new System.Windows.Forms.Button();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.sqlCommandQueryWithParameters = new System.Data.SqlClient.SqlCommand();
			this.textBoxResultQueryWithParmeters = new System.Windows.Forms.TextBox();
			this.buttonCallSpWithParameters = new System.Windows.Forms.Button();
			this.textBoxCategoryName = new System.Windows.Forms.TextBox();
			this.textBoxOrdYear = new System.Windows.Forms.TextBox();
			this.sqlCommandCallSpWithParameters = new System.Data.SqlClient.SqlCommand();
			this.textBoxResultCallSpWithParameters = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// sqlCommandWorkWithDB
			// 
			this.sqlCommandWorkWithDB.Connection = this.sqlConnectionToLocalDB;
			// 
			// sqlConnectionToLocalDB
			// 
			this.sqlConnectionToLocalDB.ConnectionString = global::ITMO.ADO.NET_Practice03_DBCommand.Properties.Settings.Default.LocalDB;
			this.sqlConnectionToLocalDB.FireInfoMessageEventOnUserErrors = false;
			// 
			// buttonQueryData
			// 
			this.buttonQueryData.Location = new System.Drawing.Point(13, 13);
			this.buttonQueryData.Name = "buttonQueryData";
			this.buttonQueryData.Size = new System.Drawing.Size(137, 23);
			this.buttonQueryData.TabIndex = 0;
			this.buttonQueryData.Text = "Запрос данных";
			this.buttonQueryData.UseVisualStyleBackColor = true;
			this.buttonQueryData.Click += new System.EventHandler(this.buttonQueryData_Click);
			// 
			// textBoxResultFromQuery
			// 
			this.textBoxResultFromQuery.Location = new System.Drawing.Point(181, 13);
			this.textBoxResultFromQuery.Multiline = true;
			this.textBoxResultFromQuery.Name = "textBoxResultFromQuery";
			this.textBoxResultFromQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResultFromQuery.Size = new System.Drawing.Size(400, 82);
			this.textBoxResultFromQuery.TabIndex = 1;
			// 
			// buttonPacketQuery
			// 
			this.buttonPacketQuery.Location = new System.Drawing.Point(13, 101);
			this.buttonPacketQuery.Name = "buttonPacketQuery";
			this.buttonPacketQuery.Size = new System.Drawing.Size(137, 23);
			this.buttonPacketQuery.TabIndex = 2;
			this.buttonPacketQuery.Text = "Пакетный запрос";
			this.buttonPacketQuery.UseVisualStyleBackColor = true;
			this.buttonPacketQuery.Click += new System.EventHandler(this.buttonPacketQuery_Click);
			// 
			// textBoxResultPacketQuery
			// 
			this.textBoxResultPacketQuery.Location = new System.Drawing.Point(181, 101);
			this.textBoxResultPacketQuery.Multiline = true;
			this.textBoxResultPacketQuery.Name = "textBoxResultPacketQuery";
			this.textBoxResultPacketQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResultPacketQuery.Size = new System.Drawing.Size(400, 82);
			this.textBoxResultPacketQuery.TabIndex = 3;
			// 
			// buttonInvokeStoredProcedure
			// 
			this.buttonInvokeStoredProcedure.Location = new System.Drawing.Point(13, 187);
			this.buttonInvokeStoredProcedure.Name = "buttonInvokeStoredProcedure";
			this.buttonInvokeStoredProcedure.Size = new System.Drawing.Size(137, 23);
			this.buttonInvokeStoredProcedure.TabIndex = 4;
			this.buttonInvokeStoredProcedure.Text = "Вызов процедуры";
			this.buttonInvokeStoredProcedure.UseVisualStyleBackColor = true;
			this.buttonInvokeStoredProcedure.Click += new System.EventHandler(this.buttonInvokeStoredProcedure_Click);
			// 
			// sqlCommandInvokeStoredProcedure
			// 
			this.sqlCommandInvokeStoredProcedure.CommandText = "Ten Most Expensive Products";
			this.sqlCommandInvokeStoredProcedure.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlCommandInvokeStoredProcedure.Connection = this.sqlConnectionToLocalDB;
			// 
			// textBoxResultStoredProcedure
			// 
			this.textBoxResultStoredProcedure.Location = new System.Drawing.Point(181, 189);
			this.textBoxResultStoredProcedure.Multiline = true;
			this.textBoxResultStoredProcedure.Name = "textBoxResultStoredProcedure";
			this.textBoxResultStoredProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResultStoredProcedure.Size = new System.Drawing.Size(400, 82);
			this.textBoxResultStoredProcedure.TabIndex = 5;
			// 
			// buttonCreateTable
			// 
			this.buttonCreateTable.Location = new System.Drawing.Point(13, 283);
			this.buttonCreateTable.Name = "buttonCreateTable";
			this.buttonCreateTable.Size = new System.Drawing.Size(137, 23);
			this.buttonCreateTable.TabIndex = 6;
			this.buttonCreateTable.Text = "Создание таблицы";
			this.buttonCreateTable.UseVisualStyleBackColor = true;
			this.buttonCreateTable.Click += new System.EventHandler(this.buttonCreateTable_Click);
			// 
			// sqlCommandCreateTable
			// 
			this.sqlCommandCreateTable.Connection = this.sqlConnectionToLocalDB;
			// 
			// buttonQueryWithParameters
			// 
			this.buttonQueryWithParameters.Location = new System.Drawing.Point(13, 327);
			this.buttonQueryWithParameters.Name = "buttonQueryWithParameters";
			this.buttonQueryWithParameters.Size = new System.Drawing.Size(137, 23);
			this.buttonQueryWithParameters.TabIndex = 7;
			this.buttonQueryWithParameters.Text = "Запрос с параметрами";
			this.buttonQueryWithParameters.UseVisualStyleBackColor = true;
			this.buttonQueryWithParameters.Click += new System.EventHandler(this.buttonQueryWithParameters_Click);
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(181, 327);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(400, 20);
			this.textBoxCity.TabIndex = 8;
			this.textBoxCity.Text = "London";
			// 
			// sqlCommandQueryWithParameters
			// 
			this.sqlCommandQueryWithParameters.CommandText = "SELECT        CustomerID, CompanyName, City\r\nFROM            Customers\r\nWHERE    " +
    "    (City = @City)";
			this.sqlCommandQueryWithParameters.Connection = this.sqlConnectionToLocalDB;
			this.sqlCommandQueryWithParameters.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
			// 
			// textBoxResultQueryWithParmeters
			// 
			this.textBoxResultQueryWithParmeters.Location = new System.Drawing.Point(181, 354);
			this.textBoxResultQueryWithParmeters.Multiline = true;
			this.textBoxResultQueryWithParmeters.Name = "textBoxResultQueryWithParmeters";
			this.textBoxResultQueryWithParmeters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResultQueryWithParmeters.Size = new System.Drawing.Size(400, 50);
			this.textBoxResultQueryWithParmeters.TabIndex = 9;
			// 
			// buttonCallSpWithParameters
			// 
			this.buttonCallSpWithParameters.Location = new System.Drawing.Point(12, 417);
			this.buttonCallSpWithParameters.Name = "buttonCallSpWithParameters";
			this.buttonCallSpWithParameters.Size = new System.Drawing.Size(137, 40);
			this.buttonCallSpWithParameters.TabIndex = 10;
			this.buttonCallSpWithParameters.Text = "Процедура с параметрами";
			this.buttonCallSpWithParameters.UseVisualStyleBackColor = true;
			this.buttonCallSpWithParameters.Click += new System.EventHandler(this.buttonCallSpWithParameters_Click);
			// 
			// textBoxCategoryName
			// 
			this.textBoxCategoryName.Location = new System.Drawing.Point(181, 417);
			this.textBoxCategoryName.Name = "textBoxCategoryName";
			this.textBoxCategoryName.Size = new System.Drawing.Size(116, 20);
			this.textBoxCategoryName.TabIndex = 11;
			this.textBoxCategoryName.Text = "Beverages";
			// 
			// textBoxOrdYear
			// 
			this.textBoxOrdYear.Location = new System.Drawing.Point(325, 417);
			this.textBoxOrdYear.Name = "textBoxOrdYear";
			this.textBoxOrdYear.Size = new System.Drawing.Size(129, 20);
			this.textBoxOrdYear.TabIndex = 12;
			this.textBoxOrdYear.Text = "1997";
			// 
			// sqlCommandCallSpWithParameters
			// 
			this.sqlCommandCallSpWithParameters.CommandText = "SalesByCategory";
			this.sqlCommandCallSpWithParameters.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlCommandCallSpWithParameters.Connection = this.sqlConnectionToLocalDB;
			this.sqlCommandCallSpWithParameters.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
			// 
			// textBoxResultCallSpWithParameters
			// 
			this.textBoxResultCallSpWithParameters.Location = new System.Drawing.Point(181, 454);
			this.textBoxResultCallSpWithParameters.Multiline = true;
			this.textBoxResultCallSpWithParameters.Name = "textBoxResultCallSpWithParameters";
			this.textBoxResultCallSpWithParameters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResultCallSpWithParameters.Size = new System.Drawing.Size(400, 70);
			this.textBoxResultCallSpWithParameters.TabIndex = 13;
			// 
			// DBCommand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 632);
			this.Controls.Add(this.textBoxResultCallSpWithParameters);
			this.Controls.Add(this.textBoxOrdYear);
			this.Controls.Add(this.textBoxCategoryName);
			this.Controls.Add(this.buttonCallSpWithParameters);
			this.Controls.Add(this.textBoxResultQueryWithParmeters);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.buttonQueryWithParameters);
			this.Controls.Add(this.buttonCreateTable);
			this.Controls.Add(this.textBoxResultStoredProcedure);
			this.Controls.Add(this.buttonInvokeStoredProcedure);
			this.Controls.Add(this.textBoxResultPacketQuery);
			this.Controls.Add(this.buttonPacketQuery);
			this.Controls.Add(this.textBoxResultFromQuery);
			this.Controls.Add(this.buttonQueryData);
			this.Name = "DBCommand";
			this.Text = "Работа с БД";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Data.SqlClient.SqlConnection sqlConnectionToLocalDB;
		private System.Data.SqlClient.SqlCommand sqlCommandWorkWithDB;
		private System.Windows.Forms.Button buttonQueryData;
		private System.Windows.Forms.TextBox textBoxResultFromQuery;
		private System.Windows.Forms.Button buttonPacketQuery;
		private System.Windows.Forms.TextBox textBoxResultPacketQuery;
		private System.Windows.Forms.Button buttonInvokeStoredProcedure;
		private System.Data.SqlClient.SqlCommand sqlCommandInvokeStoredProcedure;
		private System.Windows.Forms.TextBox textBoxResultStoredProcedure;
		private System.Windows.Forms.Button buttonCreateTable;
		private System.Data.SqlClient.SqlCommand sqlCommandCreateTable;
		private System.Windows.Forms.Button buttonQueryWithParameters;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Data.SqlClient.SqlCommand sqlCommandQueryWithParameters;
		private System.Windows.Forms.TextBox textBoxResultQueryWithParmeters;
		private System.Windows.Forms.Button buttonCallSpWithParameters;
		private System.Windows.Forms.TextBox textBoxCategoryName;
		private System.Windows.Forms.TextBox textBoxOrdYear;
		private System.Data.SqlClient.SqlCommand sqlCommandCallSpWithParameters;
		private System.Windows.Forms.TextBox textBoxResultCallSpWithParameters;
	}
}

