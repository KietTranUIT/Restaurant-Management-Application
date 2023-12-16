using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManagement.Bill
{
    public partial class AddBill_Form : Form
    {
        Database db;
        public AddBill_Form(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            string query = Statement.getBillTotalSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);

            idTbox.Text = "HD" + (bill.countBill(command) + 1).ToString("D4");
        }

        private void AddBill_Form_Load(object sender, EventArgs e)
        {
            string query1 = Statement.getNameStaff;
            MySqlCommand command1 = new MySqlCommand(query1, db.con);
            List<string> data_staff = bill.getNameStaff(command1);

            // Thêm từng mục từ danh sách vào ListBox
            foreach (string item in data_staff)
            {
                listStaff.Items.Add(item);
            }

            string query2 = Statement.getNameTable;
            MySqlCommand command2 = new MySqlCommand(query2, db.con);
            List<string> data_table = bill.getNameTable(command2);

            // Thêm từng mục từ danh sách vào ListBox
            foreach (string item in data_table)
            {
                listTable.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_staff = "";
            if (listStaff.SelectedItem != null)
            {
                name_staff = listStaff.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tên nhân viên! Vui lòng chọn rồi thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string q1 = string.Format(Statement.getIdStaff, name_staff);
            MySqlCommand c1 = new MySqlCommand(q1, db.con);
            string staff_id = bill.execCommand(c1);

            string name_table = "";
            if (listTable.SelectedItem != null)
            {
                name_table = listTable.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tên bàn! Vui lòng chọn rồi thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string q2 = string.Format(Statement.getIdTable, name_table);
            MySqlCommand c2 = new MySqlCommand(q2, db.con);
            string table_id = bill.execCommand(c2);

            string id = idTbox.Text;
            string create_date = createDate.Text;
            string customer_name = nameCustomerTbox.Text;

            if (id == "" || customer_name == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin cho hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insert = string.Format(Statement.insertBillSQL, id, create_date, 0, table_id, staff_id, customer_name, "Chưa in hóa đơn");
            Error err = Staff.insertStaff(insert, db);

            if (!err.Status)
            {
                MessageBox.Show(err.Message, "Tạo hóa đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
