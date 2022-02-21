
namespace ITMO.ADO.NET_Practice_8._1_Linq2SQL
{
	partial class Linq2SQL
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
			this.listBoxLinq2SQL = new System.Windows.Forms.ListBox();
			this.buttonLoadData = new System.Windows.Forms.Button();
			this.buttonClearListBox = new System.Windows.Forms.Button();
			this.buttonAddObject = new System.Windows.Forms.Button();
			this.buttonDeleteObject = new System.Windows.Forms.Button();
			this.listViewFromSQL = new System.Windows.Forms.ListView();
			this.columnHeaderCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrdersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonOrdersDetailsToListView = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxLinq2SQL
			// 
			this.listBoxLinq2SQL.FormattingEnabled = true;
			this.listBoxLinq2SQL.Location = new System.Drawing.Point(13, 13);
			this.listBoxLinq2SQL.Name = "listBoxLinq2SQL";
			this.listBoxLinq2SQL.Size = new System.Drawing.Size(546, 212);
			this.listBoxLinq2SQL.TabIndex = 0;
			// 
			// buttonLoadData
			// 
			this.buttonLoadData.Location = new System.Drawing.Point(565, 13);
			this.buttonLoadData.Name = "buttonLoadData";
			this.buttonLoadData.Size = new System.Drawing.Size(226, 23);
			this.buttonLoadData.TabIndex = 1;
			this.buttonLoadData.Text = "Загрузка данных";
			this.buttonLoadData.UseVisualStyleBackColor = true;
			this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
			// 
			// buttonClearListBox
			// 
			this.buttonClearListBox.Location = new System.Drawing.Point(565, 43);
			this.buttonClearListBox.Name = "buttonClearListBox";
			this.buttonClearListBox.Size = new System.Drawing.Size(226, 23);
			this.buttonClearListBox.TabIndex = 2;
			this.buttonClearListBox.Text = "Очистить список";
			this.buttonClearListBox.UseVisualStyleBackColor = true;
			this.buttonClearListBox.Click += new System.EventHandler(this.buttonClearListBox_Click);
			// 
			// buttonAddObject
			// 
			this.buttonAddObject.Location = new System.Drawing.Point(565, 73);
			this.buttonAddObject.Name = "buttonAddObject";
			this.buttonAddObject.Size = new System.Drawing.Size(226, 23);
			this.buttonAddObject.TabIndex = 3;
			this.buttonAddObject.Text = "Добавить объект";
			this.buttonAddObject.UseVisualStyleBackColor = true;
			this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
			// 
			// buttonDeleteObject
			// 
			this.buttonDeleteObject.Location = new System.Drawing.Point(565, 102);
			this.buttonDeleteObject.Name = "buttonDeleteObject";
			this.buttonDeleteObject.Size = new System.Drawing.Size(226, 23);
			this.buttonDeleteObject.TabIndex = 4;
			this.buttonDeleteObject.Text = "Удалить объект";
			this.buttonDeleteObject.UseVisualStyleBackColor = true;
			this.buttonDeleteObject.Click += new System.EventHandler(this.buttonDeleteObject_Click);
			// 
			// listViewFromSQL
			// 
			this.listViewFromSQL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCustomerID,
            this.columnHeaderCity,
            this.columnHeaderOrdersCount});
			this.listViewFromSQL.HideSelection = false;
			this.listViewFromSQL.Location = new System.Drawing.Point(12, 240);
			this.listViewFromSQL.Name = "listViewFromSQL";
			this.listViewFromSQL.Size = new System.Drawing.Size(547, 205);
			this.listViewFromSQL.TabIndex = 5;
			this.listViewFromSQL.UseCompatibleStateImageBehavior = false;
			this.listViewFromSQL.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderCustomerID
			// 
			this.columnHeaderCustomerID.Text = "CustomerID";
			this.columnHeaderCustomerID.Width = 105;
			// 
			// columnHeaderCity
			// 
			this.columnHeaderCity.Text = "City";
			this.columnHeaderCity.Width = 82;
			// 
			// columnHeaderOrdersCount
			// 
			this.columnHeaderOrdersCount.Text = "OrdersCount";
			this.columnHeaderOrdersCount.Width = 103;
			// 
			// buttonOrdersDetailsToListView
			// 
			this.buttonOrdersDetailsToListView.Location = new System.Drawing.Point(565, 240);
			this.buttonOrdersDetailsToListView.Name = "buttonOrdersDetailsToListView";
			this.buttonOrdersDetailsToListView.Size = new System.Drawing.Size(226, 23);
			this.buttonOrdersDetailsToListView.TabIndex = 6;
			this.buttonOrdersDetailsToListView.Text = "Общее количество заказов";
			this.buttonOrdersDetailsToListView.UseVisualStyleBackColor = true;
			this.buttonOrdersDetailsToListView.Click += new System.EventHandler(this.buttonOrdersDetailsToListView_Click);
			// 
			// Linq2SQL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 457);
			this.Controls.Add(this.buttonOrdersDetailsToListView);
			this.Controls.Add(this.listViewFromSQL);
			this.Controls.Add(this.buttonDeleteObject);
			this.Controls.Add(this.buttonAddObject);
			this.Controls.Add(this.buttonClearListBox);
			this.Controls.Add(this.buttonLoadData);
			this.Controls.Add(this.listBoxLinq2SQL);
			this.Name = "Linq2SQL";
			this.Text = "Упражнение 8.1 и 8.2. ";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxLinq2SQL;
		private System.Windows.Forms.Button buttonLoadData;
		private System.Windows.Forms.Button buttonClearListBox;
		private System.Windows.Forms.Button buttonAddObject;
		private System.Windows.Forms.Button buttonDeleteObject;
		private System.Windows.Forms.ListView listViewFromSQL;
		private System.Windows.Forms.ColumnHeader columnHeaderCustomerID;
		private System.Windows.Forms.ColumnHeader columnHeaderCity;
		private System.Windows.Forms.ColumnHeader columnHeaderOrdersCount;
		private System.Windows.Forms.Button buttonOrdersDetailsToListView;
	}
}

