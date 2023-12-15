
namespace RestaurantManagement
{
    partial class Staff_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.addressTbox = new System.Windows.Forms.TextBox();
            this.phoneTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.user_idTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startTbox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.birthTbox = new System.Windows.Forms.DateTimePicker();
            this.salaryTbox = new System.Windows.Forms.TextBox();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manOpt = new System.Windows.Forms.RadioButton();
            this.womenOpt = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.listStaffs = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.name_searchTbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortTypes = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listStaffs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // addressTbox
            // 
            this.addressTbox.Location = new System.Drawing.Point(203, 402);
            this.addressTbox.Name = "addressTbox";
            this.addressTbox.Size = new System.Drawing.Size(284, 31);
            this.addressTbox.TabIndex = 14;
            // 
            // phoneTbox
            // 
            this.phoneTbox.Location = new System.Drawing.Point(203, 477);
            this.phoneTbox.Name = "phoneTbox";
            this.phoneTbox.Size = new System.Drawing.Size(284, 31);
            this.phoneTbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giới tính:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "CCCD:";
            // 
            // user_idTbox
            // 
            this.user_idTbox.Location = new System.Drawing.Point(203, 328);
            this.user_idTbox.Name = "user_idTbox";
            this.user_idTbox.Size = new System.Drawing.Size(284, 31);
            this.user_idTbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh:";
            // 
            // startTbox
            // 
            this.startTbox.CustomFormat = "yyyy-MM-dd";
            this.startTbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTbox.Location = new System.Drawing.Point(203, 541);
            this.startTbox.Name = "startTbox";
            this.startTbox.Size = new System.Drawing.Size(284, 31);
            this.startTbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Địa chỉ:";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(203, 38);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(284, 31);
            this.idTbox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 28);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày vào làm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 616);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 28);
            this.label11.TabIndex = 9;
            this.label11.Text = "Lương:";
            // 
            // birthTbox
            // 
            this.birthTbox.CustomFormat = "yyyy-MM-dd";
            this.birthTbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthTbox.Location = new System.Drawing.Point(203, 179);
            this.birthTbox.Name = "birthTbox";
            this.birthTbox.Size = new System.Drawing.Size(284, 31);
            this.birthTbox.TabIndex = 13;
            // 
            // salaryTbox
            // 
            this.salaryTbox.Location = new System.Drawing.Point(203, 613);
            this.salaryTbox.Name = "salaryTbox";
            this.salaryTbox.Size = new System.Drawing.Size(284, 31);
            this.salaryTbox.TabIndex = 15;
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(203, 107);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(284, 31);
            this.nameTbox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manOpt);
            this.panel1.Controls.Add(this.womenOpt);
            this.panel1.Location = new System.Drawing.Point(203, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 54);
            this.panel1.TabIndex = 16;
            // 
            // manOpt
            // 
            this.manOpt.AutoSize = true;
            this.manOpt.Location = new System.Drawing.Point(3, 9);
            this.manOpt.Name = "manOpt";
            this.manOpt.Size = new System.Drawing.Size(75, 29);
            this.manOpt.TabIndex = 14;
            this.manOpt.TabStop = true;
            this.manOpt.Text = "Nam";
            this.manOpt.UseVisualStyleBackColor = true;
            // 
            // womenOpt
            // 
            this.womenOpt.AutoSize = true;
            this.womenOpt.Location = new System.Drawing.Point(114, 11);
            this.womenOpt.Name = "womenOpt";
            this.womenOpt.Size = new System.Drawing.Size(61, 29);
            this.womenOpt.TabIndex = 15;
            this.womenOpt.TabStop = true;
            this.womenOpt.Text = "Nữ";
            this.womenOpt.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(653, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 41);
            this.label13.TabIndex = 2;
            this.label13.Text = "Danh sách nhân viên";
            // 
            // listStaffs
            // 
            this.listStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStaffs.Location = new System.Drawing.Point(653, 75);
            this.listStaffs.Name = "listStaffs";
            this.listStaffs.RowHeadersWidth = 62;
            this.listStaffs.RowTemplate.Height = 33;
            this.listStaffs.Size = new System.Drawing.Size(817, 660);
            this.listStaffs.TabIndex = 3;
            this.listStaffs.SelectionChanged += new System.EventHandler(this.listStaffs_SelectionChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(650, 835);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 34);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(799, 835);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(950, 835);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(112, 34);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Sửa";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1355, 835);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 34);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1197, 835);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(112, 34);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Làm mới";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(650, 777);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 34);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // name_searchTbox
            // 
            this.name_searchTbox.Location = new System.Drawing.Point(799, 780);
            this.name_searchTbox.Name = "name_searchTbox";
            this.name_searchTbox.Size = new System.Drawing.Size(263, 31);
            this.name_searchTbox.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(799, 752);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "Tên:";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(1197, 785);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(112, 34);
            this.sortBtn.TabIndex = 14;
            this.sortBtn.Text = "Sắp xếp";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortTypes
            // 
            this.sortTypes.FormattingEnabled = true;
            this.sortTypes.ItemHeight = 25;
            this.sortTypes.Items.AddRange(new object[] {
            "Tên NV",
            "Ngày sinh",
            "Ngày vào làm",
            "Lương"});
            this.sortTypes.Location = new System.Drawing.Point(1327, 785);
            this.sortTypes.Name = "sortTypes";
            this.sortTypes.Size = new System.Drawing.Size(140, 29);
            this.sortTypes.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1327, 757);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "Kiểu:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addressTbox);
            this.groupBox1.Controls.Add(this.phoneTbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.birthTbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.startTbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.user_idTbox);
            this.groupBox1.Controls.Add(this.nameTbox);
            this.groupBox1.Controls.Add(this.idTbox);
            this.groupBox1.Controls.Add(this.salaryTbox);
            this.groupBox1.Location = new System.Drawing.Point(29, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 660);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Staff_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1516, 899);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.sortTypes);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.name_searchTbox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listStaffs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "Staff_Form";
            this.Text = "Staff_Form";
            this.Load += new System.EventHandler(this.Staff_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listStaffs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox addressTbox;
        private System.Windows.Forms.TextBox phoneTbox;
        private System.Windows.Forms.TextBox user_idTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker birthTbox;
        private System.Windows.Forms.TextBox salaryTbox;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton manOpt;
        private System.Windows.Forms.RadioButton womenOpt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView listStaffs;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox name_searchTbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ListBox sortTypes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}