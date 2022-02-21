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

namespace ITMO.ADO.NET_Practice_8._1_LINQsql_1
{
	public partial class Form1 : Form
	{
		DataContext db;
		public Form1()
		{
			InitializeComponent();
			db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
		}

		private void buttonLoadData_Click(object sender, EventArgs e)
		{
			var results = from c in db.GetTable<Customer>()
						  where c.City == "London"
						  select c;
			foreach (var c in results)
				listBoxLinq2SQL.Items.Add(c.ToString());
		}
	}
}
