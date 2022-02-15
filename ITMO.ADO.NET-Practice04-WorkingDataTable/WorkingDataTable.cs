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

namespace ITMO.ADO.NET_Practice04_WorkingDataTable
{
	public partial class FormWorkingDataTable : Form
	{
		public FormWorkingDataTable()
		{
			InitializeComponent();
		}

		private DataSet1.CustomersRow GetSelectedRow()
		{
			String SelectedCustomerID = dataGridViewCustomersData.CurrentRow.Cells["CustomerID"].Value.ToString();
			DataSet1.CustomersRow SelectedRow =
			dataSetNorthwind.Customers.FindByCustomerID(SelectedCustomerID);
			return SelectedRow;
		}

		private void UpdateRowVersionDisplay()
		{
			try
			{
				textBoxCurrentDRV.Text = GetSelectedRow()[dataGridViewCustomersData.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
			}
			catch (Exception ex)
			{
				textBoxCurrentDRV.Text = ex.Message;
			}
			try
			{
				textBoxOriginalDRV.Text = GetSelectedRow()[dataGridViewCustomersData.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
			}
			catch (Exception ex)
			{
				textBoxOriginalDRV.Text = ex.Message;
			}

			textBoxRowState.Text = GetSelectedRow().RowState.ToString();


		}

		private void FormWorkingDataTable_Load(object sender, EventArgs e)
		{
			
			dataGridViewCustomersData.DataSource = dataSetNorthwind.Customers;
			dataGridViewCustomersData.MultiSelect = false;
			dataGridViewCustomersData.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridViewCustomersData.EditMode = DataGridViewEditMode.EditProgrammatically;
		}

		private void buttonFillTable_Click(object sender, EventArgs e)
		{
			sqlDataAdapter1.Fill(dataSetNorthwind.Customers);
		}

		private void buttonAddRow_Click(object sender, EventArgs e)
		{
			
			DataSet1.CustomersRow NewRow = (DataSet1.CustomersRow)dataSetNorthwind.Customers.NewRow();
			NewRow.CustomerID = "WINGT";
			NewRow.CompanyName = "Wingtip Toys";
			NewRow.ContactName = "Steve Lasker";
			NewRow.ContactTitle = "CEO";
			NewRow.Address = "1234 Main Street";
			NewRow.City = "Buffalo";
			NewRow.Region = "NY";
			NewRow.PostalCode = "98052";
			NewRow.Country = "USA";
			NewRow.Phone = "206-555-0111";
			NewRow.Fax = "206-555-0112";

			try
			{
				dataSetNorthwind.Customers.Rows.Add(NewRow);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Add Row Failed");
			}
		}

		private void buttonDeleteRow_Click(object sender, EventArgs e)
		{
			GetSelectedRow().Delete();

		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			GetSelectedRow()[dataGridViewCustomersData.CurrentCell.OwningColumn.Name] = textBoxCellValue.Text;
			UpdateRowVersionDisplay();
		}

		private void dataGridViewCustomersData_Click(object sender, EventArgs e)
		{
			textBoxCellValue.Text = dataGridViewCustomersData.CurrentCell.Value.ToString();
			UpdateRowVersionDisplay();
		}

		private void buttonAcceptChanges_Click(object sender, EventArgs e)
		{
			GetSelectedRow().AcceptChanges();
			UpdateRowVersionDisplay();
		}

		private void buttonRejectChanges_Click(object sender, EventArgs e)
		{
			GetSelectedRow().RejectChanges();
			UpdateRowVersionDisplay();
		}
	}
}
