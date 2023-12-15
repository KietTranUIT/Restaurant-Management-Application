
namespace RestaurantManagement
{
    partial class Menu_Form
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
            ((System.ComponentModel.ISupportInitialize)(this.listGroupDishs)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(954, 364);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 34);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(836, 364);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 34);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(714, 364);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 34);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Lưu";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(942, 185);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(103, 38);
            this.calBtn.TabIndex = 18;
            this.calBtn.Text = "Tính";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(714, 296);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(331, 31);
            this.nameTbox.TabIndex = 17;
            // 
            // idTbox
            // 
            this.idTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTbox.Location = new System.Drawing.Point(714, 185);
            this.idTbox.Name = "idTbox";
            this.idTbox.ReadOnly = true;
            this.idTbox.Size = new System.Drawing.Size(189, 31);
            this.idTbox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(714, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên nhóm món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(714, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã nhóm món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(809, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thông tin nhóm món ăn";
            // 
            // listGroupDishs
            // 
            this.listGroupDishs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listGroupDishs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGroupDishs.Location = new System.Drawing.Point(129, 66);
            this.listGroupDishs.Name = "listGroupDishs";
            this.listGroupDishs.RowHeadersWidth = 62;
            this.listGroupDishs.RowTemplate.Height = 33;
            this.listGroupDishs.Size = new System.Drawing.Size(501, 347);
            this.listGroupDishs.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách nhóm món ăn";
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 450);
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
            this.Name = "Menu_Form";
            this.Text = "Menu_Form";
            this.Load += new System.EventHandler(this.Menu_Form_Load);
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
    }
}