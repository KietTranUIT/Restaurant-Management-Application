
namespace RestaurantManagement.Bill
{
    partial class BillDetail_Form
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
            this.listDish = new System.Windows.Forms.ComboBox();
            this.countTbox = new System.Windows.Forms.TextBox();
            this.priceTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.listBills = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTbox = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBills)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.listDish);
            this.groupBox1.Controls.Add(this.countTbox);
            this.groupBox1.Controls.Add(this.priceTbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idTbox);
            this.groupBox1.Location = new System.Drawing.Point(6, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 479);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // listDish
            // 
            this.listDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDish.FormattingEnabled = true;
            this.listDish.Location = new System.Drawing.Point(261, 208);
            this.listDish.Name = "listDish";
            this.listDish.Size = new System.Drawing.Size(231, 33);
            this.listDish.TabIndex = 17;
            // 
            // countTbox
            // 
            this.countTbox.Location = new System.Drawing.Point(261, 348);
            this.countTbox.Name = "countTbox";
            this.countTbox.Size = new System.Drawing.Size(284, 31);
            this.countTbox.TabIndex = 16;
            // 
            // priceTbox
            // 
            this.priceTbox.Location = new System.Drawing.Point(261, 282);
            this.priceTbox.Name = "priceTbox";
            this.priceTbox.Size = new System.Drawing.Size(284, 31);
            this.priceTbox.TabIndex = 14;
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
            this.label12.Location = new System.Drawing.Point(61, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tên món ăn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(64, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đơn giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(64, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lượng:";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(261, 131);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(284, 31);
            this.idTbox.TabIndex = 11;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1335, 634);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 55);
            this.exitBtn.TabIndex = 41;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(820, 634);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 60);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(630, 634);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 60);
            this.addBtn.TabIndex = 39;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // listBills
            // 
            this.listBills.AllowUserToAddRows = false;
            this.listBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBills.Location = new System.Drawing.Point(630, 105);
            this.listBills.Name = "listBills";
            this.listBills.RowHeadersWidth = 62;
            this.listBills.RowTemplate.Height = 33;
            this.listBills.Size = new System.Drawing.Size(817, 479);
            this.listBills.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(559, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 36;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tổng tiền:";
            // 
            // totalTbox
            // 
            this.totalTbox.Location = new System.Drawing.Point(103, 663);
            this.totalTbox.Name = "totalTbox";
            this.totalTbox.Size = new System.Drawing.Size(275, 31);
            this.totalTbox.TabIndex = 45;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(1022, 634);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(112, 60);
            this.printBtn.TabIndex = 46;
            this.printBtn.Text = "In hóa đơn";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // BillDetail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 762);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.totalTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.label1);
            this.Name = "BillDetail_Form";
            this.Text = "BillDetail_Form";
            this.Load += new System.EventHandler(this.BillDetail_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox countTbox;
        private System.Windows.Forms.TextBox priceTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView listBills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalTbox;
        private System.Windows.Forms.ComboBox listDish;
        private System.Windows.Forms.Button printBtn;
    }
}