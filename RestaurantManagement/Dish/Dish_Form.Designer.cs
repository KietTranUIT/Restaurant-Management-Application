
namespace RestaurantManagement
{
    partial class Dish_Form
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.calBtn = new System.Windows.Forms.Button();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listGroupDishs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listName = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.listGroupDishs)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(309, 350);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 34);
            this.exitBtn.TabIndex = 32;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(170, 350);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 34);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(40, 350);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 34);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Lưu";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(405, 64);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(103, 38);
            this.calBtn.TabIndex = 29;
            this.calBtn.Text = "Tính";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(170, 137);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(331, 31);
            this.nameTbox.TabIndex = 28;
            // 
            // idTbox
            // 
            this.idTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTbox.Location = new System.Drawing.Point(170, 69);
            this.idTbox.Name = "idTbox";
            this.idTbox.ReadOnly = true;
            this.idTbox.Size = new System.Drawing.Size(189, 31);
            this.idTbox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Thông tin món ăn";
            // 
            // listGroupDishs
            // 
            this.listGroupDishs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listGroupDishs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGroupDishs.Location = new System.Drawing.Point(545, 53);
            this.listGroupDishs.Name = "listGroupDishs";
            this.listGroupDishs.RowHeadersWidth = 62;
            this.listGroupDishs.RowTemplate.Height = 33;
            this.listGroupDishs.Size = new System.Drawing.Size(630, 347);
            this.listGroupDishs.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(789, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Đơn vị tính:";
            // 
            // unitTbox
            // 
            this.unitTbox.Location = new System.Drawing.Point(170, 209);
            this.unitTbox.Name = "unitTbox";
            this.unitTbox.Size = new System.Drawing.Size(133, 31);
            this.unitTbox.TabIndex = 34;
            this.unitTbox.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nhóm món ăn:";
            // 
            // listName
            // 
            this.listName.FormattingEnabled = true;
            this.listName.ItemHeight = 25;
            this.listName.Location = new System.Drawing.Point(197, 287);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(203, 29);
            this.listName.TabIndex = 36;
            // 
            // Dish_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 450);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unitTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listGroupDishs);
            this.Controls.Add(this.label1);
            this.Name = "Dish_Form";
            this.Text = "Dish_Form";
            this.Load += new System.EventHandler(this.Dish_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listGroupDishs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listGroupDishs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listName;
    }
}