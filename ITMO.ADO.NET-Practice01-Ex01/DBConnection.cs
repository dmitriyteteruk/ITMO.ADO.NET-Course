using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace ITMO.ADO.NET_Practice01_Ex01
{
	public partial class DBConnection : Form
	{
		public DBConnection()
		{
			InitializeComponent();
			this.connection.StateChange += new StateChangeEventHandler(this.Connection_StateChange);
		}

		SqlConnection connection = new SqlConnection();
		string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";




		// действие по нажатию кнопки подключиться к БД
		private void ToolStripMenuItemConnectToDB_Click(object sender, EventArgs e)
		{
			try
			{
				if (connection.State != ConnectionState.Open)
				{
					connection.ConnectionString = connectionString;
					connection.Open();
					MessageBox.Show("Соединение с БД " + connection.Database + " выполненено успешно." + "\nСервер: " + connection.DataSource);
				}
				else
					MessageBox.Show("Соединенеи с БД уже установлено");
			}

			catch (SqlException XcpSQL)
			{
				  foreach (SqlError se in XcpSQL.Errors)
				{
					MessageBox.Show(se.Message, "Источник ошибки: " + se.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// действие по нажатию кнопки отключиться от БД
		private void ToolStripMenuItemDisconnectFromDB_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Open)
			{
				connection.Close();
				MessageBox.Show("Соединение с БД закрыто");
			}
			else
				MessageBox.Show("Соединение с БД уже закрыто");
		}


		// действие по нажатию кнопки асинхронного подключения
		private async void ToolStripMenuItemOpenAsyncConnectionToBD_Click(object sender, EventArgs e)
		{
			try
			{
				if (connection.State != ConnectionState.Open)
				{
					connection.ConnectionString = connectionString;
					await connection.OpenAsync();
					MessageBox.Show("Соединение с БД " + connection.Database + " выполненено успешно." + "\nСервер: " + connection.DataSource);
				}
				else
					MessageBox.Show("Соединенеи с БД уже установлено");
			}
			catch  (Exception Xcp)
			{
				MessageBox.Show(Xcp.Message, "Непредвиденное исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// обработчик сообытия StateChange - делает ненужные пункты меню недоступными
		private void Connection_StateChange(object sender, StateChangeEventArgs e)
		{
			ToolStripMenuItemConnectToDB.Enabled = (e.CurrentState == ConnectionState.Closed);
			ToolStripMenuItemOpenAsyncConnectionToBD.Enabled = (e.CurrentState == ConnectionState.Closed);
			ToolStripMenuItemDisconnectFromDB.Enabled = (e.CurrentState == ConnectionState.Open);
		}
	}
}
