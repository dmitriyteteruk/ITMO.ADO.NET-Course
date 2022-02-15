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

namespace ITMO.ADO.NET_Practice_04_DataAdapterWizard
{
	public partial class DataAdapterWizard : Form
	{
		public DataAdapterWizard()
		{
			InitializeComponent();
		}

		private void DataAdapterWizard_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = dataSetNorthwind.Customers;
			sqlDataAdapter1.Fill(dataSetNorthwind.Customers);
		}

		private void buttonUpdateDataInDB_Click(object sender, EventArgs e)
		{
			sqlDataAdapter1.Update(dataSetNorthwind);
		}

		private void sqlDataAdapter1_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
		{
			DataSetGenerated.CustomersRow CustRow = (DataSetGenerated.CustomersRow)e.Row;
			DialogResult response = MessageBox.Show("Continue updating " + CustRow.CustomerID.ToString() + "?", "Continue Update?", MessageBoxButtons.YesNo);
			if (response == DialogResult.No)
			{
				e.Status = UpdateStatus.SkipCurrentRow;
			}
		}

		private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			DataSetGenerated.CustomersRow CustRow = (DataSetGenerated.CustomersRow)e.Row;
			MessageBox.Show(CustRow.CustomerID.ToString() + " has been updated");

			dataSetNorthwind.Customers.Clear();
			sqlDataAdapter1.Fill(dataSetNorthwind.Customers);
		}

		private void sqlDataAdapter1_FillError(object sender, FillErrorEventArgs e)
		{
			DialogResult response = MessageBox.Show
				("The following error occurred while Filling the DataSet: " + e.Errors.Message.ToString() +
				 " Continue attempting to fill?", "FillError Encountered", MessageBoxButtons.YesNo);

			if (response == DialogResult.Yes)
			{
				e.Continue = true;
			}
			else
			{
				e.Continue = false;
			}
		}
	}
}
