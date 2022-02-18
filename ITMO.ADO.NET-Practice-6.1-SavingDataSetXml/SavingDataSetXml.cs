using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET_Practice_6._1_SavingDataSetXml
{
	public partial class SavingDataSetXml : Form
	{
		public SavingDataSetXml()
		{
			InitializeComponent();
		}

		private void buttonFillDataSet_Click(object sender, EventArgs e)
		{
			sqlDataAdapterCustomers.Fill(dataSetNorthwind1.Customers);
			sqlDataAdapterOrders.Fill(dataSetNorthwind1.Orders);

			dataGridViewCustomers.DataSource = dataSetNorthwind1.Customers;
		}

		private void buttonSaveXmlData_Click(object sender, EventArgs e)
		{
			try
			{
				dataSetNorthwind1.WriteXml("Northwind.xml");
				MessageBox.Show("Data saved as XML");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void buttonSaveXmlSchema_Click(object sender, EventArgs e)
		{
			try
			{
				dataSetNorthwind1.WriteXmlSchema("Northwind.xsd");
				MessageBox.Show("Schema saved as XSD");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
