
namespace RestaurantManagement.Bill
{
    partial class AddBill_Form
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
            this.calBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nameCustomerTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.createDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listStaff = new System.Windows.Forms.ComboBox();
            this.listTable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listTable);
            this.groupBox1.Controls.Add(this.listStaff);
            this.groupBox1.Controls.Add(this.calBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nameCustomerTbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.createDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idTbox);
            this.groupBox1.Location = new System.Drawing.Point(170, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 660);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(446, 128);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(99, 34);
            this.calBtn.TabIndex = 16;
            this.calBtn.Text = "Tính";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
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
            this.idTbox.Size = new System.Drawing.Size(144, 31);
            this.idTbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lập hóa đơn";
            // 
            // listStaff
            // 
            this.listStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listStaff.FormattingEnabled = true;
            this.listStaff.Location = new System.Drawing.Point(261, 278);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(182, 33);
            this.listStaff.TabIndex = 18;
            // 
            // listTable
            // 
            this.listTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listTable.FormattingEnabled = true;
            this.listTable.Location = new System.Drawing.Point(261, 451);
            this.listTable.Name = "listTable";
            this.listTable.Size = new System.Drawing.Size(182, 33);
            this.listTable.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tạo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 793);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddBill_Form";
            this.Text = "AddBill_Form";
            this.Load += new System.EventHandler(this.AddBill_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameCustomerTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker createDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listTable;
        private System.Windows.Forms.ComboBox listStaff;
        private System.Windows.Forms.Button button1;
    }
}