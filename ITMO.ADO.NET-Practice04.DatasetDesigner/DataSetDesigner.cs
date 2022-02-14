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

namespace ITMO.ADO.NET_Practice04.DatasetDesigner
{
	public partial class DataSetDesigner : Form
	{
		public DataSetDesigner()
		{
			InitializeComponent();
		}

		private void buttonGetCustomers_Click(object sender, EventArgs e)
		{
			NorthwindDataSet northwindDataSet = new NorthwindDataSet();
			NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
			customersTableAdapter.Fill(northwindDataSet.Customers);
			
			foreach(NorthwindDataSet.CustomersRow NWCustomer in northwindDataSet.Customers.Rows)
			{
				listBoxCustomers.Items.Add(NWCustomer.CompanyName);
			}
		}
	}
}
