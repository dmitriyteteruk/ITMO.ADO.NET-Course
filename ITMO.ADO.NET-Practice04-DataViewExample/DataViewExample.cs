using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET_Practice04_DataViewExample
{
	public partial class DataViewExample : Form
	{
		public DataViewExample()
		{
			InitializeComponent();
		}

		DataView customersDataView;
		DataView ordersDataView;

		private void DataViewExample_Load(object sender, EventArgs e)
		{
			customersTableAdapter1.Fill(northwindDataSet1.Customers);
			ordersTableAdapter1.Fill(northwindDataSet1.Orders);

			customersDataView = new DataView(northwindDataSet1.Customers); 
			ordersDataView = new DataView(northwindDataSet1.Orders);

			customersDataView.Sort = "CustomerID";

			GridViewCustomers.DataSource = customersDataView;
		}

		private void buttonSetDataViewProperties_Click(object sender, EventArgs e)
		{
			customersDataView.Sort = textBoxSort.Text;
			customersDataView.RowFilter = textBoxFilter.Text;
		}

		private void buttonAddRow_Click(object sender, EventArgs e)
		{
			DataRowView newCustomRow = customersDataView.AddNew();
			newCustomRow["CustomerID"] = "WINGT";
			newCustomRow["CompanyName"] = "Wing Tip Toys";

			newCustomRow.EndEdit();
		}

		private void buttonGetOrders_Click(object sender, EventArgs e)
		{
			string selectedCustomerID = (string)GridViewCustomers.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
			DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomerID)];
			ordersDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
			dataGridViewOrders.DataSource = ordersDataView;
		}
	}
}
