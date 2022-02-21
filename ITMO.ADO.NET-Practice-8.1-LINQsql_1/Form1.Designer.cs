
namespace ITMO.ADO.NET_Practice_8._1_LINQsql_1
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
			this.listBoxLinq2SQL = new System.Windows.Forms.ListBox();
			this.buttonLoadData = new System.Windows.Forms.Button();
			this.buttonClearList = new System.Windows.Forms.Button();
			this.buttonAddObject = new System.Windows.Forms.Button();
			this.buttonDeleteObject = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxLinq2SQL
			// 
			this.listBoxLinq2SQL.FormattingEnabled = true;
			this.listBoxLinq2SQL.Location = new System.Drawing.Point(12, 13);
			this.listBoxLinq2SQL.Name = "listBoxLinq2SQL";
			this.listBoxLinq2SQL.Size = new System.Drawing.Size(640, 420);
			this.listBoxLinq2SQL.TabIndex = 0;
			// 
			// buttonLoadData
			// 
			this.buttonLoadData.Location = new System.Drawing.Point(669, 13);
			this.buttonLoadData.Name = "buttonLoadData";
			this.buttonLoadData.Size = new System.Drawing.Size(119, 23);
			this.buttonLoadData.TabIndex = 1;
			this.buttonLoadData.Text = "Загрузка данных";
			this.buttonLoadData.UseVisualStyleBackColor = true;
			this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
			// 
			// buttonClearList
			// 
			this.buttonClearList.Location = new System.Drawing.Point(669, 43);
			this.buttonClearList.Name = "buttonClearList";
			this.buttonClearList.Size = new System.Drawing.Size(119, 23);
			this.buttonClearList.TabIndex = 2;
			this.buttonClearList.Text = "Очистить список";
			this.buttonClearList.UseVisualStyleBackColor = true;
			// 
			// buttonAddObject
			// 
			this.buttonAddObject.Location = new System.Drawing.Point(669, 73);
			this.buttonAddObject.Name = "buttonAddObject";
			this.buttonAddObject.Size = new System.Drawing.Size(119, 23);
			this.buttonAddObject.TabIndex = 3;
			this.buttonAddObject.Text = "Добавить объект";
			this.buttonAddObject.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteObject
			// 
			this.buttonDeleteObject.Location = new System.Drawing.Point(669, 103);
			this.buttonDeleteObject.Name = "buttonDeleteObject";
			this.buttonDeleteObject.Size = new System.Drawing.Size(119, 23);
			this.buttonDeleteObject.TabIndex = 4;
			this.buttonDeleteObject.Text = "Удалить объект";
			this.buttonDeleteObject.UseVisualStyleBackColor = true;
			// 
			// LINQsql_1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonDeleteObject);
			this.Controls.Add(this.buttonAddObject);
			this.Controls.Add(this.buttonClearList);
			this.Controls.Add(this.buttonLoadData);
			this.Controls.Add(this.listBoxLinq2SQL);
			this.Name = "LINQsql_1";
			this.Text = "Упражнение 8.1. Linq2SQL - Создание объектной модели";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxLinq2SQL;
		private System.Windows.Forms.Button buttonLoadData;
		private System.Windows.Forms.Button buttonClearList;
		private System.Windows.Forms.Button buttonAddObject;
		private System.Windows.Forms.Button buttonDeleteObject;
	}
}

