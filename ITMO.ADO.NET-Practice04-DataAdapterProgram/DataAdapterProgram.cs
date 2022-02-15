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

namespace ITMO.ADO.NET_Practice04_DataAdapterProgram
{
	public partial class DataAdapterProgram : Form
	{
		static SqlConnection NorthwindConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
		static string queryAllCustomers = "use [Northwind ]SELECT * FROM [dbo].[Customers]";
		static SqlDataAdapter SqlDataAdapterQuery = new SqlDataAdapter(queryAllCustomers, NorthwindConnection);

		DataSet NorthwindDataset = new DataSet("Northwind");

		SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapterQuery);
		
		public DataAdapterProgram()
		{
			InitializeComponent();
		}

		private void DataAdapterProgram_Load(object sender, EventArgs e)
		{
			SqlDataAdapterQuery.Fill(NorthwindDataset, "Customers");
			dataGridView.DataSource = NorthwindDataset.Tables["Customers"];
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			NorthwindDataset.EndInit();
			SqlDataAdapterQuery.Update(NorthwindDataset.Tables["Customers"]);
		}

		private void buttonAddRow_Click(object sender, EventArgs e)
		{
			NorthwindDataset.EndInit();
			DataRow CustRow = NorthwindDataset.Tables["Customers"].NewRow();
			Object[] CustRecord = { "AAAAA", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", null, "12209", "Germany", "030-0074321", "030-0076545" }; 
			CustRow.ItemArray = CustRecord; NorthwindDataset.Tables["Customers"].Rows.Add(CustRow);
			SqlDataAdapterQuery.Update(NorthwindDataset.Tables["Customers"]);
		}

		private void buttonDeleteRow_Click(object sender, EventArgs e)
		{
			NorthwindDataset.EndInit();
			var index = dataGridView.CurrentRow.Index; 
			NorthwindDataset.Tables["Customers"].Rows[index].Delete();
			SqlDataAdapterQuery.Update(NorthwindDataset.Tables["Customers"]);
		}
	}
}
