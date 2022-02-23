// не работает "Реализация отношения «один ко многим»" стр 85 - не связываются заказы с заказчиками

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITMO.ADO.NET_Practice_9._2_CodeFirst;
using System.Data.Entity;

namespace ITMO.ADO.NET_Practice_9._2_CustomerManager
{
	public partial class CustomerViewer : Form
	{
		SampleContext context = new SampleContext();
		byte[] Ph; //

		public CustomerViewer()
		{
			InitializeComponent();
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
		}

		private void Output() 
			{ 
				if (this.radioButtonCustomer.Checked == true)  
					dataGridViewDetails.DataSource = context.Customers.ToList();
				else if (this.radioButtonOrder.Checked == true) 
					dataGridViewDetails.DataSource = context.Orders.ToList();
				else if (this.radioButtonVipOrder.Checked == true)
					dataGridViewDetails.DataSource = context.VipOrders.ToList();
		}


		private void buttonAddCustomerToDB_Click(object sender, EventArgs e)
		{
			try
			{
				
				Customer customer = new Customer
				{
					FirstName = this.textBoxCustomerFirstName.Text,
					LastName = this.textBoxCustomerSecondName.Text,
					Email = this.textBoxCustomerAddress.Text,
					Age = Int32.Parse(this.textBoxCustomerAge.Text),
					Photo = Ph,
					Orders = listBoxCustomerOrder.SelectedItems.OfType<Order>().ToList()
				};

				context.Customers.Add(customer);
				context.SaveChanges();
				Output();
				textBoxCustomerFirstName.Text = String.Empty;
				textBoxCustomerSecondName.Text = String.Empty;
				textBoxCustomerAddress.Text = String.Empty;
				textBoxCustomerAge.Text = String.Empty;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ошибка: " + ex.ToString());
			}
		}

		private void buttonCustomerPhotoFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog diag = new OpenFileDialog(); 
			if (diag.ShowDialog() == DialogResult.OK)
			{
				Image bm = new Bitmap(diag.OpenFile());
				ImageConverter converter = new ImageConverter(); Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
			}
		}

		private void buttonGetDataFromDB_Click(object sender, EventArgs e)
		{
			Output();
			var query = from b in context.Customers 
						orderby b.FirstName 
						select b;
			listBoxCustomerOrder.DataSource = query.ToList();
		}

		private void CustomerViewer_Load(object sender, EventArgs e)
		{
			{
				context.Orders.Add(new Order 
					{ 
						ProductName = "Аудио", 
						Quantity = 12, 
						PurchaseDate = DateTime.Parse("12.01.2016") 
					});
				context.Orders.Add(new Order 
					{ 
						ProductName = "Видео", 
						Quantity = 22, 
						PurchaseDate = DateTime.Parse("10.01.2016") 
					});

				context.VipOrders.Add(new VipOrder 
					{
						ProductName = "Авто",
						Quantity = 101, 
						PurchaseDate = DateTime.Parse("10.01.2016"), 
						status = "Высокий" });

				context.SaveChanges(); 
				
				listBoxCustomerOrder.DataSource = context.Orders.ToList();
			}
		}

		private void dataGridViewDetails_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewDetails.CurrentRow == null) return; 
			var customer = dataGridViewDetails.CurrentRow.DataBoundItem as Customer; 
			if (customer == null) return;

			labelId.Text = Convert.ToString(customer.CustomerId);
			textBoxCustomerId.Text = customer.ToString();
			textBoxCustomerFirstName.Text = customer.FirstName; 
			textBoxCustomerSecondName.Text = customer.LastName; 
			textBoxCustomerAddress.Text = customer.Email; 
			textBoxCustomerAge.Text = Convert.ToString(customer.Age);
		}

		private void buttonEditCustomerData_Click(object sender, EventArgs e)
		{
			if (labelId.Text == String.Empty) return;
			var id = Convert.ToInt32(labelId.Text); 
			var customer = context.Customers.Find(id); 
			if (customer == null) return;
			customer.FirstName = this.textBoxCustomerFirstName.Text;
			customer.LastName = this.textBoxCustomerSecondName.Text; 
			customer.Email = this.textBoxCustomerAddress.Text; 
			customer.Age = Int32.Parse(this.textBoxCustomerAge.Text);

			context.Entry(customer).State = EntityState.Modified;
			
			context.SaveChanges(); 
			Output();
		}

		private void buttonDeleteCustomerData_Click(object sender, EventArgs e)
		{
			if (labelId.Text == String.Empty) return;
			
			var id = Convert.ToInt32(labelId.Text); 
			var customer = context.Customers.Find(id);
			
			context.Entry(customer).State = EntityState.Deleted; 
			context.SaveChanges(); 
			Output();
		}
	}
}
