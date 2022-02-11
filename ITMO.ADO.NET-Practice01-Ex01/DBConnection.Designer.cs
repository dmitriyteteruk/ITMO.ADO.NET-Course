
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
			// DBConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

