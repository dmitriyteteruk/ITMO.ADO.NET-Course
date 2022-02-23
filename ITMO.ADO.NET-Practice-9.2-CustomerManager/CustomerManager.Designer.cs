
namespace ITMO.ADO.NET_Practice_9._2_CustomerManager
{
	partial class CustomerViewer
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
			this.comboBoxCustomerList = new System.Windows.Forms.ComboBox();
			this.listBoxCustomerOrder = new System.Windows.Forms.ListBox();
			this.buttonAddCustomerToDB = new System.Windows.Forms.Button();
			this.buttonGetDataFromDB = new System.Windows.Forms.Button();
			this.buttonEditCustomerData = new System.Windows.Forms.Button();
			this.buttonDeleteCustomerData = new System.Windows.Forms.Button();
			this.groupBoxChooseData = new System.Windows.Forms.GroupBox();
			this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
			this.radioButtonOrder = new System.Windows.Forms.RadioButton();
			this.labelId = new System.Windows.Forms.Label();
			this.textBoxCustomerId = new System.Windows.Forms.TextBox();
			this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
			this.buttonCustomerPhotoFile = new System.Windows.Forms.Button();
			this.textBoxCustomerAge = new System.Windows.Forms.TextBox();
			this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
			this.textBoxCustomerSecondName = new System.Windows.Forms.TextBox();
			this.textBoxCustomerFirstName = new System.Windows.Forms.TextBox();
			this.labelCustomerPhoto = new System.Windows.Forms.Label();
			this.labelCustomerAge = new System.Windows.Forms.Label();
			this.labelCustomerAddress = new System.Windows.Forms.Label();
			this.labelCustomerSecondName = new System.Windows.Forms.Label();
			this.labelCustomerFirstName = new System.Windows.Forms.Label();
			this.groupBoxChooseData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxCustomerList
			// 
			this.comboBoxCustomerList.FormattingEnabled = true;
			this.comboBoxCustomerList.Location = new System.Drawing.Point(13, 13);
			this.comboBoxCustomerList.Name = "comboBoxCustomerList";
			this.comboBoxCustomerList.Size = new System.Drawing.Size(221, 21);
			this.comboBoxCustomerList.TabIndex = 0;
			// 
			// listBoxCustomerOrder
			// 
			this.listBoxCustomerOrder.FormattingEnabled = true;
			this.listBoxCustomerOrder.Location = new System.Drawing.Point(13, 41);
			this.listBoxCustomerOrder.Name = "listBoxCustomerOrder";
			this.listBoxCustomerOrder.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxCustomerOrder.Size = new System.Drawing.Size(221, 160);
			this.listBoxCustomerOrder.TabIndex = 1;
			// 
			// buttonAddCustomerToDB
			// 
			this.buttonAddCustomerToDB.Location = new System.Drawing.Point(512, 19);
			this.buttonAddCustomerToDB.Name = "buttonAddCustomerToDB";
			this.buttonAddCustomerToDB.Size = new System.Drawing.Size(102, 56);
			this.buttonAddCustomerToDB.TabIndex = 3;
			this.buttonAddCustomerToDB.Text = "Добавить данные";
			this.buttonAddCustomerToDB.UseVisualStyleBackColor = true;
			this.buttonAddCustomerToDB.Click += new System.EventHandler(this.buttonAddCustomerToDB_Click);
			// 
			// buttonGetDataFromDB
			// 
			this.buttonGetDataFromDB.Location = new System.Drawing.Point(629, 19);
			this.buttonGetDataFromDB.Name = "buttonGetDataFromDB";
			this.buttonGetDataFromDB.Size = new System.Drawing.Size(102, 56);
			this.buttonGetDataFromDB.TabIndex = 4;
			this.buttonGetDataFromDB.Text = "Показать данные";
			this.buttonGetDataFromDB.UseVisualStyleBackColor = true;
			this.buttonGetDataFromDB.Click += new System.EventHandler(this.buttonGetDataFromDB_Click);
			// 
			// buttonEditCustomerData
			// 
			this.buttonEditCustomerData.Location = new System.Drawing.Point(748, 18);
			this.buttonEditCustomerData.Name = "buttonEditCustomerData";
			this.buttonEditCustomerData.Size = new System.Drawing.Size(102, 23);
			this.buttonEditCustomerData.TabIndex = 5;
			this.buttonEditCustomerData.Text = "Редактировать";
			this.buttonEditCustomerData.UseVisualStyleBackColor = true;
			this.buttonEditCustomerData.Click += new System.EventHandler(this.buttonEditCustomerData_Click);
			// 
			// buttonDeleteCustomerData
			// 
			this.buttonDeleteCustomerData.Location = new System.Drawing.Point(748, 52);
			this.buttonDeleteCustomerData.Name = "buttonDeleteCustomerData";
			this.buttonDeleteCustomerData.Size = new System.Drawing.Size(102, 23);
			this.buttonDeleteCustomerData.TabIndex = 6;
			this.buttonDeleteCustomerData.Text = "Удалить";
			this.buttonDeleteCustomerData.UseVisualStyleBackColor = true;
			this.buttonDeleteCustomerData.Click += new System.EventHandler(this.buttonDeleteCustomerData_Click);
			// 
			// groupBoxChooseData
			// 
			this.groupBoxChooseData.Controls.Add(this.radioButtonOrder);
			this.groupBoxChooseData.Controls.Add(this.radioButtonCustomer);
			this.groupBoxChooseData.Location = new System.Drawing.Point(512, 101);
			this.groupBoxChooseData.Name = "groupBoxChooseData";
			this.groupBoxChooseData.Size = new System.Drawing.Size(338, 58);
			this.groupBoxChooseData.TabIndex = 7;
			this.groupBoxChooseData.TabStop = false;
			this.groupBoxChooseData.Text = "Выбор данных";
			// 
			// radioButtonCustomer
			// 
			this.radioButtonCustomer.AutoSize = true;
			this.radioButtonCustomer.Location = new System.Drawing.Point(14, 23);
			this.radioButtonCustomer.Name = "radioButtonCustomer";
			this.radioButtonCustomer.Size = new System.Drawing.Size(69, 17);
			this.radioButtonCustomer.TabIndex = 0;
			this.radioButtonCustomer.TabStop = true;
			this.radioButtonCustomer.Text = "Customer";
			this.radioButtonCustomer.UseVisualStyleBackColor = true;
			// 
			// radioButtonOrder
			// 
			this.radioButtonOrder.AutoSize = true;
			this.radioButtonOrder.Location = new System.Drawing.Point(117, 23);
			this.radioButtonOrder.Name = "radioButtonOrder";
			this.radioButtonOrder.Size = new System.Drawing.Size(51, 17);
			this.radioButtonOrder.TabIndex = 1;
			this.radioButtonOrder.TabStop = true;
			this.radioButtonOrder.Text = "Order";
			this.radioButtonOrder.UseVisualStyleBackColor = true;
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Location = new System.Drawing.Point(512, 181);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(18, 13);
			this.labelId.TabIndex = 8;
			this.labelId.Text = "ID";
			// 
			// textBoxCustomerId
			// 
			this.textBoxCustomerId.Location = new System.Drawing.Point(547, 177);
			this.textBoxCustomerId.Name = "textBoxCustomerId";
			this.textBoxCustomerId.Size = new System.Drawing.Size(303, 20);
			this.textBoxCustomerId.TabIndex = 9;
			// 
			// dataGridViewDetails
			// 
			this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewDetails.Location = new System.Drawing.Point(0, 213);
			this.dataGridViewDetails.Name = "dataGridViewDetails";
			this.dataGridViewDetails.Size = new System.Drawing.Size(875, 216);
			this.dataGridViewDetails.TabIndex = 10;
			this.dataGridViewDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetails_CellClick);
			// 
			// buttonCustomerPhotoFile
			// 
			this.buttonCustomerPhotoFile.Location = new System.Drawing.Point(330, 145);
			this.buttonCustomerPhotoFile.Name = "buttonCustomerPhotoFile";
			this.buttonCustomerPhotoFile.Size = new System.Drawing.Size(147, 23);
			this.buttonCustomerPhotoFile.TabIndex = 20;
			this.buttonCustomerPhotoFile.Text = "Выберите файл";
			this.buttonCustomerPhotoFile.UseVisualStyleBackColor = true;
			this.buttonCustomerPhotoFile.Click += new System.EventHandler(this.buttonCustomerPhotoFile_Click);
			// 
			// textBoxCustomerAge
			// 
			this.textBoxCustomerAge.Location = new System.Drawing.Point(330, 114);
			this.textBoxCustomerAge.Name = "textBoxCustomerAge";
			this.textBoxCustomerAge.Size = new System.Drawing.Size(147, 20);
			this.textBoxCustomerAge.TabIndex = 19;
			// 
			// textBoxCustomerAddress
			// 
			this.textBoxCustomerAddress.Location = new System.Drawing.Point(330, 82);
			this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
			this.textBoxCustomerAddress.Size = new System.Drawing.Size(147, 20);
			this.textBoxCustomerAddress.TabIndex = 18;
			// 
			// textBoxCustomerSecondName
			// 
			this.textBoxCustomerSecondName.Location = new System.Drawing.Point(330, 50);
			this.textBoxCustomerSecondName.Name = "textBoxCustomerSecondName";
			this.textBoxCustomerSecondName.Size = new System.Drawing.Size(147, 20);
			this.textBoxCustomerSecondName.TabIndex = 17;
			// 
			// textBoxCustomerFirstName
			// 
			this.textBoxCustomerFirstName.Location = new System.Drawing.Point(330, 18);
			this.textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
			this.textBoxCustomerFirstName.Size = new System.Drawing.Size(147, 20);
			this.textBoxCustomerFirstName.TabIndex = 16;
			// 
			// labelCustomerPhoto
			// 
			this.labelCustomerPhoto.AutoSize = true;
			this.labelCustomerPhoto.Location = new System.Drawing.Point(259, 150);
			this.labelCustomerPhoto.Name = "labelCustomerPhoto";
			this.labelCustomerPhoto.Size = new System.Drawing.Size(35, 13);
			this.labelCustomerPhoto.TabIndex = 15;
			this.labelCustomerPhoto.Text = "Фото";
			// 
			// labelCustomerAge
			// 
			this.labelCustomerAge.AutoSize = true;
			this.labelCustomerAge.Location = new System.Drawing.Point(259, 118);
			this.labelCustomerAge.Name = "labelCustomerAge";
			this.labelCustomerAge.Size = new System.Drawing.Size(49, 13);
			this.labelCustomerAge.TabIndex = 14;
			this.labelCustomerAge.Text = "Возраст";
			// 
			// labelCustomerAddress
			// 
			this.labelCustomerAddress.AutoSize = true;
			this.labelCustomerAddress.Location = new System.Drawing.Point(259, 86);
			this.labelCustomerAddress.Name = "labelCustomerAddress";
			this.labelCustomerAddress.Size = new System.Drawing.Size(32, 13);
			this.labelCustomerAddress.TabIndex = 13;
			this.labelCustomerAddress.Text = "Email";
			// 
			// labelCustomerSecondName
			// 
			this.labelCustomerSecondName.AutoSize = true;
			this.labelCustomerSecondName.Location = new System.Drawing.Point(259, 54);
			this.labelCustomerSecondName.Name = "labelCustomerSecondName";
			this.labelCustomerSecondName.Size = new System.Drawing.Size(56, 13);
			this.labelCustomerSecondName.TabIndex = 12;
			this.labelCustomerSecondName.Text = "Фамилия";
			// 
			// labelCustomerFirstName
			// 
			this.labelCustomerFirstName.AutoSize = true;
			this.labelCustomerFirstName.Location = new System.Drawing.Point(259, 22);
			this.labelCustomerFirstName.Name = "labelCustomerFirstName";
			this.labelCustomerFirstName.Size = new System.Drawing.Size(29, 13);
			this.labelCustomerFirstName.TabIndex = 11;
			this.labelCustomerFirstName.Text = "Имя";
			// 
			// CustomerViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 429);
			this.Controls.Add(this.buttonCustomerPhotoFile);
			this.Controls.Add(this.textBoxCustomerAge);
			this.Controls.Add(this.textBoxCustomerAddress);
			this.Controls.Add(this.textBoxCustomerSecondName);
			this.Controls.Add(this.textBoxCustomerFirstName);
			this.Controls.Add(this.labelCustomerPhoto);
			this.Controls.Add(this.labelCustomerAge);
			this.Controls.Add(this.labelCustomerAddress);
			this.Controls.Add(this.labelCustomerSecondName);
			this.Controls.Add(this.labelCustomerFirstName);
			this.Controls.Add(this.dataGridViewDetails);
			this.Controls.Add(this.textBoxCustomerId);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.groupBoxChooseData);
			this.Controls.Add(this.buttonDeleteCustomerData);
			this.Controls.Add(this.buttonEditCustomerData);
			this.Controls.Add(this.buttonGetDataFromDB);
			this.Controls.Add(this.buttonAddCustomerToDB);
			this.Controls.Add(this.listBoxCustomerOrder);
			this.Controls.Add(this.comboBoxCustomerList);
			this.Name = "CustomerViewer";
			this.Text = "Упражнение 9.2. Использование Code-First (Customer Viewer)";
			this.Load += new System.EventHandler(this.CustomerViewer_Load);
			this.groupBoxChooseData.ResumeLayout(false);
			this.groupBoxChooseData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxCustomerList;
		private System.Windows.Forms.ListBox listBoxCustomerOrder;
		private System.Windows.Forms.Button buttonAddCustomerToDB;
		private System.Windows.Forms.Button buttonGetDataFromDB;
		private System.Windows.Forms.Button buttonEditCustomerData;
		private System.Windows.Forms.Button buttonDeleteCustomerData;
		private System.Windows.Forms.GroupBox groupBoxChooseData;
		private System.Windows.Forms.RadioButton radioButtonOrder;
		private System.Windows.Forms.RadioButton radioButtonCustomer;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.TextBox textBoxCustomerId;
		private System.Windows.Forms.DataGridView dataGridViewDetails;
		private System.Windows.Forms.Button buttonCustomerPhotoFile;
		private System.Windows.Forms.TextBox textBoxCustomerAge;
		private System.Windows.Forms.TextBox textBoxCustomerAddress;
		private System.Windows.Forms.TextBox textBoxCustomerSecondName;
		private System.Windows.Forms.TextBox textBoxCustomerFirstName;
		private System.Windows.Forms.Label labelCustomerPhoto;
		private System.Windows.Forms.Label labelCustomerAge;
		private System.Windows.Forms.Label labelCustomerAddress;
		private System.Windows.Forms.Label labelCustomerSecondName;
		private System.Windows.Forms.Label labelCustomerFirstName;
	}
}

