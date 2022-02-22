﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ITMO.ADO.NET_Practice_9._1_CourseManager
{
	public partial class CourseViewer : Form
	{
		private SchoolEntities schoolContext;
		public CourseViewer()
		{
			InitializeComponent();

		}

		private void CourseViewer_Load(object sender, EventArgs e)
		{
			schoolContext = new SchoolEntities();

			var departments = from d in schoolContext.Department.Include("Courses") 
							  orderby d.Name
							  select d;
			try
			{
				this.comboBoxDepartmentList.DisplayMember = "Name";
				this.comboBoxDepartmentList.DataSource = departments.ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBoxDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Department department = (Department)this.comboBoxDepartmentList.SelectedItem;

				dataGridViewCourse.DataSource = department.Course.ToList();

				dataGridViewCourse.Columns["Department"].Visible = false;
				dataGridViewCourse.Columns["StudentGrades"].Visible = false;
				dataGridViewCourse.Columns["OnlineCourse"].Visible = false;
				dataGridViewCourse.Columns["OnsiteCourse"].Visible = false;
				dataGridViewCourse.Columns["People"].Visible = false;
				dataGridViewCourse.Columns["DepartmentId"].Visible = false;
				dataGridViewCourse.AllowUserToDeleteRows = false;
				dataGridViewCourse.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
