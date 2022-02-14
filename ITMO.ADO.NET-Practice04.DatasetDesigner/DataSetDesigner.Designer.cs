
namespace ITMO.ADO.NET_Practice04.DatasetDesigner
{
	partial class DataSetDesigner
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
			this.buttonGetCustomers = new System.Windows.Forms.Button();
			this.listBoxCustomers = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonGetCustomers
			// 
			this.buttonGetCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonGetCustomers.Location = new System.Drawing.Point(13, 13);
			this.buttonGetCustomers.Name = "buttonGetCustomers";
			this.buttonGetCustomers.Size = new System.Drawing.Size(338, 44);
			this.buttonGetCustomers.TabIndex = 0;
			this.buttonGetCustomers.Text = "Получить список клиентов";
			this.buttonGetCustomers.UseVisualStyleBackColor = true;
			this.buttonGetCustomers.Click += new System.EventHandler(this.buttonGetCustomers_Click);
			// 
			// listBoxCustomers
			// 
			this.listBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxCustomers.FormattingEnabled = true;
			this.listBoxCustomers.ItemHeight = 20;
			this.listBoxCustomers.Location = new System.Drawing.Point(13, 73);
			this.listBoxCustomers.Name = "listBoxCustomers";
			this.listBoxCustomers.Size = new System.Drawing.Size(338, 364);
			this.listBoxCustomers.TabIndex = 1;
			// 
			// DataSetDesigner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 450);
			this.Controls.Add(this.listBoxCustomers);
			this.Controls.Add(this.buttonGetCustomers);
			this.Name = "DataSetDesigner";
			this.Text = "Практическое занятие 4. Создание объектов DataSet";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonGetCustomers;
		private System.Windows.Forms.ListBox listBoxCustomers;
	}
}

