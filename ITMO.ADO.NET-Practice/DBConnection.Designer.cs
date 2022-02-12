
namespace ITMO.ADO.NET_Practice01_Ex01
{
	partial class DBConnection
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
			this.menuStripWorkWithDB = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItemConnectToDB = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemDisconnectFromDB = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemOpenAsyncConnectionToBD = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemListOfConnections = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonHowManyProducts = new System.Windows.Forms.Button();
			this.labelResultOfHowManyProducts = new System.Windows.Forms.Label();
			this.buttonInvokeWorkWithDataBaseMethod = new System.Windows.Forms.Button();
			this.labelResultFromClass = new System.Windows.Forms.Label();
			this.buttonGetListOfProducts = new System.Windows.Forms.Button();
			this.listViewProducts = new System.Windows.Forms.ListView();
			this.columnHeaderProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderQuantiryPerUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonTransaction = new System.Windows.Forms.Button();
			this.menuStripWorkWithDB.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripWorkWithDB
			// 
			this.menuStripWorkWithDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnectToDB,
            this.ToolStripMenuItemDisconnectFromDB,
            this.ToolStripMenuItemOpenAsyncConnectionToBD,
            this.ToolStripMenuItemListOfConnections});
			this.menuStripWorkWithDB.Location = new System.Drawing.Point(0, 0);
			this.menuStripWorkWithDB.Name = "menuStripWorkWithDB";
			this.menuStripWorkWithDB.Size = new System.Drawing.Size(800, 24);
			this.menuStripWorkWithDB.TabIndex = 0;
			this.menuStripWorkWithDB.Text = "Работа с базой данных";
			// 
			// ToolStripMenuItemConnectToDB
			// 
			this.ToolStripMenuItemConnectToDB.Name = "ToolStripMenuItemConnectToDB";
			this.ToolStripMenuItemConnectToDB.Size = new System.Drawing.Size(128, 20);
			this.ToolStripMenuItemConnectToDB.Text = "Подключиться к БД";
			this.ToolStripMenuItemConnectToDB.Click += new System.EventHandler(this.ToolStripMenuItemConnectToDB_Click);
			// 
			// ToolStripMenuItemDisconnectFromDB
			// 
			this.ToolStripMenuItemDisconnectFromDB.Name = "ToolStripMenuItemDisconnectFromDB";
			this.ToolStripMenuItemDisconnectFromDB.Size = new System.Drawing.Size(126, 20);
			this.ToolStripMenuItemDisconnectFromDB.Text = "Отключиться от БД";
			this.ToolStripMenuItemDisconnectFromDB.Click += new System.EventHandler(this.ToolStripMenuItemDisconnectFromDB_Click);
			// 
			// ToolStripMenuItemOpenAsyncConnectionToBD
			// 
			this.ToolStripMenuItemOpenAsyncConnectionToBD.Name = "ToolStripMenuItemOpenAsyncConnectionToBD";
			this.ToolStripMenuItemOpenAsyncConnectionToBD.Size = new System.Drawing.Size(200, 20);
			this.ToolStripMenuItemOpenAsyncConnectionToBD.Text = "Асинхронное подключение к БД";
			this.ToolStripMenuItemOpenAsyncConnectionToBD.Click += new System.EventHandler(this.ToolStripMenuItemOpenAsyncConnectionToBD_Click);
			// 
			// ToolStripMenuItemListOfConnections
			// 
			this.ToolStripMenuItemListOfConnections.Name = "ToolStripMenuItemListOfConnections";
			this.ToolStripMenuItemListOfConnections.Size = new System.Drawing.Size(142, 20);
			this.ToolStripMenuItemListOfConnections.Text = "Список Подключений";
			this.ToolStripMenuItemListOfConnections.Click += new System.EventHandler(this.ToolStripMenuItemListOfConnections_Click);
			// 
			// buttonHowManyProducts
			// 
			this.buttonHowManyProducts.Location = new System.Drawing.Point(12, 47);
			this.buttonHowManyProducts.Name = "buttonHowManyProducts";
			this.buttonHowManyProducts.Size = new System.Drawing.Size(146, 23);
			this.buttonHowManyProducts.TabIndex = 1;
			this.buttonHowManyProducts.Text = "Сколько продуктов";
			this.buttonHowManyProducts.UseVisualStyleBackColor = true;
			this.buttonHowManyProducts.Click += new System.EventHandler(this.buttonHowManyProducts_Click);
			// 
			// labelResultOfHowManyProducts
			// 
			this.labelResultOfHowManyProducts.AutoSize = true;
			this.labelResultOfHowManyProducts.Location = new System.Drawing.Point(196, 52);
			this.labelResultOfHowManyProducts.Name = "labelResultOfHowManyProducts";
			this.labelResultOfHowManyProducts.Size = new System.Drawing.Size(0, 13);
			this.labelResultOfHowManyProducts.TabIndex = 2;
			// 
			// buttonInvokeWorkWithDataBaseMethod
			// 
			this.buttonInvokeWorkWithDataBaseMethod.Location = new System.Drawing.Point(13, 96);
			this.buttonInvokeWorkWithDataBaseMethod.Name = "buttonInvokeWorkWithDataBaseMethod";
			this.buttonInvokeWorkWithDataBaseMethod.Size = new System.Drawing.Size(145, 45);
			this.buttonInvokeWorkWithDataBaseMethod.TabIndex = 3;
			this.buttonInvokeWorkWithDataBaseMethod.Text = "Сколько продуктов (через отдельный класс)";
			this.buttonInvokeWorkWithDataBaseMethod.UseVisualStyleBackColor = true;
			this.buttonInvokeWorkWithDataBaseMethod.Click += new System.EventHandler(this.buttonInvokeWorkWithDataBaseMethod_Click);
			// 
			// labelResultFromClass
			// 
			this.labelResultFromClass.AutoSize = true;
			this.labelResultFromClass.Location = new System.Drawing.Point(184, 112);
			this.labelResultFromClass.Name = "labelResultFromClass";
			this.labelResultFromClass.Size = new System.Drawing.Size(0, 13);
			this.labelResultFromClass.TabIndex = 4;
			// 
			// buttonGetListOfProducts
			// 
			this.buttonGetListOfProducts.Location = new System.Drawing.Point(12, 163);
			this.buttonGetListOfProducts.Name = "buttonGetListOfProducts";
			this.buttonGetListOfProducts.Size = new System.Drawing.Size(146, 23);
			this.buttonGetListOfProducts.TabIndex = 5;
			this.buttonGetListOfProducts.Text = "Список продуктов";
			this.buttonGetListOfProducts.UseVisualStyleBackColor = true;
			this.buttonGetListOfProducts.Click += new System.EventHandler(this.buttonGetListOfProducts_Click);
			// 
			// listViewProducts
			// 
			this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProductName,
            this.columnHeaderUnitPrice,
            this.columnHeaderQuantiryPerUnit});
			this.listViewProducts.HideSelection = false;
			this.listViewProducts.Location = new System.Drawing.Point(177, 163);
			this.listViewProducts.Name = "listViewProducts";
			this.listViewProducts.Size = new System.Drawing.Size(433, 127);
			this.listViewProducts.TabIndex = 6;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderProductName
			// 
			this.columnHeaderProductName.Text = "Название продукта";
			this.columnHeaderProductName.Width = 218;
			// 
			// columnHeaderUnitPrice
			// 
			this.columnHeaderUnitPrice.Text = "Цена";
			this.columnHeaderUnitPrice.Width = 87;
			// 
			// columnHeaderQuantiryPerUnit
			// 
			this.columnHeaderQuantiryPerUnit.Text = "Фасовка";
			this.columnHeaderQuantiryPerUnit.Width = 119;
			// 
			// buttonTransaction
			// 
			this.buttonTransaction.Location = new System.Drawing.Point(13, 302);
			this.buttonTransaction.Name = "buttonTransaction";
			this.buttonTransaction.Size = new System.Drawing.Size(145, 23);
			this.buttonTransaction.TabIndex = 7;
			this.buttonTransaction.Text = "Транзакция";
			this.buttonTransaction.UseVisualStyleBackColor = true;
			this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
			// 
			// DBConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonTransaction);
			this.Controls.Add(this.listViewProducts);
			this.Controls.Add(this.buttonGetListOfProducts);
			this.Controls.Add(this.labelResultFromClass);
			this.Controls.Add(this.buttonInvokeWorkWithDataBaseMethod);
			this.Controls.Add(this.labelResultOfHowManyProducts);
			this.Controls.Add(this.buttonHowManyProducts);
			this.Controls.Add(this.menuStripWorkWithDB);
			this.MainMenuStrip = this.menuStripWorkWithDB;
			this.Name = "DBConnection";
			this.Text = "Работа с базой данных";
			this.menuStripWorkWithDB.ResumeLayout(false);
			this.menuStripWorkWithDB.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripWorkWithDB;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnectToDB;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDisconnectFromDB;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenAsyncConnectionToBD;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemListOfConnections;
		private System.Windows.Forms.Button buttonHowManyProducts;
		private System.Windows.Forms.Label labelResultOfHowManyProducts;
		private System.Windows.Forms.Button buttonInvokeWorkWithDataBaseMethod;
		private System.Windows.Forms.Label labelResultFromClass;
		private System.Windows.Forms.Button buttonGetListOfProducts;
		private System.Windows.Forms.ListView listViewProducts;
		private System.Windows.Forms.ColumnHeader columnHeaderProductName;
		private System.Windows.Forms.ColumnHeader columnHeaderUnitPrice;
		private System.Windows.Forms.ColumnHeader columnHeaderQuantiryPerUnit;
		private System.Windows.Forms.Button buttonTransaction;
	}
}

