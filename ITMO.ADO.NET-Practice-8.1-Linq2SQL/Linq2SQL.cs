using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ITMO.ADO.NET_Practice_8._1_Linq2SQL
{
	public partial class Linq2SQL : Form
	{
		DataContext db;

		public Linq2SQL()
		{
			InitializeComponent();
			db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
		}

		public string City = "London";
		public void buttonLoadData_Click(object sender, EventArgs e)
		{
			// очистим список перед загрузкой всех данных заново
			listBoxLinq2SQL.Items.Clear();

			// загружаем все данные
			var results = from c in db.GetTable<Customer>()
						  where c.City == City
						  select c;
			foreach (var c in results)
				listBoxLinq2SQL.Items.Add(c.ToString());

			
			MessageBox.Show($"Данные с параметром City = {City} загружены");
		}

		private void buttonClearListBox_Click(object sender, EventArgs e)
		{
			listBoxLinq2SQL.Items.Clear();
			MessageBox.Show("Список очищен, данные в базе не изменены.");
		}

		private void buttonAddObject_Click(object sender, EventArgs e)
		{
			Customer cust = new Customer();
			cust.CustomerID = "WINGT";
			cust.City = "London";
			cust.CompanyName = "Steve Lasker";
			db.GetTable<Customer>().InsertOnSubmit(cust);
			db.SubmitChanges();
			
			MessageBox.Show("В БД добавлен новый объект.");

		}

		private void buttonDeleteObject_Click(object sender, EventArgs e)
		{
			var deleteIndivCust =
				from cust in db.GetTable<Customer>()
				where cust.CustomerID == "WINGT"
				select cust;

			if (deleteIndivCust.Count() > 0)
			{
				db.GetTable<Customer>().DeleteOnSubmit(deleteIndivCust.First());
				db.SubmitChanges();
			}
			
			MessageBox.Show("Объект удален из БД");
		}

		private void buttonOrdersDetailsToListView_Click(object sender, EventArgs e)
		{
			// очистим список перед загрузкой всех данных заново
			listViewFromSQL.Items.Clear();

			var custQuery =
				from cust in db.GetTable<Customer>()
				where cust.Orders.Any()
				select cust;
					foreach (var custObj in custQuery)
					{
						ListViewItem item =
						listViewFromSQL.Items.Add(custObj.CustomerID.ToString());
						item.SubItems.Add(custObj.City.ToString());
						item.SubItems.Add(custObj.Orders.Count.ToString());
					}
		}
	}
}
