
namespace ITMO.ADO.NET_Practice_8._4_LINQsqlM
{
	partial class LINQsqlM
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
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Ten Most");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Unit Price");
			this.buttonShowTop10 = new System.Windows.Forms.Button();
			this.listView10Most = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// buttonShowTop10
			// 
			this.buttonShowTop10.Location = new System.Drawing.Point(13, 13);
			this.buttonShowTop10.Name = "buttonShowTop10";
			this.buttonShowTop10.Size = new System.Drawing.Size(236, 23);
			this.buttonShowTop10.TabIndex = 1;
			this.buttonShowTop10.Text = "10 лучших";
			this.buttonShowTop10.UseVisualStyleBackColor = true;
			this.buttonShowTop10.Click += new System.EventHandler(this.buttonShowTop10_Click);
			// 
			// listView10Most
			// 
			this.listView10Most.HideSelection = false;
			this.listView10Most.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
			this.listView10Most.Location = new System.Drawing.Point(13, 43);
			this.listView10Most.Name = "listView10Most";
			this.listView10Most.Size = new System.Drawing.Size(344, 395);
			this.listView10Most.TabIndex = 2;
			this.listView10Most.UseCompatibleStateImageBehavior = false;
			this.listView10Most.View = System.Windows.Forms.View.Tile;
			// 
			// LINQsqlM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 450);
			this.Controls.Add(this.listView10Most);
			this.Controls.Add(this.buttonShowTop10);
			this.Name = "LINQsqlM";
			this.Text = "Упражнение 8.4. Автоматическое создание объектов отображения с помощью Объектно-р" +
    "еляционного конструктора";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonShowTop10;
		private System.Windows.Forms.ListView listView10Most;
	}
}

