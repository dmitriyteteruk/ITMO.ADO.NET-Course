
namespace ITMO.ADO.NET_Practice_9._1_CourseManager
{
	partial class CourseViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxDepartmentList = new System.Windows.Forms.ComboBox();
			this.buttonCloseForm = new System.Windows.Forms.Button();
			this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
			this.buttonSaveChanges = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxDepartmentList
			// 
			this.comboBoxDepartmentList.FormattingEnabled = true;
			this.comboBoxDepartmentList.Location = new System.Drawing.Point(9, 13);
			this.comboBoxDepartmentList.Name = "comboBoxDepartmentList";
			this.comboBoxDepartmentList.Size = new System.Drawing.Size(220, 21);
			this.comboBoxDepartmentList.TabIndex = 0;
			this.comboBoxDepartmentList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartmentList_SelectedIndexChanged);
			// 
			// buttonCloseForm
			// 
			this.buttonCloseForm.Location = new System.Drawing.Point(9, 140);
			this.buttonCloseForm.Name = "buttonCloseForm";
			this.buttonCloseForm.Size = new System.Drawing.Size(220, 23);
			this.buttonCloseForm.TabIndex = 1;
			this.buttonCloseForm.Text = "Закрыть";
			this.buttonCloseForm.UseVisualStyleBackColor = true;
			this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
			// 
			// dataGridViewCourse
			// 
			this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCourse.Location = new System.Drawing.Point(239, 13);
			this.dataGridViewCourse.Name = "dataGridViewCourse";
			this.dataGridViewCourse.Size = new System.Drawing.Size(549, 150);
			this.dataGridViewCourse.TabIndex = 2;
			// 
			// buttonSaveChanges
			// 
			this.buttonSaveChanges.Location = new System.Drawing.Point(9, 111);
			this.buttonSaveChanges.Name = "buttonSaveChanges";
			this.buttonSaveChanges.Size = new System.Drawing.Size(220, 23);
			this.buttonSaveChanges.TabIndex = 3;
			this.buttonSaveChanges.Text = "Обновить";
			this.buttonSaveChanges.UseVisualStyleBackColor = true;
			this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(220, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Показать офисы";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// CourseViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonSaveChanges);
			this.Controls.Add(this.dataGridViewCourse);
			this.Controls.Add(this.buttonCloseForm);
			this.Controls.Add(this.comboBoxDepartmentList);
			this.Name = "CourseViewer";
			this.Text = "Упражнение 9.1. Построение EDM для работы с базой данных (Course Viewer)";
			this.Load += new System.EventHandler(this.CourseViewer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxDepartmentList;
		private System.Windows.Forms.Button buttonCloseForm;
		private System.Windows.Forms.DataGridView dataGridViewCourse;
		private System.Windows.Forms.Button buttonSaveChanges;
		private System.Windows.Forms.Button button1;
	}
}

