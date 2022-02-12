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

namespace ITMO.ADO.NET_Practice03_DBCommand
{
	public partial class DBCommand : Form
	{
		public DBCommand()
		{
			InitializeComponent();
		}

		private void buttonQueryData_Click(object sender, EventArgs e)
		{
			StringBuilder results = new StringBuilder();
			using (sqlConnectionToLocalDB)
			{
				try
				{
					sqlConnectionToLocalDB.Open();
					SqlDataReader reader = sqlCommandWorkWithDB.ExecuteReader();
					while (reader.Read())
					{
						for (int i = 0; i < reader.FieldCount; i++)
						{
							results.Append(reader[i].ToString() + "\t");
						}
						results.Append(Environment.NewLine);
					}

					textBoxResultFromQuery.Text = results.ToString();
				}

				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}
		}

		private void buttonPacketQuery_Click(object sender, EventArgs e)
		{
			StringBuilder results = new StringBuilder();
			using (sqlConnectionToLocalDB)
			{
				sqlCommandWorkWithDB.CommandText = "USE [Northwind] SELECT ProductName, UnitPrice, QuantityPerUnit FROM [dbo].[Products];" + "USE [Northwind] SELECT CustomerID, CompanyName FROM [dbo].[Customers];";

				try
				{
					sqlConnectionToLocalDB.Open();
					SqlDataReader reader = sqlCommandWorkWithDB.ExecuteReader();
					
					bool MoreResults = false;

					do
					{
						while (reader.Read())
						{
							for (int i = 0; i < reader.FieldCount; i++)
							{
								results.Append(reader[i].ToString() + "\t");
							}
							results.Append(Environment.NewLine);
						}
						MoreResults = reader.NextResult();

					} while (MoreResults);

					textBoxResultPacketQuery.Text = results.ToString();
				}

				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}
		}

		private void buttonInvokeStoredProcedure_Click(object sender, EventArgs e)
		{
			StringBuilder results = new StringBuilder(); 
			using (sqlConnectionToLocalDB)
			{
				try
				{
					sqlConnectionToLocalDB.Open(); 
					SqlDataReader reader = sqlCommandInvokeStoredProcedure.ExecuteReader();
						while (reader.Read()) 
						{ 
							for (int i = 0; i < reader.FieldCount; i++) 
								{ 
									results.Append(reader[i].ToString() + "\t"); 
								} 
									results.Append(Environment.NewLine); }
					
					textBoxResultStoredProcedure.Text = results.ToString();
				}
				catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			}
		}
	}
}
