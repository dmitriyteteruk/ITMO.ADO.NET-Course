
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
			this.buttonQueryData = new System.Windows.Forms.Button();
			this.textBoxResultFromQuery = new System.Windows.Forms.TextBox();
			this.sqlConnectionToLocalDB = new System.Data.SqlClient.SqlConnection();
			this.buttonPacketQuery = new System.Windows.Forms.Button();
			this.textBoxResultPacketQuery = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// sqlCommandWorkWithDB
			// 
			this.sqlCommandWorkWithDB.Connection = this.sqlConnectionToLocalDB;
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
			this.textBoxResultFromQuery.Size = new System.Drawing.Size(400, 138);
			this.textBoxResultFromQuery.TabIndex = 1;
			// 
			// sqlConnectionToLocalDB
			// 
			this.sqlConnectionToLocalDB.ConnectionString = global::ITMO.ADO.NET_Practice03_DBCommand.Properties.Settings.Default.LocalDB;
			this.sqlConnectionToLocalDB.FireInfoMessageEventOnUserErrors = false;
			// 
			// buttonPacketQuery
			// 
			this.buttonPacketQuery.Location = new System.Drawing.Point(13, 169);
			this.buttonPacketQuery.Name = "buttonPacketQuery";
			this.buttonPacketQuery.Size = new System.Drawing.Size(137, 23);
			this.buttonPacketQuery.TabIndex = 2;
			this.buttonPacketQuery.Text = "Пакетный запрос";
			this.buttonPacketQuery.UseVisualStyleBackColor = true;
			this.buttonPacketQuery.Click += new System.EventHandler(this.buttonPacketQuery_Click);
			// 
			// textBoxResultPacketQuery
			// 
			this.textBoxResultPacketQuery.Location = new System.Drawing.Point(181, 169);
			this.textBoxResultPacketQuery.Multiline = true;
			this.textBoxResultPacketQuery.Name = "textBoxResultPacketQuery";
			this.textBoxResultPacketQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxResultPacketQuery.Size = new System.Drawing.Size(400, 124);
			this.textBoxResultPacketQuery.TabIndex = 3;
			// 
			// DBCommand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

