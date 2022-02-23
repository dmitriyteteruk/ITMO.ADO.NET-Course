
namespace ITMO.ADO.NET_Practice_9._1_CourseManager
{
	partial class OfficeAssignment
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
			this.dataGridViewOffices = new System.Windows.Forms.DataGridView();
			this.buttonSaveChanges = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewOffices
			// 
			this.dataGridViewOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOffices.Location = new System.Drawing.Point(13, 13);
			this.dataGridViewOffices.Name = "dataGridViewOffices";
			this.dataGridViewOffices.Size = new System.Drawing.Size(775, 384);
			this.dataGridViewOffices.TabIndex = 0;
			// 
			// buttonSaveChanges
			// 
			this.buttonSaveChanges.Location = new System.Drawing.Point(12, 403);
			this.buttonSaveChanges.Name = "buttonSaveChanges";
			this.buttonSaveChanges.Size = new System.Drawing.Size(165, 35);
			this.buttonSaveChanges.TabIndex = 1;
			this.buttonSaveChanges.Text = "Update";
			this.buttonSaveChanges.UseVisualStyleBackColor = true;
			this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
			// 
			// OfficeAssignment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonSaveChanges);
			this.Controls.Add(this.dataGridViewOffices);
			this.Name = "OfficeAssignment";
			this.Text = "OfficeAssignment";
			this.Load += new System.EventHandler(this.OfficeAssignment_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewOffices;
		private System.Windows.Forms.Button buttonSaveChanges;
	}
}