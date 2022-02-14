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
		
		public DBConnection()          // конструктор формы DBConnection
		{
			InitializeComponent();
			this.connection.StateChange += new StateChangeEventHandler(this.Connection_StateChange);
		}

		public static string GetConnectionStringByName(string name)
		{
			string returnValue = null;
			ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
			if (settings != null)
				returnValue = settings.ConnectionString;
			return returnValue;
		}

		string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");	 // обращение к App.config 

		SqlConnection connection = new SqlConnection();


		// действие по нажатию кнопки подключиться к БД
		private void ToolStripMenuItemConnectToDB_Click(object sender, EventArgs e)
		{
			try
			{
				if (connection.State != ConnectionState.Open)
				{
					connection.ConnectionString = connectionString;
					connection.Open();
					MessageBox.Show("Соединение с БД " + connection.Database + " выполнено успешно." + "\nСервер: " + connection.DataSource);
				}
				else
					MessageBox.Show("Соединение с БД уже установлено");
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
					MessageBox.Show("Соединение с БД " + connection.Database + " выполнено успешно." + "\nСервер: " + connection.DataSource);
				}
				else
					MessageBox.Show("Соединение с БД уже установлено");
			}
			catch  (Exception Xcp)
			{
				MessageBox.Show(Xcp.Message, "Непредвиденное исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// действие при StateChange - делает ненужные пункты меню недоступными
		private void Connection_StateChange(object sender, StateChangeEventArgs e)
		{
			ToolStripMenuItemConnectToDB.Enabled = (e.CurrentState == ConnectionState.Closed);
			ToolStripMenuItemOpenAsyncConnectionToBD.Enabled = (e.CurrentState == ConnectionState.Closed);
			ToolStripMenuItemDisconnectFromDB.Enabled = (e.CurrentState == ConnectionState.Open);
		}

		// действие по нажатию кнопки Список Подключений
		private void ToolStripMenuItemListOfConnections_Click(object sender, EventArgs e)
		{
			ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
			if (settings != null)
			{
				foreach (ConnectionStringSettings cs in settings)
				{
					string str = String.Format("Name = {0}\nProviderName = {1}\nConnectionString = {2}", cs.Name, cs.ProviderName, cs.ConnectionString); 
					MessageBox.Show(str, "Параметры подключений");
				}
			}
		}

		// практика 2, упражнение 1. Получение скалярного значения
		// действие по нажатию кнопки для получения данных из базы
		private void buttonHowManyProducts_Click(object sender, EventArgs e)
		{
			if(connection.State == ConnectionState.Closed)
			{
				MessageBox.Show("Сначала подключитесь к БД");
			}

			using (connection)         // практика 2, упражнение 1. Использование USING для автоматического закрытия подключения при завершении программы
			{
				SqlCommand command = new SqlCommand();
				command.Connection = connection;
				command.CommandText = "USE [Northwind] SELECT COUNT(*) FROM [dbo].[Products]"; // передаем запрос SQL серверу 
				try
				{
					int number = (int)command.ExecuteScalar();
					labelResultOfHowManyProducts.Text = number.ToString();
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			
		}

		// вызов запрос отдельным классом
		private void buttonInvokeWorkWithDataBaseMethod_Click(object sender, EventArgs e)
		{
			try
			{
				int number = WorkWithDataBase.ExecuteScalarMethod(connectionString, "USE [Northwind] SELECT COUNT(*) FROM [dbo].[Products]");
				labelResultFromClass.Text = number.ToString();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// вызов запрос к БД с отображением в Listview
		private void buttonGetListOfProducts_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					SqlCommand command = new SqlCommand("USE [Northwind] SELECT [ProductName], [UnitPrice], [QuantityPerUnit] FROM [dbo].[Products]", connection);
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						ListViewItem newItem = 
						listViewProducts.Items.Add(reader["ProductName"].ToString());	// считывание по названию столбца
						newItem.SubItems.Add(reader.GetDecimal(1).ToString());			// считывание по индексу столбца, без преобразования
						newItem.SubItems.Add(reader["QuantityPerUnit"].ToString());
					}
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// практика 2, упраженение 03.
		// выполнение транзакции по нажатию на кнопку Транзакция 
		private void buttonTransaction_Click(object sender, EventArgs e)
		{
			 using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlTransaction sqlTran = connection.BeginTransaction();
				SqlCommand command = connection.CreateCommand();
				command.Transaction = sqlTran;
				try
				{
					command.CommandText = "USE [Northwind] INSERT INTO [Products] ([ProductName], [UnitPrice], [QuantityPerUnit]) VALUES('Wrong size', 12, '1 boxes')"; command.ExecuteNonQuery();
					command.CommandText = "USE [Northwind] INSERT INTO[Products] ([ProductName], [UnitPrice], [QuantityPerUnit]) VALUES('Wrong color', 25, '100 ml')"; command.ExecuteNonQuery();
					sqlTran.Commit();
					MessageBox.Show("Строки записаны в базу данных");
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					try
					{
						sqlTran.Rollback();
					}
					catch (Exception exRollback)
					{
						MessageBox.Show(exRollback.Message);
					}
				}
			}
		}
	}
}
