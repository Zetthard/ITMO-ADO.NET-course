
namespace CustomerManager
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
            this.listBoxOrderList = new System.Windows.Forms.ListBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomers = new System.Windows.Forms.RadioButton();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCustomerList
            // 
            this.comboBoxCustomerList.FormattingEnabled = true;
            this.comboBoxCustomerList.Location = new System.Drawing.Point(12, 45);
            this.comboBoxCustomerList.Name = "comboBoxCustomerList";
            this.comboBoxCustomerList.Size = new System.Drawing.Size(255, 33);
            this.comboBoxCustomerList.TabIndex = 0;
            // 
            // listBoxOrderList
            // 
            this.listBoxOrderList.FormattingEnabled = true;
            this.listBoxOrderList.ItemHeight = 25;
            this.listBoxOrderList.Location = new System.Drawing.Point(12, 88);
            this.listBoxOrderList.Name = "listBoxOrderList";
            this.listBoxOrderList.Size = new System.Drawing.Size(255, 179);
            this.listBoxOrderList.TabIndex = 1;
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(429, 208);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(156, 58);
            this.buttonChooseFile.TabIndex = 2;
            this.buttonChooseFile.Text = "Выбрать файл";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(429, 159);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(156, 31);
            this.textBoxAge.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(429, 29);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(156, 31);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(429, 73);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(156, 31);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(429, 116);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(156, 31);
            this.textBoxAddress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Фото";
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(706, 29);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(156, 94);
            this.buttonAddData.TabIndex = 12;
            this.buttonAddData.Text = "Добавить данные";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(886, 29);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(156, 94);
            this.buttonShowData.TabIndex = 13;
            this.buttonShowData.Text = "Показать данные";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(1066, 29);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(176, 42);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1066, 81);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(176, 42);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOrders);
            this.groupBox1.Controls.Add(this.radioButtonCustomers);
            this.groupBox1.Location = new System.Drawing.Point(707, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(315, 37);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(108, 29);
            this.radioButtonOrders.TabIndex = 1;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Orders";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomers
            // 
            this.radioButtonCustomers.AutoSize = true;
            this.radioButtonCustomers.Location = new System.Drawing.Point(47, 37);
            this.radioButtonCustomers.Name = "radioButtonCustomers";
            this.radioButtonCustomers.Size = new System.Drawing.Size(146, 29);
            this.radioButtonCustomers.TabIndex = 0;
            this.radioButtonCustomers.TabStop = true;
            this.radioButtonCustomers.Text = "Customers";
            this.radioButtonCustomers.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(774, 235);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(467, 31);
            this.textBoxCustomerId.TabIndex = 17;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(716, 239);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 25);
            this.labelId.TabIndex = 18;
            this.labelId.Text = "ID";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 287);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 82;
            this.dataGridViewData.RowTemplate.Height = 33;
            this.dataGridViewData.Size = new System.Drawing.Size(1254, 459);
            this.dataGridViewData.TabIndex = 19;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 746);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonAddData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.listBoxOrderList);
            this.Controls.Add(this.comboBoxCustomerList);
            this.Name = "CustomerViewer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CustomerViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomerList;
        private System.Windows.Forms.ListBox listBoxOrderList;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonCustomers;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataGridViewData;
    }
}

