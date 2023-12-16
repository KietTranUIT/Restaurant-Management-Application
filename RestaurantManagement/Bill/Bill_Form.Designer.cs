
namespace RestaurantManagement
{
    partial class Bill_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameCustomerTbox = new System.Windows.Forms.TextBox();
            this.tableTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.createDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.nameStaffTbox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBillBtn = new System.Windows.Forms.Button();
            this.createBillBtn = new System.Windows.Forms.Button();
            this.listBills = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBills)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nameCustomerTbox);
            this.groupBox1.Controls.Add(this.tableTbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.createDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idTbox);
            this.groupBox1.Controls.Add(this.nameStaffTbox);
            this.groupBox1.Location = new System.Drawing.Point(49, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 660);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(64, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày lập:";
            // 
            // nameCustomerTbox
            // 
            this.nameCustomerTbox.Location = new System.Drawing.Point(261, 361);
            this.nameCustomerTbox.Name = "nameCustomerTbox";
            this.nameCustomerTbox.Size = new System.Drawing.Size(284, 31);
            this.nameCustomerTbox.TabIndex = 14;
            // 
            // tableTbox
            // 
            this.tableTbox.Location = new System.Drawing.Point(261, 453);
            this.tableTbox.Name = "tableTbox";
            this.tableTbox.Size = new System.Drawing.Size(284, 31);
            this.tableTbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã HĐ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(61, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nhân viên:";
            // 
            // createDate
            // 
            this.createDate.CustomFormat = "yyyy-MM-dd";
            this.createDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDate.Location = new System.Drawing.Point(261, 206);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(284, 31);
            this.createDate.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(64, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(64, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bàn ăn:";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(261, 131);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(284, 31);
            this.idTbox.TabIndex = 11;
            // 
            // nameStaffTbox
            // 
            this.nameStaffTbox.Location = new System.Drawing.Point(261, 280);
            this.nameStaffTbox.Name = "nameStaffTbox";
            this.nameStaffTbox.Size = new System.Drawing.Size(284, 31);
            this.nameStaffTbox.TabIndex = 15;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1378, 768);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 55);
            this.exitBtn.TabIndex = 25;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBillBtn
            // 
            this.deleteBillBtn.Location = new System.Drawing.Point(1066, 768);
            this.deleteBillBtn.Name = "deleteBillBtn";
            this.deleteBillBtn.Size = new System.Drawing.Size(112, 60);
            this.deleteBillBtn.TabIndex = 23;
            this.deleteBillBtn.Text = "Xóa hóa đơn";
            this.deleteBillBtn.UseVisualStyleBackColor = true;
            this.deleteBillBtn.Click += new System.EventHandler(this.deleteBillBtn_Click);
            // 
            // createBillBtn
            // 
            this.createBillBtn.Location = new System.Drawing.Point(215, 768);
            this.createBillBtn.Name = "createBillBtn";
            this.createBillBtn.Size = new System.Drawing.Size(112, 60);
            this.createBillBtn.TabIndex = 22;
            this.createBillBtn.Text = "Lập hóa đơn";
            this.createBillBtn.UseVisualStyleBackColor = true;
            this.createBillBtn.Click += new System.EventHandler(this.createBillBtn_Click);
            // 
            // listBills
            // 
            this.listBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBills.Location = new System.Drawing.Point(673, 39);
            this.listBills.Name = "listBills";
            this.listBills.RowHeadersWidth = 62;
            this.listBills.RowTemplate.Height = 33;
            this.listBills.Size = new System.Drawing.Size(817, 660);
            this.listBills.TabIndex = 21;
            this.listBills.SelectionChanged += new System.EventHandler(this.listBills_SelectionChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(673, -5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 41);
            this.label13.TabIndex = 20;
            this.label13.Text = "Danh sách hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(49, 765);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(112, 50);
            this.refreshBtn.TabIndex = 34;
            this.refreshBtn.Text = "Làm mới";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 768);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 60);
            this.button1.TabIndex = 35;
            this.button1.Text = "Chi tiết hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 880);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBillBtn);
            this.Controls.Add(this.createBillBtn);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "Bill_Form";
            this.Text = "Bill_Form";
            this.Load += new System.EventHandler(this.Bill_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameCustomerTbox;
        private System.Windows.Forms.TextBox tableTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker createDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.TextBox nameStaffTbox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBillBtn;
        private System.Windows.Forms.Button createBillBtn;
        private System.Windows.Forms.DataGridView listBills;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button button1;
    }
}