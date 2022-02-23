using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET_Practice_9._1_CourseManager
{
	public partial class OfficeAssignment : Form
	{
		private SchoolEntities schoolContext;
		public OfficeAssignment()
		{
			InitializeComponent();
		}

		private void OfficeAssignment_Load(object sender, EventArgs e)
		{
			schoolContext = new SchoolEntities();
			var instrQuery = schoolContext.Person.OfType<Instructor>();
			dataGridViewOffices.DataSource = instrQuery.ToList();
			dataGridViewOffices.Columns["HireDate"].Visible = false;
			dataGridViewOffices.Columns["Timestamp"].Visible = false;
			dataGridViewOffices.Columns["PersonID"].Visible = false;
			dataGridViewOffices.Columns["EnrollmentDate"].Visible = false;
			dataGridViewOffices.Columns["StudentGrade"].Visible = false;
			dataGridViewOffices.Columns["Course"].Visible = false;
		}

		private void buttonSaveChanges_Click(object sender, EventArgs e)
		{
			schoolContext.SaveChanges();
			MessageBox.Show("Change(s) saved to the database.");
			Refresh();
		}
	}
}
