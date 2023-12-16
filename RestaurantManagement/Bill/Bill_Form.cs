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
using RestaurantManagement.Bill;

namespace RestaurantManagement
{
    public partial class Bill_Form : Form
    {
        public Bill_Form()
        {
            InitializeComponent();
        }

        Database db = new Database();


        private void Bill_Form_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = Statement.getAllBillSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table =bill.getBill(command);
            fillGrid(table);
        }

        // Đưa dữ liệu vào DataGridView
        private void fillGrid(DataTable table)
        {
            // Đặt lại tên cột cho phù hợp
            table.Columns[0].ColumnName = "Mã HĐ";
            table.Columns[1].ColumnName = "Ngày lập";
            table.Columns[2].ColumnName = "Tổng tiền";
            table.Columns[3].ColumnName = "Tên bàn";
            table.Columns[4].ColumnName = "Tên NV";
            table.Columns[5].ColumnName = "Tên KH";
            table.Columns[6].ColumnName = "Trạng thái";

            listBills.ReadOnly = true;
            listBills.DataSource = table;
        }

        private void listBills_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listBills.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listBills.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng
                idTbox.Text = selectedRow.Cells["Mã HĐ"].Value.ToString();
                nameStaffTbox.Text = selectedRow.Cells["Tên NV"].Value.ToString();
                createDate.Value = DateTime.Parse(selectedRow.Cells["Ngày lập"].Value.ToString());
                tableTbox.Text = selectedRow.Cells["Tên bàn"].Value.ToString();
                nameCustomerTbox.Text = selectedRow.Cells["Tên KH"].Value.ToString();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        // Hàm cập nhật lại danh sách nhân viên mới nhất từ cơ sở dữ liệu
        private void RefreshTable()
        {
            listBills.DataSource = null;
            string query = Statement.getAllBillSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Staff.getStaff(command);
            fillGrid(table);
        }

        private void createBillBtn_Click(object sender, EventArgs e)
        {
            AddBill_Form add = new AddBill_Form(db);
            add.Show();
        }

        private void deleteBillBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listBills.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listBills.SelectedRows[0];

                if(selectedRow.Cells["Trạng thái"].Value.ToString() == "Đã in hóa đơn")
                {
                    MessageBox.Show($"Không thể xóa hóa đơn vì hóa đơn đã được in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string id = selectedRow.Cells["Mã HĐ"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa hóa đơn có mã '{id}'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Error err = bill.deleteBill(id, db);
                    if (!err.Status)
                    {
                        MessageBox.Show($"Xóa hóa đơn thất bại: {err.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Đóng kết nối tới cơ sở dữ liệu
            db.Close();

            if (db.status_connection)
            {
                // Đưa ra thông báo lỗi khi không thể đóng kết nối được tới cơ sở dữ liệu
                MessageBox.Show(db.err_database.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listBills.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listBills.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng
                string id = selectedRow.Cells["Mã HĐ"].Value.ToString();
                int total = int.Parse(selectedRow.Cells["Tổng tiền"].Value.ToString());
                BillDetail_Form bill_form = new BillDetail_Form(db, id, total);
                bill_form.Show();
            }
        }
    }
}
